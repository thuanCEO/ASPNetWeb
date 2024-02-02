using AutoMapper;
using UOW.Core.Entities;

public class ProductService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    public ProductService(
        IUnitOfWork unitOfWork,
        IMapper mapper
        )
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    #region Product
    public async Task<IEnumerable<ProductDTO>> GetProductAsync()
    {
        var projects = await _unitOfWork.Product.GetAll();

        return _mapper.Map<IEnumerable<ProductDTO>>(projects);
    }

    public async Task<bool> InsertProductAsync(ProductDTO projectDTO)
    {
        var project = _mapper.Map<Product>(projectDTO);
        return await _unitOfWork.Product.Add(project);
    }

    #endregion

    public async Task<bool> UpdateProductAsync(ProductDTO productDTO)
    {
        // Chuyển đổi ProductId từ string sang Guid
        string productIdString = productDTO.ProductId.ToString();
        Guid productIdGuid = Guid.Parse(productIdString);

        // Lấy sản phẩm cần cập nhật từ cơ sở dữ liệu dựa trên ProductId
        var existingProduct = await _unitOfWork.Product.GetById(productIdGuid);

        if (existingProduct == null)
        {
            return false; // hoặc thực hiện xử lý phù hợp với trường hợp sản phẩm không tồn tại
        }

        // Ánh xạ dữ liệu từ ProductDTO mới vào đối tượng sản phẩm đã tồn tại
        existingProduct.ProductName = productDTO.ProductName;
        existingProduct.Supplier = productDTO.Supplier;
        existingProduct.Category = productDTO.Category;
        existingProduct.QuantityPerUnit = productDTO.QuantityPerUnit;
        existingProduct.UnitPrice = productDTO.UnitPrice;
        existingProduct.ProductImage = productDTO.ProductImage;

        // Thực hiện cập nhật thông tin sản phẩm
        return await _unitOfWork.Product.Upsert(existingProduct,productIdGuid);
    }
    public async Task<bool> DeleteProductAsync(string productId)
    {
        // Chuyển đổi ProductId từ string sang Guid
        if (!Guid.TryParse(productId, out Guid productIdGuid))
        {
            // Xử lý lỗi khi không thể chuyển đổi ProductId thành Guid
            return false;
        }

        // Lấy sản phẩm cần xóa từ cơ sở dữ liệu dựa trên ProductId
        var existingProduct = await _unitOfWork.Product.GetById(productIdGuid);

        if (existingProduct == null)
        {
            return false; // hoặc thực hiện xử lý phù hợp với trường hợp sản phẩm không tồn tại
        }

        // Gọi phương thức xóa sản phẩm từ đối tượng Product trong UnitOfWork
        return await _unitOfWork.Product.Remove(productIdGuid);
    }

    public async Task<int> CompletedAsync()
    {
        return await _unitOfWork.CompletedAsync();
    }

}

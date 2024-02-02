using Microsoft.AspNetCore.Mvc;

namespace WebAppRazorPages.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductService _service;

        public ProductController(ProductService service)
        {
            _service = service;
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateAsync(ProductDTO Account)
        {
            try
            {
                await _service.InsertProductAsync(Account);
                await _service.CompletedAsync();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace WebAppRazorPages.Controllers
{
    public class AccountController : Controller
    {
        private readonly AccountService _service;

        public AccountController(AccountService service)
        {
            _service = service;
        }
        public async Task<ActionResult> Index()
        {
            var accounts = await _service.GetAccountAsync();
            return View(accounts);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateAsync(AccountDTO Account)
        {
            try
            {
                await _service.InsertAsync(Account);
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

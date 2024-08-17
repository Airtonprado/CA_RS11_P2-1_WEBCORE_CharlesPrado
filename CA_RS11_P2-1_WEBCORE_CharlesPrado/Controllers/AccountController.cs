using Microsoft.AspNetCore.Mvc;

namespace CA_RS11_P2_1_WEBCORE_CharlesPrado.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    namespace YourNamespace.Controllers
    {
        public class AccountController : Controller
        {
            // Exibe a página de login
            [HttpGet]
            public IActionResult Login()
            {
                return View();
            }

            // Manipula o envio do formulário de login
            [HttpPost]
            public IActionResult Login(string username, string password)
            {
                // Verifica se as credenciais estão corretas
                if (username == "admin" && password == "admin")
                {
                    // Armazena as informações de login na sessão (ou outro mecanismo)
                    HttpContext.Session.SetString("Username", username);

                    // Redireciona para a página inicial ou painel de administração
                    return RedirectToAction("Index", "Home");
                }

                // Se as credenciais estiverem incorretas, exibe uma mensagem de erro
                ViewBag.ErrorMessage = "Credenciais inválidas!";
                return View();
            }

            // Manipula o logout
            public IActionResult Logout()
            {
                // Limpa a sessão
                HttpContext.Session.Clear();

                // Redireciona para a página de login
                return RedirectToAction("Login");
            }
        }
    }
}
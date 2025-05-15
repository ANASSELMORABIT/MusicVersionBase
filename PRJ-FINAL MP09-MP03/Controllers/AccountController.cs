using Microsoft.AspNetCore.Mvc;
using PRJ_FINAL_MP09_MP03.Data;
using PRJ_FINAL_MP09_MP03.Models;
using PRJ_FINAL_MP09_MP03.Helpers;

namespace PRJ_FINAL_MP09_MP03.Controllers
{
    using System.Net.Mail;
    using System.Net;

    public class AccountController : Controller
    {
        private readonly TodoContext _context;

        public AccountController(TodoContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Verificar si el usuario existe en la base de datos
                var user = _context.Users.FirstOrDefault(u => u.Username == model.Username);

                if (user != null && PasswordHelper.VerifyPassword(user.Password, model.Password))
                {
                    HttpContext.Session.SetString("Username", user.Username);
                    return RedirectToAction("Dashboard", "Music");

                }


                // Mostrar un mensaje de error si las credenciales son incorrectas
                ModelState.AddModelError("", "Usuario o contraseña incorrectos.");
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var existingUserByUsername = _context.Users.FirstOrDefault(u => u.Username == model.Username);
                if (existingUserByUsername != null)
                {
                    ModelState.AddModelError("Username", "El nombre de usuario ya está en uso.");
                    return View(model);
                }

                var existingUserByEmail = _context.Users.FirstOrDefault(u => u.Email == model.Email);
                if (existingUserByEmail != null)
                {
                    ModelState.AddModelError("Email", "El correo ya está en uso. Elige uno nuevo.");
                    return View(model);
                }

                var newUser = new User
                {
                    Username = model.Username,
                    Password = PasswordHelper.HashPassword(model.Password),
                    Email = model.Email,
                    Role = "user", // Asignar un rol por defecto
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    VerificationCode = GenerateRandomCode()
                };

                _context.Users.Add(newUser);
                _context.SaveChanges();

                return RedirectToAction("Login");
            }

            return View(model);
        }



        // Método para generar un código aleatorio
        public string GenerateRandomCode()
        {
            var random = new Random();
            var code = random.Next(100000, 999999).ToString(); // Un código de 6 dígitos
            return code;
        }   

        // Método para enviar el código de verificación por correo electrónico
        public void SendVerificationCodeEmail(string email, string verificationCode)
        {
            string To = email;

            string Subject = "Código de verificación";


            string Body = $"Tu código de verificación es: {verificationCode}";

            MailAddress addressFrom = new MailAddress("elmorabittesanass@gmail.com", "MusicApp");

            MailAddress addressTo = new MailAddress(To);

            MailMessage message = new MailMessage(addressFrom, addressTo);

            message.Subject = Subject;
            message.Body = Body;
            message.IsBodyHtml = true;

            SmtpClient client = new SmtpClient("smtp.gmail.com");

            client.Port = 587;

            client.EnableSsl = true;

            client.UseDefaultCredentials = false;

            client.Credentials = new System.Net.NetworkCredential("elmorabittesanass@gmail.com", "tftjrtdkmoernhbv");

            try
            {
                client.Send(message);
            }
            catch (Exception ex)
            {
                // Manejar la excepción si el envío falla
                Console.WriteLine("Error al enviar el correo: " + ex.Message);
            }
        }



        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login", "Account");
        }



        [HttpGet]
        public IActionResult SendVerification()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendVerification(string email)
        {
            var user = _context.Users.FirstOrDefault(u => u.Email == email);

        //    if (string.IsNullOrEmpty(HttpContext.Session.GetString("Username")))
        //     {
        //         return RedirectToAction("Login", "Account");
        //     }
            if (user != null)
            {
                
                user.VerificationCode = GenerateRandomCode();
                _context.Users.Update(user);
                _context.SaveChanges();

                SendVerificationCodeEmail(email, user.VerificationCode);

                TempData["Email"] = email; // Guarda el email temporalmente
                return RedirectToAction("VerifyCode");
            }

            ModelState.AddModelError("", "No se encontró un usuario con ese correo.");
            return View();
        }

        [HttpGet]
        public IActionResult VerifyCode()
        {
            return View();
        }

        [HttpPost]
        public IActionResult VerifyCode(string code)
        {
            string email = TempData["Email"] as string;
            // if (string.IsNullOrEmpty(HttpContext.Session.GetString("Username")))
            // {
            //     return RedirectToAction("Login", "Account");
            // }
            if (email == null)
            {
                ModelState.AddModelError("", "La sesión ha expirado. Por favor, vuelve a solicitar el código.");
                return RedirectToAction("SendVerification");
            }

            var user = _context.Users.FirstOrDefault(u => u.Email == email);

            if (user != null && user.VerificationCode == code)
            {
                // Mantenemos el email temporalmente disponible para la próxima vista
                TempData["VerifiedEmail"] = email;

                var model = new ForgetPasswordViewModel
                {
                    Email = email,
                    VerificationCode = code
                };

                return View("ForgetPassword", model);
            }

            // Volvemos a guardar el email porque TempData se borra tras el primer acceso
            TempData["Email"] = email;
            ModelState.AddModelError("", "Código incorrecto.");
            return View();
        }



        
        [HttpGet]
        public IActionResult ForgetPassword()
        {
            if (TempData["VerifiedEmail"] == null)
                return RedirectToAction("SendVerification");

            return View();
        }

        [HttpPost]
        public IActionResult ForgetPassword(ForgetPasswordViewModel model)
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("Username")))
            {
                return RedirectToAction("Login", "Account");
            }
            if (!ModelState.IsValid)
                return View(model);

                
            var user = _context.Users.FirstOrDefault(u => u.Email == model.Email);
            if (user == null)
            {
                ModelState.AddModelError("", "No se encontró el usuario.");
                return View(model);
            }

            if (user.VerificationCode != model.VerificationCode)
            {
                ModelState.AddModelError("", "Código de verificación incorrecto.");
                return View(model);
            }

            user.Password = PasswordHelper.HashPassword(model.Password);
            user.UpdatedAt = DateTime.Now;
            user.VerificationCode = GenerateRandomCode(); // Generar un nuevo código

            _context.Users.Update(user);
            _context.SaveChanges();

            return RedirectToAction("Login");
        }


        public IActionResult Profile()
        {
            return View();
        }






    }
}
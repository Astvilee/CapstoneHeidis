using Microsoft.AspNetCore.Mvc;
using Capstone.Services.IServices;
using Capstone.ViewModels;
using System.Linq;
using Capstone.Utilities;
using Capstone.Repository.IRepository;
using Microsoft.AspNetCore.Mvc.Rendering;
using Capstone.ActionFilters;
using Newtonsoft.Json;
using System.Collections.Generic;
using Capstone.Data;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Web;
using System.Web.Helpers;
using System.Net.Mail;
using System.Net;
using Rotativa.AspNetCore;
using MailKit.Search;
using System.Threading.Tasks;

namespace Capstone.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMailService _mailService;
        private readonly ISessionService _sessionService;
        private readonly IUserRepository _userRepository;
        private readonly IProductRepository _productRepository;

        public HomeController(ISessionService sessionService, IUserRepository userRepository, IProductRepository productRepository, IMailService mailService)
        {
            _sessionService = sessionService;
            _userRepository = userRepository;
            _productRepository = productRepository;
            _mailService = mailService;
        }

        public IActionResult Index()
        {
            _sessionService.SetItems(SessionKeys.UserAccessStatus, (_sessionService.GetItems(SessionKeys.UserAccessStatus, HttpContext) ?? SessionKeys.UserAccessStatusLoggedOut), HttpContext);
            _sessionService.SetItems(SessionKeys.User, (_sessionService.GetItems(SessionKeys.User, HttpContext) ?? ""), HttpContext);
            _sessionService.SetItems(SessionKeys.UserAccessRole, (_sessionService.GetItems(SessionKeys.UserAccessRole, HttpContext) ?? ""), HttpContext);

            TempData.Remove("ViewData");
            if (TempData["register-success"] != null)
            {
                ViewBag.RegisterSuccess = true;
            }
            if (TempData["login-success"] != null)
            {
                ViewBag.LoginSuccess = true;
            }
            if (TempData["logout-success"] != null)
            {
                ViewBag.LogoutSuccess = true;
            }

            return View("Index");
        }

        public IActionResult About()
        {
            return View("About");
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Profile()
        {
            if (_sessionService.GetItems(SessionKeys.UserAccessStatus, HttpContext).Equals(SessionKeys.UserAccessStatusLoggedIn))
            {
                UserViewModel user = _userRepository.GetUser(_sessionService.GetItems(SessionKeys.User, HttpContext));
                return View("Profile", new ProfileViewModel() { EmailAddress = user.Email,Password = _userRepository.DecryptPassword(user.Password),
                    UserId=user.Id, Role=user.Role,
                    PhoneNumber = user.Phone,StreetAddress=user.StreetAddress,Barangay=user.Barangay,Address = $"{user.StreetAddress}{user.Barangay}"});
            }
            else
            {
                return Redirect("/");
            }
        }

        public IActionResult OrderBeingProcess()
        {
            return View();
        }

        public IActionResult ViewOrders()
        {
            if (_sessionService.GetItems(SessionKeys.UserAccessStatus, HttpContext).Equals(SessionKeys.UserAccessStatusLoggedIn))
            {
                UserViewModel user = _userRepository.GetUser(_sessionService.GetItems(SessionKeys.User, HttpContext));
                ViewBag.UserId = user.Id;
                return View("ViewOrders", _productRepository.GetUserOrders(user));
            }
            else
            {
                return Redirect("/");
            }
        }

        public IActionResult Store()
        {
            StoreViewModel storeViewModel = new StoreViewModel();
            storeViewModel.Products = _productRepository.GetProducts();

            return View("Store", storeViewModel);
        }

        public IActionResult Cart()
        {
            if (_sessionService.GetItems(SessionKeys.UserAccessStatus, HttpContext).Equals(SessionKeys.UserAccessStatusLoggedIn))
            {
                var CartItems = _userRepository.GetCartViewModel(_sessionService.GetItems(SessionKeys.User, HttpContext));
                Dictionary<string, int> ProductStock = new Dictionary<string, int>();
                foreach (var item in CartItems.Cart)
                {
                    ProductStock.Add(item.Name,_productRepository.GetProductCount(item.Name));
                }
                ViewBag.ProductStock = ProductStock;
                Debug.WriteLine("#################################"+CartItems);
                Debug.WriteLine("#################################" + ProductStock);
                return View("Cart", CartItems);
            }
            else
            {
                return Redirect("/Login");
            }
        }
        public IActionResult CheckoutOrder()
        {
            if (_sessionService.GetItems(SessionKeys.UserAccessStatus, HttpContext).Equals(SessionKeys.UserAccessStatusLoggedIn))
            {
                UserViewModel user = _userRepository.GetUser(_sessionService.GetItems(SessionKeys.User, HttpContext));
                _productRepository.CheckoutOrder(user);
                return Json(new { Success = true });
            }
            else
            {
                return Json(new { Success = false });
            }
        }

        public IActionResult GetTotalCartItem()
        {
            if (_sessionService.GetItems(SessionKeys.UserAccessStatus, HttpContext).Equals(SessionKeys.UserAccessStatusLoggedIn))
            {
                UserViewModel user = _userRepository.GetUser(_sessionService.GetItems(SessionKeys.User, HttpContext));
                return Json(new { Success = true, total = _productRepository.GetTotalCartItem(user) });
            }
            else
            {
                return Json(new { Success = false });
            }

        }

        public IActionResult AddToCart(string id)
        {
            if (_sessionService.GetItems(SessionKeys.UserAccessStatus, HttpContext).Equals(SessionKeys.UserAccessStatusLoggedIn))
            {
                UserViewModel user = _userRepository.GetUser(_sessionService.GetItems(SessionKeys.User, HttpContext));
                _productRepository.AddCartItem(user, id);
                return Json(new { Success = true, Item = _productRepository.GetCartItem(user, id) });
            }
            else
            {
                return Json(new { Success = false });
            }
        }
        public IActionResult SubtractToCart(string id)
        {
            if (_sessionService.GetItems(SessionKeys.UserAccessStatus, HttpContext).Equals(SessionKeys.UserAccessStatusLoggedIn))
            {
                UserViewModel user = _userRepository.GetUser(_sessionService.GetItems(SessionKeys.User, HttpContext));
                _productRepository.SubtractCartItem(user, id);
                return Json(new { Success = true });
            }
            else
            {
                return Json(new { Success = false });
            }
        }

        public IActionResult RemoveToCart(string id)
        {
            if (_sessionService.GetItems(SessionKeys.UserAccessStatus, HttpContext).Equals(SessionKeys.UserAccessStatusLoggedIn))
            {
                UserViewModel user = _userRepository.GetUser(_sessionService.GetItems(SessionKeys.User, HttpContext));
                _productRepository.RemoveCartItem(user, id);
                return Json(new { Success = true });
            }
            else
            {
                return Json(new { Success = false });
            }
        }

        [ImportModelState]
        public IActionResult Login()
        {
            if (_sessionService.GetItems(SessionKeys.UserAccessStatus, HttpContext).Equals(SessionKeys.UserAccessStatusLoggedIn))
            {
                return Redirect("/");
            }
            return View("Login", new LoginViewModel());
        }

        [ExportModelState]
        public IActionResult LoginUser(LoginViewModel user)
        {
          
            if (!_userRepository.ValidateUserLogin(user.Email, _userRepository.EncryptPassword(user.Password)))
            {
                ModelState.AddModelError("Email", "Email or Password is incorrect, try again");
            }
            if (!_userRepository.VerifyUserLogin(user.Email, _userRepository.EncryptPassword(user.Password)))
            {
                ModelState.AddModelError("Verification", "Your account is not yet verified.");
            }
            if (!ModelState.IsValid)
            {
                return Redirect("/Login");
            }

            UserViewModel dbUser = _userRepository.GetUser(user.Email);

            if (dbUser != null)
            {
                _sessionService.SetItems(SessionKeys.User, dbUser.Email, HttpContext);
                _sessionService.SetItems(SessionKeys.UserAccessStatus, SessionKeys.UserAccessStatusLoggedIn, HttpContext); ;
                _sessionService.SetItems(SessionKeys.UserAccessRole, (dbUser.Role.Equals(SessionKeys.UserAccessRoleAdmin) ? SessionKeys.UserAccessRoleAdmin : SessionKeys.UserAccessRoleDefault), HttpContext);
            }

            TempData["login-success"] = true;
            return RedirectToAction("Store");
        }

        public IActionResult Logout()
        {
            _sessionService.SetItems(SessionKeys.User, "", HttpContext);
            _sessionService.SetItems(SessionKeys.UserAccessStatus, SessionKeys.UserAccessStatusLoggedOut, HttpContext); ;
            _sessionService.SetItems(SessionKeys.UserAccessRole, "None", HttpContext);

            TempData["logout-success"] = true;
            return RedirectToAction("Index");
        }

        [ImportModelState]
        public IActionResult Register()
        {
            ViewBag.BarangayList = FunctionHelper.GetBarangayList().Select((value, index) => new { value, index }).Select(x => new SelectListItem() { Value = x.index.ToString(), Text = x.value });
            return View("Register", new UserViewModel());
        }

        [HttpPost]
        [ExportModelState]
        public async Task <IActionResult> RegisterUser(UserViewModel user)
        {
            if (_userRepository.IsEmailExist(user.Email))
            {
                ModelState.AddModelError("Email", "Email address already exists");
            }

            if (!ModelState.IsValid)
            {
                ViewBag.BarangayList = FunctionHelper.GetBarangayList().Select((value, index) => new { value, index }).Select(x => new SelectListItem() { Value = x.index.ToString(), Text = x.value });
                return Redirect("/Register");
            }

            var phoneNumberUtil = PhoneNumbers.PhoneNumberUtil.GetInstance();
            string phoneNumber = user.Phone;

            if (!string.IsNullOrEmpty(user.Phone))
            {
                var parsedPhoneNumber = phoneNumberUtil.Parse(user.Phone.Replace(" ", ""), "PH");
                var formattedPhoneNumber = phoneNumberUtil.Format(parsedPhoneNumber, PhoneNumbers.PhoneNumberFormat.INTERNATIONAL);
                bool isValidPhoneNumber = phoneNumberUtil.IsValidNumber(parsedPhoneNumber);

                if (!isValidPhoneNumber)
                {
                    ModelState.AddModelError("Phone", "Please provide a valid phone number");
                    ViewBag.BarangayList = FunctionHelper.GetBarangayList().Select((value, index) => new { value, index }).Select(x => new SelectListItem() { Value = x.index.ToString(), Text = x.value });
                    return Redirect("/Register");
                }
                else if (_userRepository.IsPhoneNumberExist(formattedPhoneNumber))
                {
                    ModelState.AddModelError("Phone", "Phone number already exists");
                    return Redirect("/Register");
                }
                phoneNumber = formattedPhoneNumber;
            }
            var encryptpass = _userRepository.EncryptPassword(user.Password.ToString());
            Random random = new Random();
            int otp = random.Next(100000, 999999);
            _userRepository.Create(new UserViewModel() { Email = user.Email,Otp= otp, Password = encryptpass, Barangay = FunctionHelper.GetBarangayList()[int.Parse(user.Barangay)], StreetAddress = user.StreetAddress, Phone = phoneNumber, Profile = user.Profile });
            ViewBag.UserId = _userRepository.GetUserIdByEmail(user.Email);
            ViewBag.Status = false;
            await _mailService.SendEmail(user.Email, "Your verification code is " + otp,
            "This code can be used to verify your account.", new string[] { "info@heidiswater.com" });
            TempData["register-success"] = true;
            return View("VerifyRegistration");
        }
        public IActionResult VerifyRegistration(string id,string code)
        {
            ViewBag.UserId = id;
            if (_userRepository.VerifyUserById(id, code))
            {
                return Redirect("/Login");
            }
            else
            {
                ViewBag.Status = true;;
                return View("VerifyRegistration");
            }
            
        }
        public IActionResult ForgotPassword(string email)
        {
            ViewBag.Result = false;
            return View();
        }
        public async Task<IActionResult> ResetPassword(string email)
        {
            
            if (_userRepository.IsEmailExist(email))
            {
                string resetcode = Guid.NewGuid().ToString();
                await _mailService.SendEmail(email, "Password reset request",
                "You can reset your password <a href='https://localhost:44338/Home/ResetPassword'>here</a>", new string[] { "info@heidiswater.com" });
                ViewBag.CurrentPassword = _userRepository.DecryptPassword(_userRepository.GetUserPasswordByEmail(email));
                return View();

            }
            else
            {
                ViewBag.Result = true;
                return View("ForgotPassword");
            }
            
        }
        public IActionResult ReturnProduct(int ProductId, int Quantity, int UserId, int OrderId)
        {
            if (_sessionService.GetItems(SessionKeys.UserAccessStatus, HttpContext).Equals(SessionKeys.UserAccessStatusLoggedIn))
            {
                UserViewModel user = _userRepository.GetUser(_sessionService.GetItems(SessionKeys.User, HttpContext));
                var userOrders = _productRepository.GetUserOrders(user);
                var order = userOrders.Orders.FirstOrDefault(m => m.Id == OrderId);
                var productOrder = order.ProductOrders.FirstOrDefault(m => m.Id == ProductId);
                var datetime = DateTime.Now;
                return View("ReturnProduct", new ReturnedOrder()
                {
                    Name = productOrder.Name,
                    Image = productOrder.Image,
                    Details = "",
                    Quantity = Quantity,
                    UserId = UserId,
                    OrderId = OrderId,
                    ProductId = ProductId,
                    DateCreated = datetime,
                 });
            }
            else
            {
                return Json(new { Success = false });
            }
        }

        [HttpPost]
        public IActionResult ReturnOrder(ReturnedOrder ReturnOrder)
        {
            _productRepository.SaveReturnOrder(ReturnOrder);
            return Redirect("/ViewOrders");
        }
        public IActionResult UpdateInfo(ProfileViewModel profile)
        {
            _userRepository.UpdateInfo(profile);
            return Json(new { Success = "Success" });
        }
        public IActionResult DeliveryList()
        {
            return new ViewAsPdf("DeliveryList", _productRepository.GetAllUserOrders());
        }
       
      

    }
}

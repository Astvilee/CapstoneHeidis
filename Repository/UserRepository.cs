using System;
using System.Linq;
using Capstone.Data;
using Capstone.ViewModels;
using Capstone.Repository.IRepository;
using Capstone.Utilities;
using System.Collections.Generic;
using System.Web;
using MailKit.Search;

namespace Capstone.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Create(UserViewModel user)
        {
            if (IsExist(user) == null)
            {
                _context.Users.Add(new User() { Email = user.Email,Otp=user.Otp,Password = user.Password, StreetAddress = user.StreetAddress, Barangay = user.Barangay, Phone = user.Phone, Profile = user.Profile, Role = SessionKeys.UserAccessRoleDefault });
                _context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }


        public UserViewModel IsExist(UserViewModel user)
        {
            var dbUser = _context.Users.FirstOrDefault(u => u.Email.ToLower().Equals(user.Email.ToLower()));
            return (dbUser != null) ? new UserViewModel()
            {
                Id = dbUser.Id,
                Email = dbUser.Email,
                Password = dbUser.Password,
                Phone = dbUser.Phone,
                Barangay = dbUser.Barangay,
                Profile = dbUser.Profile,
                Role = dbUser.Role,
                StreetAddress = dbUser.StreetAddress
            } : null;
        }
        public bool IsEmailExist(string email)
        {
            var dbUser = _context.Users.FirstOrDefault(u => u.Email.ToLower().Equals(email.ToLower()));
            return (dbUser != null) ? true : false;
        }

        public bool IsPhoneNumberExist(string phone)
        {
            var dbUser = _context.Users.FirstOrDefault(u => u.Phone.Equals(phone));
            return (dbUser != null) ? true : false;
        }

        public void Update(int id, UserViewModel user)
        {
            throw new NotImplementedException();
        }

        public bool ValidateUserLogin(string email, string password)
        {
            if (email == null || password == null)
            {
                return false;
            }
            var dbUser = _context.Users.FirstOrDefault(u => u.Email.ToLower().Equals(email.ToLower()) && u.Password.Equals(password));
            return (dbUser != null) ? true : false;
        }
        public bool VerifyUserLogin(string email, string password)
        {
            if (email == null || password == null)
            {
                return false;
            }
            var dbUser = _context.Users.FirstOrDefault(u => u.Email.ToLower().Equals(email.ToLower()) && u.Password.Equals(password) && u.isVerified == 1);
            return (dbUser != null) ? true : false;
        }
        public UserViewModel GetUser(string email)
        {
            var dbUser = _context.Users.FirstOrDefault(u => u.Email.ToLower().Equals(email.ToLower()) && u.isArchive==0);
            return (dbUser != null) ? new UserViewModel()
            {
                Id = dbUser.Id,
                Email = dbUser.Email,
                Password = dbUser.Password,
                Phone = dbUser.Phone,
                Barangay = dbUser.Barangay,
                Profile = dbUser.Profile,
                Role = dbUser.Role,
                StreetAddress = dbUser.StreetAddress
            } : null;
        }

        public CartViewModel GetCartViewModel(string email)
        {
            var dbUser = _context.Users.FirstOrDefault(u => u.Email.ToLower().Equals(email.ToLower()));
            CartViewModel cart = new CartViewModel();
            cart.user = GetUser(email);
            List<CartItemViewModel> cartItems = new List<CartItemViewModel>();
            List<CartProduct> cartProducts = _context.CartProducts.Where(u => u.User == dbUser).ToList();
            foreach (var item in cartProducts)
            {
                Product product = _context.Products.Where(m => m.CartProducts.Contains(item)).FirstOrDefault();
                ProductBaseImage pbi = _context.BaseImages.Where(m => m.Product == product).FirstOrDefault();
                cartItems.Add(new CartItemViewModel() { Id = product.Id, Image = (pbi == null) ? "" : product.BaseImage.Path, Name = product.BaseName, Price = product.BasePrice, Quantity = item.Quantity });
            }
            cart.Cart = cartItems;

            return cart;
        }

        public List<UserViewModel> GetAllUsers()
        {
            var dbUsers = _context.Users.Where(m => m.isArchive==0).ToList();
            List<UserViewModel> ListOfUsers = new List<UserViewModel>();
            foreach (var item in dbUsers)
            {
                ListOfUsers.Add((item != null) ? new UserViewModel()
                {
                    Id = item.Id,
                    Email = item.Email,
                    Password = item.Password,
                    Phone = item.Phone,
                    Barangay = item.Barangay,
                    Profile = item.Profile,
                    Role = item.Role,
                    StreetAddress = item.StreetAddress
                } : null);

            }
            return ListOfUsers;
        }

        public bool RemoveUser(string id)
        {
            User dbUser = _context.Users.Where(u => u.Id.ToString().Equals(id)).FirstOrDefault();
            if (dbUser != null)
            {
                dbUser.isArchive = 1;
            }
            _context.SaveChanges();
            User check = _context.Users.Where(u => u.Id.ToString().Equals(id)).FirstOrDefault();
            return check != null ? false : true;
        }

        public void CreateOrUpdate(UserViewModel user)
        {
            User u = _context.Users.Where(m => m.Id.ToString().Equals(user.Id.ToString()) && (m.Email == user.Email || m.Phone == user.Phone)).FirstOrDefault();
            if (u == null)
            {
                if(_context.Users.Where(m => m.Email.Equals(user.Email)).FirstOrDefault() == null && _context.Users.Where(m => m.Phone.Equals(user.Phone)).FirstOrDefault() == null)
                {
                    _context.Users.Add(new User() { Email = user.Email, Password = user.Password, StreetAddress = user.StreetAddress, Barangay = user.Barangay, Phone = user.Phone, Profile = user.Profile, Role = user.Role.ToString() });
                }
            }
            else
            {
                User uu = new User() { Id=u.Id, Email = user.Email, Password = user.Password, StreetAddress = user.StreetAddress, Barangay = user.Barangay, Phone = user.Phone, Profile = user.Profile, Role = user.Role.ToString() };
                _context.Entry(u).CurrentValues.SetValues(uu);
            }
            _context.SaveChanges();
        }

        public void UpdateInfo(ProfileViewModel profile)
        {
            var model = _context.Users.FirstOrDefault(m => m.Id == profile.UserId);
            byte[] EncDataByte = new byte[profile.Password.Length];
            EncDataByte = System.Text.Encoding.UTF8.GetBytes(profile.Password);
            string EncryptedPassword = Convert.ToBase64String(EncDataByte);
            _context.Entry(model).CurrentValues.SetValues(new User()
            {
                Id = profile.UserId,
                Email= profile.EmailAddress,
                Phone = profile.PhoneNumber,
                Password = EncryptedPassword,
                StreetAddress = profile.StreetAddress,
                Barangay = profile.Barangay,
                Role=profile.Role,
                Profile=model.Profile,
            });
            _context.SaveChanges();
        }
        public string EncryptPassword(string password)
        {
            try
            {
                byte[] EncDataByte = new byte[password.Length];
                EncDataByte = System.Text.Encoding.UTF8.GetBytes(password);
                string EncryptedPassword = Convert.ToBase64String(EncDataByte);
                return EncryptedPassword;
            }
            catch (Exception ex)
            {

                throw new Exception("Error in code: " + ex.Message);
            }
            
        }
        public string DecryptPassword(string password)
        {
            try
            {
                System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
                System.Text.Decoder UTF8Decode = encoder.GetDecoder();
                byte[] DecodeByte = Convert.FromBase64String(password);
                int CharCount = UTF8Decode.GetCharCount(DecodeByte,0,DecodeByte.Length);
                char[] DecodeChar = new char[CharCount];
                UTF8Decode.GetChars(DecodeByte, 0, DecodeByte.Length, DecodeChar, 0);
                string DecryptedPassword = new string(DecodeChar);
                return DecryptedPassword;
            }
            catch (Exception ex)
            {

                throw new Exception("Error in code: " + ex.Message);
            }
        }
        public string GetUserEmailByOrderId(string orderId)
        {
            Order order = _context.Orders.Where(x => x.Id.ToString().Equals(orderId)).FirstOrDefault();
            var userId = order.UserId;
            var user = _context.Users.FirstOrDefault(m => m.Id == userId);
            return user.Email;
        }
        public string GetUserIdByEmail(string email)
        {
            var currentuser= _context.Users.FirstOrDefault(m => m.Email.Equals(email));
            return currentuser.Id.ToString();
        }
        public bool VerifyUserById(string id,string code)
        {
            var user = _context.Users.FirstOrDefault(m => m.Id.ToString().Equals(id));
            if (user != null)
            {
                if (user.Otp.ToString().Equals(code))
                {
                    user.isVerified = 1;
                    _context.SaveChanges();
                    return true;
                }
                else
                {
                   return false;
                }
            }
            else
            {
                return false;
            }

        }
       
        public string GetUserPasswordByEmail(string email)
        {
            var user = _context.Users.FirstOrDefault(m => m.Email.Equals(email));
            var userpass = user.Password;
            return userpass;
        }

        public void SetResetPasswordCode(string email, string code)
        {
            var user = _context.Users.FirstOrDefault(m => m.Email.ToLower().Equals(email.ToLower()));
            if(user != null)
            {
                user.PasswordResetCode = code;
            }

            _context.SaveChanges();
        }

        public bool ValidateResetCode(string email, string code)
        {
            var user = _context.Users.FirstOrDefault(m => m.Email.ToLower().Equals(email.ToLower()));
            if(user != null )
            {
                return user.PasswordResetCode.ToLower().Equals(code.ToLower());
            } else
            {
                return false;
            }
        }

        public void UpdatePassword(string email, string pass)
        {
            var user = _context.Users.FirstOrDefault(m => m.Email.ToLower().Equals(email.ToLower()));
            if(user != null)
            {
                user.Password = EncryptPassword(pass);
            }
            _context.SaveChanges();
        }
    }
}


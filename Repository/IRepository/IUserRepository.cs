using Capstone.Data;
using Capstone.ViewModels;
using System.Collections.Generic;

namespace Capstone.Repository.IRepository
{
    public interface IUserRepository
    {
        void Create(UserViewModel user);
        void CreateOrUpdate(UserViewModel user);
        void Delete(int id);
        void Update(int id, UserViewModel user);
        UserViewModel IsExist(UserViewModel user);
        bool IsPhoneNumberExist(string phone);
        bool IsEmailExist(string email);
        bool ValidateUserLogin(string email, string password);
        UserViewModel GetUser(string email);
        CartViewModel GetCartViewModel(string email);
        List<UserViewModel> GetAllUsers();
        bool RemoveUser(string id);
        void UpdateInfo(ProfileViewModel profile);
        string EncryptPassword(string password);
        string DecryptPassword(string password);
        string GetUserEmailByOrderId(string orderId);
        string GetUserIdByEmail(string email);
        bool VerifyUserById(string id, string code);
        bool VerifyUserLogin(string email, string password);
        string GetUserPasswordByEmail(string email);
        void SetResetPasswordCode(string email, string code);
        bool ValidateResetCode(string email, string code);
        void UpdatePassword(string email, string pass);
    }
}

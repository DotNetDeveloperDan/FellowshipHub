using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FellowshipHub.Core.Services.Interfaces
{
    public interface IAuthService
    {
        Task<ApiResponse<User>> LoginAsync(string email, string password);
        Task<ApiResponse<User>> RegisterAsync(string firstName, string lastName, string email, string password);
        Task<ApiResponse<bool>> LogoutAsync();
        Task<ApiResponse<User>> GetCurrentUserAsync();
        Task<ApiResponse<bool>> ForgotPasswordAsync(string email);
        Task<ApiResponse<bool>> ResetPasswordAsync(string token, string newPassword);
        Task<ApiResponse<User>> UpdateProfileAsync(User user);
        bool IsAuthenticated { get; }
        User? CurrentUser { get; }
        event EventHandler<User?>? UserChanged;
    }
}

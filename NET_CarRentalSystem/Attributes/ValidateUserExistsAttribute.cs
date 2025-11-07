using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using NET_CarRentalSystem.Application.Interfaces.Services;
using NET_CarRentalSystem.Shared.Constants.MessageConstants;
using NET_CarRentalSystem.Shared.Wrapper;
using Microsoft.AspNetCore.Authorization;
using NET_CarRentalSystem.Domain.Enums;

namespace NET_CarRentalSystem.API.Attributes
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, Inherited = true, AllowMultiple = true)]
    public class ValidateUserExistsAttribute : AuthorizeAttribute, IAsyncAuthorizationFilter
    {
        public async Task OnAuthorizationAsync(AuthorizationFilterContext context)
        {
            var currentUserService = context.HttpContext.RequestServices.GetService<ICurrentUserService>();
            var loggedInUserId = currentUserService?.GetUserId();

            if (loggedInUserId == null)
            {
                var response = ApiResponse.ErrorResult(AuthMessage.User.NotValid, 401);
                context.Result = new ObjectResult(response) { StatusCode = response.StatusCode };
                return;
            }

            var identityService = context.HttpContext.RequestServices.GetService<IIdentityService>()!;
            var user = await identityService.FindUserByIdAsync(loggedInUserId.Value.ToString());

            if (user == null)
            {
                var response = ApiResponse.ErrorResult(AuthMessage.User.NotValid, StatusCodes.Status401Unauthorized);
                context.Result = new ObjectResult(response) { StatusCode = response.StatusCode };
                return;
            }
            
            if (user.Status == UserStatus.Banned)
            {
                var response = ApiResponse.ErrorResult(AuthMessage.Login.Banned, StatusCodes.Status403Forbidden);
                context.Result = new ObjectResult(response) { StatusCode = response.StatusCode };
            }
        }
    }
}


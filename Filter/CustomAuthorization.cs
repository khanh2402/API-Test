using System.Globalization;
using Microsoft.AspNetCore.Mvc;
using API.CSDL.BaoChi.Repository;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Authorization;

namespace API.CSDL.BaoChi.Filter
{
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class CustomAuthorization : Attribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if (context != null)
            {
                //Cho phép bỏ qua bước kiểm tra OnAuthorization
                var allowAnonymous = context.ActionDescriptor.EndpointMetadata.OfType<AllowAnonymousAttribute>().Any();
                if (allowAnonymous)
                    return;

                string access_token = "";
                bool tokenValid = false;
                if (string.IsNullOrEmpty((string)context.HttpContext.Request.Headers[Crypt.getVariableToken()]))
                {
                    context.Result = new UnauthorizedResult();
                }
                else
                {
                    access_token = (string)context.HttpContext.Request.Headers[Crypt.getVariableToken()];
                }
                var arrAuthor = access_token.Split(' ');
                

                if (!tokenValid)
                {
                    context.Result = new UnauthorizedResult();
                }
            }
            
        }
    }
}
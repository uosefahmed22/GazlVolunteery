using Account.Apis.Errors;
using Account.Core.Services.Content;
using Account.Reposatory.Reposatories.Content;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace Account.Apis.Extentions
{
    public static class ApplictionServiceExtention
    {
        public static IServiceCollection AddAplictionService(this IServiceCollection service, IConfiguration configuration)
        {
            service.Configure<ApiBehaviorOptions>(Options =>
            {
                Options.InvalidModelStateResponseFactory = (actionContext) =>
                {
                    var Errors = actionContext.ModelState
                        .Where(P => P.Value.Errors.Count() > 0)
                        .SelectMany(P => P.Value.Errors)
                        .Select(E => E.ErrorMessage)
                        .ToArray();

                    var ValidationErrorResponse = new ApiValidationErrorResponse()
                    {
                        Errors = Errors
                    };

                    return new BadRequestObjectResult(ValidationErrorResponse);
                };
            });

            service.AddScoped<IVolunteerRepo, VolunteerRepo>();
            service.AddScoped<INotificationService, NotificationService>();


            return service;
        }
    }
}

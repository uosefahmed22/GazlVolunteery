using Account.Apis.Errors;
using Account.Apis.Extentions;
using Account.Core.Models.Account;
using Account.Reposatory.Data.Content;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Account.Apis
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            #region configure service

            builder.Services.AddControllers();

            builder.Services.Configure<MailSettings>(builder.Configuration.GetSection(nameof(MailSettings)));

            builder.Services.AddIdentityServices(builder.Configuration);

            builder.Services.AddSwaggerService();
            builder.Services.AddAplictionService(builder.Configuration);
            builder.Services.AddMemoryCache();

            builder.Services.AddCors(Options =>
            {
                Options.AddPolicy("MyPolicy", Options =>
                {
                    Options.AllowAnyHeader().
                    AllowAnyMethod()
                    .AllowAnyOrigin();
                });
            });

            #endregion
            var app = builder.Build();

            using var Scope = app.Services.CreateScope();
            var Services = Scope.ServiceProvider;

            var loggerFactory = Services.GetRequiredService<ILoggerFactory>();
            try
            {
                var DbContext = Services.GetRequiredService<AppDBContext>();
                await DbContext.Database.MigrateAsync();
            }
            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<Program>();
                logger.LogError(ex, ex.Message);

            }

            #region configure middlewares

            app.UseStatusCodePagesWithReExecute("/errors/{0}");


            if (app.Environment.IsDevelopment())
            {
                app.UseSwaggerMiddlewares();
            }
            app.UseMiddleware<ExeptionMiddleWares>();
            app.UseHttpsRedirection();
            app.UseCors("MyPolicy");
            app.UseRouting();
            app.UseAuthorization();
            app.UseAuthentication();
            app.MapControllers();


           #endregion

            app.Run();
        }
    }
}

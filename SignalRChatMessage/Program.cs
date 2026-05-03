using SignalRChatMessage.Service_Hub;

namespace SignalRChatMessage
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            //============================================
            #region Inject Object From Signal R
            builder.Services.AddSignalR();
            #endregion
            //============================================
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthorization();

            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=chat}/{action=Index}/{id?}")
                .WithStaticAssets();
            #region Make URL For This Service 
            app.MapHub<ChatMessageHub>("/Chat"); 
            //Make URL For Service  عشان لما ادوس على زرار send Call Method service by this Link
            //وعملت اللينك كدا عشان موجود معايا فى نفس الProject انما لو موجود فى Poject تانى لازك ابقى اكتب اللينك بتاعه كامل 
            #endregion
            app.Run();
        }
    }
}

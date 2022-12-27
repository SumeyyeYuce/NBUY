using Microsoft.EntityFrameworkCore;
using ShoppingApp.Data.Concrete.EfCore.Contexts;

namespace ShoppingApp.Web.Extensions
{
    //Extensions claslar static olmalı
    public static class MigrationManager
    {
        public static IHost UpdateDatabase(this IHost host)//sistemdeki IHostu parametre olarak alıcak
        {
            using(var scope = host.Services.CreateScope()) 
            {
                using (var shopAppContext = scope.ServiceProvider.GetRequiredService<ShopAppContext>())
                {
                    try
                    {
                        //Bu komut henüz işlenmemiş migrationları alır ve database update işlemine tabi tutar
                        shopAppContext.Database.Migrate();
                    }
                    catch (Exception)
                    {
                        //Hatalrın tutuldugu loglar burada
                        throw;
                    }
                }
            }
            return host;
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ShoppingAppClient.Models;

namespace ShoppingAppClient.Controllers
{
    public class CategoryController : Controller
    {
        public async Task<IActionResult> Index()
        {
            //Api'mizdan kategori listesini getiren bir istekde bulunucak
            var categoriler = new List<CategoryViewModel>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:5200/api/category")) //listeyi bzie getircek
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    categoriler = JsonConvert.DeserializeObject<List<CategoryViewModel>>(apiResponse);
                }

            } 
            return View(categoriler);
            
        }
    }
}

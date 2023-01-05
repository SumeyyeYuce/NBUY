﻿using GetCountriesFromApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text.Json;

namespace GetCountriesFromApi.Controllers
{
    public class HomeController : Controller
    {
        

        public async Task<IActionResult> Index()
        {
            List<Country> countryList = new List<Country>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://restcountries.com/v2/all"))
                {
                   var stringResponse = await response.Content.ReadAsStringAsync();//string olan data nın 
                   countryList = JsonSerializer.Deserialize<List<Country>>(stringResponse);
                }
            }
            return View(countryList); 
        }
          
        public async Task<IActionResult> Privacy()
        {
            List<User> userList = new List<User>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://reqres.in/api/users?page=2"))
                { 
                    var stringResponse = await response.Content.ReadAsStringAsync();
                    userList = JsonSerializer.Deserialize<List<User>>(stringResponse);
                }
            }
            return View(userList);
        }
       
       
    }
}
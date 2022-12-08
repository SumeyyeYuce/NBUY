﻿using Microsoft.AspNetCore.Mvc;
using ShoppingApp.Business.Abstract;

namespace ShoppingApp.Web.ViewComponents
{
    public class CategoriesViewComponent :ViewComponent
    {
        private readonly ICategoryService _categoryManager;

        public CategoriesViewComponent(ICategoryService categoryManager)
        {
            _categoryManager = categoryManager;
        }
       public async  Task<IViewComponentResult> InvokeAsync()
        {
            if (RouteData.Values["id"] != null)
            {
                ViewBag.SelectedCategory = RouteData.Values["id"];//kategori olarak hangisi yazıyosa onu al 
            }
            var categories=await _categoryManager.GetAllAsync();
            return View(categories);    //buralar Default.cshtml'e gidyor
        }
    }
}

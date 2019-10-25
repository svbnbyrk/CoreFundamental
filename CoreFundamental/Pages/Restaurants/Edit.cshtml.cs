using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreFundamental.Core;
using CoreFundamental.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CoreFundamental.Pages.Restaurants
{
    public class EditModel : PageModel
    {
        private readonly IRestaurantData restaurantData;
        public Restaurant Restaurant { get; set; }
        public EditModel(IRestaurantData restaurantData )
        {
            this.restaurantData = restaurantData;
        }
        public void OnGet(int restaurantId)
        {

        }
    }
}
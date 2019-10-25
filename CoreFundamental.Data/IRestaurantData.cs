using CoreFundamental.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreFundamental.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        readonly List<Restaurant> restaurants;
        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant{ Id=1, Location="İzmit",Name="Kavuret", Cousin = CousinType.Turkish  },
                new Restaurant{ Id=2, Location="İzmit",Name="Burger King" ,Cousin = CousinType.Russian },
            };

        }
        public IEnumerable<Restaurant> GetAll()
        {
            return from r in restaurants
                   orderby r.Name
                   select r;
        }
    }
}

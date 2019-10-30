using CoreFundamental.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreFundamental.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetRestaurantsByName(string name);
        Restaurant GetById(int id);
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
                new Restaurant{ Id=3, Location="Tuzla",Name="Tuzla Balıkçısı" ,Cousin = CousinType.Mexico },
                new Restaurant{ Id=4, Location="Sakarya",Name="Köfteci Nazmi" ,Cousin = CousinType.Turkish },
            };

        }
        public Restaurant GetById(int id)
        {
            return restaurants.SingleOrDefault(r => r.Id == id);
        }

        public IEnumerable<Restaurant> GetRestaurantsByName(string name)
        {
            return from r in restaurants
                   where string.IsNullOrEmpty(name) || r.Name.StartsWith(name)
                   orderby r.Name
                   select r;
        }
    }
}

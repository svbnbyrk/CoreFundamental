using CoreFundamental.Core;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CoreFundamental.Data
{
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

        public Restaurant Update(Restaurant updatedRestaurant)
        {
            var restaurant = restaurants.SingleOrDefault(r => r.Id == updatedRestaurant.Id);
            if (restaurant != null)
            {
                restaurant.Name = updatedRestaurant.Name;
                restaurant.Location = updatedRestaurant.Location;
                restaurant.Cousin = updatedRestaurant.Cousin;
            }

            return restaurant;
        }
        public Restaurant Add(Restaurant newRestaurant)
        {
            restaurants.Add(newRestaurant);
            newRestaurant.Id = restaurants.Max(r => r.Id) + 1;
            return newRestaurant;
        }
        public int Commit()
        {
            return 0;
        }

        public Restaurant Delete(int id)
        {
            var restaurant = restaurants.FirstOrDefault(r => r.Id == id);
            if(restaurant != null)
            {
                restaurants.Remove(restaurant);
            }
            return restaurant;
        }
    }
}

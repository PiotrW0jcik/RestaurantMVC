using System.Collections.Generic;
using System.Linq;

namespace PiotrWojcik.Restaurant.Models
{
    public class DishModel
    {
        private List<Dish> dishes;

            public DishModel()
            {
                this.dishes = new List<Dish>() {
                    new Dish() {
                        Id = 1,
                        Name = "Pizza",
                        Price = 20
                    },
                    new Dish() {
                        Id = 2,
                        Name = "Sałatka",
                        Price = 10
                    },
                    new Dish() {
                        Id = 3,
                        Name = "Sok Pomarańczowy",
                        Price = 5
                    },
                    new Dish() {
                        Id = 4,
                        Name = "Cola",
                        Price = 3
                    }
                };
            }

            public List<Dish> findAll()
            {
                return this.dishes;
            }

            public Dish find(int id)
            {
                return this.dishes.Single(p => p.Id.Equals(id));
            }

        }
}

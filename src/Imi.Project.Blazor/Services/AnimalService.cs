using Imi.Project.Blazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Blazor.Services
{
    public class AnimalService : ICRUDService<AnimalListItem, AnimalItem>
    {
        static InputSelectItem[] diets = new InputSelectItem[]
        {
            new InputSelectItem() {Value = "1" , Label = "Omnivoor"},
            new InputSelectItem() {Value = "2" , Label = "Carnivoor"},
            new InputSelectItem() {Value ="3" , Label = "Herbivoor"}
        };

        static InputSelectItem[] types = new InputSelectItem[]
        {
            new InputSelectItem() {Value = "1" , Label = "vis"},
            new InputSelectItem() {Value = "2" , Label = "Garnaal"},
            new InputSelectItem() {Value = "3" , Label = "Kreeft"},
            new InputSelectItem() {Value = "4" , Label = "Slak"}
        };

        static InputSelectItem[] continents = new InputSelectItem[]
        {
            new InputSelectItem(){Value = "1" ,Label = "Azië"},
            new InputSelectItem(){Value = "2", Label = "Afrika"},
            new InputSelectItem(){Value = "3", Label = "Noord-Amerika"},
            new InputSelectItem(){Value = "4", Label = "Zuid-Amerika"},
            new InputSelectItem(){Value = "5", Label = "Overal ter wereld"}
        };

        static InputSelectItem[] socials = new InputSelectItem[]
        {
            new InputSelectItem() {Value = "1" , Label = "Leeft in een groep"},
            new InputSelectItem() {Value = "2" , Label = "Leeft alleen"},
            new InputSelectItem() {Value = "3" , Label = "Leeft in een harem"},
            new InputSelectItem() {Value = "4" , Label = "Leeft als koppel"}
        };

        static List<AnimalItem> items = new List<AnimalItem>
        {
            new AnimalItem()
            {
                Id = 1,
                NameFamily = "Osphronemidae",
                NameDutch = "Betta Splendens",
                Image = new Uri("https://cdn.pixabay.com/photo/2021/02/19/11/26/fighting-fish-6029905_960_720.jpg"),
                TypeId = 1,
                DietId = 2,
                ContinentId = 1,
                SocialId = 2,
                minTemp = 20,
                maxTemp = 28,
                minPh = 7,
                maxPh = 8,
                minGh = 8,
                maxGh = 12
             },
            new AnimalItem()
            {
                Id = 1,
                NameFamily = "Loricariidae",
                NameDutch = "Ancistruss",
                Image = new Uri("https://aquainfo.nl/wp-content/uploads/2011/12/Ancistrus-Cf-Cirrhosus.jpg"),
                TypeId = 1,
                DietId = 1,
                ContinentId = 4,
                SocialId = 4,
                minTemp = 23,
                maxTemp = 26,
                minPh = 6,
                maxPh = 8,
                minGh = 5,
                maxGh = 15
             }
        };

        public Task Create(AnimalItem item)
        {
            throw new System.NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<AnimalItem> Get(int id)
        {
            var animal = items.SingleOrDefault(a => a.Id == id);
            return Task.FromResult(animal);
        }

        public Task<AnimalListItem[]> GetList()
        {
            return Task.FromResult(
                items.Select(a => new AnimalListItem()
                {
                    Image = a.Image,
                    NameDutch = a.NameDutch,
                    NameFamily = a.NameFamily
                }).ToArray()
                );
        }

        public Task<AnimalItem> GetNew()
        {
            throw new System.NotImplementedException();
        }

        public Task Update(AnimalItem item)
        {
            throw new System.NotImplementedException();
        }
    }
}

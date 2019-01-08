using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BertScout2019.Models;

namespace BertScout2019.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        List<Item> items;

        public MockDataStore()
        {
            items = new List<Item>();
            var mockItems = new List<Item>
            {
                new Item { Id = Guid.NewGuid().ToString(), Number = 1, Name = "The Juggernauts", Location = "Pontiac, Michigan, USA" },
                new Item { Id = Guid.NewGuid().ToString(), Number = 4, Name = "Team 4 ELEMENT", Location = "Van Nuys, California, USA" },
                new Item { Id = Guid.NewGuid().ToString(), Number = 5, Name = "Robocards", Location = "Melvindale, MI, USA" },
                new Item { Id = Guid.NewGuid().ToString(), Number = 6, Name = "The CogSquad", Location = "Plymouth, MN, USA" },
                new Item { Id = Guid.NewGuid().ToString(), Number = 7, Name = "Team007", Location = "Baltimore, MD, USA" },
                new Item { Id = Guid.NewGuid().ToString(), Number = 8, Name = "Paly Robotics", Location = "Palo Alto, California, USA" },
            };

            foreach (var item in mockItems)
            {
                items.Add(item);
            }
        }

        public async Task<bool> AddItemAsync(Item item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            var oldItem = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}
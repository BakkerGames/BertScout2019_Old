using System;
using System.Collections.Generic;
using System.Collections.Concurrent;

namespace BertScout2019.Models
{
    public class ItemRepository : IItemRepository
    {
        private static ConcurrentDictionary<string, Item> items =
            new ConcurrentDictionary<string, Item>();

        public ItemRepository()
        {
            Add(new Item { Id = Guid.NewGuid().ToString(), Number = 1, Name = "Name 1", Location = "Location 1" });
            Add(new Item { Id = Guid.NewGuid().ToString(), Number = 2, Name = "Name 2", Location = "Location 2" });
            Add(new Item { Id = Guid.NewGuid().ToString(), Number = 3, Name = "Name 3", Location = "Location 3" });
        }

        public Item Get(string id)
        {
            return items[id];
        }

        public IEnumerable<Item> GetAll()
        {
            return items.Values;
        }

        public void Add(Item item)
        {
            item.Id = Guid.NewGuid().ToString();
            items[item.Id] = item;
        }

        public Item Find(string id)
        {
            Item item;
            items.TryGetValue(id, out item);

            return item;
        }

        public Item Remove(string id)
        {
            Item item;
            items.TryRemove(id, out item);

            return item;
        }

        public void Update(Item item)
        {
            items[item.Id] = item;
        }
    }
}

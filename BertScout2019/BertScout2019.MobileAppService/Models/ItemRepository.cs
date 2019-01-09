using System;
using System.Collections.Generic;
using System.Collections.Concurrent;

namespace BertScout2019.Models
{
    public class ItemRepository : IItemRepository
    {
        private static ConcurrentDictionary<string, Team> items =
            new ConcurrentDictionary<string, Team>();

        public ItemRepository()
        {
            Add(new Team { Id = Guid.NewGuid().ToString(), Number = 1, Name = "Name 1", Location = "Location 1" });
            Add(new Team { Id = Guid.NewGuid().ToString(), Number = 2, Name = "Name 2", Location = "Location 2" });
            Add(new Team { Id = Guid.NewGuid().ToString(), Number = 3, Name = "Name 3", Location = "Location 3" });
        }

        public Team Get(string id)
        {
            return items[id];
        }

        public IEnumerable<Team> GetAll()
        {
            return items.Values;
        }

        public void Add(Team item)
        {
            item.Id = Guid.NewGuid().ToString();
            items[item.Id] = item;
        }

        public Team Find(string id)
        {
            Team item;
            items.TryGetValue(id, out item);

            return item;
        }

        public Team Remove(string id)
        {
            Team item;
            items.TryRemove(id, out item);

            return item;
        }

        public void Update(Team item)
        {
            items[item.Id] = item;
        }
    }
}

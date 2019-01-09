using System;
using System.Collections.Generic;

namespace BertScout2019.Models
{
    public interface IItemRepository
    {
        void Add(Team item);
        void Update(Team item);
        Team Remove(string key);
        Team Get(string id);
        IEnumerable<Team> GetAll();
    }
}

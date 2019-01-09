using System;

using BertScout2019.Models;

namespace BertScout2019.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Team Team { get; set; }
        public ItemDetailViewModel(Team team = null)
        {
            Title = team.FullName;
            Team = team;
        }
    }
}

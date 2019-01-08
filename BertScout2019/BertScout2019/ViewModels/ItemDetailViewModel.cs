﻿using System;

using BertScout2019.Models;

namespace BertScout2019.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Item Item { get; set; }
        public ItemDetailViewModel(Item item = null)
        {
            Title = item.FullName;
            Item = item;
        }
    }
}

using System;

namespace BertScout2019.Models
{
    public class Item
    {
        public string Id { get; set; }
        private int _Number = 0;
        public int Number
        {
            get { return _Number; }
            set
            {
                _Number = value;
                FullName = $"Team {_Number} - {_Name}";
            }
        }
        private string _Name = "";
        public string Name
        {
            get { return _Name; }
            set
            {
                _Name = value;
                FullName = $"Team {_Number} - {_Name}";
            }
        }
        public string Location { get; set; }
        public string FullName { get; private set; } = "";
    }
}

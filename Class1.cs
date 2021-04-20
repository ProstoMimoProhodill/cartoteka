using System;
using System.Collections.Generic;
using System.Text;

namespace cartoteka
{
    class book
    {
        public book()
        {
        }

        public book(int count, string author, string name, string PublishingHouse, string Section, string Availability, string Condition)
        {
            Count = count;
            Author = author;
            Name = name;
            PublishingHouse = PublishingHouse;
            Section = Section;
            Availability = Availability;
            Condition = Condition;
        }

        public int Count { get; set; }
        public string Author { get; set; }
        public string Name { get; set; }
        public string PublishingHouse { get; set; }
        public string Section { get; set; }
        public string Availability { get; set; }
        public string Condition { get; set; }
    }
}

using la_mia_pizzeria_static.Models;

namespace la_mia_pizzeria_static.Models
{
    public class Pizza
    {
        private string v1;
        private string v2;
        private int v3;

        public string Name { get; set; }
        public string Description { get; set; }
        public string Photo { get; set; }
        public int Price { get; set; }

        public Pizza(string name, string description, int price)
        {
            Name = name;
            Description = description;
            Price = price;
        }
    }
}

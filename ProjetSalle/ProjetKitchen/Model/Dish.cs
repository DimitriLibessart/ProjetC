namespace ProjetKitchen.Model
{

    public class Dish
    {
        public string Name { get; set; }

        public string Category { get; set; }

        public ElementStatus StatusDish { get; set; }

        public int CleaningTime { get; set; }

    }
}
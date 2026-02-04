namespace project_template.Services
{
    public class RestaurantPickerService
    {
        private readonly Dictionary<string, string[]> _restaurantsByCuisine = new()
        {
            {
                "Mexican", new[]
                {
                    "Taco Bell",
                    "Chipotle Mexican Grill",
                    "Qdoba",
                    "Moe's Southwest Grill",
                    "El Torito",
                    "Baja Fresh",
                    "Del Taco",
                    "Taco Cabana",
                    "Tijuana Flats",
                    "Rubio's Coastal Grill"
                }
            },
            {
                "Chinese", new[]
                {
                    "Panda Express",
                    "P.F. Chang's",
                    "Pei Wei",
                    "Pick Up Stix",
                    "Leeann Chin",
                    "Mandarin Express",
                    "China King",
                    "Golden Dragon",
                    "Happy Wok",
                    "New China Buffet"
                }
            },
            {
                "Italian", new[]
                {
                    "Olive Garden",
                    "Carrabba's Italian Grill",
                    "Maggiano's Little Italy",
                    "Romano's Macaroni Grill",
                    "Buca di Beppo",
                    "The Old Spaghetti Factory",
                    "Fazoli's",
                    "Bravo! Italian Kitchen",
                    "Bertucci's",
                    "Biaggi's Ristorante Italiano"
                }
            }
        };

        public string PickRandomRestaurant()
        {
            Random random = new Random();
            var cuisines = _restaurantsByCuisine.Keys.ToArray();
            string selectedCuisine = cuisines[random.Next(cuisines.Length)];
            string[] restaurants = _restaurantsByCuisine[selectedCuisine];
            string selectedRestaurant = restaurants[random.Next(restaurants.Length)];
            
            return $"Tonight's pick: {selectedRestaurant} ({selectedCuisine} cuisine)!";
        }
    }
}

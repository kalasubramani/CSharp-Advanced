

using Refresher;

FoodMenu summerMenu = new FoodMenu();
summerMenu.name = "Summer Menu";
summerMenu.AddMenuItem("Salmon", "Fresh Norwegian Salmon with Sandefjord butter.", 25.50);
summerMenu.AddMenuItem("Taco", "Tacos with fresh spinach,cheese crumbles and lettuce.", 10);
summerMenu.HospitalDirections = "Right around the corner of 5th street. Ask for Dr.Jones.";

DrinkMenu outsideDrinks = new DrinkMenu();
outsideDrinks.Disclaimer = "Outside drinks not allowed.";
outsideDrinks.AddMenuItem("Virgin Cuba Libre", "A Classic.", 10.00);
outsideDrinks.AddMenuItem("Screwdriver", "Makes you hammered.", 15.50);

//create list of objects
Order hungryGuestOrder = new Order();

for(int i = 0; i < summerMenu.items.Count; i++)
{
    MenuItem currentItem = summerMenu.items[i];
    hungryGuestOrder.items.Add(currentItem);
}

foreach(MenuItem item in outsideDrinks.items)
{
    hungryGuestOrder.items.Add(item);
}

Console.WriteLine("Order Total:",hungryGuestOrder.Total,"rewt");

try
{
    outsideDrinks.AddMenuItem("Test", "test desc", -5.50);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

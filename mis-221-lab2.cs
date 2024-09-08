// varaiables
int numberOfSandwiches = 0;
int numberOfToppings = 0;
double tip = 0;
double totalSandwichCost;
double totalToppingCost;
double baseCost;
//constants
const double COST_OF_SANDWICH = 4.75;
const double COST_OF_TOPPING = 0.55;
const double DISCOUNT_AMOUNT = 0.10;
// Prompt user for sandwiches
System.Console.WriteLine("How many sandwiches do you want?");
numberOfSandwiches= int.Pare(Console.Readline());
System.Console.WriteLine("Sandwiches "+numberOfSandwiches);
//Prompt user for toppings
System.Console.Writeline("How many toppings do you want?");
numberOfToppings = int.Pare(Console.ReadLine());
System.Console.WriteLine("Toppings "+numberOfToppings);
System.Console.WriteLine("Would you like to add a tip?");
tip = double.Parse(Console.ReadLine());
double totalSandwichCost = COST_OF_SANDWICH * numberOfSandwiches;
double totalToppingCost = COST_OF_TOPPING * numberOfToppings;
double baseCost = totalSandwichCost + totalToppingCost;

orderCost = tip + baseCost * (1-DISCOUNT_AMOUNT);
System.Console.WriteLine(orderCost);

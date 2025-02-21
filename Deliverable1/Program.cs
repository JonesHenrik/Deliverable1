// See https://aka.ms/new-console-template for more information

Console.WriteLine("Welcome to the restocking tool.");

int stockSoda = 100;
int restockSoda = 100;

int stockChips = 40;
int restockChips = 40;

int stockCandy = 60;
int restockCandy = 60;

Console.WriteLine($"How many Sodas have been sold today? {stockSoda} are in stock");
int soldSoda = Convert.ToInt32(Console.ReadLine());

if (soldSoda <= stockSoda)
{
    stockSoda -= soldSoda;
    Console.WriteLine($"There are {stockSoda} sodas left\n");
    if (stockSoda <= 40)
    {
        stockSoda = restockSoda;
        // set a value to true so that it will be printed in summary
    }
   
}
else
{
    Console.WriteLine("That value is too high. Stock not adjusted");
}

Console.WriteLine($"How many Sodas have been sold today? {stockChips} are in stock");
int soldChips = Convert.ToInt32(Console.ReadLine());

if (soldChips <= stockChips)
{
    stockChips -= soldChips;
    Console.WriteLine($"There are {stockChips} chips left\n");
    if (stockChips <= 40)
    {
        stockChips = restockChips;
        // set a value to true so that it will be printed in summary
    }
   
}
else
{
    Console.WriteLine("That value is too high. Stock not adjusted");
}

Console.WriteLine($"How many Sodas have been sold today? {stockCandy} are in stock");
int soldCandy = Convert.ToInt32(Console.ReadLine());

if (soldCandy <= stockCandy)
{
    stockCandy -= soldCandy;
    Console.WriteLine($"There are {stockCandy} candy left\n");
    if (stockCandy <= 40)
    {
        stockCandy = restockCandy;
        // set a value to true so that it will be printed in summary
    }
   
}
else
{
    Console.WriteLine("That value is too high. Stock not adjusted");
}
// See https://aka.ms/new-console-template for more information

Console.WriteLine("Welcome to the restocking tool.\n");

var stockSoda = 100;
const int restockSoda = 100;
const int minSodaStock = 40;

var stockChips = 40;
const int restockChips = 40;
const int minChipsStock = 40;

var stockCandy = 60;
const int restockCandy = 60;
const int minCandyStock = 40;

var needToRestockSoda = false;
var needToRestockChips = false;
var needToRestockCandy = false;

// User Input
Console.WriteLine($"How many Sodas have been sold today? {stockSoda} are in stock");
var soldSoda = Convert.ToInt32(Console.ReadLine());

if (soldSoda <= stockSoda)
{
    stockSoda -= soldSoda;
    Console.WriteLine($"There are {stockSoda} sodas left\n");
    if (stockSoda <= minSodaStock)
    {
        stockSoda = restockSoda;
        needToRestockSoda = true;
    }
   
}
else
{
    Console.WriteLine("That value is too high. Stock not adjusted\n");
}

Console.WriteLine($"How many Chips have been sold today? {stockChips} are in stock");
var soldChips = Convert.ToInt32(Console.ReadLine());

if (soldChips <= stockChips)
{
    stockChips -= soldChips;
    Console.WriteLine($"There are {stockChips} chips left\n");
    if (stockChips <= minChipsStock)
    {
        stockChips = restockChips;
        needToRestockChips = true;
    }
   
}
else
{
    Console.WriteLine("That value is too high. Stock not adjusted\n");
}

Console.WriteLine($"How much Candy has been sold today? {stockCandy} are in stock");
var soldCandy = Convert.ToInt32(Console.ReadLine());

if (soldCandy <= stockCandy)
{
    stockCandy -= soldCandy;
    Console.WriteLine($"There are {stockCandy} candy left\n");
    if (stockCandy <= minCandyStock)
    {
        stockCandy = restockCandy;
        needToRestockCandy = true;
    }
   
}
else
{
    Console.WriteLine("That value is too high. Stock not adjusted\n");
}

// Stock Summary
Console.WriteLine("Thank you for filling out the values. Here's what needs to be restocked.");

if (needToRestockSoda)
{
    Console.WriteLine("Sodas need to be restocked.\n");
}

if (needToRestockChips)
{
    Console.WriteLine("Chips need to be restocked.\n");
}

if (needToRestockCandy)
{
    Console.WriteLine("Candy needs to be restocked.\n");
}

if (needToRestockSoda == false && needToRestockChips == false && needToRestockCandy == false)
{
    Console.WriteLine("Nothing need to be restocked.\n");
}

Console.WriteLine("\nGoodbye!");
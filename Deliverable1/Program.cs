// See https://aka.ms/new-console-template for more information

Console.WriteLine("Welcome to the restocking tool.\n");

int stockSoda = 100;
int restockSoda = 100;

int stockChips = 40;
int restockChips = 40;

int stockCandy = 60;
int restockCandy = 60;

bool needToRestockSoda = false;
bool needToRestockChips = false;
bool needToRestockCandy = false;

// User Input
Console.WriteLine($"How many Sodas have been sold today? {stockSoda} are in stock");
int soldSoda = Convert.ToInt32(Console.ReadLine());

if (soldSoda <= stockSoda)
{
    stockSoda -= soldSoda;
    Console.WriteLine($"There are {stockSoda} sodas left\n");
    if (stockSoda <= 40)
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
int soldChips = Convert.ToInt32(Console.ReadLine());

if (soldChips <= stockChips)
{
    stockChips -= soldChips;
    Console.WriteLine($"There are {stockChips} chips left\n");
    if (stockChips <= 40)
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
int soldCandy = Convert.ToInt32(Console.ReadLine());

if (soldCandy <= stockCandy)
{
    stockCandy -= soldCandy;
    Console.WriteLine($"There are {stockCandy} candy left\n");
    if (stockCandy <= 40)
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

if (needToRestockSoda == true)
{
    Console.WriteLine("Sodas need to be restocked.\n\nGoodbye!");
}

if (needToRestockChips == true)
{
    Console.WriteLine("Chips need to be restocked.\n\nGoodbye!");
}

if (needToRestockCandy == true)
{
    Console.WriteLine("Candy needs to be restocked.\n\nGoodbye!");
}

if (needToRestockSoda == false && needToRestockChips == false && needToRestockCandy == false)
{
    Console.WriteLine("Nothing need to be restocked.\n\nGoodbye!");
}
Console.WriteLine("Welcome to the restocking tool.\n");

int sodaStock = 100;
int sodaRestock = 40;
int chipsStock = 40;
int chipsRestock = 20;
int candyStock = 60;
int candyRestock = 40;

Console.WriteLine($"How many Sodas have been sold today? {sodaStock} are in stock");
int amountSold = int.Parse(Console.ReadLine());

if (amountSold > sodaStock) {
    Console.WriteLine("That value is too high. Stock not adjusted\n");
} else {
    sodaStock -= amountSold;
    Console.WriteLine($"There are {sodaStock} Sodas left\n");
}


Console.WriteLine($"How many Chips have been sold today? {chipsStock} are in stock");
amountSold = int.Parse(Console.ReadLine());
if (amountSold > chipsStock) {
    Console.WriteLine("That value is too high. Stock not adjusted\n");
} else {
    chipsStock -= amountSold;
    Console.WriteLine($"There are {chipsStock} Chips left\n");
}


Console.WriteLine($"How many Candy have been sold today? {candyStock} are in stock");
amountSold = int.Parse(Console.ReadLine());
if (amountSold > candyStock)
{
    Console.WriteLine("That value is too high. Stock not adjusted\n");
} else
{
    candyStock -= amountSold;
    Console.WriteLine($"There are {candyStock} Candy left\n");
}





string restockMessage = "Nothing";
if (sodaStock <= sodaRestock) {
    restockMessage = "";
    restockMessage += "Sodas";
}

if (chipsStock <= chipsRestock) {
    if (restockMessage != "Nothing") {
        restockMessage += ", ";
    } else if (restockMessage == "Nothing") {
        restockMessage = "";
    }
    restockMessage += "Chips";
}

if (candyStock <= candyRestock) {
    if (restockMessage != "Nothing") {
        restockMessage += ", ";
    } else if (restockMessage == "Nothing") {
        restockMessage = "";
    }
    restockMessage += "Candy";
}

restockMessage += " needs to be restocked";
Console.WriteLine("Thank you for filling out the values. Here’s what needs to be restocked.");
Console.WriteLine(restockMessage);
Console.WriteLine("\nGoodbye!");

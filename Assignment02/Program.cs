/*
* Student ID : 1690702756
* Name       : Lab02
* Section    : 129C
* No.        : N/A
* Course     : GI113 Computer Programming (GI)
*/
namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string MaterialName = "Copper";
            const double SmeltRate = 0.2500;
            const double SalvageRate = 0.3000;
            const double MaxBatch = 500;

            {
                char selectedMenu;
                double quantity;

                Console.WriteLine("==========================================");
                Console.WriteLine("          Welcome to Copper Forge");
                Console.WriteLine("==========================================");
                Console.WriteLine($"=> {MaterialName} Smelt Rate   : {SmeltRate:F4}");
                Console.WriteLine($"=> {MaterialName} Salvage Rate : {SalvageRate:F4}");
                Console.WriteLine("=> S = Smelt (Ore -> Ingot)");
                Console.WriteLine("=> B = Breakdown (Ingot -> Ore)");

                Console.Write("=> Choose Menu: ");
                string menuText = Console.ReadLine();

                Console.Write("=> How much would you like: ");
                string amountText = Console.ReadLine();

                bool validMenu = char.TryParse(menuText, out selectedMenu);
                bool validAmount = double.TryParse(amountText, out quantity);
                
                if (validAmount && quantity > 0 && quantity <= MaxBatch)
                {
                    if (validMenu && (selectedMenu == 'S' || selectedMenu == 's'))
                    {
                        double ingotAmount = quantity * SmeltRate;

                        Console.WriteLine(
                            $"=> {quantity:F2} {MaterialName} Ore = {ingotAmount:F2} {MaterialName} Ingot"
                        );
                    }
                    else if (validMenu && (selectedMenu == 'B' || selectedMenu == 'b'))
                    {
                        double oreAmount = quantity / SalvageRate;

                        Console.WriteLine(
                            $"=> {quantity:F2} {MaterialName} Ingot = {oreAmount:F2} {MaterialName} Ore"
                        );
                    }
                    else
                    {
                        Console.WriteLine("error: menu");
                    }
                }
                else
                {
                    Console.WriteLine("error: amount");
                }
            }

        }
        
    }
}
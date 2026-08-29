/*
 * Student ID : 1690702756
 * Name       : Lab02
 * Section    : 129C
 * No.        : N/A
 * Course     : GI113 Computer Programming (GI)
 */
namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bossName = "Kirin";
            char rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            Console.WriteLine($"Attack Power: {attackPower}");
            Console.WriteLine($"Crit Multiplier: {critMultiplier}");
            Console.WriteLine($"IsBoss: {isBoss}");
            Console.WriteLine();
            int hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercent}%");
            Console.WriteLine();
            currentHp = currentHp - 60;
            Console.WriteLine();
            Console.WriteLine("Kirin takes 60 damage!");
            Console.WriteLine();
            Console.WriteLine("===== BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercent}%");
            Console.WriteLine();

            // ตัวละคร 1 Uri
            string uriName = "Uri";
            char urirank = 'S';
            int urilevel = 10;
            int urimaxHp = 250;
            int uricurrentHp = 150;
            float uriattackPower = 50.5f;
            double uricritMultiplier = 2.25;
            bool isFighter = true;

            Console.WriteLine("===== URI STATUS: INITIAL =====");
            Console.WriteLine($"Name: {uriName}");
            Console.WriteLine($"Rank: {urirank}");
            Console.WriteLine($"Level: {urilevel}");
            Console.WriteLine($"HP: {uricurrentHp} / {urimaxHp}");
            Console.WriteLine($"Attack Power: {uriattackPower}");
            Console.WriteLine($"Crit Multiplier: {uricritMultiplier}");
            Console.WriteLine($"IsFighter: {isFighter}");

            // ตัวละคร 2 Uka
            string ukaName = "Uka";
            char ukarank = 'A';
            int ukalevel = 9;
            int ukamaxHp = 200;
            int ukacurrentHp = 185;
            float ukaattackPower = 48.5f;
            double ukacritMultiplier = 2.15;
            bool isDancer = false;

            Console.WriteLine("===== UKA STATUS: INITIAL =====");
            Console.WriteLine($"Name: {ukaName}");
            Console.WriteLine($"Rank: {ukarank}");
            Console.WriteLine($"Level: {ukalevel}");
            Console.WriteLine($"HP: {ukacurrentHp} / {ukamaxHp}");
            Console.WriteLine($"Attack Power: {ukaattackPower}");
            Console.WriteLine($"Crit Multiplier: {ukacritMultiplier}");
            Console.WriteLine($"IsDancer: {isDancer}");

            // ตัวละคร 3 Uno
            string unoName = "Uno";
            char unorank = 'B';
            int unolevel = 8;
            int unomaxHp = 100;
            int unocurrentHp = 100;
            float unoattackPower = 48.5f;
            double unocritMultiplier = 1.25;
            bool isHealer = true;

            Console.WriteLine("===== UNO STATUS: INITIAL =====");
            Console.WriteLine($"Name: {unoName}");
            Console.WriteLine($"Rank: {unorank}");
            Console.WriteLine($"Level: {unolevel}");
            Console.WriteLine($"HP: {unocurrentHp} / {unomaxHp}");
            Console.WriteLine($"Attack Power: {unoattackPower}");
            Console.WriteLine($"Crit Multiplier: {unocritMultiplier}");
            Console.WriteLine($"IsHealer: {isHealer}");

            // ตัวละคร 4 Ume
            string umeName = "Ume";
            char umerank = 'D';
            int umelevel = 5;
            int umemaxHp = 125;
            int umecurrentHp = 95;
            float umeattackPower = 26.5f;
            double umecritMultiplier = 1.45;
            bool isVillager = true;

            Console.WriteLine("===== UME STATUS: INITIAL =====");
            Console.WriteLine($"Name: {umeName}");
            Console.WriteLine($"Rank: {umerank}");
            Console.WriteLine($"Level: {umelevel}");
            Console.WriteLine($"HP: {umecurrentHp} / {umemaxHp}");
            Console.WriteLine($"Attack Power: {umeattackPower}");
            Console.WriteLine($"Crit Multiplier: {umecritMultiplier}");
            Console.WriteLine($"IsVillager: {isVillager}");

         
        }
    }
    
}
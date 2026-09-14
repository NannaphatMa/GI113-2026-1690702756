/*
* Student ID : 1690702756
* Name       : Lab02
* Section    : 129C
* No.        : N/A
* Course     : GI113 Computer Programming (GI)
*/

namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string GameTitle = "Teamfight Tactics";

            var heroName = "Ahri";
            var heroRange = '4';
            int heroStars = 1;
            float magicDamage = 40.5f;
            double attackSpeed = 0.8;
            bool isBlossom = true;

            Console.WriteLine($"===== {GameTitle} =====");
            Console.WriteLine($"Hero Name: {heroName}");
            Console.WriteLine($"Range: {heroRange}");
            Console.WriteLine($"Stars: {heroStars}");
            Console.WriteLine($"Magic Damage: {magicDamage}");
            Console.WriteLine($"Attack Speed: {attackSpeed}");
            Console.WriteLine($"Is Blossom: {isBlossom}");
            Console.WriteLine();

            double heroStarsAsDouble = heroStars; 
            Console.WriteLine($"Stars as double (implicit): {heroStarsAsDouble}");

            int attackSpeedTruncated = (int)attackSpeed;              
            int attackSpeedRounded = Convert.ToInt32(attackSpeed);   
            Console.WriteLine($"Attack Speed cast (truncates)  : {attackSpeedTruncated}");
            Console.WriteLine($"Attack Speed Convert (rounds)  : {attackSpeedRounded}");


            
        }
    }
}
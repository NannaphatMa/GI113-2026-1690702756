/*
 * Student ID : 1690702756
 * Name       : Lab02
 * Section    : 129C
 * No.        : N/A
 * Course     : GI113 Computer Programming (GI)
 */
namespace Lab05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Game Title, Sub-title
            Console.WriteLine("==>> MY GAME DEE ,,==");
            Console.WriteLine("Hero vs. Monster, Fight damge calculator\n");

            // Hero stats input HP, ATK, DEF
            Console.Write("Hero Health: ");
            bool heroHpOk = int.TryParse(Console.ReadLine(), out int heroHp);
            Console.Write("Hero Attack: ");
            bool heroAtkOk = int.TryParse(Console.ReadLine(), out int heroAtk);
            Console.Write("Hero Defense: ");
            bool heroDefOk = int.TryParse(Console.ReadLine(), out int heroDef);

            // Monster stats input
            Console.Write("Monster Health: ");
            bool monHpOk = int.TryParse(Console.ReadLine(), out int monHp);
            Console.Write("Monster Attack: ");
            bool monAtkOk = int.TryParse(Console.ReadLine(), out int monAtk);
            Console.Write("Monster Defense: ");
            bool monDefOk = int.TryParse(Console.ReadLine(), out int monDef);

            // Input validation
            bool isHeroIntValid = heroHpOk && heroAtkOk && heroHpOk;
            bool isMonIntValid = monHpOk && monAtkOk && monDefOk;
            Console.WriteLine($"\nHERO STATUS VALID: {isHeroIntValid}");
            Console.WriteLine($"MONSTER STATUS VALID: {isMonIntValid}");

            Console.WriteLine($"[HERO       HP: {heroHp} ATK: {heroAtk} DEF: {heroDef}");
            Console.WriteLine($"[MONSTER    HP: {monHp}  ATK: {monAtk}  DEF: {monDef}");
            //bool allIntValid = isHeroIntValid && isMonIntValid;
            // ถ้าเอาแค่ชื่อ bool มาเช็ค คือ เช็คว่าเป็นจริงไหม แต่ถ้าใส่ ! ด้านหน้าคือตรงข้าม (จริง -> เท็จ)

            // Compound assignment : +=
            int potionHeal = 8;
            //heroHp = hero + potionHeal;  // แบบยาว
            heroHp = potionHeal;           // แบบสั้น
            Console.WriteLine($"\nHero drinks a potion, healing {potionHeal} HP. Hero HP now {heroHp}");

            // Arithmetic + การโจมตีธรรมดา
            int normDmg = Math.Max(0, heroAtk - monDef); // ความแรงการโจมตีขึ้นอยู่กับค่าป้องกันของศัตรู
            Console.WriteLine($"\nNormal Attack would dead: {normDmg} DMG");

            // Precedence การโจมตีพิเศษ
            int pwrDmg = Math.Max(0, (heroAtk *2)- monDef);
            Console.WriteLine($"\nPower Attack would dead: {pwrDmg} DMG");

            // Random, Simple percent chance of crtical chance
            Random randomSomething = new Random();
            int roll = randomSomething.Next(1, 101); // ต้อง +1 ค่ามากสุดเสมอ เช่น อยากได้ 100 ต้อง 101
            bool isCrit = roll <= 10; // 10 percent Chance จาก 100
            int critDmg = normDmg + Convert.ToInt32(isCrit) * normDmg; // Bool 1 หรือ 0
            Console.WriteLine($"\nCritical hit roll: {roll} (critical: {isCrit}");
            Console.WriteLine($"If critical, normal attack would instead deal: {critDmg}");

;


        }
    }
}

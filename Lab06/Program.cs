/*
 * Student ID : 1690702756
 * Name       : Lab02
 * Section    : 129C
 * No.        : N/A
 * Course     : GI113 Computer Programming (GI)
 */
namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int lives = 1;

            //if (lives == 0) // ใส่เงื่อนไขที่ต้องการเช็ค ค่าที่ได้ต้องเป็น bool true / false
            //{
            // Codeด้านในจะรันก็ต่อเมื่อ if เป็น true เท่านั้น
            //Console.WriteLine("Game Over");
            //}
            //else
            //{
            // Console.WriteLine("Keep Fighting");
            //}

            // ถ้า if ทำงานเสร็จแล้ว หรือเป็น false จะทำงานต่อมาบรรทัดด้านนอกทันที
            // Console.WriteLine("Continue Code");

            // int level = 10;
            //bool hasKey = true;

            //Console.WriteLine("Your Level (1-99): ");
            //bool inputValid = int.TryParse(Console.ReadLine(), out int level);

            //if (inputValid || level < 99) // เงื่อนไขที่ถือว่าข้อมูลผิด
            //{
            //Console.WriteLine("Invalid Level"); // เตือนเมื่อ user ใส่ข้อมูลผิด
            //}    

            // เมื่อใช้เงื่อนไขหลายเคส ให้เช็คเลขจาก มาก -> น้อย เสมอ
            //else if (level >= 10 && hasKey) // เงื่อนไข 1 หรือเท่ากับ 10 และต้องมีกุญแจ
            //{
            //Console.WriteLine("The door open.");
            //}
            //else if (level >= 5) // เงื่อนไข 2 ถ้ายังไม่ตรงเงื่อนไข 1
            //{
            //Console.WriteLine("Boss floor unloked");
            //}
            //else // เมื่อไม่ตรงสักเงื่อนไข
            //{
            //Console.WriteLine("The door stay shut.");
            //}

            //bool isPosioned = true;

            //if (isPosioned == true) // เช็คว่าเป็นจริงไหม
            //{
            //Console.WriteLine("You Died");
            //}
            //else if (isPosioned != true) // เช็คว่าเป็นเท็จไหม  
            //{
            //Console.WriteLine("You Lives");
            //}

            int heroStamina = 500;
            int monStamina = 400;
            int atk = 100;
            int staminaHeal = 50;
            
            Console.WriteLine("==>> WAYFARER <<==");
            Console.WriteLine("Hero vs. Monster Actions:");
            Console.WriteLine("ACTION 1: ATTACK");
            Console.WriteLine("ACTION 2: REST TO HEAL STAMINA");

            Console.Write("Choose your action (1-2): ");
            bool userInput = int.TryParse(Console.ReadLine(), out int choice);

            if (!userInput || choice < 1 || choice > 2 || choice > 3)
            {
                if (choice < 1 || choice > 2)
                {
                    Console.WriteLine("Choose a number between 1-2");
                }
                else
                {
                    Console.WriteLine("Invalid input, plese choose number between 1-2 only");

                }
            }
            else if (choice == 1) // โจมตี
            {
                monStamina -= atk;
                if (monStamina <= 0)
                {
                    Console.WriteLine("Monster Defeat!");
                }
                else
                {
                    Console.WriteLine($"Hero Attacked the Monster, Monster have {monStamina} Stamina Left");
                }
                    Console.WriteLine($"Monster cannot use skills");
            }
            else if (choice == 2) // พักเพื่อฮีลสตามินา
            {
                heroStamina += staminaHeal;
                Console.WriteLine($"Player rested to heal stamina, player now have {heroStamina} Stamina");
            }

        }
    }
}

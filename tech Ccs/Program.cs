using System;


namespace tech_Ccs

{

 


    internal class Program
    {
   
        static void Main(string[] args)

        {
            Random random = new Random();

            int playerHelth = 100;
            int playerEnergy = 100;

            int enemyHelth = 100;
            int enemyEnergy = 100;

            int action = -1;

            while (true)
            {
                Console.Clear();

                Console.WriteLine(@"     Жизни: {0}           Жизни вируса: {1} ",playerHelth,enemyHelth);
                Console.WriteLine(@"   Энергия: {0}         Энергия вируса: {1} ", playerEnergy, enemyEnergy);

                Console.WriteLine();

                Console.WriteLine("1. Почистить папку Temp (20 урона, -10 энергии)");
                Console.WriteLine("2. Использовать Касперского (30 урона, -40 энергии)");
                Console.WriteLine("3. Выпить кофе (+20 энергии)");
                Console.WriteLine("4. Заказать доставку пиццы(+30 жизни, -20 энергии)");

                Console.WriteLine();

                
                if (enemyHelth <= 0)
                {
                    Console.WriteLine("Ты выиграл!");
                    break;
                }
                if (playerHelth <= 0)
                {
                    Console.WriteLine("Вирус победил!");
                    break;
                }

                Console.WriteLine("Введите число от 1 до 4");
                Console.WriteLine();

                action = int.Parse(Console.ReadLine());

                if (action==1)
                {
                    if (playerEnergy >= 10)
                    {
                        enemyHelth -= 20;
                        playerEnergy -= 10;
                    }
                    else
                    {
                        Console.WriteLine("Недостаточно энергии. Ты пропустил ход!");
                        Console.WriteLine("Нажмите Enter");
                        Console.ReadLine();
                    }
                }
                if (action == 2)
                {
                    if (playerEnergy >= 40)
                    {
                        enemyHelth -= 30;
                        playerEnergy -= 40;
                    }
                    else
                    {
                        Console.WriteLine("Недостаточно энергии. Ты пропустил ход!");
                        Console.WriteLine("Нажмите Enter");
                        Console.ReadLine();
                    }
                }
                if (action == 3)
                {
                    playerEnergy += 20;
                }

                if (action == 4)
                {
                    if (playerEnergy >= 20)
                    {
                        playerHelth += 30;
                        playerEnergy -= 20;
                    }
                    else
                    {
                        Console.WriteLine("Недостаточно энергии. Ты пропустил ход!");
                        Console.WriteLine("Нажмите Enter");
                        Console.ReadLine();
                    }
                }

                

                if (enemyEnergy == 0)
                {
                    action = 3;
                }
                else if(enemyHelth <= 30 && enemyEnergy >= 20 )
                    {
                    action = 4;
                }
                else if(enemyHelth > 30 && enemyEnergy <= 40)
                {
                    action = 1;
                }
                else
                {
                    action = random.Next(1, 3);
                }


                if (action == 1)
                {
                    if (enemyEnergy >= 10)
                    {
                        playerHelth -= 20;
                        enemyEnergy -= 10;
                        Console.WriteLine("Вы получили 20 урона");
                        Console.WriteLine();
                        Console.WriteLine("Нажмите Enter");
                        Console.ReadLine();
                    }
                   
                }
                if (action == 2)
                {
                    if (enemyEnergy >= 40)
                    {
                        playerHelth -= 30;
                        enemyEnergy -= 40;
                        Console.WriteLine("Вы получили 30 урона");
                        Console.WriteLine();
                        Console.WriteLine("Нажмите Enter");
                        Console.ReadLine();
                    }
                  
                }
                if (action == 3)
                {
                    enemyEnergy += 20;
                    Console.WriteLine("Вирус пополнил энергию на 20");
                    Console.WriteLine();
                    Console.WriteLine("Нажмите Enter");
                    Console.ReadLine();
                }

                if (action == 4)
                {
                    if (enemyEnergy >= 20)
                    {
                        enemyHelth += 30;
                        enemyEnergy -= 20;
                        Console.WriteLine("Вирус пополнил здоровье на 30");
                        Console.WriteLine();
                        Console.WriteLine("Нажмите Enter");
                        Console.ReadLine();
                    }
                    
                }

            }
            Console.ReadLine();
        }

    }
}

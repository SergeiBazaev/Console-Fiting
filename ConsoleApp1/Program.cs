using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void DrawCross (int x, int y, int size)
        {
            for (int i = x; i <= x + size; i++)
            {
                for (int j = y; j <= y + size; j++)
                {
                    if ( i - j == x - y || i + j == y + x + size)
                    {
                        Console.SetCursorPosition(i, j);
                        Console.Write("█");
                    }
                }
            }
        }
        static void DrowRectangle(int x, int y, int size)
        {
            for (int i = x; i <= x + size; i++)
            {
                for (int j = y; j <= y + size; j++)
                {
                    if (i == x || i == x + size || j == y || j == y + size)
                    {
                        Console.SetCursorPosition(i, j);
                        Console.Write("█");
                    }
                }
            }
        }
        static void DrowField(int width, int height, int sellSize)
        {
            for (int y = 0; y <= height; y += sellSize)
            {
                for (int x = 0; x < width; x++)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write("█");
                }
            }
            for (int x = 0; x <= width; x += sellSize)
            {
                for (int y = 0; y <= height; y++)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write("█");
                }
            }
        }
        static void Main(string[] args)
        {
            Console.SetWindowSize(90, 34);
            Console.SetBufferSize(90, 34);
            
            DrowField(33, 33, 11);

            for (int i = 1; i < 10; i++)
            {
                int a = (i - 1) % 3 * 11 + 5;
                int b = (i - 1) / 3 * 11 + 1;
                Console.SetCursorPosition(a, b);
                Console.Write(i);
            }

            int Win = -1;
            int input;

            

            int c1, c2, c3, c4, c5, c6, c7, c8, c9;
            c1 = -1; c2 = -2; c3 = -3; c4 = -4; c5 = -5; c6 = -6; c7 = -7; c8 = -8; c9 = -9;
            for (int i = 0; i < 9; i++)
            {
                Console.SetCursorPosition(35, 0);
                Console.Write("                                              ");
                Console.SetCursorPosition(35, 0);
                Console.Write("Введите номер клетки: ");

                


                bool errorInput = !int.TryParse(Console.ReadLine(), out input);

                if (input < 1 || input > 9)
                {
                    errorInput = true;
                    Console.SetCursorPosition(35, 3);
                    Console.Write("                                            ");
                    Console.SetCursorPosition(35, 3);
                    Console.Write("Ошибка! Вводите только числа от 1 до 9! ");
                }
                if (input == 1 && c1 >= 0)
                {
                    errorInput = true;
                    Console.SetCursorPosition(35, 3);
                    Console.Write("                                             ");
                    Console.SetCursorPosition(35, 3);
                    Console.Write("Ошибка! Клетка уже занята! ");
                }
                if (input == 2 && c2 >= 0)
                { 
                    errorInput = true;
                    Console.SetCursorPosition(35, 3);
                    Console.Write("                                              ");
                    Console.SetCursorPosition(35, 3);
                    Console.Write("Ошибка! Клетка уже занята! ");
                }
                if (input == 3 && c3 >= 0)
                {
                    errorInput = true;
                    Console.SetCursorPosition(35, 3);
                    Console.Write("                                              ");
                    Console.SetCursorPosition(35, 3);
                    Console.Write("Ошибка! Клетка уже занята! ");
                }
                if (input == 4 && c4 >= 0)
                {
                    errorInput = true;
                    Console.SetCursorPosition(35, 3);
                    Console.Write("                                              ");
                    Console.SetCursorPosition(35, 3);
                    Console.Write("Ошибка! Клетка уже занята! ");
                }
                if (input == 5 && c5 >= 0)
                {
                    errorInput = true;
                    Console.SetCursorPosition(35, 3);
                    Console.Write("                                                ");
                    Console.SetCursorPosition(35, 3);
                    Console.Write("Ошибка! Клетка уже занята! ");
                }
                if (input == 6 && c6 >= 0)
                {
                    errorInput = true;
                    Console.SetCursorPosition(35, 3);
                    Console.Write("                                                ");
                    Console.SetCursorPosition(35, 3);
                    Console.Write("Ошибка! Клетка уже занята! ");
                }
                if (input == 7 && c7 >= 0)
                {
                    errorInput = true;
                    Console.SetCursorPosition(35, 3);
                    Console.Write("                                                 ");
                    Console.SetCursorPosition(35, 3);
                    Console.Write("Ошибка! Клетка уже занята! ");
                }
                if (input == 8 && c8 >= 0)
                {
                    errorInput = true;
                    Console.SetCursorPosition(35, 3);
                    Console.Write("                                                  ");
                    Console.SetCursorPosition(35, 3);
                    Console.Write("Ошибка! Клетка уже занята! ");
                }
                if (input == 9 && c9 >= 0)
                {
                    errorInput = true;
                    Console.SetCursorPosition(35, 3);
                    Console.Write("                                                   ");
                    Console.SetCursorPosition(35, 3);
                    Console.Write("Ошибка! Клетка уже занята! ");
                }

                if(errorInput == true)
                {
                    
                    i--;
                    continue;
                }

               

                if (input == 1) c1 = i % 2;
                if (input == 2) c2 = i % 2;
                if (input == 3) c3 = i % 2;
                if (input == 4) c4 = i % 2;
                if (input == 5) c5 = i % 2;
                if (input == 6) c6 = i % 2;
                if (input == 7) c7 = i % 2;
                if (input == 8) c8 = i % 2;
                if (input == 9) c9 = i % 2;


                int x = (input - 1) % 3 * 11 + 2;
                int y = (input - 1) / 3 * 11 + 2;

                if ( i% 2 == 0)
                {
                    DrawCross(x, y, 7);
                    Console.SetCursorPosition(35,(i+ 5));
                    Console.WriteLine($"Вы поставили крестик на клетку номер: {input} ");
                    Console.SetCursorPosition(35, 3);
                    Console.Write("                                            ");
                }
                else
                {
                    DrowRectangle(x, y, 7);
                    Console.SetCursorPosition(35, (i + 5));
                    Console.WriteLine($"Вы поставили нолик на клетку номер: {input} ");
                    Console.SetCursorPosition(35, 3);
                    Console.Write("                                           ");
                }

                if (c1 == c2 && c2 == c3) Win = c1;
                if (c4 == c5 && c5 == c6) Win = c4;
                if (c7 == c8 && c8 == c9) Win = c7;
                if (c1 == c4 && c4 == c7) Win = c1;
                if (c2 == c5 && c5 == c8) Win = c2;
                if (c3 == c6 && c6 == c9) Win = c3;
                if (c1 == c5 && c5 == c9) Win = c1;
                if (c3 == c5 && c5 == c7) Win = c3;
                
                if(Win == 0)
                {
                    Console.SetCursorPosition(35, 15);
                    Console.Write("Победили крестики ");
                    break;
                }
                if (Win == 1)
                {
                    Console.SetCursorPosition(35, 15);
                    Console.Write("Победили нолики ");
                    break;
                }

               

            }

            Console.SetCursorPosition(35, 15);
            if (Win == -1) Console.WriteLine("Ничья!");

            Console.ReadLine();

        }
    }
}

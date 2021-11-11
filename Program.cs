using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_WorkConsole3
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Добро пожаловать в игру Камень Ножницы Бумага");
            Console.WriteLine("Введите ваше имя");
            string userName = Console.ReadLine();
            Console.WriteLine($"{userName} а теперь установите пароль ");
            string passwordSet = Console.ReadLine();
            Console.WriteLine("Введите пароль для потверждения ");
            string passwordChek = Console.ReadLine();
            while (passwordSet!=passwordChek)
            {
                Console.WriteLine("Не верный пароль.Повторите попытку");
                passwordChek = Console.ReadLine();
            }
            if (passwordChek==passwordSet)
            {
                Console.Clear();
                Console.WriteLine($"{userName}  пароль установлен");
            }

            Console.WriteLine("Меню игры: 1 - играть, 2 - сменить имя, 3 сменить пароль, 4 - настройки вида, 0 - выход.");
            string userInput = Console.ReadLine();

            while (userInput != "0")                
            {                
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Начнем игру? 1 - Старт, 2 - Назад");
                        string userInputGame = Console.ReadLine();
                        if (userInputGame == "1")
                        {
                            while (userInputGame == "1")
                            {
                                Console.WriteLine("Правила игры просты выбери 1 - камень 2 - ножницы 3 - бумагу и победи");
                                                                            // 1 камень    2 ножницы  3 бумага 
                                string userPlay =  Console.ReadLine();
                                Random rand  = new Random();
                                int botPlay = rand.Next(1, 4);
                                if (userPlay == "1")
                                {
                                    if (botPlay == 1) 
                                    {
                                        Console.WriteLine($"{userName} показали камень но и противник тоже выбрал камень. Ничья! ");
                                    }
                                    else if(botPlay == 2)
                                    {
                                        Console.WriteLine($"{userName} показали камень, а противник ножницы. Поздравляем вы победили!");
                                    }
                                    else if (botPlay == 3)
                                    {
                                        Console.WriteLine($"{userName} показали камень, а противник бумагу. Противник победил!");
                                    }
                                }
                                else if(userPlay == "2")
                                {
                                    if(botPlay == 1)
                                    {
                                        Console.WriteLine($"{userName} показали ножницы, а противник камень. Противник победил!");
                                    }
                                    else if(botPlay == 2)
                                    {
                                        Console.WriteLine($"{userName} показали ножницы но противник тоже выбрал ножницы. Ничья!");
                                    }
                                    else if(botPlay == 3)
                                    {
                                        Console.WriteLine($"{userName} показали ножницы, а противник бумагу. Поздравляем вы победили!");
                                    }
                                }
                                else if(userPlay == "3")
                                {
                                    if(botPlay == 1)
                                    {
                                        Console.WriteLine($"{userName} показали бумагу, а противник камень. Поздравляем вы победили!");
                                    }
                                    else if(botPlay == 2)
                                    {
                                        Console.WriteLine($"{userName} показали бумагу, а противние ножницы. Противник победил!");
                                    }
                                    else if(botPlay == 3)
                                    {
                                        Console.WriteLine($"{userName} показали бумагу но противник тоже выбрал бумагу. Ничья");
                                    }
                                }
                                Console.WriteLine($"{userName} продолжим игру? 1 - продолжить, 2 - закончить");
                                userInputGame = Console.ReadLine();
                            }
                        }                                                        
                        break;
                        
                    case "2":
                        Console.WriteLine("Для смены имя введите пароль.");
                        passwordChek = Console.ReadLine();
                        if (passwordChek == passwordSet)
                        {
                            Console.WriteLine("Введите новое имя");
                            userName = Console.ReadLine();
                            Console.WriteLine($"{userName}  ваше новое имя");
                        }
                        else                        
                            Console.WriteLine("Пароль веден не верно");                          
                        break;

                    case "3":
                        Console.WriteLine("Для смены пароля  введите старый пароль.");
                        passwordChek = Console.ReadLine();
                        if (passwordChek == passwordSet)
                        {
                            Console.WriteLine("Введите новый пароль");
                            passwordSet = Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine($"{userName}  ваш новый пароль устрановлен.");
                        }
                        else
                            Console.WriteLine("Пароль введен не верно");
                        break;

                    case "4":
                        Console.WriteLine("Настроить внешний вид игры\n 1 - изменить цвет текста\n 2 - изменить фон.");
                        string userInputSettings = Console.ReadLine();
                        if (userInputSettings == "1")
                        {
                            Console.WriteLine("Выберите цвет текста 1 - красный. 2 - зеленый. 3 - белый.");
                            string userInputColor = Console.ReadLine();

                            if (userInputColor == "1")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                            }  
                            else if(userInputColor == "2")
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                            }
                            else if(userInputColor == "3")
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                        }
                        else if(userInputSettings == "2")
                        {
                            Console.WriteLine("Выберите цвет фона 1 - красный. 2 - зеленый. 3 - чёрный.");
                            string userInputColor = Console.ReadLine();
                            if (userInputColor == "1")
                            {
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.Clear();
                            }
                            else if (userInputColor == "2")
                            {
                                Console.BackgroundColor = ConsoleColor.Green;
                                Console.Clear();
                            }
                            else if (userInputColor == "3")
                            {
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.Clear();
                            }
                        }                                               
                        break;
                    
                }
                Console.WriteLine("Меню игры: 1 - играть, 2 - сменить имя, 3 сменить пароль, 4 - настройки вида, 0 - выход.");
                userInput = Console.ReadLine();
            }
            Console.WriteLine("Выход из игры.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Theme_03
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Описание игры: программа загадывает случайное число от 12 до 120.");            
            Console.WriteLine();
            Console.WriteLine("Игроки ходят по очереди.");
            Console.WriteLine("Игрок, ход которого указан вводит число, которое может принимать значения 1, 2, 3 или 4.");
            Console.WriteLine("Введенное число вычитается из числа игры. Выигрывает тот игрок, после чьего хода число игры ");
            Console.WriteLine("обратилось в 0");
            Console.WriteLine();
            Console.WriteLine("Введите имя первого игрока (или нажмите Enter чтобы играл компьютер): ");
            var userName1 = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Введите имя второго игрока (или нажмите Enter чтобы играл компьютер): ");
            var userName2 = Console.ReadLine();

            var randomize = new Random();
            //var gameNumber = randomize.Next(12, 121);
            var gameNumber = randomize.Next(12, 15);

            for (var tryNumber = 0; ; tryNumber++)
            {
                Console.WriteLine();
                Console.WriteLine($"Число: {gameNumber}");

                var userName = tryNumber % 2 == 0 ? userName1 : userName2;
                var isComputer = userName == "";
                if (isComputer)
                {
                    userName = $"Мега-мозг-{(tryNumber % 2)+1}";
                }

                Console.Write($"Ход {userName}: ");

                int userTry;
                if (!isComputer)
                {
                    userTry = Convert.ToInt32(Console.ReadLine());

                    for (; userTry < 1 || 4 < userTry || gameNumber < userTry;)
                    {
                        Console.WriteLine("Недопустимое число, введите от 1 до 4, но не больше текущего числа игры");
                        userTry = Convert.ToInt32(Console.ReadLine());
                    }

                }
                else
                {
                    var computerTry = gameNumber % 5;
                    if (computerTry == 0)
                    {
                        computerTry = randomize.Next(1, 5);
                    }

                    Console.WriteLine(computerTry);
                    userTry = computerTry;
                }

                gameNumber = gameNumber - userTry;

                if (gameNumber <= 0)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Число: {gameNumber}");

                    Console.WriteLine();
                    Console.WriteLine("Конец игры");

                    Console.WriteLine($"Выиграл {userName}");

                    break;
                }

            }



            //Console.WriteLine($"Число: {gameNumber}");
            //Console.Write($"Ход {userName2}: ");
            //var userTry2 = Convert.ToInt32(Console.ReadLine());
            //gameNumber = gameNumber - userTry2;




            // Просматривая сайты по поиску работы, у вас вызывает интерес следующая вакансия:

            // Требуемый опыт работы: без опыта
            // Частичная занятость, удалённая работа
            //
            // Описание 
            //
            // Стартап «Micarosppoftle» занимающийся разработкой
            // многопользовательских игр ищет разработчиков в свою команду.
            // Компания готова рассмотреть C#-программистов не имеющих опыта в разработке, 
            // но желающих развиваться в сфере разработки игр на платформе .NET.
            //
            // Должность Интерн C#/
            //
            // Основные требования:
            // C#, операторы ввода и вывода данных, управляющие конструкции 
            // 
            // Конкурентным преимуществом будет знание процедурного программирования.
            //
            // Не технические требования: 
            // английский на уровне понимания документации и справочных материалов
            //
            // В качестве тестового задания предлагается решить следующую задачу.
            //
            // Написать игру, в которою могут играть два игрока.
            // При старте, игрокам предлагается ввести свои никнеймы.
            // Никнеймы хранятся до конца игры.
            // Программа загадывает случайное число gameNumber от 12 до 120 сообщая это число игрокам.
            // Игроки ходят по очереди(игра сообщает о ходе текущего игрока)
            // Игрок, ход которого указан вводит число userTry, которое может принимать значения 1, 2, 3 или 4,
            // введенное число вычитается из gameNumber
            // Новое значение gameNumber показывается игрокам на экране.
            // Выигрывает тот игрок, после чьего хода gameNumber обратилась в ноль.
            // Игра поздравляет победителя, предлагая сыграть реванш
            // 
            // * Бонус:
            // Подумать над возможностью реализации разных уровней сложности.
            // В качестве уровней сложности может выступать настраиваемое, в начале игры,
            // значение userTry, изменение диапазона gameNumber, или указание большего количества игроков (3, 4, 5...)

            // *** Сложный бонус
            // Подумать над возможностью реализации однопользовательской игры
            // т е игрок должен играть с компьютером


            // Демонстрация
            // Число: 12,
            // Ход User1: 3
            //
            // Число: 9
            // Ход User2: 4
            //
            // Число: 5
            // Ход User1: 2
            //
            // Число: 3
            // Ход User2: 3
            //
            // User2 победил!
        }
    }
}

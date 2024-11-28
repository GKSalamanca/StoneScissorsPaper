namespace Камень_Ножницы_Бумага
{
  
        internal class Program
        {
            static void Main(string[] args)
            {
                int Player1;
                int Player2;

                string result1 = null;
                string result2 = null;

                //Цикл для повторения игры
                while (true)
                {
                    // Чистим консоль после возвращения к новой игре
                    Console.Clear();

                    //обработка исключений на ввод не верного формата
                    try
                    {
                        Console.WriteLine("1-Камень");
                        Console.WriteLine("2-Ножницы");
                        Console.WriteLine("3-Бумага");

                        Console.WriteLine("Игрок один вводит значение (1 или 2 или 3)");

                        //ввод данных пользователем
                        Player1 = int.Parse(Console.ReadLine());
                    }

                    // Оповещаем пользователя о том что введены не верные данные
                    catch (Exception)
                    {
                        Console.WriteLine("Введен не верный формат данных");
                        Console.ReadLine();
                        continue;
                    }

                    // Чистим консоль после и ввод первого игрока для исключения того, что при вводе своего значения второй игрок увидит ввод первого 
                    Console.Clear();

                    // Аналогично для второго пользователя
                    try
                    {
                        Console.WriteLine("1-Камень");
                        Console.WriteLine("2-Ножницы");
                        Console.WriteLine("3-Бумага");
                        Console.WriteLine("Игрок два вводит значение (1 или 2 или 3)");
                        Player2 = int.Parse(Console.ReadLine());
                    }

                    catch (Exception)
                    {
                        Console.WriteLine("Введен не верный формат данных");
                        Console.ReadLine();
                        continue;
                    }
                    //Системная аналогия
                    Console.Clear();

                    // Определяем результат по введенным данным игроком 1
                    if (Player1 == 1)
                    {
                        result1 = "Камень";
                    }
                    else if (Player1 == 2)
                    {
                        result1 = "Ножницы";
                    }
                    else if (Player1 == 3)
                    {
                        result1 = "Бумага";
                    }

                    // Определяем результат по введенным данным игроком 2
                    if (Player2 == 1)
                    {
                        result2 = "Камень";
                    }
                    else if (Player2 == 2)
                    {
                        result2 = "Ножницы";
                    }
                    else if (Player2 == 3)
                    {
                        result2 = "Бумага";
                    }


                    //Функция определяющая ничью в зависимости от ввода
                    if ((Player1 == 1 && Player2 == 1) || (Player1 == 2 && Player2 == 2) || (Player1 == 3 && Player2 == 3))
                    {
                        Console.WriteLine($"Игрок 1 = {result1}");
                        Console.WriteLine($"Игрок 2 = {result2}");
                        Console.WriteLine("Ничья");
                    }

                    //Функция определяющая победу первого игрока в зависимости от ввода
                    else if ((Player1 == 1 && Player2 == 2) || (Player1 == 2 && Player2 == 3) || (Player1 == 3 && Player2 == 1))
                    {
                        Console.WriteLine($"Игрок 1 = {result1}");
                        Console.WriteLine($"Игрок 2 = {result2}");
                        Console.WriteLine("Победил Игрок 1");
                    }

                    //Функция определяющая победу второго игрока в зависимости от ввода
                    else if ((Player1 == 1 && Player2 == 3) || (Player1 == 2 && Player2 == 1) || (Player1 == 3 && Player2 == 2))
                    {
                        Console.WriteLine($"Игрок 1 = {result1}");
                        Console.WriteLine($"Игрок 2 = {result2}");
                        Console.WriteLine("Победил Игрок 2");
                    }

                    // В случае если введены данный 1 или 2 или 3
                    else
                    {
                        Console.WriteLine("Неверный ввод. Введите 1 или 2 или 3");
                    }

                    Console.ReadKey();
                }
            }
        }
   }

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace D.E.L.E.T.E_plz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    int razm, diapoz, i, index, detect; // Задаём переменные
                    Console.WriteLine("Задайте размер: ");
                    razm = Convert.ToInt32(Console.ReadLine());
                    if (razm < 11) //Ограничение размера массива 
                    {
                        Console.WriteLine("Задайте диапазон: ");
                        diapoz = Convert.ToInt32(Console.ReadLine()); //Задача диапазона
                        if (diapoz < 15)
                        {
                            int[] mas = new int[razm];
                            Random rnd = new Random(); //Генерация
                            for (i = 0; i < razm; i++)
                            {
                                mas[i] = rnd.Next(diapoz);
                            }

                            for (i=0; i<mas.Length; i++)
                            {
                                Console.Write(mas[i] + " " ); // Вывод массива
                            }
                            Console.WriteLine(" ");
                            Console.WriteLine("Что ищите? Напишите пожалуйста"); // Выбираем число!
                            index=Convert.ToInt32(Console.ReadLine()); // Индексируем 
                            Console.WriteLine("Искомое значение: " + mas[index]); // Выводим искомое значение по его индексу
                            Console.WriteLine("Введите 666, чтобы избрать путь уничтожения, или введите 777 чтобы выбрать путь созидания..."); // Выбираем путь...самурая (Удаление номера или его замена)
                            detect=Convert.ToInt32(Console.ReadLine()); // Давайте проверять!
                            if (detect == 666 || detect == 777) // Кнопки
                            {
                                if (detect == 666) // Если ввели вот енто, то мы аннигилируем значение
                                {
                                    var puppet = mas.ToList(); // Было
                                    puppet.RemoveAt(index); // Удалило
                                    var ulrtamassive = puppet.ToArray(); // Стало
                                    Console.WriteLine("Обновляем массив на раз два:"); 
                                    for (i=0; i<ulrtamassive.Length; i++) // Выводим из массива
                                    {
                                        Console.Write(ulrtamassive[i]+ " ");
                                    }
                                    
                                }

                                if (detect == 777) // Если ввели енто, то созидаем
                                {
                                    Console.WriteLine("Что вы хотите поменять в своей жизни? Напишите номер, на который заменяете:"); // На что заменяем
                                    int backflip = Convert.ToInt32(Console.ReadLine());
                                    mas[index] = backflip; // Изменённый массив
                                    for (i=0; i<mas.Length; i++)
                                    {
                                        Console.Write(mas[i] + " ");
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Думается что-то тут не так...");
                            }
                        }
                        else
                        {
                            Console.WriteLine("НЕВОЗМОЖНЫЙ ДИАПОЗОН Я ВАС УМОЛЯЮ!");
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine("Увы, на такое сия программа не способна, неподходящий размер =3");
                    }
                    Console.ReadKey();
                }
                catch
                {
                    Console.WriteLine("Здравствуйте! Вы что-то неправильно поняли! Пожалуйста, больше так не делайте, следующая ошибка отвечает за запуск ядерных ракет....");
                }
            }
        }
    }
}

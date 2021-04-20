using System;
using System.Collections.Generic;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace cartoteka
{
    class Program
    {


        static void Main()
        {
            List<book> biblioteka = new List<book>();
            int Count = 5;

            biblioteka.Add(new book(1, "Л.Н.Толстой", "Война и мир 1 том", "Издательство АСТ", "Классическая проза", "Да", "Хорошее"));
            biblioteka.Add(new book(2, "Л.Н.Толстой", "Война и мир 2 том", "Издательство АСТ", "Классическая проза", "Да", "Хорошее"));
            biblioteka.Add(new book(3, "Л.Н.Толстой", "Война и мир 2 том", "Издательство АСТ", "Классическая проза", "Да", "Хорошее"));
            biblioteka.Add(new book(4, "Л.Н.Толстой", "Анна Каренина", "Издательство АСТ", "Драма", "Да", "Хорошее"));


            while (true)
            {
                Console.WriteLine("Библиотека");
                Console.WriteLine("1 Вывод книг");
                Console.WriteLine("2 Редактирование книги");
                Console.WriteLine("3 Добавление книги");
                Console.WriteLine("4 Удаление книги");
                Console.WriteLine("5 Выгрузка всех книг в файл");
                Console.WriteLine("6 Загрузка книг из файла");

                int chose = Convert.ToInt32(Console.ReadLine()); ;


                if (chose == 3)
                {

                    Console.WriteLine("Автор");
                    string Author = Convert.ToString(Console.ReadLine());
                    // Console.WriteLine(Author);
                    Console.WriteLine("Название");
                    string Name = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Издательство");
                    string PublishingHouse = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Раздел");
                    string Section = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Наличие");
                    string Availability = Convert.ToString(Console.ReadLine());
                        if (Availability =="Да" | Availability =="Нет")
                        {

                        }
                        else
                        {
                            Console.WriteLine("Введите повторно наличие");
                            Availability = Convert.ToString(Console.ReadLine());
                    }

                    Console.WriteLine("Состояние");
                    string Condition = Convert.ToString(Console.ReadLine());

                    biblioteka.Add(new book() { Count = Count, Author = Author, Name = Name, PublishingHouse = PublishingHouse, Section = Section, Availability = Availability, Condition = Condition });
                    Count = Count + 1;

                }
                else if (chose == 1)
                {
                    Console.WriteLine("Выберите пунк меню");
                    Console.WriteLine("1 Весь список");
                    Console.WriteLine("2 По автору");
                    Console.WriteLine("3 По разделу");
                    Console.WriteLine("4 По наличию");

                    int chosebook = Convert.ToInt32(Console.ReadLine());

                    if (chosebook == 1)
                    {
                        foreach (book b in biblioteka)
                            Console.WriteLine("Номер:" + b.Count + " Автор:" + b.Author + " Книга:" + b.Name + " Раздел:" + b.Section + " Издательство:" + b.PublishingHouse + " Наличие:" + b.Availability + " Состояние:" + b.Condition);
                        Console.WriteLine("Ожидается нажатие клавиатуры");
                        Console.ReadLine();
                    }

                    if (chosebook == 2)
                    {
                        Console.WriteLine("Введите автора");
                        string author = Convert.ToString(Console.ReadLine());
                       // Console.WriteLine("\r\n");

                        foreach (book b in biblioteka)
                            if (b.Author == author)
                            {
                            Console.WriteLine("Номер:" + b.Count + " Автор:" + b.Author + " Книга:" + b.Name + " Раздел:" + b.Section + " Издательство:" + b.PublishingHouse + " Наличие:" + b.Availability + " Состояние:" + b.Condition);
                            }
                            else
                            {
                                Console.WriteLine("Такого автора нет "+ " \r\n");
                                break;
                            }
                    }

                    if (chosebook == 3)
                    {
                        Console.WriteLine("Введите раздел");
                        string Section = Convert.ToString(Console.ReadLine());
                        // Console.WriteLine("\r\n");

                        foreach (book b in biblioteka)
                            if (b.Section == Section)
                            {
                                Console.WriteLine("Номер:" + b.Count + " Автор:" + b.Author + " Книга:" + b.Name + " Раздел:" + b.Section + " Издательство:" + b.PublishingHouse + " Наличие:" + b.Availability + " Состояние:" + b.Condition);
                            }

                    }

                    if (chosebook == 4)
                    {
                        Console.WriteLine("Введите наличие (Да или Нет)");
                        string Availability = Convert.ToString(Console.ReadLine());
                        // Console.WriteLine("\r\n");

                        foreach (book b in biblioteka)
                            if (b.Availability == Availability)
                            {
                                Console.WriteLine("Номер:" + b.Count + " Автор:" + b.Author + " Книга:" + b.Name + " Раздел:" + b.Section + " Издательство:" + b.PublishingHouse + " Наличие:" + b.Availability + " Состояние:" + b.Condition);
                            }
                            else
                            {
                                Console.WriteLine("Ошибка ввода" + " \r\n");
                                break;
                            }
                    }



                }

                else if (chose == 5)
                {
                    foreach (book b in biblioteka)
                        File.AppendAllText("F:\\new_file.txt", "Номер:" + b.Count + " Книга:" + b.Name + " Раздел:" + b.Section + " Издательство:" + b.PublishingHouse + " Наличие:" + b.Availability + " Состояние:" + b.Condition + " \r\n");
                    Console.Write("Данные успешно записаны в файл F:\\new_file.txt" + " \r\n");


                }

                else if (chose == 4)
                {
                    Console.WriteLine("Введите номер записи");
                    int zapis = Convert.ToInt16(Console.ReadLine());
                    zapis = zapis-1;
                    biblioteka.RemoveAt(zapis);
                }

                else if (chose == 2)
                {
                    Console.WriteLine("Весь список");
                    foreach (book b in biblioteka)
                        Console.WriteLine("Номер:" + b.Count + " Книга:" + b.Name + " Раздел:" + b.Section + " Издательство:" + b.PublishingHouse + " Наличие:" + b.Availability + " Состояние:" + b.Condition);

                    Console.Write("Выберите порядковый номер");
                    int pointer = Convert.ToInt16(Console.ReadLine());
                    pointer = pointer - 1;


                    Console.WriteLine("Номер:" + biblioteka[pointer].Count + " Книга:" + biblioteka[pointer].Name + " Раздел:" + biblioteka[pointer].Section + " Издательство:" + biblioteka[pointer].PublishingHouse + " Наличие:" + biblioteka[pointer].Availability + " Состояние:" + biblioteka[pointer].Condition);
                    Console.Write("Какой пункт хотите исправить ");
                    string Section = Convert.ToString(Console.ReadLine()); ;

                    if (Section == "Книга")
                    {
                        Console.Write("Новое имя = ");
                        string newname = Convert.ToString(Console.ReadLine());
                        biblioteka[pointer].Name = newname;
                    }

                    else if (Section == "Раздел")
                    {
                        Console.Write("Новое имя = ");
                        string newname = Convert.ToString(Console.ReadLine());
                        biblioteka[pointer].Section = newname;
                    }



                    else if (Section == "Издательство")
                    {
                        Console.Write("Новое имя = ");
                        string newname = Convert.ToString(Console.ReadLine());
                        biblioteka[pointer].PublishingHouse = newname;
                    }

                    else if (Section == "Наличие")
                    {
                        Console.Write("Новое имя = ");
                        string newname = Convert.ToString(Console.ReadLine());
                        biblioteka[pointer].Availability = newname;
                    }

                    else if (Section == "Состояние")
                    {
                        Console.Write("Новое имя = ");
                        string newname = Convert.ToString(Console.ReadLine());
                        biblioteka[pointer].Condition = newname;
                    }

                }
            }
        }

    }
}

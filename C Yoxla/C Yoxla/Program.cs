using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Yoxla
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 ci ededi daxil et");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2 ci ededi daxil et");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Isareni daxil edin");
            string sign = Console.ReadLine();

            switch (sign)
            {
                case "+":
                    Console.WriteLine(a + b);
                    break;

                case "-":
                    Console.WriteLine(a - b);
                    break;
                case "*":
                    Console.WriteLine(a * b);
                    break;
                case "/":
                    Console.WriteLine("a/b");
                    if (b == 0)
                    {
                        Console.WriteLine("Error!!!");
                    }
                    break;



                default:
                    break;

                    //        string[] bookTitles = { "Book 1", "Book 2", "Book 3", "Book 4", "Book 5" };
                    //string[] bookAuthors = { "Author 1", "Author 2", "Author 3", "Author 4", "Author 5" };
                    //string[] bookGenres = { "Fiction", "Mystery", "Romance", "Fantasy", "Sci-Fi" };
                    //int[] bookCopiesAvailable = { 5, 3, 7, 0, 2 };

                    //Console.WriteLine("Kitab adini qeyd edin");
                    //string BookName = Console.ReadLine();
                    //byte count = 0;

                    //for (int i = 0; i < bookTitles.Length; i++)
                    //{
                    //    if (BookName.ToLower() == bookTitles[i].ToLower() && bookCopiesAvailable[i]!= 0)
                    //    {
                    //        count += 1;
                    //    }

                    //}
                    //if (count > 0)
                    //{
                    //    Console.WriteLine("Bu kitab movcuddur");
                    //}
                    //else
                    //{
                    //    Console.WriteLine("Bu kitab movcud deyil");
                    //}




                    //Console.WriteLine("Kitabin adini qeyd edin");
                    //string SearchTitles = Console.ReadLine();


                    //for (int i = 0; i < bookTitles.Length; i++)
                    //{
                    //    if (bookTitles[i].ToLower()==SearchTitles.ToLower())
                    //    {
                    //        Console.WriteLine("Kitab tapildi");
                    //        Console.WriteLine(bookTitles[i]);
                    //        Console.WriteLine(bookAuthors[i]);
                    //        Console.WriteLine(bookGenres[i]);
                    //        Console.WriteLine(bookCopiesAvailable[i]);
                    //    }
                    //}


                    //Console.WriteLine("Kitablarin siyahisi");

                    //for (int i = 0; i < bookTitles.Length; i++)
                    //{
                    //    Console.WriteLine(bookTitles[i]);
                    //    Console.WriteLine(bookAuthors[i]);
                    //    Console.WriteLine(bookGenres[i]);
                    //    Console.WriteLine(bookCopiesAvailable[i]);

                    //}

                    //while (true)
                    //{
                    //    Console.WriteLine("Butun kitablar 1");
                    //    Console.WriteLine("Muellif 2");
                    //    Console.WriteLine("Janr 3");
                    //    Console.WriteLine("Kitabin sayi");
                    //    int choice = Convert.ToInt32(Console.ReadLine());

                    //    switch (choice)
                    //    {
                    //        case 1:
                    //            for (int i = 0; i < bookTitles.Length; i++)
                    //            {
                    //                Console.WriteLine("Kitabin adi." + " " + bookTitles[i] +  " " + "Kitabin Muellifi." + " " + bookAuthors[i] + " " +   "Janr." +  bookGenres[i] + " " + "Kitabin sayi." + " " + bookCopiesAvailable[i]);
                    //            }
                    //            break;

                    //        default:
                    //            break;
                    //    }

            }




            //int[] numbers = { 12, 45, 67, 23, 9, 56, 89, 9, 37, 7, 18, 12, 9, 77 };

            //Console.WriteLine("1-9 arasinda eded daxil edin");
            //int num = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= 9; i++)
            //{
            //    int mult = num * i;
            //    Console.WriteLine(num + "*" + i + "=" + mult  );
            //}




            //foreach (var num in numbers)
            //{
            //    if (num > 10 && num < 30)
            //    {
            //        Console.WriteLine(num);
            //    }
            //}

            //int count = 0;

            //foreach (var num in numbers)
            //{
            //    if (num == 9)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);




            //int sum = 0;

            //foreach (var item in numbers)
            //{
            //    sum += item;
            //}
            //Console.WriteLine(sum);




            //Console.WriteLine(numbers.Max());
            //Console.WriteLine(numbers.Min());

            //int max = numbers[0];
            //int min = numbers[0];

            //foreach (var item in numbers)
            //{
            //    if (max < item)
            //    {
            //        max = item;
            //    }
            //    if (min > item)
            //    {
            //        min = item;
            //    }               
            //}
            //Console.WriteLine(max);
            //Console.WriteLine(min);



        }
    }

}

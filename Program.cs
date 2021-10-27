using System;
using System.Collections.Generic;
namespace proje_3question
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            string[] listname = new string[10000];
            int[] listgrade = new int[10000];

            int m = 0;
            Console.WriteLine();
            Console.WriteLine("!!!--------------------------- Enter Student's Name ---------------------------!!!");
            while (name != "no")
            {
                Console.WriteLine();
                Console.Write("\t\t\t  Name Student {0} : ", (m + 1));
                name = Console.ReadLine();
                listname[m] = name;
                m++;
            }


            // حلقه گرفتن نمره دانش آموزان
            Console.WriteLine();
            Console.WriteLine("!!!--------------------------- Enter Student Grade ---------------------------!!!");
            Console.WriteLine();

            for (var i = 0; i < m - 1; i++)
            {
                Console.Write("\t\t\t  Grade >>>> {0} : ", listname[i]);
                listgrade[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

            }


            // حلقه نمره های زیر 10
            Console.WriteLine("*****************************|     Results     |**********************************");
            Console.WriteLine();
            Console.WriteLine("\t\t--------------->>> Rejected <<<--------------");
            Console.WriteLine();
            int[] mardud = new int[10000];

            for (var i = 0; i < m - 1; i++)
            {

                if (listgrade[i] < 10)
                {
                    mardud[i] = listgrade[i];
                    string n = listname[i];
                    Console.WriteLine("\t\t\t" + n + " ------- " + mardud[i]);
                }

            }


            //حلقه دانش آموزان قبولی
            Console.WriteLine();
            Console.WriteLine("\t\t--------------->>> Accepted <<<--------------");
            Console.WriteLine();
            int[] ghabul = new int[10000];
            string[] ghabulname = new string[10000];
            int s = 0;
            int count = 0;
            for (s = 0; s < m - 1; s++)
            {
                if (listgrade[s] >= 10)
                {
                    ghabul[s] = listgrade[s];
                    ghabulname[s] = listname[s];
                    count++;

                }
            }


            // حلقه مرتب کردن نمرات
            int temp = 0;
            string tempname = "";
            for (var i = 0; i < s; i++)
            {
                for (var j = 0; j < s - 1; j++)
                {
                    if (ghabul[j] < ghabul[j + 1])
                    {
                        temp = ghabul[j];
                        tempname = ghabulname[j];

                        ghabul[j] = ghabul[j + 1];
                        ghabulname[j] = ghabulname[j + 1];

                        ghabul[j + 1] = temp;
                        ghabulname[j + 1] = tempname;
                    }
                }

            }

            // نمایش نمرات مرتب شده
            for (var i = 0; i < count; i++)
            {
                Console.WriteLine("\t\t\t" + ghabulname[i] + " ------- " + ghabul[i]);
            }
            System.Console.WriteLine();

        }
    }
}

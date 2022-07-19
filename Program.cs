using System;
using System.IO;
using System.Threading;

namespace BeginBeginov
{
    internal class Program
    {

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------
        void Vivod(int[,] a)
        {

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }

        }

        void Deistra(string p)
        {
            Console.WriteLine("~All program on the RUSSIA.LNG~");
            Console.WriteLine("~РАБОТА АЛГОРИТМА ДЕЙКСТРЫ~");
            Console.Write("Введите вершину: "); var z = Console.ReadLine();
            int n = Convert.ToInt32(z);


            Program Vivod = new Program();
            string c;
            string path = "D:\\text.txt";

            //Подсчёт чисел в строке
            StreamReader sk = new StreamReader(path);

            string k = "";
            k = sk.ReadLine();
            sk.Close();
            int h = 0;

            for (int i = 0; i < k.Length; i++)
            {
                if (Convert.ToString(k[i]) == " ")
                {
                    h = h + 1;
                }
            }

            StreamReader sr = new StreamReader(path);
            int[,] a = new int[h, h];

            //Запись из текстового файла в массив
            for (int l = 0; l < h; l++)
            {
                c = sr.ReadLine();
                int i = 0;
                string t = "";
                int j = 0;

                while (i < c.Length)
                {

                    if (Convert.ToString(c[i]) != " ")
                    {
                        t = t + Convert.ToString(c[i]);
                        i = i + 1;
                    }
                    else
                    {
                        a[l, j] = Convert.ToInt32(t);

                        j = j + 1;
                        i = i + 1;

                        t = "";

                    }

                }
            }
            Console.WriteLine("Граф: ");
            Vivod.Vivod(a);
            Console.WriteLine();

            sr.Close();

            //Присвоение всем вершинам кроме 1 максимальные значения        
            for (int i = 0; i < h; i++)
            {
                if (i != n - 1)
                {
                    a[i, i] = 10000;
                }
            }
            Console.WriteLine("Создан граф для работы алгоритма: ");
            Vivod.Vivod(a);
            Console.WriteLine();

            // Работа самого метода
            int put = 0;
            for (int l = 0; l < h; l++)
            {
                for (int i = 0; i < h; i++)
                {
                    if (a[l, i] != 0)
                    {
                        put = a[l, l];
                        put = put + a[l, i];
                        if (i != h)
                        {
                            if (a[l, i] != 0 & put < a[i, i])
                            {
                                a[i, i] = put;

                                if (a[l, l] == a[i, i])
                                {
                                    a[l, l] = put / 2;
                                }
                            }
                        }
                    }
                    else
                    {
                        put = put + a[i, i] + a[l, l];
                        if (a[l, i] != 0 | put < a[i, i])
                        {
                            a[i, i] = put;
                        }
                    }
                    put = 0;

                }
            }

            Console.WriteLine("Граф после обработки: ");
            Vivod.Vivod(a);
            Console.WriteLine();

            string[] g = new string[h];

            for (int i = 0; i < h; i++)
            {
                if (a[i, i] != 10000)
                {
                    g[i] = Convert.ToString(a[i, i]) + " ед";
                }
                else
                {
                    g[i] = "Нет пути";
                }
            }

            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------");
            for (int i = 0; i < h; i++)
            {
                if (i != n - 1)
                {
                    Console.WriteLine("Путь из " + n + " в " + (i + 1) + " --> " + g[i]);
                }
            }

            Console.WriteLine();

            Console.WriteLine();
        }//Конец программы

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------


        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------
        void Timee(string z)
        {
            try
            {

                Program gr = new Program();
                Console.WriteLine("~Output on the RUSSIA.LNG~");
                Console.WriteLine("     |Set number action.");
                Console.WriteLine("     |1 - Input with PC");
                Console.WriteLine("     |2 - Manual input");
                Console.Write("     |---> "); var p = Console.ReadLine();

                string z2 = "";

                if (p == "2")
                {
                    Console.Write("     |Write time (hh:mm) : "); z2 = Console.ReadLine();
                }
                else if (p == "1")
                {
                    z2 = Convert.ToString(DateTime.Now);
                    for (int i = 0; i < z2.Length; i++)
                    {
                        if (Convert.ToString(z2[i]) == " ")
                        {
                            break;
                        }
                        z2 = z2.Remove(i, 1);
                    }
                    z2 = z2.Remove(0, 6);
                    z2 = z2.Remove(z2.Length - 3, 3);
                }
                else
                {
                    Console.WriteLine("     |KEY is invalid!");
                    Console.WriteLine();
                    return;
                }

                string H = Convert.ToString(z2[0]) + Convert.ToString(z2[1]);
                string M = Convert.ToString(z2[3]) + Convert.ToString(z2[4]);

                int h = Convert.ToInt32(H);
                int m = Convert.ToInt32(M);

                if (z2.Length > 5 | h < 0 | h > 23 | m < 0 | m > 59 | Convert.ToString(z2[2]) != ":")
                {
                    Console.WriteLine("     |DATA is invalid!");
                    Console.WriteLine();
                    return;
                }

                string[] hh = { "час", "первого (ДО полудня)", "второго (ДО полудня)", "третьего (ДО полудня)",
                            "четвертого (ДО полудня)", "пятого (ДО полудня)", "шестого (ДО полудня)",
                            "седьмого (ДО полудня)", "восьмого (ДО полудня)", "девятого (ДО полудня)",
                            "десятого (ДО полудня)", "одиннадцатого (ДО полудня)", "двенадцатого (ДО полудня)",

                            "первого (ПОСЛЕ полудня)", "второго (ПОСЛЕ полудня)", "третьего (ПОСЛЕ полудня)",
                            "четвертого (ПОСЛЕ полудня)", "пятого (ПОСЛЕ полудня)", "шестого (ПОСЛЕ полудня)",
                            "седьмого (ПОСЛЕ полудня)", "восьмого (ПОСЛЕ полудня)", "девятого (ПОСЛЕ полудня)",
                            "десятого (ПОСЛЕ полудня)", "одиннадцатого (ПОСЛЕ полудня)", "двенадцатого (ПОСЛЕ полудня)",};

                string[] hh1 = { "Полночь", "Час (ДО полудня)", "Два часа (ДО полудня)", "Три часа (ДО полудня)",
                            "Четыре часа (ДО полудня)", "Пять часов (ДО полудня)", "Шесть часов (ДО полудня)",
                            "Семь часов (ДО полудня)", "Восемь часов (ДО полудня)", "Девять часов (ДО полудня)",
                            "Десять часов ", "Одиннадцать часов (ДО полудня)", "Полдень",

                            "Час (ПОСЛЕ полудня)", "Два часа (ПОСЛЕ полудня)", "Три часа (ПОСЛЕ полудня)",
                            "Четыре часа (ПОСЛЕ полудня)", "Пять часов (ПОСЛЕ полудня)", "Шесть часов (ПОСЛЕ полудня)",
                            "Семь часов (ПОСЛЕ полудня)", "Восемь часов (ПОСЛЕ полудня)", "Девять часов (ПОСЛЕ полудня)",
                            "Десять часов ", "Одиннадцать часов (ПОСЛЕ полудня)", "Двенадцать часов (ПОСЛЕ полудня)",};
                string[] mm = { "Ноль", "Одна минута", "Две минуты", "Три минуты", "Четыре минуты", "Пять минут", "Шесть минут",
                            "Семь минут", "Восемь минут", "Девять минут", "Десять минут",
                            "Одиннадцать минут", "Двенадцать минут", "Тринадцать минут", "Четырнадцать минут", "Пятнадцать минут",
                            "Шестнадцать минут",
                             "Семнадцать минут", "Восемнадцать минут", "Девятнадцать минут",
                            "Двадцать минут", "Двадцать одна минута", "Двадцать две минуты",  "Двадцать три минуты",  "Двадцать четыре минуты",
                            "Двадцать пять минут",  "Двадцать шесть минут", "Двадцать семь минут",  "Двадцать восемь минут",  "Двадцать девять минут",
                            "Половина", "Тридцать одна минута", "Тридцать две минуты",  "Тридцать три минуты",  "Тридцать четыре минуты",
                            "Тридцать пять минут",  "Тридцать шесть минут", "Тридцать семь минут",  "Тридцать восемь минут",  "Тридцать девять минут",
                            "Сорок минут", "Сорок одна минута", "Сорок две минуты",  "Сорок три минуты",  "Сорок четыре минуты",
                            "Без пятнадцати",  "Без четырнадцати", "Без тринадцати",  "Без двенадцати",  "Без одиннадцати",
                            "Без десяти", "Без девяти", "Без восьми",  "Без семи",  "Без шести",
                            "Без пяти",  "Без четырёх", "Без трёх",  "Без двух",  "Без одной"};

                string otvet = "";

                if (m == 0)
                {
                    otvet = Convert.ToString(hh1[h]);
                }
                else
                {
                    otvet = Convert.ToString(mm[m]) + " " + Convert.ToString(hh[h + 1]);
                }
                Console.WriteLine();
                Console.WriteLine("     |Nowwwww: ");
                Console.WriteLine("     |-> " + otvet);

            }
            catch
            {
                Console.WriteLine("     |DATA is invalid!");
                Console.WriteLine();
            }



            Console.WriteLine();
        }//Конец программы

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------


        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------
        void Hours(string z)
        {
            Program gr = new Program();

            string[][] A = new string[10][];
            A[0] = new string[5];
            A[1] = new string[5];
            A[2] = new string[5];
            A[3] = new string[5];
            A[4] = new string[5];
            A[5] = new string[5];
            A[6] = new string[5];
            A[7] = new string[5];
            A[8] = new string[5];
            A[9] = new string[5];

            //
            A[0][0] = " _---_ ";
            A[0][1] = "|     |";
            A[0][2] = "|     |";
            A[0][3] = "|     |";
            A[0][4] = "'-___-'";
            //

            //
            A[1][0] = "    ,~,";
            A[1][1] = "   /  |";
            A[1][2] = "  /   |";
            A[1][3] = "      |";
            A[1][4] = "      |";
            //

            //
            A[2][0] = " _--_  ";
            A[2][1] = "    /  ";
            A[2][2] = "   /   ";
            A[2][3] = "  /    ";
            A[2][4] = " /___= ";
            //

            //
            A[3][0] = " _---_ ";
            A[3][1] = "      |";
            A[3][2] = "   --- ";
            A[3][3] = "      |";
            A[3][4] = " -___- ";
            //

            //
            A[4][0] = ".     .";
            A[4][1] = "|     |";
            A[4][2] = " -----|";
            A[4][3] = "      |";
            A[4][4] = "      |";
            //

            //
            A[5][0] = " _---- ";
            A[5][1] = "|      ";
            A[5][2] = " ----- ";
            A[5][3] = "      |";
            A[5][4] = " -___- ";
            //

            //
            A[6][0] = " _---_ ";
            A[6][1] = "|      ";
            A[6][2] = "|_---_ ";
            A[6][3] = "|     |";
            A[6][4] = " -___- ";
            //

            //
            A[7][0] = "_----_ ";
            A[7][1] = "     / ";
            A[7][2] = "    /  ";
            A[7][3] = " --/_  ";
            A[7][4] = "  /    ";
            //

            //
            A[8][0] = " _---_ ";
            A[8][1] = "|     |";
            A[8][2] = "'_____'";
            A[8][3] = "|     |";
            A[8][4] = "'_____'";
            //


            //
            A[9][0] = " _---_ ";
            A[9][1] = "|     |";
            A[9][2] = "'-___-'";
            A[9][3] = "     / ";
            A[9][4] = "   _/  ";
            //

            string z2 = "";
            int hh = 0, h1 = 0, h2 = 0, m1 = 0, m2 = 0, s1 = 0, s2 = 0;
            Console.WriteLine("     |Process.");
            Thread.Sleep(1000);
            Console.WriteLine("         |Process..");
            Thread.Sleep(1000);
            Console.WriteLine("             |Process...");
            Thread.Sleep(1000);
            Console.Clear();

            z2 = Convert.ToString(DateTime.Now);

            for (int i = 0; i < z2.Length; i++)
            {
                if (Convert.ToString(z2[i]) == " ")
                {
                    break;
                }
                z2 = z2.Remove(i, 1);
            }

            z2 = z2.Remove(0, 6);

            string H = Convert.ToString(z2[0]) + Convert.ToString(z2[1]); ;
            hh = Convert.ToInt32(H);
            string M1 = Convert.ToString(z2[3]);
            m1 = Convert.ToInt32(M1);
            string M2 = Convert.ToString(z2[4]);
            m2 = Convert.ToInt32(M2);
            string S1 = Convert.ToString(z2[6]);
            s1 = Convert.ToInt32(S1);
            string S2 = Convert.ToString(z2[7]);
            s2 = Convert.ToInt32(S2);

            for (int j = 0; j < 1200; j++)
            {

                s2 = s2 + 1;
                if (s1 == 6)
                {
                    s2 = 2;
                    s1 = 0;
                    m2 = m2 + 1;

                }
                if (s2 == 10)
                {
                    s2 = 0;
                    s1 = s1 + 1;
                }
                if (m1 == 6)
                {
                    m2 = 2;
                    m1 = 0;
                    hh = hh + 1;
                }
                if (m2 == 10)
                {
                    m2 = 0;
                    m1 = m1 + 1;
                }
                if (hh == 24)
                {
                    s2 = 2;
                    s1 = 0;
                    m1 = 0;
                    m2 = 0;
                    hh = 0;
                }

                h1 = hh / 10;
                h2 = hh % 10;
                Console.Write(A[h1][0] + " " + A[h2][0] + "     " + A[m1][0] + " " + A[m2][0] + "     " + A[s1][0] + " " + A[s2][0] + " "); Console.WriteLine();
                Console.Write(A[h1][1] + " " + A[h2][1] + "  0  " + A[m1][1] + " " + A[m2][1] + "  0  " + A[s1][1] + " " + A[s2][1] + " "); Console.WriteLine();
                Console.Write(A[h1][2] + " " + A[h2][2] + "     " + A[m1][2] + " " + A[m2][2] + "     " + A[s1][2] + " " + A[s2][2] + " "); Console.WriteLine();
                Console.Write(A[h1][3] + " " + A[h2][3] + "  0  " + A[m1][3] + " " + A[m2][3] + "  0  " + A[s1][3] + " " + A[s2][3] + " "); Console.WriteLine();
                Console.Write(A[h1][4] + " " + A[h2][4] + "     " + A[m1][4] + " " + A[m2][4] + "     " + A[s1][4] + " " + A[s2][4] + " "); Console.WriteLine();

                Thread.Sleep(1000);
                Console.Clear();
            }
        }//End the program

        void Mennu()
        {
            Program gr = new Program();
            Console.WriteLine("Set number of action: ");
            Console.WriteLine("1 - Algorithm Deistri");
            Console.WriteLine("2 - What if time?");
            Console.WriteLine("3 - Digital Watch");
            Console.Write("--> "); var z = Console.ReadLine();
            Console.WriteLine();


            if (z == "1")
            {
                gr.Deistra(z);
            }
            else if (z == "2")
            {
                gr.Timee(z);
            }
            else if (z == "3")
            {
                gr.Hours(z);
            }
            else
            {
                Console.WriteLine(" KEY is invalid!");
                Console.WriteLine("=================");
                Console.WriteLine();
                gr.Mennu();
            }

        }//End the program
//-----------------------------------------------------------------------------------------------------------------------------------------------------------------
        static void Main(string[] args)
        {
            Program gr = new Program();
            gr.Mennu();

        }
    }
}

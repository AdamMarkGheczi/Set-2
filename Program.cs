using System;
using System.Reflection;

namespace Set_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti numarul problemei, sau 0 pentru a opri programul: ");

            int n;
            n = int.Parse(Console.ReadLine());

            while (n != 0)
            {
                CallMethod($"p{n}");
                Console.WriteLine("Introduceti numarul problemei, sau 0 pentru a opri programul: ");
                n = int.Parse(Console.ReadLine());
            }
        }

        public static void CallMethod(string method)
        {
            try
            {
                Type type = typeof(Program);
                MethodInfo methodInfo = type.GetMethod(method);
                methodInfo.Invoke(method, null);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                Console.ReadKey();
            }
        }
        
        public static void p1()
        {
            int n, x, even=0;

            Console.WriteLine("Introduceti n: ");
            n = int.Parse(Console.ReadLine());

            for(int i=1; i<=n; i++)
            {
                Console.WriteLine($"Introduceti numarul");
                x = int.Parse(Console.ReadLine());
                if (x % 2 == 0)
                    even++;
            }

            Console.WriteLine($"In secventa sunt {even} numere pare");
        }

        public static void p2()
        {
            int n, x, neg=0, pos=0, zero=0;

            Console.WriteLine("Introduceti n: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Introduceti numarul");
                x = int.Parse(Console.ReadLine());
                if (x < 0) neg++;
                if (x > 0) pos++;
                if (x == 0) zero++;
            }

            Console.WriteLine($"In secventa sunt {neg} numere negative {pos} pozitive si {zero} zerouri");
        }

        public static void p3()
        {
            int n;
            ulong x = 1;
            Console.WriteLine("Introduceti n: ");
            n = int.Parse(Console.ReadLine());

            for (uint i = 1; i <= n; i++) x *= (uint)i;

            Console.WriteLine($"Suma: {n*(n+1)/2}, Produsul: {x}");
        }

        public static void p4()
        {
            int n, a, x, k=-1;

            Console.WriteLine("Introduceti n: ");
            n = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Introduceti a: ");
            a = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Introduceti numarul");
                x = int.Parse(Console.ReadLine());
                if (x == a) k = i;
            }

            Console.WriteLine($"{a} se afla pe pozitia {k}");
        }

        public static void p5()
        {
            int n, x, c=0;

            Console.WriteLine("Introduceti n: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Introduceti numarul");
                x = int.Parse(Console.ReadLine());
                if (x == i) c++;
            }

            Console.WriteLine($"{c} elemente sunt egale cu pozitia lor");
        }

        public static void p6()
        {
            int n, x, y;
            bool incr = true;
            Console.WriteLine("Introduceti n: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Introduceti numarul");
            y = int.Parse(Console.ReadLine());

            for (int i = 0; i < n-1; i++)
            {
                Console.WriteLine($"Introduceti numarul");
                x = int.Parse(Console.ReadLine());
                if (y > x) incr = false;
                y = x;

            }

            if(incr)
                Console.WriteLine("Elementele sunt in ordine crescatoare");
            else
                Console.WriteLine("Elementele nu sunt in ordine crescatoare");

        }

        public static void p7()
        {
            int n, x, min, max;
            
            Console.WriteLine("Introduceti n: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Introduceti numarul");
            x = int.Parse(Console.ReadLine());

            min = x;
            max = x;

            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine($"Introduceti numarul");
                x = int.Parse(Console.ReadLine());
                if (max < x) max = x;
                if (min > x) min = x;

            }

            Console.WriteLine($"Min: {min}, Max: {max}");

        }

        public static void p8()
        {
            int n, x=0, y=1, z=1;

            Console.WriteLine("Introduceti n: ");
            n = int.Parse(Console.ReadLine());

            if (n == 1) Console.WriteLine(0);
            if (n == 2) Console.WriteLine(1);
            if (n > 2)
            {
                for (int i = 1; i <= n - 2; i++)
                {
                    z = x + y;
                    x = y;
                    y = z;
                }

                Console.WriteLine(z);
            }
        }

        public static void p9()
        {
            int n, x, y;

            bool incr = true, decr = true;

            Console.WriteLine("Introduceti n: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Introduceti numarul");
            y = int.Parse(Console.ReadLine());

            for(int i=1; i<=n-1; i++)
            {
                Console.WriteLine($"Introduceti numarul");
                x = int.Parse(Console.ReadLine());

                if(y < x) decr = false;
                if(y > x) incr = false;

                y = x;
            }

            if (incr || decr)
                Console.WriteLine("Secventa este monotona");
            else
                Console.WriteLine("Secventa nu este monotona");

        }

        public static void p10()
        {
            int n, x, y, nr=0, nrmax=0;


            Console.WriteLine("Introduceti n: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Introduceti numarul");
            y = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n - 1; i++)
            {
                Console.WriteLine($"Introduceti numarul");
                x = int.Parse(Console.ReadLine());

                if (x == y) nr++;
                else
                {
                    if(nr != 0) nrmax = nr + 1;
                    nr = 0;
                }

                y = x;
            }

            Console.WriteLine($"Numarul maxim de termeni consecutive egale este {nrmax}");
        }

        public static void p11()
        {
            int n, x;

            double suma = 0;


            Console.WriteLine("Introduceti n: ");
            n = int.Parse(Console.ReadLine());


            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Introduceti numarul");
                x = int.Parse(Console.ReadLine());

                suma += 1 / (double)x;
            }

            Console.WriteLine($"Suma inverselor termenilor este {suma}");
        }

        public static void p12()
        {
            int n, x=0, y, nr = 0;

            Console.WriteLine("Introduceti n: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Introduceti numarul");
            y = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n - 1; i++)
            {
                Console.WriteLine($"Introduceti numarul");
                x = int.Parse(Console.ReadLine());

                if (x == 0 && y != 0) nr++;

                y = x;
            }

            if (x != 0) nr++;

            Console.WriteLine($"In secventa sunt {nr} grupuri de numere separate cu 0");

        }

        public static void p13()
        {
            int n, x = 0, y, nrOfDecreeses = 0, first;

            Console.WriteLine("Introduceti n: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Introduceti numarul");
            y = int.Parse(Console.ReadLine());

            first = y;

            for (int i = 1; i <= n - 1; i++)
            {
                Console.WriteLine($"Introduceti numarul");
                x = int.Parse(Console.ReadLine());

                if (y > x) nrOfDecreeses++;
                y = x;

            }

            if ((nrOfDecreeses == 1 && first > x) || nrOfDecreeses == 0)
                Console.WriteLine($"Este o secventa crescatoare rotita");
            else
                Console.WriteLine($"Nu este o secventa crescatoare rotita");

        }

        public static void p14()
        {
            int n, x = 0, y, first;
            int nrOfIncreeses = 0, nrOfDecreeses = 0;
            bool decreesesFirst = true;
            bool flag = true;

            Console.WriteLine("Introduceti n: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Introduceti numarul");
            y = int.Parse(Console.ReadLine());

            first = y;

            for (int i = 1; i <= n - 1; i++)
            {
                Console.WriteLine($"Introduceti numarul");
                x = int.Parse(Console.ReadLine());

                if(flag)
                {
                    if (x < y) decreesesFirst = true;
                    else decreesesFirst = false;
                    flag = false;
                }

                if (y < x) nrOfIncreeses++;
                if (y > x) nrOfDecreeses++;
                y = x;

            }

            if (Math.Min(nrOfDecreeses, nrOfIncreeses) == 1)
            {
                if (decreesesFirst)
                {
                    if (x > first) flag = true;
                    else flag = false;
                }
                else
                {
                    if (x < first) flag = true;
                    else flag = false;
                }
            }
            else
            {
                if (Math.Min(nrOfDecreeses, nrOfIncreeses) == 0) flag = true;
                else flag = false;
            }

            if (flag)
                Console.WriteLine($"Este o secventa monotona rotita");
            else
                Console.WriteLine($"Nu este o secventa monotona rotita");

        }

        public static void p15()
        {
            int n, x, y, prevTendency = 0, currentTendency = 0, tendencyChanges = 0, firstTendency = 0;

            Console.WriteLine("Introduceti n: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Introduceti numarul");
            y = int.Parse(Console.ReadLine());


            for(int i=1; i<=n-1; i++)
            {
                if (currentTendency != 0)
                {
                    prevTendency = currentTendency;
                    
                    if(firstTendency == 0) firstTendency = currentTendency;
                }

                Console.WriteLine($"Introduceti numarul");
                x = int.Parse(Console.ReadLine());

                currentTendency = Math.Sign(x - y);
                y = x;

                if (currentTendency != 0 && prevTendency != 0 && currentTendency != prevTendency)
                    tendencyChanges++;

            }

            if(tendencyChanges == 1 && firstTendency == 1 && n > 2)
                Console.WriteLine("Este o secventa bitonica");
            else
                Console.WriteLine("Nu este o secventa bitonica");
        }

        public static void p16()
        {
            int n, x=0, y, prevTendency = 0, currentTendency = 0, tendencyChanges = 0, firstTendency = 0;

            Console.WriteLine("Introduceti n: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Introduceti numarul");
            y = int.Parse(Console.ReadLine());

            int first = y;

            for (int i = 1; i <= n - 1; i++)
            {
                if (currentTendency != 0)
                {
                    prevTendency = currentTendency;

                    if (firstTendency == 0) firstTendency = currentTendency;
                }

                Console.WriteLine($"Introduceti numarul");
                x = int.Parse(Console.ReadLine());

                currentTendency = Math.Sign(x - y);
                y = x;

                if (currentTendency != 0 && prevTendency != 0 && currentTendency != prevTendency)
                    tendencyChanges++;

            }

            if (tendencyChanges == 1 || tendencyChanges == 2 && ((firstTendency == 1 && first >= x) || (firstTendency == -1 && first <= x)))
                Console.WriteLine("Este o secventa bitonica rotita");
            else
                Console.WriteLine("Nu este o secventa bitonica rotita");
        }

        public static void p17()
        {
            int n, x, s = 0, max=0;
            bool corect = true;


            Console.WriteLine("Introduceti n: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Introduceti numarul");
                x = int.Parse(Console.ReadLine());

                if (x == 0) s++;
                else s--;

                max = Math.Max(s, max);

                if (s < 0) corect = false;
            }

            if (s > 0) corect = false;

            if (corect)
                Console.WriteLine($"Secventa este corecta, nivelul maxim de incuibare este {max}");
            else
                Console.WriteLine($"Secventa nu este corecta");
        }
    }
}

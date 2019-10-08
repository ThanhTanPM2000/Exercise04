using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;
            bool test = true;
            while (test)
            {
                Console.WriteLine("xin mời nhập n: ");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("xin mời chọn kí tự vẽ: ");
                char k = char.Parse(Console.ReadLine());
                DrawVertical(n, k);
                Console.WriteLine("======================================================================");
                DrawHorizal(n, k);
                Console.WriteLine("\n======================================================================");
                DrawSquare(n, k);
                Console.WriteLine("\n======================================================================");
                DrawU(n, k);
                Console.WriteLine("\n======================================================================");
                DrawV(n, k);
                Console.WriteLine("\n======================================================================");
                DrawTriangle(n, k);
                Console.WriteLine("\n======================================================================");
                DrawTriAngLe2(n, k);
                Console.WriteLine("\n======================================================================");
                DrawW(n, k);
                Console.WriteLine("\n======================================================================");
                DrawA(n, k);
                Console.WriteLine("\n======================================================================");
                DrawX(n, k);
                Console.WriteLine("\n======================================================================");
                DrawPlus(n, k);

                Console.WriteLine("\n\n bạn có muốn tiếp tục (Y/N)");
                string q = Console.ReadLine();
                if (q.ToUpper().Equals("Y")) test = true;
                else test = false;
            }



            Console.ReadLine();
        }

        public static void DrawVertical(int n, char c)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(c);
            }
        }

        public static void DrawHorizal(int n, char c)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(c);
            }
        }

        public static void DrawSquare(int n, char c)
        {
            for (int i = 0; i < n; i++)
            {
                DrawHorizal(n, c);
                Console.WriteLine();
            }

        }

        public static void DrawU(int n, char c)
        {
            for (int i = 0; i < n - 1; i++)
            {
                DrawHorizal(1, c);
                DrawHorizal(n - 2, ' ');
                DrawHorizal(1, c);
                Console.WriteLine();
            }
            DrawHorizal(n, c);
        }

        public static void DrawV(int n, char c)
        {
            int A = n + 1, B = 0;

            for (int i = 0; i < n; i++)
            {
                DrawHorizal(B, ' ');
                DrawHorizal(1, c);
                DrawHorizal(A, ' ');
                if (B < n - 1) DrawHorizal(1, c);
                A -= 2; B++;
                Console.WriteLine();
            }
        }

        public static void DrawTriangle(int n, char c)
        {
            DrawHorizal(2 * n - 1, c);
            Console.WriteLine();

            int A = n - 1, B = 1;
            for (int i = 0; i < n - 1; i++)
            {
                DrawHorizal(B, ' ');
                DrawHorizal(1, c);
                DrawHorizal(A, ' ');
                if (i != n - 2) DrawHorizal(1, c);
                A -= 2; B++;
                Console.WriteLine();
            }
        }

        public static void DrawTriAngLe2(int n, char c)
        {
            int A = n - 1, B = 0;
            for (int i = 0; i < n - 1; i++)
            {
                DrawHorizal(A, ' ');
                DrawHorizal(1, c);
                if (i != 0)
                {
                    DrawHorizal(B, ' ');
                    DrawHorizal(1, c);
                    B += 2;
                }
                else B++;
                A--;
                Console.WriteLine();
            }
            DrawHorizal(2 * n - 1, c);
        }

        public static void DrawW(int n, char c)
        {
            int B = 2 * n - 3, C = 0, A = 0;
            for (int i = 0; i < n; i++)
            {
                DrawHorizal(A, ' ');
                DrawHorizal(1, c);
                DrawHorizal(B, ' ');
                if (i != n - 1) DrawHorizal(1, c);
                DrawHorizal(C, ' ');
                if (i == 0) C++;
                else C += 2;
                if (i != 0) DrawHorizal(1, c);
                DrawHorizal(B, ' ');
                if (i != n - 1) DrawHorizal(1, c);
                A++; B -= 2;
                Console.WriteLine();
            }
        }

        public static void DrawA(int n, char c)
        {
            int A = n, B = 0;
            for (int i = 0; i <= n; i++)
            {
                DrawHorizal(A, ' ');
                DrawHorizal(1, c);
                if (i != 0)
                {
                    if (i != n / 2)
                    {
                        DrawHorizal(B, ' ');
                    }
                    else DrawHorizal(B, c);
                    DrawHorizal(1, c);
                    B += 2;
                }
                else B++;
                A--;
                Console.WriteLine();
            }
        }

        public static void DrawX(int n, char c)
        {
            int A = n - 1, B = 0;
            for (int i = 0; i < n / 2; i++)
            {
                DrawHorizal(B, ' ');
                DrawHorizal(1, c);
                DrawHorizal(A, ' ');
                DrawHorizal(1, c);
                A -= 2; B++;
                Console.WriteLine();
            }
            if (n % 2 == 0)
            {
                DrawHorizal(n / 2, ' ');
                DrawHorizal(1, c);
                B = 1;
                Console.WriteLine();
            }
            else
            {
                DrawHorizal(n / 2, ' ');
                DrawHorizal(1, c);
                DrawHorizal(1, c);
                B = 2;
                Console.WriteLine();
            }
            A = n / 2 - 1;
            for (int j = 0; j < n / 2; j++)
            {
                DrawHorizal(A, ' ');
                DrawHorizal(1, c);
                DrawHorizal(B, ' ');
                DrawHorizal(1, c);
                A--; B += 2;
                Console.WriteLine();
            }
        }

        public static void DrawPlus(int n, char c)
        {
            for (int i = 0; i <= n; i++)
            {
                if (i != n / 2)
                {
                    DrawHorizal(n - 2, ' ');
                    DrawHorizal(1, c);
                    Console.WriteLine();
                }
                else
                {
                    DrawHorizal(n + 1, c); Console.WriteLine();
                }
            }
        }
    }
}

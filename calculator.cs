using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class ProgramKalkulator
    {
        static void Main(string[] args)
        {
            string menu;
            Console.Title = "Aplikasi Calculator";

            /*int a = 10;*/ // Deklarasi Variabel a, dg nilai awal 10;
            /*int b = 6;*/ // Deklarasi variabel b, dg nilai awal 6;

            /*            Console.Write("Inputkan Nilai a = ");
                        int a = int.Parse(Console.ReadLine()); // Proses Casting*/

            /*            Console.Write("Inputkan Nilai b = ");
                        int b = int.Parse(Console.ReadLine()); // Proses Casting*/

            /*Console.WriteLine();*/ // Menambahhkan baris Kosong

            Console.WriteLine("Pilih Menu Calculator :\n\n1. Penambahan\n2. Pengurangan\n3. Perkalian\n4. Pembagian\n");

            Console.Write("Input Nomor menu [1..4]: ");
            menu = Console.ReadLine();

            if (menu == "1")
            {
                Console.Write("Inputkan Nilai a = ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Inputkan Nilai b = ");
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + Penambahan(a, b));
            } else if (menu == "2")
            {
                Console.Write("Inputkan Nilai a = ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Inputkan Nilai b = ");
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b));
            } else if (menu == "3")
            {
                Console.Write("Inputkan Nilai a = ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Inputkan Nilai b = ");
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));

            } else if (menu == "4")
            {
                Console.Write("Inputkan Nilai a = ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Masukkan Nilai b = ");
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));
            } else
            {
                Console.WriteLine("Maaf Menu yang anda Pilih tidak Tersedia");
            }


            Console.WriteLine("\nTekan sembarang key untuk keluar");
            Console.ReadKey();
        }

        static int Penambahan(int a, int b)
        {
            return a + b;
        }

        static int Pengurangan(int a, int b)
        {
            return a - b;
        }

        static int Perkalian(int a, int b)
        {
            return a * b;
        }

        static float Pembagian(float a, float b)
        {
            return a / b;
        }
    }
}

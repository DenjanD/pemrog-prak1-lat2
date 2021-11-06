using System;

namespace P1_4_1204039
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tampilkan Judul
            Console.WriteLine("MENU PERSEGI PANJANG \n" +
                "1. Hitung Luas\n" +
                "2. Hitung Keliling\n" +
                "3. Hitung Panjang Diagonal");

            // Ambil pilihan menu
            Console.Write("Menu Pilihan: ");

            int menuChoice = Convert.ToInt32(Console.ReadLine());

            // Cek Pilihan Menu
            if (menuChoice == 1)
            {
                luasFunction();
            } else if (menuChoice == 2)
            {
                kelilingFunction();
            } else if (menuChoice == 3)
            {
                diagonalFunction();
            } else
            {
                Console.WriteLine("Menu tidak tersedia, silakan pilih menu yang tersedia.");
            }
        }

        private static void luasFunction()
        {
            // get panjang
            Console.Write("Masukkan Panjang: ");
            int panjang = Convert.ToInt32(Console.ReadLine());

            // get lebar
            Console.Write("Masukkan Lebar: ");
            int lebar = Convert.ToInt32(Console.ReadLine());

            // hitung luas
            int luas = panjang * lebar;
            Console.WriteLine("Luas Persegi Panjang = " + luas);
        }

        private static void kelilingFunction()
        {
            // get panjang
            Console.Write("Masukkan Panjang: ");
            int panjang = Convert.ToInt32(Console.ReadLine());

            // get lebar
            Console.Write("Masukkan Lebar: ");
            int lebar = Convert.ToInt32(Console.ReadLine());

            // hitung keliling
            int keliling = 2*(panjang + lebar);
            Console.WriteLine("Keliling Persegi Panjang = " + keliling);
        }

        private static void diagonalFunction()
        {
            // get panjang
            Console.Write("Masukkan Panjang: ");
            int panjang = Convert.ToInt32(Console.ReadLine());

            // get lebar
            Console.Write("Masukkan Lebar: ");
            int lebar = Convert.ToInt32(Console.ReadLine());

            // hitung panjang diagonal
            int diagonal = (panjang*panjang) + (lebar*lebar);
            double panjangDiagonal = Math.Sqrt(diagonal);
            Console.WriteLine("Panjang Diagonal Persegi Panjang = " + panjangDiagonal);
        }
    }
}

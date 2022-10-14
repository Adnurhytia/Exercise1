using System;

namespace Exercise
{
    class Program
    {
        // Deklarasi  int dengan ukuran yang ditentukan
        private int[] dinda = new int[29];

        //Deklarasi variabel int untuk menyimpan banyaknya data pada array
        private int n;

        //Fungsi method untuk menerima masukan
        public void read()
        {
            //Menerima angka untuk menentukan banyaknya data yang disimpan pada array
            while (true)
            {
                Console.WriteLine("Masukkan banyaknya elemen pada Array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 29)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 29 elemen. \n");
            }
            Console.WriteLine("");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Masukkan elemen Array");
            Console.WriteLine("------------------------------");

            //Pengguna memasukkan elemen pada dinda
            for (int i = 0; i < n; i++)
            {
                Console.Write((i + 1) + " . ");
                string s1 = Console.ReadLine();
                dinda[i] = Int32.Parse(s1);
            }
        }
        public void display()
        {
            //Menampilkan array yang tersusun
            Console.WriteLine("");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Element array yang telah tersusun");
            Console.WriteLine("---------------------------------");
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(dinda[j]);
            }
            Console.WriteLine("");
        }

        public void BubbleSortArray()
        {
            // For n - 1 passes
            for (int i = 1; i < n; i++)
            {
                //Pada pass i, bandingkan n - i elemen pertama dengan elemen selanjutnya
                for (int an = 0; an < n - i; an++)
                {
                    //Jika elemen tidak dalam urutan yang benar
                    if (dinda[an] <  dinda[an + 1])
                    {
                        //Tukar elemen
                        int temp;
                        temp = dinda[an];
                        dinda[an] = dinda[an + 1];
                        dinda[an + 1] = temp;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            //Creating the object of the Exercise class
            Program myList = new Program();

            //Pemanggilan fungsi untuk menerima elemen 
            myList.read();

            //pemanggilan fungsi untuk mengurutkan elemen
            myList.display();

            //Exit
            Console.WriteLine("\n\nTekan Tombol Apa Saja Untuk Keluar");
            Console.Read();
        }


    }
}
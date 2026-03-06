//using System; //import atau library console

//namespace DasarDasarC //mengelompokkan class
//{
//    class DasarCSharp //mengelompokkan method atau cara penyelesaian
//    {
//        static void Main(string[] args) //titik awal mulai dijalannya program atau entry point
//        {
//            Console.WriteLine("C# Dasar");
//            Console.WriteLine("");
//            //Tipe Data
//            //int, long, float, double, string, char, bool
//            Console.WriteLine("=========Ini adalah Tipe Data C#==========");
//            Console.WriteLine("");
//            int angka1 = 8;
//            Console.WriteLine("Ini adalah Int " + angka1);

//            long angka2 = 8999999999;
//            Console.WriteLine("Ini adalah long " + angka2);

//            float float1 = 8.8f;
//            Console.WriteLine("Ini adalah Float " + float1);

//            double double1 = 9.6;
//            Console.WriteLine("Ini adalah Double " + double1 + angka1);

//            string nama = "Adya";
//            Console.WriteLine("Halo Aku " + nama);

//            char nama2 = 'A';
//            Console.WriteLine("Ini adalah char " + nama2);

//            bool boolean = false;
//            Console.WriteLine("Ini adalah Bool " + boolean);
//            Console.WriteLine("");

//            //Tipe Data Koleksi
//            Console.WriteLine("============Tipe Data Koleksi==============");
//            //Array
//            string[] kategori = { "Ikan", "Adya", " Lutfi", "Halo" };
//            Console.WriteLine(kategori[1]);

//            int[] angkaarray = { 1, 2, 3, 4, 5, 6, };
//            double[] doublearray = { 1.2, 3.2 };
//            Console.WriteLine(angkaarray[1] + doublearray[0]);

//            //list
//            List<string> keranjang = new List<string>();
//            keranjang.Add("Laptop");
//            keranjang.Add("Ikan");
//            Console.WriteLine(keranjang.Count);
//            Console.WriteLine("");

//            Console.WriteLine("============Operator Utama==============");
//            //Operator Utama
//            Console.WriteLine("Aritmatika");
//            int angka01 = 3;
//            double angka02 = 5.2;
//            Console.WriteLine(angka01 + angka02);
//            Console.WriteLine(angka01 - angka02);
//            Console.WriteLine(angka01 * angka02);
//            Console.WriteLine(angka01 / angka02);
//            Console.WriteLine(angka02 % angka01);
//            Console.WriteLine("");

//            //Perbandingan
//            Console.WriteLine("Perbandingan");
//            string nama01 = "Adya";
//            string nama02 = "Lutfi";
//            Console.WriteLine(nama01 == nama02);
//            Console.WriteLine(nama01 != nama02);
//            Console.WriteLine(nama01.Length <= nama02.Length);
//            Console.WriteLine("");

//            //Logika
//            Console.WriteLine("Logika");
//            Console.WriteLine(angka01 == angka02 && angka01 != angka02);
//            Console.WriteLine(angka01 == angka02 || angka01 != angka02);
//            Console.WriteLine("");

//            Console.WriteLine("============Percabangan==============");
//            //Percabangan

//            //ini dengan inputan manual
//            Console.Write("Masukkan Ipk : ");
//            double ipk = double.Parse(Console.ReadLine());
//            if (ipk >= 3.5)
//            {
//                Console.WriteLine("Cumlaude");
//            }
//            else
//            {
//                Console.WriteLine("Kamu ngulang");
//            }
//            Console.WriteLine("");

//            double ipk2 = 6;
//            if (ipk >= 3.5)
//            {
//                Console.WriteLine("Cumlaude");
//            }
//            else if (ipk2 >= 3.0)
//            {
//                Console.WriteLine("Bagus");
//            }
//            else if (ipk2 >= 2.5)
//            {
//                Console.WriteLine("Bagus");
//            }
//            else
//            {
//                Console.WriteLine("Kamu ngulang");
//            }

//            int hari = 5;
//            switch (hari)
//            {
//                case 1:
//                    Console.WriteLine("Senin");
//                    break;
//                case 2:
//                    Console.WriteLine("Selasa");
//                    break;
//                default:
//                    Console.WriteLine("Hari tidak valid");
//                    break;
//            }
//            Console.WriteLine("");

//            Console.WriteLine("============Looping==============");
//            //for(start, stop, step)
//            for (int i = 1; i <= 5; i++)
//            {
//                Console.Write($"Iterasi Ke-{i} ");
//            }
//            Console.WriteLine("");

//            int ikan = 4;
//            for (ikan = 1; ikan <= 5; ikan++)
//            {
//                Console.WriteLine($"Iterasi Ke-{ikan} ");
//            }

//            //while loop 
//            int j = 0;
//            while (j < 3)
//            {
//                Console.WriteLine($"Iterasi While ke - {j} ");
//                j++;
//            }

//            int k = 0;
//            do
//            {
//                Console.WriteLine($"Iterasi Do-While ke - {k}");
//                k++;
//            } while (k < 3);
//            Console.WriteLine("");

//            //array
//            string[] hobi = { "Coding", "Gaming", "Reading" };
//            //Foreach digunakan untuk mencetak output dari dalam array
//            foreach (string item in hobi)
//            {
//                Console.WriteLine("Hobi: " + item);
//            }

//            //list
//            List<string> products = ["Laptop", "Keyboard", "Kamera"];
//            foreach (string product in products)
//            {
//                Console.WriteLine("Produk: " + product);
//            }
//        }
//    }
//}

////write : digunakan untuk satu baris output tanpa baris baru
////writeline : digunakan untuk otput dengan baris baru
////readline : untuk memasukkan input
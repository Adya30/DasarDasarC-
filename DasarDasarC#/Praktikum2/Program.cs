using System;

//namespace Praktikum2
//{
//    class Mobil
//    {
//        public string Merk;
//        public int JumlahKursi;
//        public string Warna;

//        public void MobilBergerak()
//        {
//            Console.WriteLine($"Mobil merk {Merk} yang jumlah kursinya {JumlahKursi} dengan warna {Warna} 'BERGERAK'");
//        }
//        public void MobilBerhenti()
//        {
//            Console.WriteLine($"Mobil merk {Merk} yang jumlah kursinya {JumlahKursi} dengan warna {Warna} 'BERHENTI'");
//        }
//    }

//class Program
//{
//    public static void Main(string[] args)
//    {
//        Console.WriteLine("=======3 OBJEK MOBIL GUA========");
//        Mobil mobil1 = new Mobil();
//        mobil1.Merk = "Lamborgini";
//        mobil1.JumlahKursi = 5;
//        mobil1.Warna = "Coklat";
//        mobil1.MobilBergerak();
//        mobil1.MobilBerhenti();
//        Console.WriteLine("");

//        Mobil mobil2 = new Mobil();
//        mobil2.Merk = "XPANDER";
//        mobil2.JumlahKursi = 7;
//        mobil2.Warna = "Kuning";
//        mobil2.MobilBergerak();
//        mobil2.MobilBerhenti();
//        Console.WriteLine("");

//        Mobil mobil3 = new Mobil();
//        mobil3.Merk = "SUPRA";
//        mobil3.JumlahKursi = 4;
//        mobil3.Warna = "Merah";
//        mobil3.MobilBergerak();
//        mobil3.MobilBerhenti();
//        Console.WriteLine("");

//        Console.Write("Masukkan apakah mobil hidup : ");
//        string kondisi = Console.ReadLine().ToLower();

//        if (kondisi == "hidup")
//        {
//            mobil1.MobilBergerak();
//        }
//        else
//        {
//            mobil1.MobilBerhenti();
//        }
//    }
//}
//}

//namespace Constructor
//{
//    class Mahasiswa
//    {
//        string nama;
//        int umur;

//        public Mahasiswa( string Nama, int Umur)
//        {
//            nama = Nama;
//            umur = Umur;

//            Console.WriteLine($"Halo {nama} umur {umur}");
//        }

//        class Program
//        {
//            public static void Main(string[] args)
//            {
//                Mahasiswa mahasiswa1 = new Mahasiswa("Adya", 8);
//            }
//        }
//    }
//}

//namespace Kuliah //folder kuliah
//{
//    class Tugas //file tugas 
//    {
//        public void Tugas1()
//        {
//            Console.WriteLine("Ini adalah tugas folder kuliah");
//        }
//    }
//}

//namespace Pribadi //folder pribadi
//{
//    class Tugas //file tugas
//    {
//        public void Tugas1()
//        {
//            Console.WriteLine("Ini adalah tugas folder pribadi");
//        }
//    }
//}

//using Kuliah;
//using Pribadi;

//namespace RunProgram //folder run program
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            Kuliah.Tugas tugaskuliah = new Kuliah.Tugas();
//            Pribadi.Tugas tugaspribadi = new Pribadi.Tugas();
//            tugaskuliah.Tugas1();
//            tugaspribadi.Tugas1();

//        }
//    }
//}

//fungsi classnya
//class Program
//{
//    public static void Main()
//    {
//        Console.WriteLine("Rumah dengan Warna " + Rumah.Warna);

//        Rumah rumahWildan = new Rumah("Wildan", 8);
//        rumahWildan.Tampil();

//        //static kalkulator
//        int hasil = Kalkulator.Penjumlahan(5, 6);
//        Console.WriteLine("Hasil Penjumlahan :" + hasil);
//    }
//}
//class Rumah
//{
//    public static string Warna = "Merah";
//    string Nama;
//    int Jumlah;

//    public Rumah(string Nama, int Jumlah)
//    {
//        this.Nama = Nama;
//        this.Jumlah = Jumlah;
//    }

//    public void Tampil()
//    {
//        Console.WriteLine($"Rumah dengan Nama {Nama} jumlahnya {Jumlah}");
//    }
//}

//class Kalkulator
//{
//    public static int Penjumlahan(int a, int b)
//    {
//        return a + b;
//    }
//}

//Soal Live Coding
//1
namespace SistemParkir
{
    class Motor
    {
        public string PlatNomor;
        public string Warna;

        public Motor(string PlatNomor, string Warna)
        {
            this.PlatNomor = PlatNomor;
            this.Warna = Warna;
        }

        public void CetakInfo()
        {
            Console.WriteLine($"Motor dengan plat {PlatNomor} berwarna {Warna} telah masuk parkiran.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Motor motor1 = new Motor("B 1234 ABC", "Hitam");

            motor1.CetakInfo();
        }
    }
}

//2
//namespace Bank
//{
//    class Program
//    {
//        public static void Main()
//        {
//            Dompet DompetRehan = new Dompet(0);
//            DompetRehan.IsiDompet(50000);

//            Console.WriteLine($"Nominal Saldo Terbaru {DompetRehan.Saldo}");
//        }
//    }

//    class Dompet
//    {
//        public int Saldo;

//        public Dompet(int Saldo)
//        {
//            this.Saldo = Saldo;
//        }

//        public void IsiDompet(int Tambahan)
//        {
//            Saldo = Saldo + Tambahan;
//        }
//    }
//}
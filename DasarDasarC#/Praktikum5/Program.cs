using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace DasarDasarC_.Praktikum5
{

    class Dosen
    {
        public String Nama { get; set; }

        public Dosen(string nama)
        {
            Nama = nama;
        }

    }

    class Mahasiswa
    {
        public string Nama { get; set;  }
        public Dosen Dosen { get; set; } //Asosiasi

        public Mahasiswa(string nama, Dosen dosen)
        {
            Nama = nama;
            Dosen = dosen;
        }

        public void Info()
        {
            if (Dosen != null)
            {
                Console.WriteLine($"{Nama} Bisa lulus karena {Dosen.Nama}");
            }

            else
            {
                Console.WriteLine($"{Nama} bisa lulus");
            }
        }
    }

    class Pemain
    {
        public string Nama { get; set; }

        public Pemain(string Nama)
        {
            this.Nama = Nama;
        }
    }

    class Tim
    {
        public string Nama { get; set; }

        public List<Pemain> pemainlist { get; set; } //agregasi karena memuat kumpulan objek

        public Tim(string nama, List<Pemain> pemainlist)
        {
            this.Nama = nama;
            this.pemainlist = pemainlist;
        }

        public void Info()
        {
            foreach (Pemain p in pemainlist)
            {
                Console.WriteLine($"{Nama} tim ini memiliki pemain dengan nama ini {p.Nama}");
            }
        }
    }

    class Mesin
    {
        public string tipe { get; set; }

        public Mesin(string tipe)
        {
            this.tipe = tipe;
        }
    }

    class Mobil
    {
        public string namaMobil { get; set;  }
        public Mesin Mesin { get; set; }
        //public string tipeMesin { get; set; }

        public Mobil(string NamaMobil, string TipeMesin)
        {
            namaMobil = NamaMobil;
            Mesin = new Mesin(TipeMesin);
            //tipeMesin = TipeMesin;
        }

        public void Info()
        {
            Console.WriteLine($"Mobil = {namaMobil}");
            Console.WriteLine($"Mesin = {Mesin.tipe}");
        }

    }

    class Program
    {
        static void Main()
        {

            Console.WriteLine("Asosiasi");
            Dosen dosen1 = new Dosen("Pak Adya");

            Mahasiswa mhs1 = new Mahasiswa("Budi", dosen1);
            Mahasiswa mhs2 = new Mahasiswa("Gandhi", null);

            mhs1.Info();
            mhs2.Info();
            Console.WriteLine("");
            Console.WriteLine("Ini adalah Agregasi");
            Pemain pemain1 = new Pemain("Budi");
            Pemain pemain2 = new Pemain("Iklina");
            Pemain pemain3 = new Pemain("Dimas");

            List<Pemain> daftarPemain = new List<Pemain>()
            {
                pemain1, pemain2, pemain3
            };

            Tim tim1 = new Tim("Barcelona", daftarPemain);
            tim1.Info();

            Console.WriteLine("");
            Console.WriteLine("Kompesisi");
            Mobil mobil1 = new Mobil("Avanza", "GTX RADEON");
            mobil1.Info();
            
        }
    }
}

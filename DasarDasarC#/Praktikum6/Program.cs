using System;
using System.Collections.Generic;
using System.Text;

namespace DasarDasarC_.Praktikum6
{
    abstract class Hero
    {
        public abstract void Skill(); //ini method abstrack
        public abstract void Ultimate();
        
        public void Info() //ini adalah method isi yang memiliki isi
        {
            Console.WriteLine("Ini adalah Hero Mobile Legend");
        }
        public void Senjata()
        {
            Console.WriteLine("Senjatanya Panah Busur");
        }
    }
    
    //pemanggilan dari method abstrack
    class Miya : Hero
    {
        public override void Skill()
        {
            Console.WriteLine("Ini adalah skill Miya Serbuan Panah");
        }

        public override void Ultimate()
        {
            Console.WriteLine("Ultimate Miya Slashing");
        }
    }

    // Abstract class
    //abstract class Pembayaran
    //{
    //    public string NamaMetode { get; set; }


    //    public Pembayaran(string nama)
    //    {
    //        NamaMetode = nama;
    //    }


    //    // Method abstract
    //    public abstract void ProsesPembayaran(decimal jumlah);


    //    // Method umum
    //    public void TampilkanMetode()
    //    {
    //        Console.WriteLine("Metode: " + NamaMetode);
    //    }
    //}


    //// Implementasi Transfer Bank
    //class TransferBank : Pembayaran
    //{
    //    public TransferBank() : base("Transfer Bank") { }


    //    public override void ProsesPembayaran(decimal jumlah)
    //    {
    //        Console.WriteLine($"Transfer sebesar {jumlah} melalui bank.");
    //        Console.WriteLine("Validasi rekening...");
    //        Console.WriteLine("Pembayaran berhasil!");
    //    }
    //}


    //// Implementasi E-Wallet
    //class EWallet : Pembayaran
    //{
    //    public EWallet() : base("E-Wallet") { }


    //    public override void ProsesPembayaran(decimal jumlah)
    //    {
    //        Console.WriteLine($"Membayar {jumlah} menggunakan E-Wallet.");
    //        Console.WriteLine("Scan QR Code...");
    //        Console.WriteLine("Saldo terpotong!");
    //    }
    //}


    //// Implementasi Kartu Kredit
    //class KartuKredit : Pembayaran
    //{
    //    public KartuKredit() : base("Kartu Kredit") { }


    //    public override void ProsesPembayaran(decimal jumlah)
    //    {
    //        Console.WriteLine($"Pembayaran {jumlah} dengan kartu kredit.");
    //        Console.WriteLine("Verifikasi CVV...");
    //        Console.WriteLine("Transaksi disetujui!");
    //    }
    //}

    //Interface 
    interface Penjahat
    {
        void skill();
        void Info();
    }

    //turunan dari interface
    class Arlod : Penjahat
    {
        public void skill() //pemanggilan dari interface langsung bisa menggunakan void tanpa override
        {
            Console.WriteLine("Skill Penjahat ngeslash");
        }

        public void Info()
        {
            Console.WriteLine("Info Penjahat tebusan 200k");
        }
    }

    // Interface (kontrak)
    interface IPembayaran
    {
        void ProsesPembayaran(decimal jumlah);
        string GetMetode();
    }

    // Implementasi Transfer Bank
    class TransferBank : IPembayaran
    {
        public void ProsesPembayaran(decimal jumlah)
        {
            Console.WriteLine($"Transfer {jumlah} via Bank");
            Console.WriteLine("Validasi rekening...");
            Console.WriteLine("Sukses!");
        }


        public string GetMetode()
        {
            return "Transfer Bank";
        }
    }

    // Implementasi E-Wallet
    class EWallet : IPembayaran
    {
        public void ProsesPembayaran(decimal jumlah)
        {
            Console.WriteLine($"Bayar {jumlah} pakai E-Wallet");
            Console.WriteLine("Scan QR...");
            Console.WriteLine("Berhasil!");
        }


        public string GetMetode()
        {
            return "E-Wallet";
        }
    }

    // Implementasi Kartu Kredit
    class KartuKredit : IPembayaran
    {
        public void ProsesPembayaran(decimal jumlah)
        {
            Console.WriteLine($"Bayar {jumlah} pakai Kartu Kredit");
            Console.WriteLine("Verifikasi OTP...");
            Console.WriteLine("Disetujui!");
        }


        public string GetMetode()
        {
            return "Kartu Kredit";
        }
    }


    // Service (menggunakan abstraction)
    class PaymentService
    {
        public void Bayar(IPembayaran metode, decimal jumlah)
        {
            Console.WriteLine("=== Pembayaran ===");
            Console.WriteLine("Metode: " + metode.GetMetode());
            metode.ProsesPembayaran(jumlah);
            Console.WriteLine();
        }
    }


    class Program
    {
        static void Main()
        {
            //Penggunaan Abtract class
            Hero h1 = new Miya();
            h1.Info();
            h1.Skill();
            Console.WriteLine("");

            //Penggunaan Abtract Class
            Penjahat h2 = new Arlod();
            h2.Info();
            h2.skill();
            Console.WriteLine("");

            //Pemanggailan dalam List bentuk abstract
            //List<Pembayaran> daftarPembayaran = new List<Pembayaran>()
            //{
            //    new TransferBank(),
            //    new EWallet(),
            //    new KartuKredit()
            //};

            //foreach (var pembayaran in daftarPembayaran)
            //{
            //    pembayaran.TampilkanMetode();
            //    pembayaran.ProsesPembayaran(50000);
            //    Console.WriteLine();
            //}


            //Pemanggilan object dari Interface
            PaymentService service = new PaymentService();


            service.Bayar(new TransferBank(), 100000);
            service.Bayar(new EWallet(), 50000);
            service.Bayar(new KartuKredit(), 200000);
        }
    }
}

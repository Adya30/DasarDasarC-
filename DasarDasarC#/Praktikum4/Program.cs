using System;
using System.Collections.Generic;
using System.Text;

namespace DasarDasarC_.Praktikum4
{

    public class Kantoran
    {
        public void kegiatan()
        {
            Console.WriteLine("Marahin anaknya");
        }

        public void kegiatan(string kantor)
        {
            Console.WriteLine($"Kerja kantoran di kantor {kantor}");
        }

        public void kegiatan(string produk, int jumlah)
        {
            Console.WriteLine($"Berbelanja {produk} dengan jumlah {jumlah}");
        }
    }

    public class Pembayaran
    {
        public string toko;

        public Pembayaran(string toko)
        {
            this.toko = toko;
        }

        public void Bayar(string norek)
        {
            Console.WriteLine($"Ini adalah metode pembayaran menggunakan nomer rekening no.{norek} dari toko {toko}");
        }

        public void Bayar(int nominal)
        {
            Console.WriteLine($"Ini adalah metode pembayaran cash dengan nominal Rp.{nominal} dari toko {toko}");
        }
    }

    public class Hewan
    {
        public string Jenis;

        public Hewan(string Jenis)
        {
            this.Jenis = Jenis;
        }

        public virtual void Suara()
        {
            Console.WriteLine($"Ini adalah Hewan besuara {Jenis}");
        }
    }

    public class Kucing : Hewan
    {
        public string warna;

        public Kucing(string Jenis, string warna) : base(Jenis)
        {
            this.warna = warna;
        }

        public override void Suara()
        {
            Console.WriteLine($"Suara Kucing {warna} : ngeong-ngeong {Jenis}");
        }
    }

    public class Kanguru : Hewan
    {
        public string warna;

        public Kanguru(string Jenis, string warna) : base(Jenis)
        {
            this.warna = warna;
        }

        public override void Suara()
        {
            Console.WriteLine($"Suara Kanguru {warna} : Waug-waug {Jenis}");
        }
    }

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Pegawai Kantoran");
            Kantoran pegawai1 = new Kantoran();
            pegawai1.kegiatan();
            pegawai1.kegiatan("Bank BRI");
            pegawai1.kegiatan("Marjan", 4);

            Console.WriteLine("");

            Console.WriteLine("Pembayaran Toko");
            Pembayaran b1 = new Pembayaran("Koperasi Merah Putih");
            b1.Bayar("87498273849823");
            b1.Bayar(500000);

            Console.WriteLine("");

            Console.WriteLine("Bagian Hewan");
            Hewan kucing1 = new Kucing("Mamalia", "Kuning");
            kucing1.Suara();

            Hewan kanguru1 = new Kanguru("Mamalia", "Coklat");
            kanguru1.Suara();
        }
    }
}

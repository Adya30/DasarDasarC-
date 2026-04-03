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

    //public class Program
    //{
    //    public static void Main()
    //    {
    //        Console.WriteLine("Pegawai Kantoran");
    //        Kantoran pegawai1 = new Kantoran();
    //        pegawai1.kegiatan();
    //        pegawai1.kegiatan("Bank BRI");
    //        pegawai1.kegiatan("Marjan", 4);

    //        Console.WriteLine("");

    //        Console.WriteLine("Pembayaran Toko");
    //        Pembayaran b1 = new Pembayaran("Koperasi Merah Putih");
    //        b1.Bayar("87498273849823");
    //        b1.Bayar(500000);

    //        Console.WriteLine("");

    //        Console.WriteLine("Bagian Hewan");
    //        Hewan kucing1 = new Kucing("Mamalia", "Kuning");
    //        kucing1.Suara();

    //        Hewan kanguru1 = new Kanguru("Mamalia", "Coklat");
    //        kanguru1.Suara();
    //    }
    //}

    class RekeningBank
    {
        // PRIVATE: Hanya bisa diakses oleh RekeningBank
        private string namaPemilik;

        // PROTECTED: Bisa diakses oleh RekeningBank DAN class turunannya
        protected double saldo;

        public string NamaPemilik
        {
            get { return namaPemilik; }
        }

        public double Saldo
        {
            get { return saldo; }
        }

        public RekeningBank(string nama, double saldoAwal)
        {
            namaPemilik = nama;
            saldo = (saldoAwal >= 0) ? saldoAwal : 0;
        }

        public virtual void SetorUang(double jumlah)
        {
            if (jumlah > 0)
            {
                saldo += jumlah;
                Console.WriteLine($"Setor Reguler berhasil. Saldo bertambah: Rp{jumlah}");
            }
        }
    }

    class RekeningPrioritas : RekeningBank
    {
        private double bonusSetoran = 50000;

        public RekeningPrioritas(string nama, double saldoAwal) : base(nama, saldoAwal)
        {
        }

        public override void SetorUang(double jumlah)
        {
            if (jumlah > 0)
            {
                // BUKTI PROTECTED: 
                // Class anak BISA mengakses dan mengubah variabel 'saldo' secara langsung
                saldo += (jumlah + bonusSetoran);
                Console.WriteLine($"Setor Prioritas berhasil! Anda mendapat bonus Rp{bonusSetoran}.");
            }
        }

        /*Contoh Error ketika ingin mengubah namaPemilik yang bersifat private:
         * 
        public void GantiNama(string namaBaru)
        {
            namaPemilik = namaBaru; // ERROR: Tidak bisa mengubah namaPemilik karena bersifat private
        }*/
    }

    class Program
    {
        static void Main(string[] args)
        {
            RekeningPrioritas rekVIP = new RekeningPrioritas("Praktikan VIP", 100000);

            Console.WriteLine($"Pemilik: {rekVIP.NamaPemilik}");
            Console.WriteLine($"Saldo Awal: Rp{rekVIP.Saldo}");
            Console.WriteLine("------------------------");

            rekVIP.SetorUang(200000);

            Console.WriteLine("------------------------");
            Console.WriteLine($"Saldo Akhir: Rp{rekVIP.Saldo}");

            /* CATATAN PENTING:
            Baris di bawah ini akan tetap ERROR (Compile Error):
            rekVIP.saldo = 5000000; 

            Alasan: Meskipun bersifat 'protected', variabel 'saldo' 
            tetap tertutup dari dunia luar (method Main). Ia HANYA terbuka 
            untuk class itu sendiri dan class turunannya.
            */

            /* CONTOH ERROR ketika mengakses namaPemilik yang bersifat private:

            rekVIP.namaPemilik = "Nama Baru"; 

            Alasan: method atau attribut yang bersifat private TIDAK BISA diakses
            atau diubah dari luar class, termasuk dari class turunannya.
            */
        }
    }
}


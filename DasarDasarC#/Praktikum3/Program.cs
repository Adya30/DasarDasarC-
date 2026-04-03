using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace DasarDasarC_.Praktikum3
{
    public class Parent //induk
    {
        public string nama;
        public string sifat;

        public Parent() { } //ini digunakan untuk yang tanpa konstruktor dalamnya tanpa paramater
        public Parent(string nama, string sifat) //ini untuk parameter
        {
            this.nama = nama;
            this.sifat = sifat;
        }

        public void tampilkanparent()
        {
            Console.WriteLine($"Ini adalah nama {nama} dan sifatnya{sifat}");
        }
    }

    class Child1 : Parent //child
    {
        string perilaku;
        string cirikhas;
        public Child1(string nama, string sifat, string perilaku, string cirikhas) : base(nama, sifat)
        {
            this.perilaku = perilaku;
            this.cirikhas = cirikhas;
        }

        public void tampilkanchild()
        {
            Console.WriteLine($"Ini adalah anak dari Parent ada tambahan perilaku {perilaku} dan cirikhasnya {cirikhas}");
        }
    }

    public class child2 : Parent
    {
        public string sifatanak2;

        public void Tampil2()
        {
            Console.WriteLine($"Ini adalah pewarisan anak pertamanya {sifatanak2}");
        }
    }

    //class Program
    //{
    //    public static void Main()
    //    {
    //        //Child1 anak1 = new Child1("Adit", "Pemarah, Ngambekan", "Hyperaktif" , "Brewokan");
    //        child2 anak2 = new child2();
    //        anak2.nama = "Sofyan";
    //        anak2.sifatanak2 = "Pemalu";
    //        //anak1.tampilkanparent();
    //        //anak1.tampilkanchild();
    //        anak2.Tampil2();
    //    }
    //}
}

//Live Coding

//SOAL 1
public class Produk
{
    public string namaProduk;
    public int harga;
    public Produk(string namaProduk, int harga)
    {
        this.namaProduk = namaProduk;
        this.harga = harga;
    }

    public void TampilkanProduk()
    {
        Console.WriteLine($"Nama Produk : {namaProduk}");
        Console.WriteLine($"Harga       : {harga}");
    }
}

// Class turunan
public class ProdukElektronik : Produk
{
    public int garansi;

    public ProdukElektronik(string namaProduk, int harga, int garansi) : base(namaProduk, harga)
    {
        this.garansi = garansi;
    }

    public void TampilkanElektronik()
    {
        Console.WriteLine($"Garansi : {garansi} bulan");
    }
}

// Class turunan 
public class ProdukMakanan : Produk
{
    public string tanggalKadaluarsa;

    public ProdukMakanan(string namaProduk, int harga, string tanggalKadaluarsa) : base(namaProduk, harga)
    {
        this.tanggalKadaluarsa = tanggalKadaluarsa;
    }

    public void TampilkanMakanan()
    {
        Console.WriteLine($"Kadaluarsa  : {tanggalKadaluarsa}");
    }
}

//public class Program
//{
//    public static void Main()
//    {
//        ProdukElektronik elektronik = new ProdukElektronik("Laptop", 8000000, 12);
//        ProdukMakanan makanan = new ProdukMakanan("Roti", 15000, "30-03-2026");

//        Console.WriteLine("Elektronik");
//        elektronik.TampilkanProduk();
//        elektronik.TampilkanElektronik();

//        Console.WriteLine();

//        Console.WriteLine("Makanan");
//        makanan.TampilkanProduk();
//        makanan.TampilkanMakanan();
//    }
//}


//SOAL 2
public class Buku
{
    public string judul;
    public string pengarang;
    public int tahunTerbit;
    public double harga;

    public Buku(string judul, string pengarang, int tahunTerbit, double harga)
    {
        this.judul = judul;
        this.pengarang = pengarang;
        this.tahunTerbit = tahunTerbit;
        this.harga = harga;
    }

    public void tampilkanDetail()
    {
        Console.WriteLine($"Judul        : {judul}");
        Console.WriteLine($"Pengarang    : {pengarang}");
        Console.WriteLine($"Tahun Terbit : {tahunTerbit}");
        Console.WriteLine($"Harga        : {harga}");
    }
}

public class BukuFiksi : Buku
{
    public string genre;
    public bool isBestSeller;

    public BukuFiksi(string judul, string pengarang, int tahunTerbit, double harga, string genre, bool isBestSeller) : base(judul, pengarang, tahunTerbit, harga)
    {
        this.genre = genre;
        this.isBestSeller = isBestSeller;
    }

    public void tampilkanTambahan()
    {
        Console.WriteLine($"Genre        : {genre}");
        Console.WriteLine($"Best Seller  : {isBestSeller}");
        Console.WriteLine($"Diskon       : {getDiskon()}");
    }

    public double getDiskon()
    {
        return harga * 0.10; //diskon 10%
    }
}

public class BukuNonFiksi : Buku
{
    public string kategori;
    public int edisi;

    public BukuNonFiksi(string judul, string pengarang, int tahunTerbit, double harga, string kategori, int edisi) : base(judul, pengarang, tahunTerbit, harga)
    {
        this.kategori = kategori;
        this.edisi = edisi;
    }

    public void tampilkanTambahan()
    {
        Console.WriteLine($"Kategori     : {kategori}");
        Console.WriteLine($"Edisi        : {edisi}");
        Console.WriteLine($"Diskon       : {getDiskon()}");
    }

    public double getDiskon()
    {
        return harga * 0.10;
    }
}

//public class Program
//{
//    static void Main()
//    {
//        BukuFiksi fiksi = new BukuFiksi("Laskar Pelangi", "Andrea Hirata", 2005, 80000, "Drama", true);
//        BukuNonFiksi nonFiksi = new BukuNonFiksi("Atomic Habits", "James Clear", 2018, 120000, "Self Development", 1);

//        Console.WriteLine("Buku Fiksi");
//        fiksi.tampilkanDetail();    
//        fiksi.tampilkanTambahan();   

//        Console.WriteLine();

//        Console.WriteLine("Buku Non Fiksi");
//        nonFiksi.tampilkanDetail();  
//        nonFiksi.tampilkanTambahan();
//    }
//}


//SOAL 3
public class Karyawan
{
    public string nama;
    public string tanggalLahir;
    public string jenisKelamin;

    public Karyawan(string nama, string tanggalLahir, string jenisKelamin)
    {
        this.nama = nama;
        this.tanggalLahir = tanggalLahir;
        this.jenisKelamin = jenisKelamin;
    }

    public void TampilkanInfo()
    {
        Console.WriteLine($"Nama           : {nama}");
        Console.WriteLine($"Tanggal Lahir  : {tanggalLahir}");
        Console.WriteLine($"Jenis Kelamin  : {jenisKelamin}");
    }
}

public class Manager : Karyawan
{
    public int tahunDiangkat;

    public Manager(string nama, string tanggalLahir, string jenisKelamin, int tahunDiangkat) : base(nama, tanggalLahir, jenisKelamin)
    {
        this.tahunDiangkat = tahunDiangkat;
    }

    public void TampilkanInfoManager()
    {
        Console.WriteLine($"Tahun Diangkat : {tahunDiangkat}");
    }
}

//class Program
//{
//    static void Main()
//    {
//        Karyawan k1 = new Karyawan("Budi", "10-01-1990", "Laki-laki");
//        Console.WriteLine("Data Karyawan");
//        k1.TampilkanInfo();

//        Console.WriteLine();

//        Manager m1 = new Manager("Siti", "05-05-1985", "Perempuan", 2020);
//        Console.WriteLine("Data Manager");
//        m1.TampilkanInfo();
//        m1.TampilkanInfoManager();
//    }
//}
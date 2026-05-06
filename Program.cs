using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

class Item
{
    public string Judul { get; set; }
    public int Tahun { get; set; }

    public Item(string judul, int tahun)
    {
        Judul = judul;
        Tahun = tahun;
    }

    public virtual void Deskripsi()
    {
        Console.WriteLine($"Item: {Judul} ({Tahun})");
    }
    public void infoItem()
    {
        Console.WriteLine($"Judul: {Judul}, Tahun:{Tahun}");
    }
}

class Buku : Item
{
    public string Penulis {  get; set; }
    public Buku(string judul, int tahun, string penulis) : base (judul, tahun)
    {
        Penulis = penulis;
    }
    public void cekPenulis()
    {
        Console.WriteLine($"Penulis:{Penulis}");
    }
    public override void Deskripsi() {
        Console.WriteLine($"Buku: {Judul} oleh {Penulis} ({Tahun})");
    }
}

class Majalah : Item
{
    public string Edisi { get; set; }
    public Majalah(string judul, int tahun, string edisi):base(judul, tahun)
    {
        Edisi = edisi;
    }
    public void infoEdisi()
    {
        Console.WriteLine($"Majalah '{Judul}', Edisi:{Edisi}");
    }
    public override void Deskripsi() {
        Console.WriteLine($"Majalah: {Judul} - Edisi {Edisi} ({Tahun})");

    }
}

class Novel : Buku
{
    public Novel(string judul, int tahun, string penulis) : base(judul, tahun, penulis) { }
    public void BacaSinopsis()
    {
        Console.WriteLine($"Menampilkan sinopsis novel '{Judul}' karya {Penulis}");
    }
    public override void Deskripsi()
    {
        Console.WriteLine($"Novel: {Judul} oleh {Penulis} ({Tahun})");
    }
}

class Komik : Buku
{
    public Komik(string judul, int tahun, string penulis): base(judul, tahun, penulis) { }
    public void TampilkanIlustrasi()
    {
        Console.WriteLine($"Menampilkan ilustrasi komik '{Judul}'");
    }
    public override void Deskripsi()
    {
        Console.WriteLine($"Komik: {Judul} oleh {Penulis} ({Tahun})");
    }
}

class MajalahAnak : Majalah
{
    public MajalahAnak(string judul, int tahun, string edisi) : base(judul, tahun, edisi) { }
    public void kategoriAnak()
    {
        Console.WriteLine($"Majalah '{Judul} termasuk kategori: Majalah Anak-Anak");
    }
    public override void Deskripsi()
    {
        Console.WriteLine($"Majalah Anak: {Judul} ({Tahun}) - Edisi {Edisi}");
    }
}

class MajalahTeknologi : Majalah
{
    public MajalahTeknologi(string judul, int tahun, string edisi):base(judul, tahun, edisi) { }
    public void topikTeknologi()
    {
        Console.WriteLine($"Majalah '{Judul}' membahas topik: Tekonologi terbaru");
    }
    public override void Deskripsi()
    {
        Console.WriteLine($"Majalah Teknologi: {Judul} ({Tahun}) - Edisi {Edisi}");
    }
}

class Perpustakaan
{
    private List<Item> daftarItem = new List<Item>();

    public void TambahItem(Item item)
    {
        daftarItem.Add(item);
    }

    public void DaftarItem()
    {
        Console.WriteLine("=== Daftar Item Perpustakaan ===");
        foreach (var item in daftarItem)
        {
            item.Deskripsi(); 
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
  
        Novel novel = new Novel("Midninght in December", 2024, "Kith");
        Majalah majalah = new Majalah("Bobo", 2020, "Edisi 10");
        MajalahTeknologi majalahteknologi = new MajalahTeknologi("Tech Today", 2023, "Edisi 5");
        Komik komik = new Komik("Detektif Conan", 1994, "Gosho Aoyama");


        // Soal no 1 menjalankan method Deskripsi() pada objek novel dan majalah
        Console.WriteLine("Soal no 1 menjalankan method Deskripsi() pada objek novel dan majalah");
        novel.Deskripsi();
        majalah.Deskripsi();
        Console.WriteLine();

        // Soal no 2 menjalankan method BacaSinopsis() pada Novel
        Console.WriteLine("Soal no 2 menjalankan method BacaSinopsis() pada Novel");
        novel.BacaSinopsis();
        Console.WriteLine();

        // Soal no 3 Menampilkan informasi lengkap Novel
        Console.WriteLine("Soal no 3 Menampilkan informasi lengkap Novel");
        novel.infoItem();      
        novel.cekPenulis();
        Console.WriteLine();

        // Soal no 4 menjalankan method TopikTeknologi() pada MajalahTeknologi
        Console.WriteLine("Soal no 4 menjalankan method TopikTeknologi() pada MajalahTeknologi");
        majalahteknologi.topikTeknologi();
        Console.WriteLine();

        // Soal no 5 
        Console.WriteLine("Soal no 5");
        Item item = komik;
        item.Deskripsi();
        
    }
}
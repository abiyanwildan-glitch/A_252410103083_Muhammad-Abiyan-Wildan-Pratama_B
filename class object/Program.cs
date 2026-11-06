using System;
//class Agen
//{
//    public string nama;
//    public string id;
//    public int stok;

//    public void Tampilinfo()
//    {
//        Console.WriteLine(nama, id, stok);
//    }
//}

//class Agenn
//{
//    public string hasil;
//    public string setoran;
//    public string rekapan;

//    public void Tampilinfo()
//    {
//        Console.WriteLine(hasil, setoran, rekapan);
//    }
//}

//class program
//{
//    static void Main(string[] Args)
//    {
//        Agen agen1 = new Agen();
//        Agenn agen2 = new Agenn();
//        agen1.nama = "polar";
//        agen1.id = "1";
//        agen1.stok = 20;
//        agen1.Tampilinfo();

//        agen2.hasil = "banyak";
//        agen2.setoran = "lumayan";
//        agen2.rekapan = "";
//    }
//}

//soal nomor 2
//class ProdukGalon
//{
//    private (string idProduk, string namaProduk, int stokGudang)

//        public void Kurangistok(int jumlah)
//        {
//        if
//        stokGudang < 0;
//        {
//            Console.WriteLine("Tidak terdeteksi");
//        }
//        else
//        {
//            Console.WriteLine("berhasil");
//        }
//}

//    class program
//    {
//        static void Main(string[] Args)
//        {
//            ProdukGalon galon1 = new ProdukGalon();

//            galon1.Kurangistok();

//        }
//    }
//soal nomor 3

//class ProdukGalon
//{
//    public string nama;

//    public void Tampilinfo()
//    {
//        Console.WriteLine("galon asli");
//    }
//}

//class GalonAkua : ProdukGalon
//{
//    public void Tampilinfo()
//    {
//        Console.WriteLine(" jenis air galon bermerek resmi dengan harga Rp20.000 per galon.");
//    }
//}

//class GalonBerkeran : ProdukGalon
//{
//    public void Tampilinfo()
//    {
//        Console.WriteLine("jenis air galon berkeran langsung dengan harga Rp12.000 per galon. galon jenis ini memiliki jenis keran yang berbeda beda ");
//    }
//}

//class program
//{
//    static void Main(string[] Args)
//    {
//        ProdukGalon galon1 = new ProdukGalon();
//        ProdukGalon galon2 = new GalonAkua();
//        ProdukGalon galon3 = new GalonBerkeran();


//        galon1.nama = "Asli";
//        galon1.Tampilinfo();
//        galon2.nama = "Aqua";
//        galon2.Tampilinfo();
//        galon3.nama = "Keran";
//        galon3.Tampilinfo();

//    }

//}

//soal 4
//class ProdukGalon
//{
//    public string nama;
//    public virtual void HitungBiaya(int jumlah);
//}

//class GalonAkua : ProdukGalon
//{
//    public override void HitungBiaya(int jumlah)
//    {
//        Console.WriteLine(jumlah * 20.000);
//    }
//}

//class GalonBerkeran : ProdukGalon
//{
//    public override void HitungBiaya(int jumlah)
//    {
//        Console.WriteLine(jumlah * 12.000);
//    }
//}

//class program
//{
//    static void Main(string[] Args)
//    {
//        ProdukGalon galon1 = new GalonAkua();
//        ProdukGalon galon2 = new GalonBerkeran();

//        galon1.HitungBiaya();
//        galon2.HitungBiaya();
//    }
//}

//soal 5
//abstract class ProdukGalon
//{
//    public string nama;
//    abstract virtual void HitungBiaya(int jumlah);
//}

//class GalonAkua : ProdukGalon
//{
//    public override void HitungBiaya(int jumlah)
//    {
//        Console.WriteLine(jumlah * 20.000);
//    }
//}

//class GalonBerkeran : ProdukGalon
//{
//    public override void HitungBiaya(int jumlah)
//    {
//        Console.WriteLine(jumlah * 12.000);
//    }
//}

//class program
//{
//    static void Main(string[] Args)
//    {
//        ProdukGalon galon1 = new GalonAkua();
//        ProdukGalon galon2 = new GalonBerkeran();

//        galon1.HitungBiaya();
//        galon2.HitungBiaya();
//    }
//}

//soal 6

//interface DapatDidistribusikan
//{
//    public (string Agen, string ProdukGalon, int jumlah)
//    public void KirimPaket()

//         public void Kurangistok(int jumlah)
//    {
//        if
//        stokGudang < 0;
//        {
//            Console.WriteLine("Tidak terdeteksi");
//        }
//        else
//        {
//            Console.WriteLine("berhasil");
//        }
//    }
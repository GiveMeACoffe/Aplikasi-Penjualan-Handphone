public class Handphone
{
    public string Nama { get; set; }
    public string Merek { get; set; }
    public decimal Harga { get; set; }
    public int Stok { get; set; }

    public Handphone(string nama, string merek, decimal harga, int stok)
    {
        Nama = nama;
        Merek = merek;
        Harga = harga;
        Stok = stok;
    }
}

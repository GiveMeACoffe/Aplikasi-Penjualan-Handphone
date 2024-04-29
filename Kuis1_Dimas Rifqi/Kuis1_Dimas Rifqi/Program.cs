using System;

class Program
{
    static void Main(string[] args)
    {
        ProductManager productManager = new ProductManager();

        Console.WriteLine("=== Selamat datang di Aplikasi Penjualan Handphone ===");
        Console.Write("Masukkan username: ");
        string username = Console.ReadLine();
        Console.Write("Masukkan password: ");
        string password = Console.ReadLine();

        User user = new User("admin", "1234");
        if (!user.Authenticate(username, password))
        {
            Console.WriteLine("Username atau password salah. Aplikasi akan keluar.");
            return;
        }

        Console.WriteLine("\nLogin berhasil!");

        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Cari Produk berdasarkan Nama");
            Console.WriteLine("2. Cari Produk berdasarkan Harga (min-max)");
            Console.WriteLine("3. Sortir Produk berdasarkan Jumlah Stok");
            Console.WriteLine("4. Tambah Produk Baru");
            Console.WriteLine("5. Hapus Produk");
            Console.WriteLine("6. Keluar");

            Console.Write("\nPilih menu (1-6): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Masukkan nama produk: ");
                    string productName = Console.ReadLine();
                    var productsByName = productManager.SearchByName(productName);
                    DisplayProducts(productsByName);
                    break;
                case "2":
                    Console.Write("Masukkan harga minimum: ");
                    decimal minPrice = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("Masukkan harga maksimum: ");
                    decimal maxPrice = Convert.ToDecimal(Console.ReadLine());
                    var productsByPriceRange = productManager.SearchByPriceRange(minPrice, maxPrice);
                    DisplayProducts(productsByPriceRange);
                    break;
                case "3":
                    var sortedProductsByStock = productManager.SortByStock();
                    DisplayProducts(sortedProductsByStock);
                    break;
                case "4":
                    Console.Write("Masukkan nama produk baru: ");
                    string newProductName = Console.ReadLine();
                    Console.Write("Masukkan merek produk: ");
                    string newProductBrand = Console.ReadLine();
                    Console.Write("Masukkan harga produk: ");
                    decimal newProductPrice = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("Masukkan stok produk: ");
                    int newProductStock = Convert.ToInt32(Console.ReadLine());
                    Handphone newProduct = new Handphone(newProductName, newProductBrand, newProductPrice, newProductStock);
                    productManager.AddProduct(newProduct);
                    Console.WriteLine("Produk baru berhasil ditambahkan!");
                    break;
                case "5":
                    Console.Write("Masukkan nama produk yang ingin dihapus: ");
                    string productToDelete = Console.ReadLine();
                    productManager.RemoveProduct(productToDelete);
                    break;
                case "6":
                    Console.WriteLine("Terima kasih telah menggunakan aplikasi!");
                    return;
                default:
                    Console.WriteLine("Pilihan tidak valid. Silakan pilih menu yang tersedia.");
                    break;
            }
        }
    }

    static void DisplayProducts(List<Handphone> products)
    {
        Console.WriteLine("\nDaftar Produk:");
        foreach (var product in products)
        {
            Console.WriteLine($"- {product.Nama} ({product.Merek}), Harga: Rp {product.Harga:N0}, Stok: {product.Stok}");
        }
    }
}

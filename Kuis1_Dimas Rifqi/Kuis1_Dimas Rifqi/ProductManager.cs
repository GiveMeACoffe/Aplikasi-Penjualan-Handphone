using System;
using System.Collections.Generic;
using System.Linq;

public class ProductManager
{
    private List<Handphone> products = new List<Handphone>
    {
        new Handphone("Samsung Galaxy S21", "Samsung", 12000000, 15),
        new Handphone("iPhone 13 Pro", "Apple", 15000000, 12),
        new Handphone("Redmi Note 11", "Xiaomi", 3000000, 20),
        new Handphone("OPPO Reno 7", "OPPO", 8000000, 18),
        new Handphone("Vivo X70 Pro", "Vivo", 10000000, 16),
        new Handphone("Realme GT 2 Pro", "Realme", 7000000, 14),
        new Handphone("OnePlus 10 Pro", "OnePlus", 13000000, 17),
        new Handphone("Google Pixel 6", "Google", 9000000, 19),
        new Handphone("Sony Xperia 1 III", "Sony", 11000000, 13),
        new Handphone("Nokia G50", "Nokia", 5000000, 16),
        new Handphone("Samsung Galaxy A52s", "Samsung", 6000000, 18),
        new Handphone("iPhone SE (2022)", "Apple", 7000000, 15),
        new Handphone("Xiaomi 11T", "Xiaomi", 5500000, 20),
        new Handphone("OPPO Find X5 Pro", "OPPO", 14000000, 14),
        new Handphone("Vivo V23", "Vivo", 4000000, 17),
        new Handphone("Realme 9 Pro", "Realme", 3500000, 19),
        new Handphone("OnePlus Nord 3", "OnePlus", 9000000, 16),
        new Handphone("Google Pixel 5a", "Google", 8000000, 18),
        new Handphone("Sony Xperia 5 III", "Sony", 10000000, 12),
        new Handphone("Nokia X20", "Nokia", 4500000, 20)
    };

    public void AddProduct(Handphone handphone)
    {
        products.Add(handphone);
    }

    public void RemoveProduct(string productName)
    {
        Handphone product = products.FirstOrDefault(p => p.Nama.Equals(productName, StringComparison.OrdinalIgnoreCase));
        if (product != null)
        {
            products.Remove(product);
            Console.WriteLine($"Produk '{productName}' berhasil dihapus.");
        }
        else
        {
            Console.WriteLine($"Produk '{productName}' tidak ditemukan.");
        }
    }

    public List<Handphone> SearchByName(string keyword)
    {
        return products.Where(p => p.Nama.Contains(keyword, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    public List<Handphone> SearchByPriceRange(decimal minPrice, decimal maxPrice)
    {
        return products.Where(p => p.Harga >= minPrice && p.Harga <= maxPrice).ToList();
    }

    public List<Handphone> SortByStock()
    {
        return products.OrderBy(p => p.Stok).ToList();
    }
}

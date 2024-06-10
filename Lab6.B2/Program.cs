using System;
using System.Collections.Immutable;

public class Phone
{
    public int id;
    public string name;
    public int shopId;
    public int price;
    public string des;
    public Phone(int id, int shopId, string name, int price, string des)
    {
        this.id = id;
        this.name = name;
        this.shopId = shopId;
        this.price = price;
        this.des = des;
    }
}
public class Shop
{
    public int id;
    public string tinh;
    public string quan;
    public Shop(int id, string tinh, string quan)
    {
        this.id = id;
        this.tinh = tinh;
        this.quan = quan;
    }
}
public class Program
{
    static void Main(string[] args)
    {
        List<Shop> listShop = new List<Shop>();
        listShop.Add(new Shop(1, "HCM", "Quan 12"));
        listShop.Add(new Shop(2, "HN", "Quan Nam Tu Lien"));
        listShop.Add(new Shop(3, "DN", "Quan Hai Chau"));

        List<Phone> listPhone = new List<Phone>();
        listPhone.Add(new Phone(1, 1, "IP 15", 100, "dlbg"));
        listPhone.Add(new Phone(2, 2, "IP 16", 1000, "dlbg"));
        listPhone.Add(new Phone(3, 3, "IP 17", 10000, "dlbg"));
        listPhone.Add(new Phone(4, 1, "IP 18", 100000, "dlbg"));

        Console.WriteLine("Cau 2a: ");
        var resulta = listShop.Join(listPhone,
                                  item1 => item1.id,
                                  item2 => item2.id,
                                  (item1, item2) => new
                                  {
                                      item1.tinh,
                                      item2.name,
                                  }
    );
        foreach (var item in resulta)
        {
            Console.WriteLine("ShopName: " + item.tinh + " |PhoneName: " + item.name);
            Console.WriteLine("---------");
        }

        Console.WriteLine("Cau 2b: ");
        var resultb = listShop.GroupJoin(listPhone,
                                          shop => shop.id,
                                          phone => phone.shopId,
                                          (shop, phone) => new
                                          {
                                              shop.tinh,
                                              price = phone.Select(x => x.price),
                                              name = phone.Select(y => y.name),

                                          }
    ); ;
        foreach (var item in resultb)
        {
            Console.WriteLine("ShopName: " + item.tinh);
            Console.WriteLine("----------------");
            for (var i = 0; i < item.name.Count(); i++)
            {
                Console.WriteLine("PhoneName: " + item.name.ElementAt(i) + "\nPhonePrice: " + item.price.ElementAt(i));
            }
            Console.WriteLine("----------------");
        }
    }
}
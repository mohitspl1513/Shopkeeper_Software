using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopKeeperSoftware
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShopKeeper shopKeeper = new ShopKeeper();
            shopKeeper.AddItems();
            shopKeeper.MenuCard();
            shopKeeper.OrderItems();
            shopKeeper.BillNo();
            shopKeeper.Print();
        }
    }
}

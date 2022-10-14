using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ShopKeeperSoftware
{
    internal class ShopKeeper
    {
        IDictionary<string, int> items = new Dictionary<string, int>();
        List<string> itemsList = new List<string>();
        ArrayList Order = new ArrayList();
        ArrayList Quantities = new ArrayList();
        ArrayList OrderedItem = new ArrayList();
        int i = 0;
        string itemsName, OrderItem;
        int Price, Quantity, A, Amount, SNo=1;
        string a = "01";
        string b = "22";
        string c = "000000";
        string last;
        static int f = 1;
        string billNo;
        public void AddItems()
        {
            do
            {
                Console.WriteLine("Enter the itemsName :");
                itemsName = Console.ReadLine();
                Console.WriteLine("Enter the items Price :");
                Price = Convert.ToInt32(Console.ReadLine());
                items.Add(itemsName, Price);
                Console.WriteLine("Do you want to Add More items Press 1 for Yes and Press 0 for No :");
                i = Convert.ToInt32(Console.ReadLine());
            } while (i == 1);
        }
        public void MenuCard()
        {
            Console.WriteLine("*********************** Here is Menu Card*******************");
            foreach (KeyValuePair<string, int> kvp in items)
                Console.WriteLine("itemName: {0}, Price: {1}", kvp.Key, kvp.Value);
            Console.WriteLine("************************************************************");
            Console.WriteLine();

         
        }
        public void OrderItems()
        {
            do
            {
                Console.WriteLine("What do you want to order :");
                OrderItem = Console.ReadLine();
                OrderedItem.Add(OrderItem);
                foreach (KeyValuePair<string, int> kvp in items)
                {
                    if (OrderItem == kvp.Key)
                    {
                        Console.WriteLine("Item is Available ");
                        A = kvp.Value;
                    }
                    else
                    {
                        break;
                    }
                }
                Console.WriteLine("Enter the Quantity of Ordered Item :");
                Quantity = Convert.ToInt32(Console.ReadLine());
                Quantities.Add(Quantity);
                Amount = A * Quantity;
                Order.Add(Amount);

                Console.WriteLine("Do you want More items Press 1 for Yes and Press 0 for No :");
                i = Convert.ToInt32(Console.ReadLine());
                SNo++;
            } while (i == 1);
        }
        public void BillNo()
        {
            Console.WriteLine("****************************Here is Your Bill**********************");
            last = f.ToString();
            int i = last.Length;
            billNo = a + b + (c.Substring(0, c.Length - i)) + last;
            f++;
            Console.WriteLine("Bill No.: " + billNo);

            Date();
            Console.WriteLine();
            Time();
        }
        public void Print()
        {
            int temp=0;
            Console.WriteLine(" S.No." + "  " + "Name of Items" + "  " + "Quantity" + "  " + "Amount");
            for(int i= 0; i < OrderedItem.Count; i++)
            {
                Console.Write(i+1 +"        "+ OrderedItem[i] +"          "+ Quantities[i]+"          " + Order[i]);
                Console.WriteLine();
                temp = temp+Convert.ToInt32(Order[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Total Bills : "+ temp);
             Console.WriteLine();
            Console.WriteLine("******************************************************************");
        }
        public void Date_Time()
        {
            DateTime thisDay = DateTime.Today;
            Console.WriteLine("Date : " + thisDay.ToString("D"));
            Console.WriteLine("Time : " + thisDay.ToString("g"));
        }

    }
}

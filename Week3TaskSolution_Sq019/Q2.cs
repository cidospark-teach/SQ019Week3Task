using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3TaskSolution_Sq019
{
    internal static class Q2
    {
        public static List<Item> itemlist = new List<Item>
        {
            new Item { ItemId = 1, ItemDes = "Bag" },
            new Item { ItemId = 2, ItemDes = "Pen" },
            new Item { ItemId = 3, ItemDes = "Book " },
            new Item { ItemId = 4, ItemDes = "Shoe " },
            new Item { ItemId = 5, ItemDes = "Pin " }
        };


        public static List<Sales> saleslist = new List<Sales>      
        {
            new Sales{ InvNo=1, ItemId = 3, Qty = 10 },
            new Sales{ InvNo=2, ItemId = 2, Qty = 20 },
            new Sales{ InvNo=3, ItemId = 3, Qty = 500 },
            new Sales{ InvNo=4, ItemId = 4, Qty = 20 },
            new Sales{ InvNo=5, ItemId = 3, Qty = 100 },
            new Sales{ InvNo=6, ItemId = 1, Qty = 50 }
        };

        public static void PrintResult()
        {
            var joined = itemlist.Join(saleslist, i => i.ItemId, s => s.ItemId, (i, s) => new
            {
                itemId = i.ItemId,
                itemName = i.ItemDes,
                Quantity = s.Qty
            });

            Console.WriteLine("ItemId\tName\tQuantity");
            foreach (var item in joined)
            {
                Console.WriteLine($"{item.itemId}\t{item.itemName}\t{item.Quantity}");
            }
        }

    }

    public class Item
    {
        public int ItemId;
        public string ItemDes;
    }

    public class Sales
    {
        public int InvNo;
        public int ItemId;
        public int Qty;
    }
}

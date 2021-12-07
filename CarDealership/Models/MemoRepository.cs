using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealership.Models
{
    public class MemoRepository : IRepository
    {

        private Dictionary<int, Memo> items;

        public MemoRepository()
        {
            items = new Dictionary<int, Memo>();
            //some hard code data for the table
            new List<Memo>
            {
                new Memo{InvoiceID=1,CustomerName="Jack",CarSerial=1233,PurchaseDate="1/1/2000",NetPrice=200,OtherFees=100,EmployeeID=101},
                new Memo{InvoiceID=2,CustomerName="Mike",CarSerial=1334,PurchaseDate="11/12/2009",NetPrice=440,OtherFees=150,EmployeeID=102}
            }.ForEach(m => AddMemo(m));
        }
        public Memo this[int id] => items.ContainsKey(id) ? items[id] : null;
        public IEnumerable<Memo> Memos => items.Values;

        public Memo AddMemo(Memo memo)
        {
            if (memo.InvoiceID == 0)
            {
                int key = items.Count;
                while (items.ContainsKey(key))
                { key++; }
                items[key] = memo;
            }

            items[memo.InvoiceID] = memo;
            return memo;
        }
        public void DeleteMemo(int id) => items.Remove(id);

        public Memo UpdateMemo(Memo memo)
            => AddMemo(memo);
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealership.Models
{
    public interface IRepository
    {
        //pure getter method
        IEnumerable<Memo> Memos { get; }
        //getting memos by id's
        Memo this[int id] { get; }

        //adding methods
        Memo AddMemo(Memo memo);
        //updating method
        Memo UpdateMemo(Memo memo);
        //deleting method
        void DeleteMemo(int id);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.Core.Data
{
    public class StockCard:BaseEntity
    {
        public DateTime TransDate { get; set; }
        public string Description { get; set; }
        public int Qty { get; set; }
        public int BalanceQty { get; set; }
        public int SerialNumber { get; set; }

        public Guid StockId { get; set; }

        public virtual Stock Stocks { get; set; }
    }
}

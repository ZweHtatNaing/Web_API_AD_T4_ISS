using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.Core.Data
{
    public class RequisitionDetail:BaseEntity
    {
        
        public Guid StockId { get; set; }
        public Guid RequisitionHeaderId { get; set; }
        public int RequestedQty { get; set; }
        public int RetrieveQty { get; set; }
        public int OutstandingQty { get; set; }
        public bool OutstandingStatus { get; set; }
        public string TransactionStatus { get; set; }
        public RequititionHeader RequititionHeader { get; set; }
//        public virtual ICollection<Stock> Stocks { get; set; }


        

        


    }
}

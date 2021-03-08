using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_Server_Crud.Data
{
    public class itemDetail
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int itemId { get; set; }
        public string itemName { get; set; }

        public decimal itemRate { get; set; }

        public DateTime? mDate { get; set; }

        public DateTime? eDate { get; set; }
    }
}

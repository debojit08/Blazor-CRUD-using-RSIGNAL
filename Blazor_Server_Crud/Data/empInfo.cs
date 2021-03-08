using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor_Server_Crud.Data
{
    public class empInfo
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int empId { get; set; }
        public string empName { get; set; }

        public string designation { get; set; }

        public string department { get; set; }
    }
}

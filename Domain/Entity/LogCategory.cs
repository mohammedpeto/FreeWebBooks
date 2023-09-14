using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
   public class LogCategory
    {
        public int Id { get; set; }
        public string Action { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }

        public int CatagoryId { get; set; }
        [ForeignKey("CatagoryId")]
        public Category Category { get; set; }
    }
}

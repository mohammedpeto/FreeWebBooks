using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class LogSubCategory
    {
        public int Id { get; set; }
        public string Action { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }

        public int SubCatagoryId { get; set; }
        [ForeignKey("SubCatagoryId")]
        public SubCategory  SubCategory { get; set; }
    }
}

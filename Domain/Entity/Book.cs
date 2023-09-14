using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Book
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "The Name is Requried !")]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "The Name must be at least 3 char and max 15 !")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The Name is Requried !")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "The Name must be at least 3 char and max 20 !")]
        public string Author { get; set; }
        public string ImageName { get; set; }
        public string FileName { get; set; }
        public string Description { get; set; }
        public bool Publish { get; set; }

        public int CurrentState { get; set; }

        public int CatagoryId { get; set; }
        [ForeignKey("CatagoryId")]
        public Category Category { get; set; }

        public int SubCatagoryId { get; set; }
        [ForeignKey("SubCatagoryId")]
        public SubCategory SubCategory { get; set; }



    }
}

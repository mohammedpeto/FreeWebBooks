﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
   public class Category
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="The Name is Requried !")]
        [StringLength(20,MinimumLength =3,ErrorMessage ="The Name must be at least 3 char and max 20 !")]
        public string Name { get; set; }
        public string Description { get; set; }

        public int CurrentStates { get; set; }


    }
}

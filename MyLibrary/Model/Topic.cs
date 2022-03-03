﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyLibrary.Model
{
    [Table("Topics")]

    public partial class Topic
    {
        public int Id { get; set; }

        [Required]

        public string Name { get; set; }
        public string Slug { get; set; }
        public int Parentid { get; set; }

        public int Orders { get; set; }




        public string MetaKey { get; set; }
        public string MetaDesc { get; set; }
        public int? Created_By { get; set; }
        public DateTime? Created_At { get; set; }
        public int? Updated_By { get; set; }
        public DateTime? Updated_At { get; set; }
        public int? Status { get; set; }
    }
}

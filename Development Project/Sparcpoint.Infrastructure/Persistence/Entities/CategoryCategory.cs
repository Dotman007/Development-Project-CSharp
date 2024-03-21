﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparcpoint.Infrastructure.Persistence.Entities
{
    public class CategoryCategory
    {
        [Key]
        [Column(Order = 1)]
        public int InstanceId { get; set; }

        [Key]
        [Column(Order = 2)]
        public int CategoryInstanceId { get; set; }

        [ForeignKey("InstanceId")]
        public virtual Category ParentCategory { get; set; }

        [ForeignKey("CategoryInstanceId")]
        public virtual Category ChildCategory { get; set; }
    }
}

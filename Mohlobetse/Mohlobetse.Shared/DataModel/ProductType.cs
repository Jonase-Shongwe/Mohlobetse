﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mohlobetse.Shared.DataModel
{
    public class ProductType
    {

        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }

        public bool IsDeleted { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mohlobetse.Shared.DataModel
{
    public class Product
    {
        public Guid Id { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public decimal Price { get; set; }
        public string Description { get; set; }
        [Required]
        public bool Availability { get; set; }
        [Required]
        public int Count { get; set; }

        public bool IsDeleted { get; set; }
    }
}

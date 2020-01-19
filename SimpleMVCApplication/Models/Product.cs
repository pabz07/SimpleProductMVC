using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SimpleMVCApplication.Models
{
    public class Product
    {
        public int Id { get; set; }
        // add index for column Name
        [Column(TypeName = "VARCHAR")]
        [StringLength(100)]
        [Required]
        [Index]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        // foreign key related to Category Table
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        // Add Table Time 
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
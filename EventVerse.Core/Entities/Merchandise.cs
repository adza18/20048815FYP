using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventVerse.Core.Entities
{
    [Table("Merchandise")]
    public class Merchandise
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Stock { get; set; }
        public int Price { get; set; }

        public MerchVariant MerchVariant { get; set; }


    }
}

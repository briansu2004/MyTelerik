using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelerikAutoComplete_simple.Dto;

namespace TelerikAutoComplete_simple.Data
{
    public class Category
    {
        public int CategoryId { get; set; }

        [Required]
        [StringLength(15)]
        public string CategoryName { get; set; }

        public string Description { get; set; }

        [StringLength(150)]
        public string PictureUrl { get; set; }

        public List<ProductDto> Products { get; set; }
    }
}

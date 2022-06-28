using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class ProductToReturnDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; } 

        public decimal Price { get; set; }  

        public string PrictureUrl { get; set; } //Qitu me ba PictureUrl, edhe me e migrate

        public string ProductType { get; set; }    

        public string ProductBrand { get; set; }  

    }
}
namespace Core.Entities
{
    public class Product : BaseEntity
    {
        
        public string Name { get; set; }

        public string Description { get; set; } 

        public decimal Price { get; set; }  

        public string PrictureUrl { get; set; } //Qitu me ba PictureUrl, edhe me e migrate

        public ProductType ProductType { get; set; }    

        public int ProductTypeId { get; set; }  

        public ProductBrand ProductBrand { get; set; }  

        public int ProductBrandId { get; set; }
    }
}
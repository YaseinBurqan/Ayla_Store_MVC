namespace Ayla_Store_MVC.Models.ViewModels
{
    public class ChartViewModel
    {

        public ChartViewModel()
        {
            Categories = new List<Category>();
            Products = new List<Product>();
            Reviews = new List<Review>();
            LatestProduct = new List<Product>();

        }

        public List<Category> Categories { get; set; }
        public List<Review> Reviews { get; set; }
        public List<Product> Products { get; set; }
        public List<Product> LatestProduct { get; set; }
    }
}

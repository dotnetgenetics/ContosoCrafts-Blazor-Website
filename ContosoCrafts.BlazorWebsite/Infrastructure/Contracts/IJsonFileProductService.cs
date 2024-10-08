using ContosoCrafts.BlazorWebsite.Model;

namespace ContosoCrafts.BlazorWebsite.Infrastructure.Contracts
{
    public interface IJsonFileProductService
    {
        public IEnumerable<Product> GetProducts();
        public void AddRating(string productId, int rating);
    }
}

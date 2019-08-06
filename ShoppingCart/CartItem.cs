using System.Collections.Generic;

namespace ShoppingCart
{
    public class CartItem
    {
        private Dictionary<Product, int> _products = new Dictionary<Product, int>();

        public void AddToCart(Product product, int quantity)
        {
            if (_products.ContainsKey(product))
            {
                _products[product] += quantity;
            }
            else
            {
                _products[product] = quantity;
            }
        }

        public double GetPriceOfProduct(Product product)
        {
            return _products[product] * product.Price;
        }

        public Dictionary<Product, int> GetProductList()
        {
            return _products;
        }
    }

    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Product
    {
        public string Name {  get; }
        public double Price {  get; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }

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

    public class Cart
    {
        private CartItem _cartItem;
        private Dictionary<Product, int> _productList;
        private double _totalCost = 0;
        public Cart(CartItem cartItem)
        {
            _cartItem = cartItem;
            
        }

        public double GetTotalPrice()
        {
            _productList = _cartItem.GetProductList();
            foreach (var item in _productList)
            {
                _totalCost += _cartItem.GetPriceOfProduct(item.Key);
            }

            return _totalCost;
        }

       

    }

    
}

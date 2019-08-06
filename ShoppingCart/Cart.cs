using System.Collections.Generic;

namespace ShoppingCart
{
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

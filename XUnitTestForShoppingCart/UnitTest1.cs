using ShoppingCart;
using System;
using System.Collections.Generic;
using Xunit;

namespace XUnitTestForShoppingCart
{
    public class UnitTest1
    {
        [Fact]
        public void Test_Case_For_Add_Products()
        {
            CartItem _cartItem = new CartItem();
            _cartItem.AddToCart(new Product("SamSung", 10000), 2);
            _cartItem.AddToCart(new Product("ViVo", 14000), 2);
            Dictionary<Product, int> _expectedResult = new Dictionary<Product, int>();
            _expectedResult.Add(new Product("SamSung", 10000), 2);
            _expectedResult.Add(new Product("ViVo", 14000), 2);
            var _actualResult = _cartItem.GetProductList();
            Assert.Equal(_expectedResult.ToString(), _actualResult.ToString());
        }

        [Fact]
        public void Test_Case_For_Get_Products_Total_Cost()
        {
            CartItem _cartItem = new CartItem();
            _cartItem.AddToCart(new Product("SamSung", 10000), 2);
            _cartItem.AddToCart(new Product("ViVo", 14000), 2);
            Cart _cart = new Cart(_cartItem);
            var _actualResult = _cart.GetTotalPrice();
            Assert.Equal(48000, _actualResult);
        }
    }
}

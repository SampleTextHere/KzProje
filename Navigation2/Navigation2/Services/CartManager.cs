using Navigation2.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
namespace Navigation2.Services
{
    public static class CartManager
    {
        public static ObservableCollection<CartItem> Cart { get; set; }

        public static void AddToCart(Product product)
        {
            foreach (CartItem cartItem in Cart)
            {
                if (cartItem.Product == product)
                {
                    cartItem.Amount++;
                    return;
                }
            }
            Cart.Add(new CartItem(product,1));
        }

        public static void RemoveItem(Product product, int amount = 0)
        {
            foreach (CartItem cartItem in Cart)
            {
                if (cartItem.Product == product)
                {
                    if (amount >= cartItem.Amount || amount == 0)
                    {
                        Cart.Remove(cartItem);
                    }
                    else
                    {
                        cartItem.Amount -= amount;
                    }
                    
                }
            }
        }

        public static float ReturnTotal(Product product)
        {
            foreach (CartItem cartItem in Cart)
            {
                if (cartItem.Product == product)
                {
                    return cartItem.Amount * product.Price;
                }
            }
            return 0f;
        }

        public static void CleanCart()
        {
            Cart.Clear();
        }


        static CartManager()
        {
            Cart = new ObservableCollection<CartItem>();
        }
    }
}

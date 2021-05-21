﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using Navigation2.ViewModels;
using Navigation2.Views;
using Navigation2.Models;
using System.Threading.Tasks;


namespace Navigation2.ViewModels
{
    class SepetViewModel : BaseViewModel
    {
        public ObservableCollection<CartItem> CartItems { get; set; }
        private float totalPrice;
        public float TotalPrice
        {
            get => totalPrice;
            set
            {
                totalPrice = value;
                OnPropertyChanged();
            }      
        }

        public Command CartCleanCommand { get; }
        public Command SatinAlmaCommand { get; }

        public SepetViewModel()
        {
            TotalPrice= 0f;
            CartItems = GetCart();
            foreach (CartItem cartItem  in CartItems)
            {
                float total = cartItem.Product.Price * cartItem.Amount;
                cartItem.Total = total;
                TotalPrice += total;
            }
            CartCleanCommand = new Command(CartClean);
            SatinAlmaCommand = new Command(SatinAlma);
        }
        
        private void CartClean(object obj)
        {
            TotalPrice = 0f;
            CartWipe();
        }

        private async void SatinAlma()
        {
            if (CartItems == null || CartItems.Count == 0)
                return;
            CartClean(this);
            await Shell.Current.GoToAsync($"///{nameof(Anasayfa)}/{nameof(SatinAlindi)}");

        }




    }
}

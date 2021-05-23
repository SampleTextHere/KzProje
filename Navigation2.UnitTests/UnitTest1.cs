using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Autofac.Extras.Moq;
using NUnit.Framework;
using FluentAssertions;
using Xamarin.Forms;
using AutoFixture;
using System.Threading.Tasks;
using System.Linq;
using Moq;
using System.Collections.Generic;

using Navigation2.Models;
using Navigation2.Services;
using Navigation2.ViewModels;
using Navigation2.Views;

namespace Navigation2.UnitTests
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void AnasayfaUrunTest()
        {
            using (var mock = AutoMock.GetLoose())
            {
                var anasayfa = mock.Create<AnasayfaViewModel>();
            
                anasayfa.Products.Should().NotBeEmpty("ürünler getirilimedi");
                foreach (var item in DataHolder.Products)
                {
                    anasayfa.Products.Should().Contain(item, "ürünler eksik");
                }
            }
        }

        [Test]
        public void SepetEkleTest()
        {
            using (var mock = AutoMock.GetLoose())
            {
                var anasayfa = mock.Create<AnasayfaViewModel>();
                List<Product> addedProducts = new List<Product>();
                foreach (var item in DataHolder.Products)
                {
                    addedProducts.Add(item);
                    anasayfa.SelectedProduct = item;
                    anasayfa.AddToCart();
                }

                CartManager.Cart.Should().NotBeEmpty();

                List<Product> productsInCart = new List<Product>();
                foreach (var item in CartManager.Cart)
                {
                    productsInCart.Add(item.Product);
                }
                foreach (var item in addedProducts)
                {
                    productsInCart.Should().Contain(item);
                }
            }
        }

        [Test]
        public void SepetTemizleTest()
        {
            using (var mock = AutoMock.GetLoose())
            {
                var anasayfa = mock.Create<AnasayfaViewModel>();
                for (int i = 0; i < 5; i++)
                {

                }
                var sepet = mock.Create<SepetViewModel>();
                sepet.CartWipe();
                CartManager.Cart.Should().BeEmpty();
            }
        }

    }
}

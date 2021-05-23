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
    }
}

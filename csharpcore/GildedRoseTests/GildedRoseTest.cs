using GildedRose.Models;
using GildedRose.Services.Contracts;
using GildedRoseKata;
using System.Collections.Generic;
using Xunit;

namespace GildedRoseTests
{
    public class GildedRoseTest
    {
        [Fact]
        public void ItemNameShouldNotBeModified()
        {
            string actual = "foo";
            IList<GenericItem> Items = new List<GenericItem> { new GenericItem { Name = actual, SellIn = 0, Quality = 0 } };
            GildedRoseKata.GildedRose app = new GildedRoseKata.GildedRose(Items);
            app.UpdateQualityNewVersion();
            Assert.Equal(actual, Items[0].Name);
        }

        [Fact]
        public void GenericItemShouldUpdateSellIn()
        {
            GenericItem item = new GenericItem("", 5, 6);

            var actual = item.SellIn;


            item.UpdateItem();

            var expected = actual - 1;

            Assert.Equal(item.SellIn, expected);
        }

        [Fact]
        public void SulfurasItemQualityShoudBe80()
        {
            Sulfuras item = new Sulfuras(5, 6);



            item.UpdateItem();

            var expected = 80;

            Assert.Equal(item.Quality, expected);
        }

        [Fact]
        public void SulfurasItemShouldNotUpdateSellIn()
        {
            Sulfuras item = new Sulfuras(5, 6);

            var actual = item.SellIn;


            item.UpdateItem();

            var expected = actual;

            Assert.Equal(item.SellIn, expected);
        }

        [Fact]
        public void AgedBrieItemQualityShouldBeGreaterAfterUpdate()
        {
            AgedBrie item = new AgedBrie(5, 6);

            var actual = item.Quality;

            item.UpdateItem();

            Assert.True(item.Quality > actual);
        }
    }
}

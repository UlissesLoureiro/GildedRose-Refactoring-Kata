using GildedRose.Services.Contracts;
using GildedRose.Services.Implementations;
using GildedRoseKata;

namespace GildedRose.Models
{
    public class GenericItem : Item, IItem
    {
        protected GenericHandler _handler { get; set; }

        public GenericItem()
        {
            _handler = new GenericHandler();
        }

        public GenericItem(string name, int sellIn, int quality)
        {
            _handler = new GenericHandler();
            Name = name;
            Quality = quality;
            SellIn = sellIn;
        }

        public void UpdateItem()
        {
            var clone = new Item();

            clone.Name = this.Name;
            clone.Quality = this.Quality;
            clone.SellIn = this.SellIn;

            _handler.UpdateQuality(ref clone);
            _handler.CheckQualityMaxValue(ref clone);
            _handler.CheckQualityMinValue(ref clone);
            _handler.UpdateSellIn(ref clone);

            this.Name = clone.Name;
            this.Quality = clone.Quality;
            this.SellIn = clone.SellIn;
        }
    }
}

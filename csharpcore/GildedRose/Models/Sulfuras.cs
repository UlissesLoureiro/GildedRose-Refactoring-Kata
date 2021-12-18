using GildedRose.Services.Contracts;
using GildedRose.Services.Implementations;
using GildedRoseKata;

namespace GildedRose.Models
{
    public class Sulfuras : GenericItem
    {

        public Sulfuras(int sellIn, int quality)
          : base("Sulfuras, Hand of Ragnaros", sellIn, quality)
        {
            _handler = new AgedBrieHandler();
        }

        public override T UpdateItem<T>(T item)
        {
            return item;
        }
    }
}

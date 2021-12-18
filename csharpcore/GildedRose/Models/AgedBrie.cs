using GildedRose.Services.Implementations;

namespace GildedRose.Models
{
    public class AgedBrie : GenericItem
    {
        public AgedBrie(int sellIn, int quality)
            : base("Aged Brie", sellIn, quality)
        {
            _handler = new AgedBrieHandler();
        }

    }
}

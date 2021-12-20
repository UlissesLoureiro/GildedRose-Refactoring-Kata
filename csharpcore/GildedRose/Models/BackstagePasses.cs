using GildedRose.Services.Contracts;
using GildedRose.Services.Implementations;
using GildedRoseKata;

namespace GildedRose.Models
{
    public class BackstagePasses : GenericItem
    {

        public BackstagePasses(int sellIn, int quality)
         : base("Backstage passes to a TAFKAL80ETC concert", sellIn, quality)
        {
            _handler = new BackstagePassesHandler();
        }
    }
}



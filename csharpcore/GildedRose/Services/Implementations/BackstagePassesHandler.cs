
using GildedRoseKata;

namespace GildedRose.Services.Implementations
{
    public class BackstagePassesHandler : GenericHandler
    {
        public override void UpdateQuality(ref Item item)
        {
            if (item.SellIn <= 0)
            {
                item.Quality = 0;
                return;
            }
            else if (item.SellIn <= 5)
            {
                item.Quality = item.Quality + 3 * QualityFactor;
                return;
            }
            else if (item.SellIn <= 10)
            {
                item.Quality = item.Quality + 2 * QualityFactor;
                return;
            }

            item.Quality = item.Quality + QualityFactor;
        }
    }
}

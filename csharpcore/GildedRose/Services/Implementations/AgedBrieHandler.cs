
using GildedRoseKata;

namespace GildedRose.Services.Implementations
{
    public class AgedBrieHandler : GenericHandler
    {
        public override void UpdateQuality(ref Item item)
        {
            item.Quality = item.Quality + QualityFactor;
        }
    }
}

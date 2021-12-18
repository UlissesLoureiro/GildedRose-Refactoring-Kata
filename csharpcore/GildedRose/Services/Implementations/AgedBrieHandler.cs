
using GildedRoseKata;

namespace GildedRose.Services.Implementations
{
    public class AgedBrieHandler : GenericHandler
    {
        public override void UpdateQuality<T>(ref T item) 
        {
            item.Quality = item.Quality + QualityFactor;
        }
    }
}

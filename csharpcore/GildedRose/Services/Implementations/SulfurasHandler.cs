
using GildedRoseKata;

namespace GildedRose.Services.Implementations
{
    public class SulfurasHandler : GenericHandler
    {
        public SulfurasHandler()
        {
            QualityMaxValue = 80;
        }
        public override void UpdateQuality(ref Item item)
        {
            item.Quality = 80;
        }

        public override void UpdateSellIn(ref Item item)
        {
        }
    }
}

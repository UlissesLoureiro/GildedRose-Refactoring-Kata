
using GildedRoseKata;

namespace GildedRose.Services.Implementations
{
    public class SulfurasHandler : GenericHandler
    {
        public override void UpdateQuality(ref Item item)
        {
            item.Quality = 80;
        }
    }
}


using GildedRoseKata;

namespace GildedRose.Services.Implementations
{
    public class SulfurasHandler : GenericHandler
    {
        public override void UpdateQuality<SulfurasHandler>(ref SulfurasHandler item)
        {
            item.Quality = 80;
        }
    }
}

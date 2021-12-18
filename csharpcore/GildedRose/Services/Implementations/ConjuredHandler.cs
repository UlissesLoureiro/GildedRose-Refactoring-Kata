

namespace GildedRose.Services.Implementations
{
    public class ConjuredHandler : GenericHandler
    {
        public ConjuredHandler()
        {
            QualityFactor = 2 * QualityFactor;
        }
    }
}

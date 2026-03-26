using System.ComponentModel;

namespace GildedRoseKata.Strategies;

public class AgedBrieUpdateQualityStrategy : IUpdateQuality
{
    public void UpdateItemQuality(Item item)
    {
        item.SellIn--;

        if(item.Quality < 50)
            {
                item.Quality++;
            }

        if(item.SellIn < 0)
        {
            if(item.Quality < 50)
            {
                item.Quality++;
            }
        }
    }
}
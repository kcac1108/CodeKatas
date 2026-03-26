namespace GildedRoseKata.Strategies;

public class BackstagePassesUpdateQualityStrategy : IUpdateQuality
{
    public void UpdateItemQuality(Item item)
    {

        if (item.Quality < 50)
        {
            item.Quality++;
            
            if (item.SellIn < 11)
            {
                if (item.Quality < 50)
                {
                    item.Quality++;
                }
            }

            if (item.SellIn < 6)
            {
                if (item.Quality < 50)
                {
                    item.Quality++;
                }
            }
        }

        item.SellIn--;

        if (item.SellIn < 0)
        {
            item.Quality = 0;
        }
    }
}
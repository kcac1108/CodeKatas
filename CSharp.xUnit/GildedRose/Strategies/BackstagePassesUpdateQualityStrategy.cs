using GildedRoseKata.Models;

namespace GildedRoseKata.Strategies;

public class BackstagePassesUpdateQualityStrategy : IUpdateQuality
{
    public void UpdateItemQuality(Item item)
    {
        item.IncreaseQuality();

        if (item.SellIn < 11)
        {
            item.IncreaseQuality();
        }

        if (item.SellIn < 6)
        {
            item.IncreaseQuality();
        }

        item.DecreaseSellIn();

        if (item.SellIn < 0)
        {
            item.Quality = 0;
        }
    }
}
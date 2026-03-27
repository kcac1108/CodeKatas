using GildedRoseKata.Models;

namespace GildedRoseKata.Strategies;

public class AgedBrieUpdateQualityStrategy : IUpdateQuality
{
    public void UpdateItemQuality(Item item)
    {
        item.IncreaseQuality();
        item.DecreaseSellIn();

        if(item.SellIn < 0)
        {
            item.IncreaseQuality();
        }
    }
}
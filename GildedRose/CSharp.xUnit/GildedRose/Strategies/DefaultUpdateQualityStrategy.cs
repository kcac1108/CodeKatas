using GildedRoseKata.Models;

namespace GildedRoseKata.Strategies;

public class DefaultUpdateQualityStrategy : IUpdateQuality
{
	public void UpdateItemQuality(Item item)
	{
        item.DecreaseQuality();
        item.DecreaseSellIn();
        
        if (item.SellIn < 0)
        {
            item.DecreaseQuality();
        }
	}
}
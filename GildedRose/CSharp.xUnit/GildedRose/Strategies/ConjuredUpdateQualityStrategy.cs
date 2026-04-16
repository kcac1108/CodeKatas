using GildedRoseKata.Models;

namespace GildedRoseKata.Strategies;

public class ConjuredUpdateQualityStrategy : IUpdateQuality
{
	public void UpdateItemQuality(Item item)
	{
		item.DecreaseQuality();
		item.DecreaseQuality();

		item.DecreaseSellIn();
		
		if (item.SellIn < 0)
		{
			item.DecreaseQuality();
		}
	}
}
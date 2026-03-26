namespace GildedRoseKata.Strategies;

public class ConjuredUpdateQualityStrategy : IUpdateQuality
{
	public void UpdateItemQuality(Item item)
	{
		item.SellIn--;
		item.Quality -= 2;

		if (item.SellIn < 0)
		{
			item.Quality -= 2;
		}
	}
}
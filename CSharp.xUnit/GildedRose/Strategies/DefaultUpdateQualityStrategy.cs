namespace GildedRoseKata.Strategies;

public class DefaultUpdateQualityStrategy : IUpdateQuality
{
	public void UpdateItemQuality(Item item)
	{
		item.SellIn--;
		
		if (item.Quality > 0)
		{
			item.Quality--;

			if (item.SellIn < 0)
			{
				if (item.Quality > 0)
				{
					item.Quality--;
				}
			}
		}
	}
}
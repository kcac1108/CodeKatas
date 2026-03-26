using System.Collections.Generic;
using GildedRoseKata.Strategies;

namespace GildedRoseKata;

public class GildedRose(IList<Item> Items)
{
    IList<Item> Items = Items;

    public void UpdateQuality()
    {
        IUpdateQuality strategy;
        foreach(var item in Items)
        {
            strategy = item.Name switch
            {
                "Aged Brie" => new AgedBrieUpdateQualityStrategy(),
                "Sulfuras, Hand of Ragnaros" => new SulfurasUpdateQualityStrategy(),
                "Backstage passes to a TAFKAL80ETC concert" => new BackstagePassesUpdateQualityStrategy(),
                // "Conjured Mana Cake" => new ConjuredUpdateQualityStrategy(),
                _ => new DefaultUpdateQualityStrategy(),
            };

            strategy.UpdateItemQuality(item);
        }
    }
}
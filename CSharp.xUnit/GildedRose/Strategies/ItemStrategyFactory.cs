using GildedRoseKata.Models;
using GildedRoseKata.Strategies;

namespace GildedRoseKata.Strategies;

public class ItemStrategyFactory
{
    public static IUpdateQuality CreateStrategyFor(Item item)
    {
        return item.Name switch
        {
            "Aged Brie" => new AgedBrieUpdateQualityStrategy(),
            "Sulfuras, Hand of Ragnaros" => new SulfurasUpdateQualityStrategy(),
            "Backstage passes to a TAFKAL80ETC concert" => new BackstagePassesUpdateQualityStrategy(),
            "Conjured Mana Cake" => new ConjuredUpdateQualityStrategy(),
            _ => new DefaultUpdateQualityStrategy(),
        };
    }
}
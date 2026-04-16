using System.Collections.Generic;
using GildedRoseKata.Models;
using GildedRoseKata.Strategies;

namespace GildedRoseKata;

public class GildedRose(IList<Item> Items)
{
    readonly IList<Item> Items = Items;

    public void UpdateQuality()
    {
        foreach(var item in Items)
        {
            var strategy = ItemStrategyFactory.CreateStrategyFor(item);
            strategy.UpdateItemQuality(item);
        }
    }
}
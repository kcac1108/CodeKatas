using Xunit;
using System.Collections.Generic;
using GildedRoseKata;

namespace GildedRoseTests;

public class GildedRoseTest
{
    [Fact]
    public void ConjuredManaCake()
    {
        IList<Item> Items = [new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}];
        GildedRose app = new(Items);
        app.UpdateQuality();
        Assert.Equal("Conjured Mana Cake", Items[0].Name);
        Assert.Equal(2, Items[0].SellIn);
        Assert.Equal(4, Items[0].Quality);
    }

    [Fact]
    public void AgedBrieItem()
    {
        IList<Item> Items = [new Item {Name = "Aged Brie", SellIn = 2, Quality = 0}];
        GildedRose app = new(Items);
        app.UpdateQuality();
        Assert.Equal("Aged Brie", Items[0].Name);
        Assert.Equal(1, Items[0].SellIn);
        Assert.Equal(1, Items[0].Quality);
    }
}
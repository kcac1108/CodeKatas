using Xunit;
using System.Collections.Generic;
using GildedRoseKata;
using GildedRoseKata.Models;

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

    [Fact]
    public void SulfurasItem()
    {
        IList<Item> Items = [new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80}];
        GildedRose app = new(Items);
        app.UpdateQuality();
        Assert.Equal("Sulfuras, Hand of Ragnaros", Items[0].Name);
        Assert.Equal(0, Items[0].SellIn);
        Assert.Equal(80, Items[0].Quality);
    }

    [Fact]
    public void BackstagePassesItem()
    {
        IList<Item> Items = [new Item {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15, Quality = 20}];
        GildedRose app = new(Items);
        app.UpdateQuality();
        Assert.Equal("Backstage passes to a TAFKAL80ETC concert", Items[0].Name);
        Assert.Equal(14, Items[0].SellIn);
        Assert.Equal(21, Items[0].Quality);
    }

    [Fact]
    public void RegularItem()
    {
        IList<Item> Items = [new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20}];
        GildedRose app = new(Items);
        app.UpdateQuality();
        Assert.Equal("+5 Dexterity Vest", Items[0].Name);
        Assert.Equal(9, Items[0].SellIn);
        Assert.Equal(19, Items[0].Quality);
    }
}
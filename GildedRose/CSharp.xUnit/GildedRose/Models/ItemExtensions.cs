using System;
using System.Data;
using System.Runtime.CompilerServices;

namespace GildedRoseKata.Models;

public static class ItemExtension
{
    public static void DecreaseSellIn(this Item item)
    {
        item.SellIn--;
    }

    public static void IncreaseQuality(this Item item)
    {
        if (item.Quality < 50)
        {
            item.Quality++;
        }
    }

    public static void DecreaseQuality(this Item item)
    {
        if (item.Quality > 0)
        {
            item.Quality--;
        }
    }
}
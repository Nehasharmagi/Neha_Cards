using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Neha_Cards.Data;
using System;
using System.Linq;

namespace Neha_Cards.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Neha_CardsContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<Neha_CardsContext>>()))
            {
                // Look for any movies.
                if (context.Cards.Any())
                {
                    return;   // DB has been seeded
                }

                context.Cards.AddRange(
                    new Cards
                    {
                       CardSize= "Medium",
                       CardType="Heart",
                       BrandName="Bicycle Playing Cards",
                       Desgin="Heart",
                       Color="Red",
                       Rating=7


                    },
                    new Cards
                    {
                        CardSize = "Jumbo",
                        CardType = "Oval",
                        BrandName = "KEM Cards",
                        Desgin = "Arrow",
                        Color = "Blue",
                        Rating = 8


                    },
                    new Cards
                    {
                        CardSize = "Regular",
                        CardType = "Queen",
                        BrandName = "Cartamondi",
                        Desgin = "Rectangle",
                        Color = "Black",
                        Rating = 8


                    },
                    new Cards
                    {
                        CardSize = "Standard",
                        CardType = "King",
                        BrandName = "Gemaco Cards",
                        Desgin = "Square",
                        Color = "Red",
                        Rating = 4


                    },
                    new Cards
                    {
                        CardSize = "Jumbo",
                        CardType = "Diamond",
                        BrandName = "Cartamunt USA",
                        Desgin = "Diamond",
                        Color = "Black",
                        Rating = 7


                    }, 
                    new Cards
                    {
                        CardSize = "Small",
                        CardType = "Crazy Eights",
                        BrandName = "Clubs Cards",
                        Desgin = "Clubs",
                        Color = "Red",
                        Rating = 6


                    },
                    new Cards
                    {
                        CardSize = "Meduim",
                        CardType = "Jack",
                        BrandName = "JP Morgan chase",
                        Desgin = "Cri Clubs",
                        Color = "Black",
                        Rating = 8


                    },
                    new Cards
                    {
                        CardSize = "Meduim",
                        CardType = "Jack card",
                        BrandName = "JP Morgan chase",
                        Desgin = "Cri Clubs",
                        Color = "Red",
                        Rating = 8


                    },
                    new Cards
                    {
                        CardSize = "Regular",
                        CardType = "Jack",
                        BrandName = "Morgan chase",
                        Desgin = "Cri Clubs",
                        Color = "Black",
                        Rating = 8


                    },
                    new Cards
                    {
                        CardSize = "Standard",
                        CardType = "Jack Card",
                        BrandName = "JP Morgan chase",
                        Desgin = "Cri Clubs",
                        Color = "Red",
                        Rating = 8


                    }, new Cards
                    {
                        CardSize = "Meduim",
                        CardType = "Jack",
                        BrandName = "Morgan chase",
                        Desgin = "Clubs",
                        Color = "Black",
                        Rating = 8


                    }



                );
                context.SaveChanges();
            }
        }
    }
}
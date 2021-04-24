using GameStore.Data.Interfaces;
using GameStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.Data.Mocks
{
    public class MockGames : IAllGames
    {
        private readonly IGamesCategory _categoryGames = new MockCategory();
        public IEnumerable<Game> Games 
        {
             
            get
            {
                return new List<Game>
                {
                    new Game{
                        Name = "Red Dead Redemption 2",
                        ShortDescription="Wild West",
                        LongDescription = "The game is the third entry in the Red Dead series and is a prequel to the 2010 game Red Dead Redemption. The story is set in 1899 in a fictionalized representation of the Western, Midwestern, and Southern United States and follows outlaw Arthur Morgan, a member of the Van der Linde gang.",
                        Image = "/img/rdr2.jpg",
                        Price = 45,
                        IsFavourite = true,
                        Available = true,
                        Category = _categoryGames.AllCategories.First()
                        },
                    new Game{
                        Name = "Civilization VI",
                        ShortDescription="Development and progress",
                        LongDescription="Civilization VI is a turn-based strategy video game in which one or more players compete alongside computer-controlled AI opponents to grow their individual civilization from a small tribe to control of the entire planet across several periods of development.",
                        Image = "/img/civilization.jpg",
                        Price = 20,
                        IsFavourite = true,
                        Available = true,
                        Category = _categoryGames.AllCategories.First()
                    },
                    new Game{
                        Name="The Witcher 3: Wild Hunt",
                        ShortDescription="The brave Witcher fighting the Wild Hunt",
                        LongDescription="The Witcher: Wild Hunt is a story-driven open world RPG set in a visually stunning fantasy universe full of meaningful choices and impactful consequences.",
                        Image="/img/thewitcher.jpg",
                        Price = 30,
                        IsFavourite = true,
                        Available = true,
                        Category = _categoryGames.AllCategories.Last()
                    },
                    new Game
                    {   
                        Name="The Elder Scrolls V: Skyrim",
                        ShortDescription = "Travel across a vast world",
                        LongDescription = "The Elder Scrolls V: Skyrim is an open world action role-playing video game developed by Bethesda Game Studios and published by Bethesda Softworks.",
                        Image = "/img/skyrim.jpg",
                        Price = 15, 
                        IsFavourite = true,
                        Available = true,
                        Category = _categoryGames.AllCategories.Last()
                    }
                };
            }
        }
        public IEnumerable<Game> GetFavGames { get; set; }

        public Game getObjectGame(int gameId)
        {
            throw new NotImplementedException();
        }
    }

}

using GameStore.Data.Interfaces;
using GameStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.Data.Mocks
{
    public class MockCategory : IGamesCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category{CategoryName = "Action-Adventure Game", Description = "Action-adventure is a video game genre that combines core elements from both the action game and adventure game genres."},
                    new Category{CategoryName = "Role-playing", Description  = "A role-playing game is a game in which players assume the roles of characters in a fictional setting."}
                };
            }
        }
    }
}

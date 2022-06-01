﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class MockPieRepository : IPieRepository
    {
        public IEnumerable<Pie> AllPies => new List<Pie>
        {
             new Pie {PieId=1,Name="Strawberry Pie",Price=15.95M,ShortDescription="hello"},
             new Pie {PieId=1,Name="Cheese cake",Price=18.95M,ShortDescription="hello"},
             new Pie {PieId=1,Name="Rhubarb Pie",Price=15.95M,ShortDescription="hello"},
             new Pie {PieId=1,Name="Pumkin Pie",Price=12.95M,ShortDescription="hello"}
        };
        public IEnumerable<Pie> PiesOfTheWeek { get; }
        public Pie GetPieById(int pieId)
        {
            return AllPies.FirstOrDefault(p => p.PieId == pieId);
        }
    }
}

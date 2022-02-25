using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Neha_Cards.Models;

namespace Neha_Cards.Data
{
    public class Neha_CardsContext : DbContext
    {
        public Neha_CardsContext (DbContextOptions<Neha_CardsContext> options)
            : base(options)
        {
        }

        public DbSet<Neha_Cards.Models.Cards> Cards { get; set; }
    }
}

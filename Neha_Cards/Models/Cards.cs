using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using System.ComponentModel.DataAnnotations;


namespace Neha_Cards.Models
{
    public class Cards
    {
        public int Id { get; set; }
        public string CardSize { get; set; }

        public string CardType { get; set; }
        public string BrandName { get; set; }
        public string Desgin { get; set; }

        public string Color { get; set; }

        public int Rating { get; set; }

    }
}

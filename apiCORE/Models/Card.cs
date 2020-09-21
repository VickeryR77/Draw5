using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiCORE.Models
{
    public class Card
    {
        public string value { get; set; }
        public string suit { get; set; }
        public bool success { get; set; }
        public string deck_id { get; set; }
        public Hand[] cards { get; set; }
    }
}

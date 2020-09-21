using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiCORE.Models
{
    public class Deck
    {
        public bool success { get; set; }
        public string deck_id { get; set; }
        public bool shuffled { get; set; }
        public int remaining { get; set; }
        
        //Not displaying this one at the moment.
    }
}

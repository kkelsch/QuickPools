using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickPools
{
    public class Fencer
    {
        //Properties of Fencers
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }
        public char Rating { get; set; }  // A -> E,  U (Unrated) 
        public int Place { get; set; }

        //Pool items
        public int pIndicator { get; set; }
        public int pVictories { get; set; }
        public int pTouchesScored { get; set; }
        public int pTouchesRec { get; set; }
    
        //to be messed with Later
        public string Club { get; set; }
        public string Division { get; set; }
        public int Seed { get; set; }
                    
    }

     
}

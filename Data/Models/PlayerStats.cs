using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class PlayerStats
    {
        public Player player;
        public int goals;
        public int yellowCards;

        public override string ToString()
        {
            return $"{player.Name}";
        }
    }
}

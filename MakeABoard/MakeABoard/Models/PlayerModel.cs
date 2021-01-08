using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakeABoard.Models
{
    public class PlayerModel
    {
        /* The Player Model . . .
         * is a child of Match Model
         * requires a game
         * calculates a next move
         * creates player display
         * future- saves move data for learning
         * future- gathers move data via UI
         */

        public string DisplayName { get; set; }
        public int PlayerNum { get; set; }
        public string PlayerMark { get; set; }

        public BoardModel Move()
        {
            throw new NotImplementedException();
        }


    }
}

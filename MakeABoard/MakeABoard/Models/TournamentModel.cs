using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakeABoard.Models
{
    public class TournamentModel
    {
        /* A tournament 
         * is a collection of Matches
         * owns the "base screen" of the webapp
         * presents the match screen space
         * is the startup module
         * maintains collective statistics of the Matches
         */
        private class Match
        {
            DateTime whenPlayed;
            string playerX;
            string playerY;
            string winner;
        }
        List<Match> matches = new List<Match>();

        // display window
        // create assignment of P1 & P2
        // start match
        // record results

    }
}

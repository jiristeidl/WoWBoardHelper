using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoWBoardHelper.Core
{
    public static class Global
    {
        public static Dictionary<int, Player> Players;

        public static int CurrentPlayer;

        private static int numberOfPlayers;

        public static int NumberOfPlayers
        {
            get
            {
                return numberOfPlayers;
            }
            set
            {
                Players = new Dictionary<int, Player>();
                numberOfPlayers = value;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoWBoardHelper.Core
{
    public static class _Global
    {
        public static Dictionary<int, Player> Players { get; private set; }

        public static int CurrentPlayer { get; set; }

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
                if (value > 4)
                {
                    NumberOfCharacters = 6;
                }
                else
                {
                    NumberOfCharacters = 4;
                }
                numberOfPlayers = value;
            }
        }

        public static int NumberOfCharacters { get; private set; }
    }
}
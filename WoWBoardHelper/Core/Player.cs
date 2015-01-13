using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoWBoardHelper.Data.Enums;

namespace WoWBoardHelper.Core
{
    public class Player
    {
        public string Name { get; set; }

        private Dictionary<int, Character> characters;
        private int selectedChar;

        public Player(string name)
        {
            this.Name = name;
            characters = new Dictionary<int, Character>();
            selectedChar = 1;
        }

        public void AddCharacter(Classes selectedClass, Sides side)
        {
            if (characters.Count < 2)
            {
                characters.Add(selectedChar, new Character(selectedClass, side));
                selectedChar++;
            }
            else
            {
                throw new InvalidOperationException("Can't control more then two characters");
            }
        }
    }
}
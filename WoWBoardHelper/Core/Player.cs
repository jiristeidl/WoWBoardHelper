using WoWBoardHelper.Core.Interfaces;
using WoWBoardHelper.Data.Classes;
using WoWBoardHelper.Data.Enums;

namespace WoWBoardHelper.Core
{
    public class Player
    {
        public string Name { get; set; }

        public int Gold { get; set; }

        public IPlayerClass Class { get; set; }

        public int Experience { get; set; }

        public Player(Classes selectedClass, Sides side, string name)
        {
            this.Name = name;
            var test = (int)selectedClass;
            this.Class = Helpers.CreateNewPlayerClass(selectedClass, side);
        }
    }
}
using WoWBoardHelper.Core.Interfaces;
using WoWBoardHelper.Data.Classes;
using WoWBoardHelper.Data.Enums;

namespace WoWBoardHelper.Core
{
    public class Character
    {
        public int Gold { get; set; }

        public IPlayerClass Class { get; set; }

        public int Experience { get; set; }

        public Character(Classes selectedClass, Sides side)
        {
            this.Class = Helpers.CreateNewPlayerClass(selectedClass, side);
        }
    }
}
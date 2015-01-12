using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoWBoardHelper.Core.Interfaces;
using WoWBoardHelper.Data.Classes;
using WoWBoardHelper.Data.Enums;

namespace WoWBoardHelper.Core
{
    public static class Helpers
    {
        public static IPlayerClass CreateNewPlayerClass(Classes selectedClass, Sides side)
        {
            switch ((int)selectedClass)
            {
                case 0:
                    return new Shaman(side);

                default:
                    return null;
            }
        }
    }
}
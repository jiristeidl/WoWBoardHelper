using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoWBoardHelper.Core.Interfaces;

namespace WoWBoardHelper.Data.Equipables.Abilities
{
    public class Thunder : IEquippable
    {
        public Enums.EquipableType type
        {
            get { return Enums.EquipableType.Spell; }
        }

        public string Name
        {
            get { return Properties.Resources.Thunder; }
        }

        public Enums.SubType subType
        {
            get { return Enums.SubType.None; }
        }
    }
}
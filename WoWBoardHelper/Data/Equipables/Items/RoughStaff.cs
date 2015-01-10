using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoWBoardHelper.Core.Interfaces;

namespace WoWBoardHelper.Data.Equipables.Items
{
    internal class RoughStaff : IEquippable
    {
        public Enums.EquipableType type
        {
            get { return Enums.EquipableType.MeleeWeapon; }
        }

        public string Name
        {
            get { return Properties.Resources.RoughStaff; }
        }

        public Enums.SubType subType
        {
            get { return Enums.SubType.Staff; }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoWBoardHelper.Core;
using WoWBoardHelper.Core.Interfaces;

namespace WoWBoardHelper.Data.Equipables.Abilities
{
    public class BloodFury : IEquippable
    {
        Enums.EquipableType IEquippable.type
        {
            get { return Enums.EquipableType.Racial; }
        }

        public string Name
        {
            get { return Properties.Resources.BloodFury; }
        }

        public Enums.SubType subType
        {
            get { throw new NotImplementedException(); }
        }
    }
}
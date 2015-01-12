using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoWBoardHelper.Core.Interfaces;

namespace WoWBoardHelper.Data.Equipables.Items
{
    public class startingBandage : IEquippable
    {
        public Enums.EquipableType type
        {
            get { return Enums.EquipableType.Armor; }
        }

        public Enums.SubType subType
        {
            get { return Enums.SubType.Leather; }
        }

        public string Name
        {
            get { return Properties.Resources.startingBandage; }
        }
    }
}
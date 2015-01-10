using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WoWBoardHelper.Core.Interfaces;
using WoWBoardHelper.Data.Enums;

namespace WoWBoardHelper.Core
{
    internal class Slot
    {
        private IEquippable item;
        private SubType[] subTypes;
        private EquipableType typeTwo, typeOne;

        public Slot(EquipableType typeOne, EquipableType typeTwo = EquipableType.None, params SubType[] subTypes)
        {
            this.typeOne = typeOne;
            this.typeTwo = typeTwo;
            this.subTypes = subTypes;
            if (subTypes.All(t => t == null))
            {
                this.subTypes = new SubType[1]{
                    SubType.None
                };
            }
        }

        public bool EquipItem(IEquippable item)
        {
            if (canEquip(item))
            {
                this.item = item;
                return true;
            }
            return false;
        }

        public bool canEquip(IEquippable item)
        {
            return (item.type.Equals(typeOne) || item.type.Equals(typeTwo)) && subTypes.Contains(item.subType);
        }

        public bool isFull()
        {
            return item != null;
        }
    }
}
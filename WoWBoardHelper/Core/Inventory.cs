using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WoWBoardHelper.Core.Interfaces;

namespace WoWBoardHelper.Core
{
    internal class Inventory
    {
        private Slot[] slots;

        public Inventory(Slot[] slots)
        {
            this.slots = slots;
        }

        public Inventory(int size)
        {
            this.slots = new Slot[size];
            for (int i = 0; i < size; i++)
            {
                this.slots[i] = new Slot(Data.Enums.EquipableType.None);
            }
        }

        internal bool Equip(IEquippable item)
        {
            Slot slot = slots.FirstOrDefault(s => !s.isFull() && s.canEquip(item));
            if (slot != null)
            {
                slot.EquipItem(item);
                return true;
            }
            else
            {
                SwitchItems(item);
            }
            return false;
        }

        private void SwitchItems(IEquippable item)
        {
            throw new NotImplementedException();
        }
    }
}
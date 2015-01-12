using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoWBoardHelper.Core.Interfaces
{
    public interface IPlayerClass
    {
        int CurrentHealth { get; set; }

        int CurrentMana { get; set; }

        Inventory EquipedItems { get; set; }

        int MaxHealth { get; }

        int MaxMana { get; }

        string name { get; }

        IEquippable Racial { get; }

        void LevelUp();
    }
}
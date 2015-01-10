using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoWBoardHelper.Core;
using WoWBoardHelper.Core.Interfaces;
using WoWBoardHelper.Data.Enums;

namespace WoWBoardHelper.Data.Classes
{
    internal abstract class baseClass : IPlayerClass
    {
        public int CurrentGold;
        public int CurrentLevel;
        public int health;
        public int mana;
        protected const int StartingGold = 5;
        public Sides side;

        public baseClass(Sides side)
        {
            this.CurrentLevel = 1;

            this.CurrentHealth = HealthAtLevel(this.CurrentLevel);
            this.CurrentMana = ManaAtLevel(this.CurrentLevel);
            this.CurrentGold = StartingGold;
            this.Backpack = new Inventory(new Slot[]{
                new Slot(Enums.EquipableType.None),
                new Slot(Enums.EquipableType.None),
                new Slot(Enums.EquipableType.None)
            });
            this.Spellbook = new Inventory(256);
            this.side = side;
        }

        abstract public Inventory Backpack { get; set; }

        abstract public int CurrentHealth { get; set; }

        abstract public int CurrentMana { get; set; }

        abstract public Inventory EquipedItems { get; set; }

        abstract public int MaxHealth { get; }

        abstract public int MaxMana { get; }

        abstract public string name { get; }

        abstract public IEquippable Racial { get; }

        abstract public Inventory Spellbook { get; set; }

        abstract protected IEquippable[] DefaultGear { get; }

        abstract public void LevelUp();

        abstract protected int HealthAtLevel(int currentLevel);

        abstract protected int ManaAtLevel(int currentLevel);
    }
}
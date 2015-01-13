using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoWBoardHelper.Core;
using WoWBoardHelper.Core.Interfaces;
using WoWBoardHelper.Data.Enums;
using WoWBoardHelper.Data.Equipables.Abilities;
using WoWBoardHelper.Data.Equipables.Items;

namespace WoWBoardHelper.Data.Classes
{
    public class Shaman : baseClass
    {
        private int[] healthLevel =
        {
            3,
            4,
            5,
            7,
            9
        };

        private int[] manaLevel =
        {
            3,
            5,
            7,
            9,
            11
        };

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "side")]
        public Shaman(Sides side)
            : base(Sides.Horde)
        {
            this.EquipedItems = new Inventory
                (new Slot[]
                  {
                      new Slot(Enums.EquipableType.Spell,Enums.EquipableType.Aura),
                      new Slot(Enums.EquipableType.Spell,Enums.EquipableType.Aura),
                      new Slot(Enums.EquipableType.Spell,Enums.EquipableType.Aura),
                      new Slot(Enums.EquipableType.Spell),
                      new Slot(Enums.EquipableType.MeleeWeapon, Enums.EquipableType.None,Enums.SubType.Mace,Enums.SubType.Staff),
                      new Slot(Enums.EquipableType.Trinket,Enums.EquipableType.Spell),
                      new Slot(Enums.EquipableType.Armor,Enums.EquipableType.None,Enums.SubType.Cloth,Enums.SubType.Leather)
                  }
                );
            foreach (IEquippable item in DefaultGear)
            {
                if (!EquipedItems.Equip(item))
                {
                    throw new InvalidProgramException();
                }
            }
        }

        public override int CurrentHealth
        {
            get
            {
                return health;
            }
            set
            {
                if (value <= MaxHealth)
                {
                    health = value;
                }
                if (health == 0)
                {
                    throw new NotImplementedException();
                }
            }
        }

        public override int CurrentMana
        {
            get
            {
                return mana;
            }
            set
            {
                if (value <= MaxMana)
                {
                    mana = value;
                }
            }
        }

        public override Inventory EquipedItems { get; set; }

        public override int MaxHealth
        {
            get { return HealthAtLevel(CurrentLevel); }
        }

        public override int MaxMana
        {
            get { return ManaAtLevel(CurrentLevel); }
        }

        public override string name
        {
            get { return Properties.Resources.Shaman; }
        }

        public override IEquippable Racial
        {
            get { return new BloodFury(); }
        }

        protected override IEquippable[] DefaultGear
        {
            get
            {
                return new IEquippable[3] {
                    new Thunder(),
                    new RoughStaff(),
                    new startingBandage()
                };
            }
        }

        public override void LevelUp()
        {
            throw new NotImplementedException();
        }

        protected override int HealthAtLevel(int level)
        {
            return healthLevel[level - 1];
        }

        protected override int ManaAtLevel(int level)
        {
            return manaLevel[level - 1];
        }

        public override Inventory Backpack { get; set; }

        public override Inventory Spellbook { get; set; }
    }
}
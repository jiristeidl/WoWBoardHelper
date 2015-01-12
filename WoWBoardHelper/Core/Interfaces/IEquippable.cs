using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoWBoardHelper.Data.Enums;

namespace WoWBoardHelper.Core.Interfaces
{
    public interface IEquippable
    {
        EquipableType type { get; }

        SubType subType { get; }

        string Name { get; }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace MonsterBattleConsole.Farming
{
    public interface IFarm
    {
        FarmPlantManager farmPlantManager { get; set; }
    }
}

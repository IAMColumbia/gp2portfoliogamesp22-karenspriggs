using System;
using System.Collections.Generic;
using System.Text;

namespace MonsterBattleConsole.Farming
{
    public class Farm : IFarm
    {
        public FarmPlantManager farmPlantManager { get; set; }
    }
}

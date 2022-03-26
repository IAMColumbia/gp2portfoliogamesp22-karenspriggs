using System;
using System.Collections.Generic;
using System.Text;

namespace MonsterBattleConsole.Farming
{
    public class Plant: IPlant
    {
        public PlantInfo plantInfo { get; set; }
        public PlantGrow plantGrow { get; set; }
    }
}

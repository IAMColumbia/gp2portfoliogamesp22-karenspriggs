using System;
using System.Collections.Generic;
using System.Text;

namespace MonsterBattleConsole.Farming
{
    public interface IPlant
    {
        PlantInfo plantInfo { get; set; }
        PlantGrow plantGrow { get; set; }
    }
}

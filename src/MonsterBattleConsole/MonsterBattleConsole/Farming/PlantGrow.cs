using System;
using System.Collections.Generic;
using System.Text;

namespace MonsterBattleConsole.Farming
{
    public enum PlantGrowStage
    {
        Seed,
        Sprout,
        Adult
    }

    public class PlantGrow
    {
        public bool canGrow { get; set; }
    }
}

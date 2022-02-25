using System;
using System.Collections.Generic;
using System.Text;

namespace MonsterBattleConsole.Battle
{
    public interface IBattleStats
    {
        public int Level { get; set; }
        public float currentEXP { get; set; }
        public float nextLevelEXP { get; set; }
        public int Health { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Speed { get; set; }
    }
}

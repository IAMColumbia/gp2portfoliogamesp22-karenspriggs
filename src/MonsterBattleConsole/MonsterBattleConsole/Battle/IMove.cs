using System;
using System.Collections.Generic;
using System.Text;

namespace MonsterBattleConsole.Battle
{
    public interface IMove
    {
        public BattleType moveType { get; set; }
        public string Name { get; set; }
        public int basePower { get; set; }
    }
}

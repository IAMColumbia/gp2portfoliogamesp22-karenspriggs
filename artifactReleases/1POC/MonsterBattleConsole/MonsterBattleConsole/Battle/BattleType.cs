using System;
using System.Collections.Generic;
using System.Text;

namespace MonsterBattleConsole.Battle
{
    public class BattleType : IBattleType
    {
        public BattleType typeWeakAgainst { get; set; }
        public BattleType typeStrongAgainst { get; set; }
        public string Name { get; set; }

        public BattleType()
        {

        }
    }
}

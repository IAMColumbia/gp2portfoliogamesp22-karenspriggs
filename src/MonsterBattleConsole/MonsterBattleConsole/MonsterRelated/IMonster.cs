using System;
using System.Collections.Generic;
using System.Text;
using MonsterBattleConsole.Battle;

namespace MonsterBattleConsole.MonsterRelated
{
    public interface IMonster
    {
        public BattleType monsterType { get; set; }
        public MoveSet monsterMoveset { get; set; }
        public BattleStats monsterBattleStats { get; set; }
        public MonsterInfo monsterInfo { get; set; }
    }
}

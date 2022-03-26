using System;
using System.Collections.Generic;
using System.Text;
using MonsterBattleConsole.Battle;

namespace MonsterBattleConsole.MonsterRelated
{
    public class Monster : IMonster
    {
        public BattleType monsterType { get; set; }
        public MoveSet monsterMoveset { get; set; }
        public BattleStats monsterBattleStats { get; set; }
        public MonsterInfo monsterInfo { get; set; }

        public Monster(BattleType mt, MoveSet ms, BattleStats b, MonsterInfo mi)
        {
            this.monsterType = mt;
            this.monsterMoveset = ms;
            this.monsterBattleStats = b;
            this.monsterInfo = mi;
        }
    }
}

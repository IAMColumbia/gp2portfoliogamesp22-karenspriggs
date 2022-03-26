using System;
using System.Collections.Generic;
using System.Text;

namespace MonsterBattleConsole.Battle
{
    public interface IMoveSet
    {
        public Move move1 { get; set; }
        public Move move2 { get; set; }
        public Move move3 { get; set; }
        public Move move4 { get; set; }
        string DisplayMoveSet();
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MonsterBattleConsole.Battle
{
    public class Move : IMove
    {
        public BattleType moveType { get; set; }
        public string Name { get; set; }
        public int basePower { get; set; }

        public Move(string _name, int _basePower, BattleType _moveType)
        {
            this.Name = _name;
            this.basePower = _basePower;
            this.moveType = _moveType;
        }
    }
}

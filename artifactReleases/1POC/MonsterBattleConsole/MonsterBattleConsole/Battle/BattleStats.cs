using System;
using System.Collections.Generic;
using System.Text;

namespace MonsterBattleConsole.Battle
{
    public class BattleStats
    {
        // All the stats for battling
        public int Level { get; set; }
        public float currentEXP { get; set; }
        public float nextLevelEXP { get; set; }
        public int Health { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Speed { get; set; }

        public BattleType monsterBattleType;

        public BattleStats(int _health, int _attack, int _defense, int _speed, BattleType _monsterBattleType)
        {
            this.Level = 1;
            this.currentEXP = 0;
            this.nextLevelEXP = 0;

            this.Health = _health;
            this.Attack = _attack;
            this.Defense = _defense;
            this.Speed = _speed;

            this.monsterBattleType = _monsterBattleType;
        }

        public void CaclulateNextLevelExp()
        {
            // Put exp calculation for next level depending on current level and some formula idk

        }
    }
}

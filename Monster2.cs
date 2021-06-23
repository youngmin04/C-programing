using System;
using System.Collections.Generic;
using System.Text;

namespace Programing
{
    public enum MonsterType2
    {
        None,
        Ramen,
        Noodle,
        Cola
    }
    class Monster2 : Creature2
    {
        protected MonsterType2 type = MonsterType2.None;

        public Monster2(MonsterType2 type) : base(CreatureType2.Monster)
        {
            this.type = type;
        }
        public MonsterType2 GetMonsterType() { return type; }
    }
    class Ramen : Monster2
    {
        public Ramen() : base(MonsterType2.Ramen)
        {
            SetInfo(30,30, 5,10);
        }
    }
    class Noodle : Monster2
    {
        public Noodle() : base(MonsterType2.Noodle)
        {
            SetInfo(20, 20, 10, 15);
        }
    }
    class Cola : Monster2
    {
        public Cola() : base(MonsterType2.Cola)
        {
            SetInfo(40,40, 15, 20);
        }
    }
}

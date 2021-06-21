using System;
using System.Collections.Generic;
using System.Text;

namespace Programing
{
    public enum CreatureType2
    {
        None,
        Player,
        Monster
    }

    class Creature2
    {
        CreatureType2 type;
        public int fullhp;
        public int hp;
        public int attack;
        public int coin;

        public Creature2(CreatureType2 type)
        {
            this.type = type;
        }
        public void SetInfo(int fullhp,int hp,int attack,int coin)
        {
            this.fullhp = fullhp;
            this.hp = hp;
            this.attack = attack;
            this.coin = coin;
        }
        public int GetHp() { return hp; }
        public int GetAttack() { return attack; }
        public bool Death() { return hp <= 0; }
        public void Damage(int damage)
        {
            hp -= damage;
            if (hp <= 0)
                hp = 0;
        }
    }
}

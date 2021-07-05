using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using static System.Console;

namespace Programing
{
    class Today
    {
        //knight (속성 : hp, attack, pos)(기능 : Move, Attack, Die)
        class knight
        {
            public int hp;
            public int attack;

            public knight Clone()
            {
                knight knight = new knight();
                knight.hp = hp;
                knight.attack = attack;
                return knight;
            }
            public void Move()
            {
                WriteLine("knight Move");
            }
            public void Attack()
            {
                WriteLine("knight Attack");
            }
        }
        struct Mage
        {
            public int hp;
            public int attack;
        }
        static void KillMage(Mage mage)
        {
            mage.hp = 0;
        }
        static void KillKnight(knight knight)
        {
            knight.hp = 0;
        }
        class nextclass
        {
            static void Main(string[] args)
            {
                Mage mage;
                mage.hp = 100;
                mage.attack = 50;

                Mage mage2 = mage;
                mage2.hp = 0;

                knight knight = new knight();
                knight.hp = 100;
                knight.attack = 10;

                knight knight2 = knight.Clone();
                knight2.hp = 0;
            }
        }
    }
}
    

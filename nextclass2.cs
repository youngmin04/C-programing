using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing
{
    class knight
    {
        public int hp;
        public int attack;

        public knight()
        {
            hp = 100;
            attack = 10;
            Console.WriteLine("생성자 호출");
        }
        public knight(int hp) : this()
        {
            this.hp = hp;
            Console.WriteLine("int 생성자 호출");
        }
        public knight Clone()
        {
            knight knight = new knight();
            knight.hp = hp;
            knight.attack = attack;
            return knight;
        }
        public void Move()
        {
            Console.WriteLine("knight Move");
        }
        public void Attack()
        {
            Console.WriteLine("knight Attack");
        }
    }
    class test
    {
        static void Main()
        {
            knight knight = new knight(50);
        }
    }
}

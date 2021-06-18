﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Programing
{
    public enum PlayerType
    {
        None = 0,
        Knight = 1,
        Archer = 2,
        Mage = 3
    }
    class Player : Creature
    {
        protected PlayerType Type = PlayerType.None;

        protected Player(PlayerType Type):base(CreatureType.Player)
        {
            this.Type = Type;
        }
        public PlayerType GetPlayerType() { return Type; }
    }
    class Knight : Player
    {
        public Knight(): base(PlayerType.Knight)
        {
            SetInfo(100, 10);
        }
    }
    class Archer : Player
    {
        public Archer() : base(PlayerType.Archer)
        {
            SetInfo(75, 12);
        }
    }
    class Mage : Player
    {
        public Mage() : base(PlayerType.Mage)
        {
            SetInfo(50, 15);
        }
    }
}

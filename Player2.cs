using System;
using System.Collections.Generic;
using System.Text;

namespace Programing
{
    public enum PlayerType2
    {
        None,
        Shortheight,
        Longheight,
        Nowheight
    }
    class Player2:Creature2
    {
        protected PlayerType2 type = PlayerType2.None;
        public Player2(PlayerType2 type) : base(CreatureType2.Player)
        {
            this.type = type;
        }
        public PlayerType2 GetPlayerType() { return type; }
    }
    class Shortheight : Player2
    {
        public Shortheight() : base(PlayerType2.Shortheight)
        {
            SetInfo(150,150, 15,0);
        }
    }
    class Longheight : Player2
    {
        public Longheight() : base(PlayerType2.Longheight)
        {
            SetInfo(180,180, 10,0);
        }
    }
    class Nowheight : Player2
    {
        public Nowheight() : base(PlayerType2.Nowheight)
        {
            SetInfo(165,165, 15,0);
        }
    }
}

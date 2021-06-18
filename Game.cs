using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Programing
{
    public enum Gamemode
    {
        None,
        Lobby,
        Town,
        Field
    }
    class Game
    {
        private Gamemode mode = Gamemode.Lobby;
        private Player player = null;
        private Monster monster = null;
        private Random rand = new Random();

        public void Process()
        {
            switch (mode)
            {
                case Gamemode.Lobby:
                    ProcessLobby();
                    break;
                case Gamemode.Town:
                    ProcessTown();
                    break;
                case Gamemode.Field:
                    ProcessField();
                    break;
            }
        }
        public void ProcessLobby()
        {
            WriteLine("직업을 선택하세요!");
            WriteLine("[1]기사");
            WriteLine("[2]궁수");
            WriteLine("[3]마법사");

            string input = ReadLine();
            switch (input)
            {
                case "1":
                    player = new Knight();
                    mode = Gamemode.Town;
                    break;
                case "2":
                    player = new Archer();
                    mode = Gamemode.Town;
                    break;
                case "3":
                    player = new Mage();
                    mode = Gamemode.Town;
                    break;
            }
        }
        public void ProcessTown()
        {
            WriteLine("마을에 입장하였습니다.");
            WriteLine("[1] 필드로 가기");
            WriteLine("[2] 로비로 돌아가기");

            string input = ReadLine();
            switch (input)
            {
                case "1":
                    mode = Gamemode.Field;
                    break;
                case "2":
                    mode = Gamemode.Lobby;
                    break;
            }
        }
        public void ProcessField()
        {
            WriteLine("필드에 입장하였습니다.");
            WriteLine("[1] 싸우기");
            WriteLine("[2] 일정 확률로 마을 돌아가기");

            CreateRandomMonster();

            string input = ReadLine();
            switch (input)
            {
                case "1":
                    ProcessFight();
                    break;
                case "2":
                    TryEscape();
                    break;
            }
        }
        public void TryEscape()
        {
            int randValue = rand.Next(0, 101);
            if (randValue < 33)
            {
                mode = Gamemode.Town;
            }
            else
            {
                ProcessFight();
            }
        }
        public void ProcessFight()
        {
            while (true)
            {
                int damage = player.GetAttack();
                monster.OnDamaged(damage);
                if (monster.IsDead())
                {
                    WriteLine("승리하였습니다!");
                    WriteLine($"남은 체력{player.GetHp()}");
                    break;
                }
                damage = monster.GetAttack();
                player.OnDamaged(damage);
                if (player.IsDead())
                {
                    WriteLine("패배하였습니다!");
                    mode = Gamemode.Lobby;
                    break;
                }
            }
        }
        public void CreateRandomMonster()
        {
            int randValue = rand.Next(0, 3);
            switch (randValue)
            {
                case 0:
                    monster = new Slime();
                    WriteLine("슬라임이 생성되었습니다!");
                    break;
                case 1:
                    monster = new Orc();
                    WriteLine("오크가 생성되었습니다!");
                    break;
                case 2:
                    monster = new Skeleton();
                    WriteLine("스켈레톤이 생성되었습니다!");
                    break;
            }
        }
    }
}

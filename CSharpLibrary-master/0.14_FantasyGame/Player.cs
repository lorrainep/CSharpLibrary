using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._14_FantasyGame
{
    public enum CharacterType
    {
        Assassin = 0,
        BlitzenBlopper = 1,
        Professor = 2,
        HorseMange = 3,
        TaxMan = 4,
        Human = 5
    }
    class Player
    {
        public string PlayerName { get; set; }
        public string Clan { get; set; }
        public int CurrentPower { get; set; }
        public CharacterType Type { get; set; }
        public int Hit { get; set; }
        public int Health { get; set; }

        public Player(string name, string clanName, CharacterType type = CharacterType.HorseMange)
        {
            this.Health = 100;
            this.PlayerName = name;
            this.Clan = clanName;
            this.CurrentPower = 100;
            this.Type = type;
            this.Hit = 30;
        }

        public CharacterType ChooseType(int t)
        {
            switch (t)
            {
                case 0:
                    return this.Type = CharacterType.Assassin;
                case 1:
                    Console.WriteLine("You are a Blizen Blopper");
                    return this.Type = CharacterType.BlitzenBlopper;
                case 2:
                    Console.WriteLine("You are a Troll Cat");
                    return this.Type = CharacterType.HorseMange;
                case 3:
                    Console.WriteLine("You are a Horse Mage");
                    return this.Type = CharacterType.TaxMan;
                default:
                    Console.WriteLine("You are a Human");
                    return this.Type = CharacterType.Human;

            }
        }

        
        public void PowerLevelCheck()
        {
            Console.WriteLine("{0}'s power level is at {1}. Your maximum damage is {2} ", this.PlayerName, this.CurrentPower, this.Hit);
            
        }

        public void BattleCry()
        {
            Console.WriteLine("YEYEYEYEYEYEYEYEYEYEYE!!!");
        }

        //create a method of ToString that returns your players details 
        public override string ToString()
        {
            return $"Player Name: {this.PlayerName}\nGamer Name: {this.Clan}\nPlayer Type: {this.Type}";
        }
       
       




}
}


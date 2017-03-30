using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._14_FantasyGame
{
     abstract class Enemy
     {
        protected ArrayList insult = new ArrayList { "noob", "wimp", "buster", "nerdcakes" };
        protected Random rnd = new Random();
        public string Name { get; set; }
        public int PowerLevel { get; set; }

        //create an insult method with a few insults

        public virtual void Insult()
        {
            int r = rnd.Next(0, insult.Count);
            Console.WriteLine("You are half of my level {0}", insult[r]);

        }


           public void Slash(Player player)
           {

                var singleAttack = Attack.ElementAt(rnd.Next(Attack.Count));
                string attackKey = singleAttack.Key;
                int attackValue = singleAttack.Value;
                player.CurrentPower -= attackValue;
                
                

                // FInish Dictionary
                Console.WriteLine("{0} power is at {1}%", player.PlayerName, player.CurrentPower);
           }

        }
    }


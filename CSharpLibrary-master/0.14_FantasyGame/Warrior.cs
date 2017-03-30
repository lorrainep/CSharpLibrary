using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._14_FantasyGame
{
    class LizardDog : Enemy
    {
        public int Damage { get; set; }

        public LizardDog()
        {
            this.Damage = 30;
            this.PowerLevel = 40;
            this.Name = "Lizard Dog";
        }

        public override void Insult()

        {
            Dictionary<string, int> Attack = new Dictionary<string, int>
                {
                    {"Head-butt", 5 },
                    {"Mallet", 15 }
                };
            int r = rnd.Next(insult.Count);
            Console.WriteLine("'I am {0} you {1}'. {0} deals {2}", this.Name, insult[r]);
        }
    }
}

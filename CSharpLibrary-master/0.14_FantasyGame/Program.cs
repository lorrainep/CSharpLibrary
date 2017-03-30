using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace _0._14_FantasyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            SpeechSynthesizer talkingConsole = new SpeechSynthesizer();
            talkingConsole.Speak("What is your name?");



            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What clan are you apart of?");
            string clan = Console.ReadLine();
            Console.WriteLine("What is your player type?\n" +
                               "0: Assassin\n" +
                               "1: Blitzen Blopper\n" +
                               "2: Professor\n" +
                               "3: Horse Mange\n" +
                               "4: Tax Man\n" +
                               "5: Human");
            int playerType = int.Parse(Console.ReadLine());

            Player player = new Player(name, clan);
            player.ChooseType(playerType);

            Console.WriteLine(player.ToString());


            LizardDog lizardDog = new LizardDog();

            lizardDog.Insult();

            lizardDog.Slash(player);



            

            //Enemy Quagga = new Enemy();
            //Quagga.Insult();


            // create a new subclass of enemy (can be any name ) that inherits from enemy class
            //that has a constructor
            // and one method
            Console.ReadLine();
        }
    }
}

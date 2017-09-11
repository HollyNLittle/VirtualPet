using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            Pluto usersPluto = new Pluto();
            usersPluto.IsChoiceCorrect = true;

            do 
            {
                Console.WriteLine
                    ("Good morning, says your favorite pet, Pluto!!!\n   Yaaawwwnnn..............I am sooooo Hungry!!!");
                Console.WriteLine
                    ("     If you want to feed Pluto, right now enter True.\n     If you would rather play outside with your friends then enter False.");
                usersPluto.IsHungry = Convert.ToBoolean(Console.ReadLine().ToLower());
                usersPluto.Display(usersPluto.IsHungry);

                Console.WriteLine("I am soooo BORED!!!  Can we go to the Pet Park, pleeeeeeeezzzz!!!!!!");
                Console.WriteLine
                    ("     If you want to take Pluto to the Pet Park enter True.  \n     If you would rather play video games then enter False.");
                usersPluto.IsBored = Convert.ToBoolean(Console.ReadLine().ToLower());
                usersPluto.Display(usersPluto.IsBored);

                Console.WriteLine("I am soooo SLEEPY!!!");
                Console.WriteLine
                    ("     If you are going to put Pluto to sleep enter True.  \n     If you would rather watch TV then enter False.");
                usersPluto.IsSleepy = Convert.ToBoolean(Console.ReadLine().ToLower());
                usersPluto.Display(usersPluto.IsSleepy);

                Console.WriteLine("Would you like to start another day?  \n If so enter True. \n     If you would rather leave Pluto sleeping then enter False.");
                usersPluto.IsChoiceCorrect = Convert.ToBoolean(Console.ReadLine().ToLower());
                usersPluto.Goodnight(usersPluto.IsChoiceCorrect, usersPluto.Points);
            } while (usersPluto.IsChoiceCorrect == true);
        }
    }
}

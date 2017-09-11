using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Pluto
    {
        //fields
        private int points = 0;
        private int score = 0;
        private bool isChoiceCorrect = true;
        private bool isHungry = true;
        private bool isBored = true;
        private bool isSleepy = true;


        //properties
        //public int HairLength { get; set; }
        //public string Name
        //    {
        //    get { return this.name; }
        //    set { this.name = value; }
        //    }

        public int Points
        {
        get { return points; }
        set { points = value; }
        }
        public int Score
        {
            get { return score; }
            set { score = value; }
        }
        public bool IsChoiceCorrect
        {
            get { return this.isChoiceCorrect; }
            set { this.isChoiceCorrect = value; }
        }
        public bool IsHungry
        {
            get { return this.isHungry; }
            set { this.isHungry = value; }
        }
        public bool IsBored
        {
            get { return this.isBored; }
            set { this.isBored = value; }
        }
        public bool IsSleepy
        {
            get { return this.isSleepy; }
            set { this.isSleepy = value; }
        }
        //Constructor
        public Pluto()
        { }

        //Methods
        //Could set properties to console.readline in program
        //then call method and use answer as the param
        public void Feed(bool isHungry)
        {
            this.isHungry = isHungry; //to lower
            if (isHungry)
            {
                Console.WriteLine("Pluto says, Thank you! You are an awesome Pet Parent!!!");
            }
            //call Display()
        }
        public void Play(bool isBored)
        {
            this.isBored = isBored;//add .ToLower
            if(this.isBored)
            {
                Console.WriteLine("Pluto says, Thank you! That was sooo much FUN!!!");
            }
        }
        public void Sleep(bool isSleepy)
        {
            this.isSleepy = isSleepy;//add .ToLower
            if (this.isSleepy)//add .ToLower
            {
                Console.WriteLine("Pluto says, Thank you! I am beat!!!");
            }
        }
        public void Display(bool isChoiceCorrect)
        {
            this.isChoiceCorrect = isChoiceCorrect;
            if (isChoiceCorrect)
            {
                points++;
                Console.WriteLine("\n Yay!!!  You get a Pet Parent Point! \n Your score is now: {0}.\n", points);
            }
            else
            {
                Console.WriteLine("\n Your score is now: {0}.\n", points);
            }
        }
        public void Goodnight(bool isChoiceCorrect, int points)
        {
            //Choose message based on answer and wants to or doesn't want to play again.
            this.isChoiceCorrect = isChoiceCorrect;
            this.points = points;
            if (isChoiceCorrect)
            {
                Console.WriteLine("\n\n\n                GREAT!!!  Let's go AGAIN!!!!!!\n\n\n");
            }
            else
            {
                switch (points)
                {
                    case 0:
                        Console.WriteLine("\n\n                 *sigh*\n           That was the WORST, most HORRIBLE, AWFUL day EVER!!!\n");
                        break;
                    case 1:
                        Console.WriteLine("\n\n           Thank you, but your pet parenting skills need a bit of work!\n");
                        break;
                    case 2:
                        Console.WriteLine("\n\n           Thanks, but you are sooo NOT ready to be a pet parent!\n");
                        break;
                    case 3:
                        Console.WriteLine("\n\n           Thank you!!!   \n             I have an AWESOME pet parent!!!!\n");
                        break;
                    default:
                        Console.WriteLine("\n\n           Thank you!!!\n");
                        break;
                }
                Console.WriteLine("\n           See you later, Alligator!\n\n                  Goodnight...zzzzzzzzzzzzzzzzzzzzzz\n\n\n");
            }
        }

    }
}

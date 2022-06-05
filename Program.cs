using System;

namespace Lab2_Task1
{
    public class Task1_Tool
    {
        public static void Main(string[] args)
        {
            Rock r1 = new Rock(8);
            Paper p1 = new Paper(6);
            Scissors s1 = new Scissors(4);

            //Print current strength
            Console.WriteLine("Current Strength ==> " + "Rock r1: " + r1.getStrength()
                                                       + "\t\tPaper p1: " + p1.getStrength()
                                                       + "\tScissors s1: " + s1.getStrength());

            Console.WriteLine("");
            Console.WriteLine("====== Fighting Results ======");

            // r1 strength double with s1
            // p1 strength double with r1
            // s1 strength double with p1


            //Print boolean value True/False - who wins the fight
            Console.WriteLine("r1.fight(p1) wins: " + r1.fight(p1) + "\tr1.fight(s1) wins: " + r1.fight(s1));
            Console.WriteLine("p1.fight(r1) wins: " + p1.fight(r1) + "\t\tp1.fight(s1) wins: " + p1.fight(s1));
            Console.WriteLine("s1.fight(r1) wins: " + s1.fight(r1) + "\ts1.fight(p1) wins: " + s1.fight(p1));
        }

        public class Tool
        {
            //protected int field strength and char field type
            //To access from the inherited class
            protected int strength;
            protected char type;

            //function void setStrength(int)
            public void setStrength(int value)
            {
                this.strength = value;
            }

            //Method to return current strength
            public int getStrength()
            {
                return this.strength;
            }

            //Method to return type
            public char getType()
            {
                return this.type;
            }
        }

        //Inherited class Rock from Tool
        public class Rock : Tool
        {
            //Constructor to initialize stregth and
            // set type as r for rock
            public Rock(int strength)
            {
                this.setStrength(strength);
                type = 'r';
            }

            //Function fight to return boolean
            //Original class wins then true else false
            public bool fight(Tool tool)
            {
                //Get original class strength
                int temp_strength = this.getStrength();

                if (tool.getType() == 's')
                {
                    //Temporarily original class strength double
                    temp_strength *= 2;
                }
                else if (tool.getType() == 'p')
                {
                    //Temporarily original class strength half
                    temp_strength /= 2;
                }

                //Return boolean value true if condition true else false
                return temp_strength >= tool.getStrength();
            }
        }

        //Inherited class Paper from Tool
        public class Paper : Tool
        {
            //Constructor to initialize stregth and
            // set type as p for paper
            public Paper(int strength)
            {
                this.setStrength(strength);
                type = 'p';
            }
            public bool fight(Tool tool)
            {
                //Get original class strength
                int temp_strength = this.getStrength();

                if (tool.getType() == 'r')
                {
                    //Temporarily original class strength double
                    temp_strength *= 2;
                }
                else if (tool.getType() == 's')
                {
                    //Temporarily original class strength half
                    temp_strength /= 2;
                }
                //Return boolean value true if condition true else false
                return temp_strength >= tool.getStrength();
            }
        }

        //Inherited class Scissors from Tool
        public class Scissors : Tool
        {
            //Constructor to initialize stregth and
            // set type as s for scissors
            public Scissors(int strength)
            {
                this.setStrength(strength);
                type = 's';
            }

            public bool fight(Tool tool)
            {
                //Get original class strength
                int temp_strength = this.getStrength();

                if (tool.getType() == 'p')
                {
                    //Temporarily original class strength double
                    temp_strength *= 2;
                }
                else if (tool.getType() == 'r')
                {
                    //Temporarily original class strength half
                    temp_strength /= 2;
                }
                //Return boolean value true if condition true else false
                return temp_strength >= tool.getStrength();
            }
        }
    }
}

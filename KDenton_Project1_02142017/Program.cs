using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDenton_Project1_02142017
{
    class Program
    {
        static void Main(string[] args)
        {
            string userQuit = "o";
            do //here is a do while to make the quit work! So far so good!
            {

                Console.WriteLine("Hello! I am the seer, I can see into a multitude of possible futures and give you your most probable destiny. Maybe...");
                Console.WriteLine("To start, would you mind giving me your first name?");
                string fN = (Console.ReadLine().ToLower());//This declares the first name as a variable(fN)
                if (fN == "quit")
                {
                    userQuit = fN;
                    break;
                }
                //This checks fN as a "quit" action. If so it breaks the loop and runs to the end.

                Console.WriteLine("Thank you! May I have your last name?");
                string lN = (Console.ReadLine().ToLower());// this declares the last name or (lN) This also makes it so case doesn't matter
                if (lN == "quit")
                {
                    userQuit = lN;
                    break;
                }//As above, check if "quit"

                Console.WriteLine("Thank you, " + fN + " " + lN + ". May I please have your age?");
                string age = (Console.ReadLine());//This makes age into a string to use for "quit".
                if (age == "quit")
                {
                    userQuit = age;
                    break;
                }// Checks if "quit"

                string retireTime;
                int ageInt = int.Parse(age); //Takes age and turns into an int. Now ageInt.

                if (ageInt % 2 == 0) //If ageInt is even. 
                {
                    retireTime = "7 years"; 
                }
                else //If odd
                {
                    retireTime = "500 years";
                }


                Console.WriteLine("Thank you, I need your birth month now. Please enter as a two digit number.");
                double money = 0;//Had to declare money as an double = 0 in order to use. Made money into a decimal! Yay!!

                string bM = (Console.ReadLine());// as above, in order to make "quit" run. birth month must start as string

                if (bM == "quit")
                {
                    userQuit = bM;
                    break;
                }//checks if "quit"

                int bMint = int.Parse(bM);//parsed bM into int for math

                if (bMint >= 1 && bMint <= 4)
                {
                    money = 1000.00;
                }
                else if (bMint >= 5 && bMint <= 8)
                {
                    money = 500.00;
                 }// birth months 5 - 8 get $500.00

                 else if ( bMint >= 9 && bMint <= 12)
                { 
                    money = 75.00;
                } // birth months 9 - 12 get only $75.00, sad days!
                else
                {
                    money = 0.00;
                    Console.WriteLine("You're not very good at following directions, huh?");
                }


                Console.WriteLine("Thank you very much, now. Please enter your favorite ROYGBIV color!");
                Console.WriteLine("Type Help for list of ROYGBIV colors.");
                string colorR = (Console.ReadLine().ToLower());

                string[] royGBiv = { "red", "orange", "yellow", "green", "blue", "indigo", "violet", };

                //I enjoyed this! I wanted it to make a list of the colors instead of naming them off.

                if (colorR == "quit")
                {
                    userQuit = colorR;
                    break;
                }// As before, checks if quit and breaks if so.

                while (colorR == "help")//Checks if help is needed!

                {
                    foreach (string color in royGBiv)
                    {
                        Console.WriteLine(color);//This lists the colors you can use!

                    }
                    Console.WriteLine("Now that you know, please enter your favorite!");
                    colorR = (Console.ReadLine().ToLower());//And lets you answer again!
                }
                string transportation;
                switch (colorR)//Used switch statment to handle the large amount of options. 
                {
                    case "red":
                        transportation = "a very nice car. Possibly a BMW. What does BMW even stand for?  ";
                        break;
                    case "orange":
                        transportation = "an okay boat.";
                        break;
                    case "yellow":
                        transportation = "a bicycle. Not bad! ";
                        break;
                    case "green":
                        transportation = "their very own plane! ";
                        break;
                    case "blue":
                        transportation = "something they built. Clever clever!! I am impressed!";
                        break;
                    case "indigo":
                        transportation = "An ATV! Be careful driving that thing!";
                        break;
                    case "violet":
                        transportation = "their own two feet... sad. ";
                        break;
                    default:
                        transportation = "Huh? they learned how to fly somehow. Weird.";
                        Console.WriteLine("Not sure that's a color, but alright I guess.");
                        //Decided to add an option if none of the colors are chosen.
                        break;

                }



                Console.WriteLine("Thank you! Now, please enter the number of siblings you own-- I mean have!");
                string siblingN = (Console.ReadLine());

                if (siblingN == "quit")
                {
                    userQuit = siblingN;
                    break;
                } // this quits the application if "quit" is entered in this spot.


                string vacationHome = "c";
                int siblingNInt = int.Parse(siblingN); //This makes the sibling amount string into a int. This way the quit will work.

                if (siblingNInt == 0)
                {
                    vacationHome = "San Diego, California";
                }
                else if (siblingNInt == 1)
                {
                    vacationHome = "Honolulu, Hawaii";
                }
                else if (siblingNInt == 2)
                {
                    vacationHome = "Las Vegas, Nevada";
                }
                else if (siblingNInt >= 3)
                {
                    vacationHome = "New York City, New York";
                }
                else
                {
                    vacationHome = "a trash can...";
                }//Only comes up if > 0. Which is the only other possible answer!



                Console.WriteLine("Thank you!!");
                Console.WriteLine("Here are your results: ");
                Console.WriteLine(" "); //This gives some space between the results and the conclusion!
                Console.WriteLine(fN + " " + lN + " will retire in " + retireTime + " with " + money + " in the bank, a vacation home in " + vacationHome + " and gets around with "  + transportation);
                break;

            } while (userQuit != "quit");

            if (userQuit == "quit")
            { 
                Console.WriteLine("No one likes a quitter!"); //No one does. This ends the do while statement and ends the program.
            }

             }
    }
}

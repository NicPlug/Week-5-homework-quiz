using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5_homework
{



    class Terminal
    {


        int? numberOfQuestions = null;
        Random rng = new Random();
        int playerPoints = 0;
        String playerAnswer = null;


        bool[] questionCheck = {false,
                                   false,
                                   false,
                                   false,
                                   false,
                                   false,
                                   false,
                                   false,
                                   false,
                                   false,
                                   false,
                                   false,
                                   false,
                                   false,
                                   false,
                                   false,
                                   false,
                                   false,
                                   false,
                                   false,};

                               

        string[] questionList = {"What was Marios first appearance in a video game?? \n1)Mario Bros.\n2)Donkey Kong\n3)Super Mario Bros.\n4)Punch Ball Mario Bros.",
                                "What game in the Mario Bros. franchise was the Tanookie suit introduced?? \n1)Super Mario world\n2)Super Mario 3D Land\n3)Super Mario Bros. 3\n4)I Am a Teacher: Super Mario Sweater ",
                                "Which one of these titles did Mario NOT appear in \n1)QIX\n2)Super Jumping Forever\n3)Tetris\n4)Yakuman DS",
                                "Which was the most powerful, unbreakable sword in The Legend of Zelda: Ocarina of Time??\n1)The Biggorons's Sword\n2)The Kokiri Sword\n3)The Master Sword\n4)The Giant's Knife",
                                "What is the first letter in the word Nintendo??\n1)R\n2)I\n3)S\n4)N",
                                "In the Kirby series, what candy can Kirby eat to become invincible??\n1)Breathmint\n2)Candycane\n3)Lollypop\n4)Jawbreaker",
                                "How many levels are there in Kirby Super Star??\n1)7\n2)4\n3)5\n4)8",
                                "In Super Metroid, Which of these factors had no effect on which ending you got??\n1)Number of times saved\n2)Time\n3)Saving the Etecoons\n4)Saving the Dachola",
                                "How many playable characters were in the original Super Smash Bros.??\n1)26\n2)12\n3)39\n4)55",
                                "Which video game character DIDN'T appear in Wreck It Ralph??\n1)Bowser\n2)Dr Eggman\n3)Cloud Strife\n4)M. Bison",
                                "Who was the boss in the original Super Smash Bros.??\n1)God Hand\n2)Master Hand\n3)The Glove\n4)The Creator",
                                "Who is the main character in Punch Out??\n1)Little Mac\n2)Big Mac\n3)Tiny Mac\n4)Huge Mac",
                                "What colour are the 1up balloons in Donkey Kong??\n1)Red\n2)Blue\n3)Green\n4)Yellow",
                                "What was Mario called before he was called Mario??\n1)Superman\n2)Jumpman\n3)Runman\n4)Flyman",
                                "What colour are Kirbys feet??\n1)Yellow\n2)Blue\n3)Red\n4)Orange",
                                "Who can jump the heighest in Super Mario Bros. 2???\n1)Princess Peach\n2)Mario\n3)Toad\n4)Luigi",
                                "Before he was a plumber, what was Mario??\n1)He's always been a plumber\n2)Carpenter\n3)Roofer\n4)Doctor",
                                "In what game does Princess Peach first appear??\n1)Super Mario Bros.\n2)Mario Bros.\n3)Donkey Kong\n4)Donkey Kong 2",
                                "What sport has Mario never played??\n1)Soccer\n2)Tennis\n3)Squash\n4)Golf",
                                "What colour is Bowsers hair??\n1)He's bald\n2)Green\n3)Yellow\n4)Red"};

        string[] answerList = { "2",
                                 "3",
                                  "2",
                                   "1",
                                    "4",
                                     "3",
                                      "4",
                                       "1",
                                        "2",
                                         "3",
                                          "2",
                                           "1",
                                            "1",
                                             "2",
                                              "3",
                                               "4",
                                                "2",
                                                 "1",
                                                  "3",
                                                   "4"};



        //print to the terminal
        public void Print (string stringToPrint)
        {
            Console.WriteLine(stringToPrint);
        }

        public bool ReturnTrueOrFalseQuestion(string question)
        {
            string answer = AskQuestion(question + " (y/n)").ToLower();
            answer = answer.Replace("yes", "y");
            answer = answer.Replace("no", "n");

            if (answer== "y")
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        
        //ask for string responce
        public string AskQuestion (string question)
        {
            Print(question);
            string answer = Console.ReadLine();
            return answer;
        }


        //ask for int responce
        public int AskForInt (string question)
        {
            string answer = AskQuestion(question);
        
            int number;

            int.TryParse(answer, out number);

            return number;
        }




        public void Run()
        {
            Print("Welcome to quiz town. Population, YOU!\n");

            string playerName = AskQuestion("What is your name, random quizzer??");
            Print("Hello, " + playerName + "\n");

            //finds out how many questions a player would like to answer
            while (numberOfQuestions == null)
            {

                numberOfQuestions = AskForInt("How many questions will you be answering today (7, 12 or 15)?\n");

                if (numberOfQuestions == 7 || numberOfQuestions == 12 || numberOfQuestions == 15)
                {
                    numberOfQuestions = numberOfQuestions;
                    Print(numberOfQuestions + " Sounds like a good number.\nPlease answer 1, 2, 3 or 4 to all of the questions.\nEvery right answer is worth 5 points.\nWrong answers will cost you 2 points.\n\nHere they come!!! \n\n");
                }
                else
                {
                    Print(numberOfQuestions + " is not a valid choice.\n");
                    numberOfQuestions = null;
                }
            }


                for (int index = 0; index < numberOfQuestions; ++index)
                {
                    int numberSelected = rng.Next(0, questionList.Length);

                    while (questionCheck[numberSelected] == true)
                    {
                        numberSelected = rng.Next(0, questionList.Length);
                    }

                    questionCheck[numberSelected] = true;

                    while (playerAnswer == null)
                    {
                        playerAnswer = AskQuestion("question " + (index + 1) + ") " + questionList[numberSelected]);
                        if (playerAnswer == "1" || playerAnswer == "2" || playerAnswer == "3" || playerAnswer == "4")
                        {
                            playerAnswer = playerAnswer;
                        }
                        else
                        {
                            Print("\n" +playerAnswer + " isn't valid!!! Please answer 1, 2, 3, 4.\n");
                            playerAnswer = null;
                        }
                            
                        
                    }

                    if (playerAnswer == answerList[numberSelected])
                    {
                        Print("Hooray. 5 points for you!!!\n\n");
                        playerPoints += 5;
                    }
                    else
                    {
                        Print("Boooooo. That's not right. The correct answer was " + answerList[numberSelected] + ". That'll cost you 2 points!!!\n\n");
                        playerPoints -= 2;
                    }
                    playerAnswer = null;

                }


                if (playerPoints > 0)
                {
                    Print("You got " + playerPoints + " points. Thats pretty good!");
                }
                else
                {
                    Print ("You got " + playerPoints + "... You are bad at quizzes and smell.");
                }
            Print ("GAME OVER");
            bool playAgainStatus = ReturnTrueOrFalseQuestion("Would you like to play again, "+ playerName + "??");
            if (playAgainStatus)
            {
                Print("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                numberOfQuestions = null;
                Run();
            }
            else
            {
                Print("Thank you for playing~");
            }
            

                    
            
            }


        }

















    class Program
    {
        static void Main(string[] args)
        {
            Terminal terminal = new Terminal();
            terminal.Run();
        }
    }
}

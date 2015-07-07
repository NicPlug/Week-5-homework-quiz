using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5_homework
{



    class Terminal
    {

        int playerPoints = 0;
        Random rng = new Random();
        const int invalidResponce = -1;
        int? numberOfQuestions = null;

        List<int> askedQuestions = new List<int>();

        string[] questionList = {"The answer is 1\n1)\n2)\n3)\n4)",
                                "The answer is 2\n1)\n2)\n3)\n4)",
                                "The answer is 3\n1)\n2)\n3)\n4)",
                                "The answer is 4\n1)\n2)\n3)\n4)",
                                "The answer is 5\n1)\n2)\n3)\n4)",
                                "The answer is 6\n1)\n2)\n3)\n4)",
                                "The answer is 7\n1)\n2)\n3)\n4)",
                                "The answer is 8\n1)\n2)\n3)\n4)",
                                "The answer is 9\n1)\n2)\n3)\n4)",
                                "The answer is 10\n1)\n2)\n3)\n4)",
                                "The answer is 11\n1)\n2)\n3)\n4)",
                                "The answer is 12\n1)\n2)\n3)\n4)",
                                "The answer is 13\n1)\n2)\n3)\n4)",
                                "The answer is 14\n1)\n2)\n3)\n4)",
                                "The answer is 15\n1)\n2)\n3)\n4)",
                                "The answer is 16\n1)\n2)\n3)\n4)",
                                "The answer is 17\n1)\n2)\n3)\n4)",
                                "The answer is 18\n1)\n2)\n3)\n4)",
                                "The answer is 19\n1)\n2)\n3)\n4)",
                                "The answer is 20\n1)\n2)\n3)\n4)"};

        string[] answerList = { "1",
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
                numberOfQuestions = AskForInt("How many questions will you be answering today(7, 12 or 15)?\n");
                if (numberOfQuestions == 7 || numberOfQuestions == 12 || numberOfQuestions == 15)
                {
                    numberOfQuestions = numberOfQuestions;
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
                   
                    while (askedQuestions.Contains(numberSelected));
                    {
                        numberSelected = rng.Next(0, questionList.Length);
                    }

                    askedQuestions.Add(numberSelected);

                    string playerAnswer = AskQuestion(questionList[numberSelected]);
                    if (playerAnswer == answerList[numberSelected])
                    {
                        Print("Hooray. 5 points for you!!!\n");
                        playerPoints += 5;
                    }
                    else
                    {
                        Print("Boooooo. No points for you!!!\n");
                    }

                    }
            Print ("You have "+ playerPoints + " points. Thats pretty good!");
            Print ("GAME OVER");
                    
            
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

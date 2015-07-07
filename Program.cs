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

        string[] questionList = {"The answer is 1\n1)\n2)\n3)\n4)",
                                "The answer is 3\n1)\n2)\n3)\n4)",
                                "The answer is 2\n1)\n2)\n3)\n4)",
                                "The answer is 1\n1)\n2)\n3)\n4)",
                                "The answer is 4\n1)\n2)\n3)\n4)",
                                "The answer is 3\n1)\n2)\n3)\n4)",
                                "The answer is 4\n1)\n2)\n3)\n4)",
                                "The answer is 1\n1)\n2)\n3)\n4)",
                                "The answer is 2\n1)\n2)\n3)\n4)",
                                "The answer is 3\n1)\n2)\n3)\n4)",
                                "The answer is 2\n1)\n2)\n3)\n4)",
                                "The answer is 1\n1)\n2)\n3)\n4)",
                                "The answer is 1\n1)\n2)\n3)\n4)",
                                "The answer is 2\n1)\n2)\n3)\n4)",
                                "The answer is 3\n1)\n2)\n3)\n4)",
                                "The answer is 4\n1)\n2)\n3)\n4)",
                                "The answer is 2\n1)\n2)\n3)\n4)",
                                "The answer is 1\n1)\n2)\n3)\n4)",
                                "The answer is 3\n1)\n2)\n3)\n4)",
                                "The answer is 4\n1)\n2)\n3)\n4)"};

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



                for (int index = 0; index < (20-numberOfQuestions); ++index)
                {
                    int questionAnswerToRemove = rng.Next(0, questionList.Length);
                    string[] leftOverQuestions = new string[questionList.Length - 1];
                    string[] leftOverAnswers = new string[answerList.Length - 1];
                    int questionIndex = 0;

                    for (int index2 = 0; index < questionList.Length; ++index)
                    {
                        if (index2 == questionAnswerToRemove)
                        {
                            continue;
                        }
                        leftOverQuestions[questionIndex] = questionList[index];
                        leftOverAnswers[questionIndex] = answerList[index];
                        ++questionIndex;
                    }
                }

                    for (int index = 0; index < questionList.Length; ++index)
                    {
                        string playerAnswer = AskQuestion(questionList[index]);
                        if (playerAnswer == answerList[index])
                        {
                            Print("Hooray. 5 points for you!!!\n");
                            playerPoints += 5;
                        }
                        else
                        {
                            Print("Boooooo. No points for you!!!\n");
                        }
                    }

                    
                
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

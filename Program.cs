using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5_homework
{
    class Terminal
    {

        const int invalidResponce = -1;
        int? numberOfQuestions = null;


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
                numberOfQuestions = AskForInt("How many questions will you be answering today(7, 12 or 15)?");
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

using System;
using RandomNameSpace;

namespace MainNameSpace
{
    class Program
    {
        int lives = 5;
        RandomNumberGenerator rng = new RandomNumberGenerator();

        int getRandomNumber(){
            return this.rng.randNumSender();
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            int userInput, generatedNumber = obj.getRandomNumber();
            for(;;){
                if(obj.lives == 1){
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You are left with only one life!!".ToUpper());
                        Console.ResetColor();
                }
                else if(obj.lives==0){
                    if(obj.willToPlay()) {
                        obj.lives = 5;
                        generatedNumber = obj.getRandomNumber();
                        continue;
                    }  
                    break;
                }
                userInput = obj.askUser();
                if(userInput == generatedNumber){
                    if(obj.successMsg()){
                            obj.lives = 5;
                             generatedNumber= obj.getRandomNumber();
                            continue;
                    }
                    break;
                }
                else{
                    obj.errorMsg();
                    --obj.lives;
                }
            }

        }
        bool successMsg(){
             Console.ForegroundColor = ConsoleColor.Green;
             Console.WriteLine("You nailed it!");
             Console.ResetColor();
             return this.willToPlay();
        }

        bool willToPlay(){
            try{
             Console.WriteLine("Wanna Play Again? Hahh [y/Y for Continuing]");
             bool willToPlayMore = Console.ReadLine().ToLower() == "y" ? true : false;
             return willToPlayMore;
             }
             catch(FormatException){
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Must be either y or n");
                Console.ResetColor();
                Console.WriteLine("Enter again...");
                return willToPlay();
             }
        }
        void errorMsg(){
             Console.ForegroundColor = ConsoleColor.Red;
             Console.WriteLine("Nope!!");
             Console.ResetColor();
        }
        int askUser(){
            Console.Write("Enter the number");
            try{
            int userInput = Int16.Parse(Console.ReadLine());    //Int64 or 32==long and ReadLine() can't take args
            return userInput;
            }
            catch(Exception e){
                if(e is FormatException){
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Must be an integer in range [1-10]. Your life was not reduced :)");
                Console.ResetColor();
                Console.WriteLine("Enter again...");
                return askUser();
                }
                else if(e is OverflowException){
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Too long input. Your life was not reduced :)");
                Console.ResetColor();
                Console.WriteLine("Enter again...");
                return askUser();
                }
                else{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Something went wrong. Report bug to Gaurav {gauravkabra.official@gmail.com}. Your life was not reduced :) ");
                Console.ResetColor();
                Console.WriteLine("Let's try again!");
                return askUser();
                }
            }
        }
    }
}
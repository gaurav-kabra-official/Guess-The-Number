using System;
namespace RandomNameSpace 
{
    class RandomNumberGenerator: Random{
        static int prevRandomNumber = 9;   //say
        Random rand = new Random(prevRandomNumber);

        public int randNumSender(){
            int newRandomNumber = rand.Next(10)+1;             // 1 to 10
            prevRandomNumber = newRandomNumber;
            return newRandomNumber;
        }
    }
}
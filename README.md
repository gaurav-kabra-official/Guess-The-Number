# Author: [Gaurav Kabra](gauravkabra.official@gmail.com)

# Run these commands in VSCode terminal:
<br>
dotnet new console --force : This initializes the project
<br>
dotnet run : This runs the code


# How to Play?
You have 5 lives. That means you can try 5 times to guess the integer<br>
which is between 1 to 10 (both inclusive).<br>
Once you guess it correct OR you run out of lives<br>
you will be asked to continue. <br>
Pressing any key other than Y or y will result in closing of game immediately.
### Note:   
Throughout game, colors on console mean something:
RED : invalid input (e.g. too long input or instead of integer you enter type-inconsistent value) OR you are left with final life!
GREEN : You guessed the number correctly. Congrats for that!
WHITE : Rest text (including crash-reports (exceptions))

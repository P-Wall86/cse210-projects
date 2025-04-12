using System;

/* I added a new method to delete goals in case we have a wrong input or something we no longer want. 
If the goal we delete had points awarded, those points will be subtracted from the total. */

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
    
}
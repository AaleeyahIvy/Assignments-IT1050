using System;
//❀ Aaleeyah Ivy 
//❀ Assignment 4 
//❀ Loops 'n' Arrays 
					
void getTeamInfo() //❀ Gets Information! 
{
	
string[] playerNames = {};
int[] playerNumbers = {};

Console.WriteLine("Team Name: ");
string teamName = Console.ReadLine();
Console.WriteLine("How many players: ");
int teamSize = Convert.ToInt32(Console.ReadLine());
	     //❀ Allocation! 
playerNames = new string[teamSize];
playerNumbers = new int[teamSize];
	
	for (int i = 0; i < teamSize; i++) //Loops and adds player to position[i]
	{
	Console.WriteLine("Player Name: ");
	playerNames[i] = Console.ReadLine();
	Console.WriteLine("Player Number: ");
	playerNumbers[i] = Convert.ToInt32(Console.ReadLine());
	}	
	
void printTeamInfo() //❀ Displays Information!
{
	for (int i = 0; i < teamSize; i++)  //Loops through players and displays current player in position[i]
	{
	Console.WriteLine(" ");
	Console.WriteLine("|---------------------|");
	Console.WriteLine("Player Name: " + playerNames[i]);
	Console.WriteLine("Player Number: " + playerNumbers[i]);
	Console.WriteLine("|---------------------|");
	Console.WriteLine(" ");
	}
}
Console.WriteLine("Team Name: " + teamName);
Console.WriteLine("|━━━━━━Team Roster━━━━━━|");
printTeamInfo();
}

getTeamInfo();

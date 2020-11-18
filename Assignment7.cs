using System;
//Aaleeyah Ivy 
//Assignment 7 
//Bring it all together
class Player
{
	public string name {get;set;}
	public int number {get;set;}
	public int rank {get;set;}
		
	public Player(int number, string name, int rank)
	{
		this.number = number;
		this.name = name;
		this.rank = rank;
	}
}

class Team
{
	public string teamName {get;set;}
	
	public Player[] players {get;set;}
	
	public Team(string teamName, Player[] players)
	{
		this.teamName = teamName;
		this.players = players;
	}
	public void printTeamInfo()
	{
		foreach (Player i in players)
		{ 
			Console.WriteLine("Team: {0}, Player: {1}", teamName, i.name + "        " + i.number + "        " + i.rank); //don't just print i, print i's values.
			Console.WriteLine();
		}
	}
}
//Players
Player p1 = new Player(25, "Jay", 1);
Player p2 = new Player(21, "Cee", 4);
Player p3 = new Player(22, "Parker", 2);
Player p4 = new Player(29, "Kole", 5);
Player p5 = new Player(23, "Niles", 3);
Player p6 = new Player(26, "Enzo", 6); 
//Player Array
Player[] players1 = new Player[3] {p1, p2, p6};
Player[] players2 = new Player[3] {p4, p3, p5};
//Teams
Team t1 = new Team("Centric Bees", players1);
Team t2 = new Team("Modest Eagles", players2);
//Print Info
Console.WriteLine("                            Name      Number    Rank");
t1.printTeamInfo();
t2.printTeamInfo();

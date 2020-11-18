using System;

public class Program
{
	public static void Main() //First Method
	{
		Console.WriteLine("What is your name?");
		string firstName = Console.ReadLine();
		Console.WriteLine("What is your middle initial");
		string middleInitial = Console.ReadLine();
		Console.WriteLine("What is your last name?");
		string lastName = Console.ReadLine();
		string fullName = firstName + " " + middleInitial + " " + lastName;
		Console.WriteLine(fullName);
    
		Console.WriteLine("What is your height in feet");
		int heightFeet = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("How many inches beyond your base height are you?"); //Example: 5'2 1/2" -> 5 feet 2.50 inches 
		double heightInches = Convert.ToDouble(Console.ReadLine());
		double totalHeightCm = (((Convert.ToDouble(heightFeet)) * 12) + (Convert.ToDouble(heightInches))) * 2.54;
		Console.WriteLine(totalHeightCm);
    
		Console.WriteLine("What is your age?");
		int age = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Are you a citizen?"); //true or false
		bool isCitizen = bool.Parse(Console.ReadLine());
		bool canVote = true || false;
		if (age > 18 && isCitizen == true)
		{
			Console.WriteLine("You can vote");
		}
		else if (age < 18 && isCitizen == true)
		{
			Console.WriteLine("You cannot vote");
		}

		Console.WriteLine(fullName);
		Console.WriteLine(totalHeightCm);
		Console.WriteLine(canVote);
	}
}

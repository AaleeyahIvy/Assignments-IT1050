using System;
// ✰ Aaleeyah Ivy
// ✰ IT 1050
// ✰ Assignment 2
public class Program
{
	public static void Main()
	{
		//---------------------------
			
		//✰Matinee Ticket Prices
		double matineeChild = 3.99;
		double matineeAdult = 5.99;
		double matineeSenior = 4.50;
				
		//✰Evening Ticket Prices
		double eveningChild = 6.99;
		double eveningAdult = 10.99;
		double eveningSenior = 8.50;
				
		//✰Concession Prices
		double popcorn = 4.50;
		double candy = 1.99;
		double soda = 3.99;
		
		//---------------------------
		
		Console.WriteLine("Showtime: Matinee or Evening?");
		string showtime = Console.ReadLine();
		
		if (showtime == "Matinee")
		{	
			//✰Tickets
			Console.WriteLine("How many Matinee Child tickets? Price $3.99");
			int howManyMatineeChild = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("How many Matinee Adult tickets? Price: $5.99");
			int howManyMatineeAdult = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("How many Matinee Senior tickets? Price $4.50");
			int howManyMatineeSenior = Convert.ToInt32(Console.ReadLine());
			//✰Concession
			Console.WriteLine("How much Popcorn? Price: $4.50");
			int howManyPopcorn = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("How much Candy? Price: $1.99");
			int howManyCandy = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("How much Soda? Price: $3.99");
			int howManySoda = Convert.ToInt32(Console.ReadLine());
			//✰Pricing 			
			int totalTickets = howManyMatineeChild  + howManyMatineeAdult + howManyMatineeSenior;
			double totalTicketCost = (howManyMatineeChild * matineeChild) + (howManyMatineeAdult * matineeAdult) + (howManyMatineeSenior * matineeSenior);
			double totalConcession = (howManyPopcorn * popcorn) + (howManyCandy * candy) + (howManySoda * soda);
			double totalCost = (totalTicketCost + totalConcession);
			//✰Cost
			Console.WriteLine("---------------------------------");
			Console.WriteLine("The selected showtime: " + showtime);
			Console.WriteLine("Your Ticket total: " + totalTicketCost);
			Console.WriteLine("Your Concession Total: " + totalConcession);
			Console.WriteLine("Your Total Cost: " + totalCost);
			Console.WriteLine("---------------------------------");
			//✰Discounts
			Console.WriteLine("---------------------------------");
			if (howManyPopcorn == howManySoda)
				Console.WriteLine("You will recieve a $2 discount");
			if (totalTickets > 3)
				Console.WriteLine("You will recieve a 1 free popcorn");
			if (howManyCandy >= 4)
				Console.WriteLine("Your 4th candy is free");
				Console.WriteLine("---------------------------------");
		}		
		else
		{
			//✰Tickets
			Console.WriteLine("How many Evening Child tickets? Price $6.99");
			int howManyEveningChild = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("How many Evening Adult tickets? Price: $10.99");
			int howManyEveningAdult = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("How many Evening Senior tickets? Price $8.50");
			int howManyEveningSenior = Convert.ToInt32(Console.ReadLine());
			//✰Concession
			Console.WriteLine("How much Popcorn? Price $3.99");
			int howManyPopcorn = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("How much Candy? Price $1.99");
			int howManyCandy = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("How much Soda? Price $3.99");
			int howManySoda = Convert.ToInt32(Console.ReadLine());
			//✰Pricing
			int totalTickets = howManyEveningChild + howManyEveningAdult + howManyEveningSenior;
			double totalTicketCost = (howManyEveningChild * eveningChild) + (howManyEveningAdult * eveningAdult) + (howManyEveningSenior * eveningSenior);
			double totalConcession = (howManyPopcorn * popcorn) + (howManyCandy * candy) + (howManySoda * soda);
			double totalCost = (totalTicketCost + totalConcession);
			//✰Cost
			Console.WriteLine("---------------------------------");
			Console.WriteLine("The selected showtime: " + showtime);
			Console.WriteLine("Your Ticket total: " + totalTicketCost);
			Console.WriteLine("Your Concession Total: " + totalConcession);
			Console.WriteLine("Your Total Cost: " + totalCost);
			Console.WriteLine("---------------------------------");
			//✰Discounts
			Console.WriteLine("---------------------------------");
			if (howManyPopcorn == howManySoda)
				Console.WriteLine("You will recieve a $2 discount");				  
			if (totalTickets > 3)
				Console.WriteLine("You will recieve a 1 free popcorn");
			if (howManyCandy >= 4)
				Console.WriteLine("Your 4th candy is free");
				Console.WriteLine("---------------------------------");
			}
		
		}
	}

using System;
//Aaleeyah Ivy ◉
//Constructors + Statics ◉
//Assignment 6 : Pets ◉

class Pet
{
	private string petName;
	private string petType;
	private int petAge;
	public static int numberOfPets;
	
	public Pet(string petName, string petType, int petAge)
	{
		this.petName = petName;
		this.petType = petType;
		this.petAge = petAge;
		Pet.numberOfPets++;
	}
	
	public string getName()
	{return this.petName;}
	
	public string getType()
	{return this.petType;}
	
	public int getAge()
	{return this.petAge;}	
	
	public void printPet()
	{
		Console.WriteLine(petName + ", is a " + petType + ", they are " + petAge + " year(s) old!");
	}
}

Pet p1 = new Pet("Mowgli", "Cat" , 1);
Pet p2 = new Pet("Sam" , "Cat" , 11);
Pet p3 = new Pet("Acer" , "Dog", 5);

p1.printPet();
p2.printPet();
p3.printPet();
Console.WriteLine("There are " + Pet.numberOfPets + " pets total!");

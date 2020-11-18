using System;
//Aaleeyah Ivy ✼
//Classes.Objects ✼
//Assignment 5 ✼
class Person
{
	//Public Variables ✼
	public int age;
	public string firstName;
	public string lastName;
	public string maritalStatus;
	public Person spouse;
	public static int count;
	public static int sumOfAges; 
	
	public static double ageAverage() //Get Ages ✼
	{
		return (double)Person.sumOfAges / (double)Person.count;
	}
	
	public string getFullName() //Get Name
	{
		return this.firstName + " " + this.lastName;
	}
	
	public void printNameAndAge() //Get Age and Name ✼
	{	
		Console.WriteLine(getFullName());
		Console.WriteLine("-----------------------");
		Console.WriteLine("Age: " + this.age + " Status: " + maritalStatus);
		Console.WriteLine("-----------------------");
	}
	
	public void getInfoFromPerson() //Get Info for Person ✼
	{
		
		Console.WriteLine("First Name: ");
		this.firstName = Console.ReadLine();
		Console.WriteLine("Last Name: ");
		this.lastName = Console.ReadLine();
		Console.WriteLine("Age: ");
		this.age = Convert.ToInt32(Console.ReadLine());
		
		Person.count ++;
		Person.sumOfAges += this.age;
	}
	
	public void getInfoFromSpouse() //Get Info for Spouse ✼
	{
		Console.WriteLine("Spouse Name: ");
		this.firstName = Console.ReadLine();
		Console.WriteLine("Spouse Age: ");
		this.age = Convert.ToInt32(Console.ReadLine());
		
		Person.count ++;
		Person.sumOfAges += this.age;
	}
	
	public void ifMarried() //Marital Status ✼
	{
		Console.WriteLine("Married or Single :");
		this.maritalStatus = Console.ReadLine();
		if (maritalStatus == "Single")
		{
			this.spouse = null;
		}
		
		if (maritalStatus == "Married" )
		{
			this.spouse = new Person();
			this.spouse.getInfoFromSpouse();
			this.spouse.spouse = this;
			this.spouse.lastName = this.lastName;
			this.spouse.maritalStatus = this.maritalStatus;
			this.spouse.printNameAndAge();
		}
	}
}

//Person! ✼
for (int i = 0; i <= Person.count; i++)
{
Person person = new Person();
person.getInfoFromPerson();
person.ifMarried();
person.printNameAndAge();
Console.WriteLine(Person.ageAverage());
}

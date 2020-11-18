//✿ Aaleeyah Ivy
//✿ Assignment 3
//✿ Functions

//✿ Function Declaration

int addAndMultipleIntegers(int x, int y, int z)
{
	return (x + y) * z; //( x + y ) to please PEMDAS Gods
}

System.Console.WriteLine(addAndMultipleIntegers(1, 1, 5));
System.Console.WriteLine(addAndMultipleIntegers(1, 2, 16));
System.Console.WriteLine(addAndMultipleIntegers(5, 6, 7));

//✿ Void Function

void reverseThisString(string x, string y)
{
	System.Console.WriteLine(y + " " + x); // " " to add space between x y
}
reverseThisString("Please", "Reverse");
reverseThisString("sticexpialidocious", "Supercalifragili"); // ask me to spell it aloud.
reverseThisString("Care", "Dont");


// Brian Lee
// C++ Programming, Jim Shain
// Homework #5, Part 3



#include <iostream>
#include <cmath>
using namespace std;

double input();  //here are my user-defined functions 
double calc();
double output();

double num1; // here is my global varible.
double factorial=1;  //this was important.  I was getting zero and weird answers before I set to 1.


double input() {

cout << endl;
cout << "// Brian Lee" << endl;
cout << "// C++ Programming, Jim Shain" << endl;
cout << "// Homework #5, Part 3" << endl;
cout << "This Program asks an integer and\n";
cout << "results the factorial of that integer. " << endl << endl;

cout << " " << endl;
cout << "Please an integer: " << endl;   // program asks for 2 numbers
cin >> num1;
cout << endl;
cout << endl;
return(num1); //the integer is returned
}


double calc() {
	while (num1 >1 ){
		
		factorial = (num1-- * factorial);  //this took me a long time.  I am still not sure of another way to make it work.
		                                   //this is the factorial calculation usuing a while loop.  Factorial is preset to 1.
		                                   //num1 is multiplied by the previous factorial and then num1 is subtracted by 1 until num1 no longer
		                                   //greater than 1.  Then the loop terminates.  
}


return(factorial);   //factorial is returned to the main function.

}




double output() {     //this section is for the output of the program.
cout << " The factorial is: ";
cout << factorial << endl;   //the factorial is resulted here.
cout << endl;
return(0);   //nothing is returned.
}


int main() {

input();   //here are the 3 functions under the main function.
calc();
output();
  
system ("pause");

return(0);
} 
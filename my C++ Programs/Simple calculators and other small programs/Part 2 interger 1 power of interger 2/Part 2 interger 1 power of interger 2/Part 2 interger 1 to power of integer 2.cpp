
// Brian Lee
// C++ Programming, Jim Shain
// Homework #5, Part 2


#include <iostream>
#include <cmath>
using namespace std;

double input();  //here are my user-defined functions 
double calc();
double output();

double num1, n; // Here are my global varibles for the 2 integers
double power=1, total_power;  //here are the rest of the golobal varibles.  The varible is here to hold the value from the pow function
char decision;


double input() {

cout << endl;
cout << "// Brian Lee" << endl;
cout << "// C++ Programming, Jim Shain" << endl;
cout << "// Homework #5, Part 2" << endl;
cout << "This Program asks for 2 numbers and raises the \n";
cout << "first number by a power of the second number. " << endl << endl;

cout << " " << endl;
cout << "Please 2 numbers :" << endl;   // program asks for 2 numbers
cin >> num1 >> n;
cout << endl;
cout << endl;
return(num1, n); //2 numbers are returned
}


double calc() {
		while (n > 1){

power = (num1*power);  //calculates interger 1 to power of interger 2  
	    n=n-1;
	
}
	total_power = (power*num1);	
	return(total_power);  //average is returned
}



double output() {
cout << "Number " << num1 <<  " raised to the power of 'n' is: ";   //this is the ouput for the calculation
cout << total_power << endl;
cout << endl;
//system ("pause");
return(0);
}


int main() {

//do{



input();
calc();
output();


//cout << endl << endl;
	//cout << "Press anykey to exit program. " << endl;  //I have been adding this loop to all my programs to help with de-bugging.
   // cin >> decision;
	//cout << endl;

//}while (decision != 7);  //if decision is not equal to "lowercase n" then repeat program.  

system ("pause");

return(0);
} 
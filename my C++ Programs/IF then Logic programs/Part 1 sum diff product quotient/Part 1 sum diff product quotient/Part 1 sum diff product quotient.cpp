// Brian Lee

// C++ Programming, Jim Shain 

// Homework #3, Part1  

//This program will calculate sum, difference, product, and quotient of 2 numbers.  Each number is assigned a variable and division by 0
//explained. 


#include <iostream>
using namespace std;

int main() {



cout << endl;
cout << "// Brian Lee" << endl;
cout << "// C++ Programming, Jim Shain" << endl;
cout << "// Homework #3, Part 1 " << endl;


//variable section. 2 numbers are entered and calulations done  
int num1;  
int num2; 


//section asks for input and then assigns the input to varibles

cout << " This program will calculate sum, diff, product, and quotient of 2 numbers." << endl << endl;
cout << " Please enter any 2 integers with a space between:  ";
cin >> num1 >> num2;


//the if statement evaluates the second integer for zero.  A block if statement is used.
if (num2 == 0) {cout << " The second integer is zero, please re-enter 2 numbers. \n" << " The second must be a non-zero. \n" << " Please enter any 2 integers with a space between: " << endl;
	cin >> num1 >> num2;
}


cout << " The sum is: " << (num1 + num2) << "   The difference is: " << (num1 - num2) << endl;
cout << " The product is: " << (num1 * num2) << "   The quotient is: " << (num1 / num2) << endl;
	
system("pause");


return 0;

}
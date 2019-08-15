// Brian Lee

// C++ Programming, Jim Shain 

// Homework #2, Part4  

// This program will calculate sum, difference, product, and quotient of 2 numbers. 


#include <iostream>
using namespace std;

int main() {

//variable section. 2 numbers are entered and calulations done  
int num1;  
int num2; 


cout << endl;
cout << "// Brian Lee" << endl;
cout << "// C++ Programming, Jim Shain" << endl;
cout << "// Homework #2, Part 4 " << endl;


//section asks for input and then assigns the input to varibles

cout << " This program will calculate sum, difference, product, and quotient of 2 numbers." << endl;
cout << " Please enter any 2 integers with a space between:  ";
cin >> num1 >> num2;
cout << " The sum is: " << (num1 + num2) << "   The difference is: " << (num1 - num2) << endl;
cout << " The product is: " << (num1 * num2) << "   The quotient is: " << (num1 / num2) << endl;


system("pause");


return 0;

}
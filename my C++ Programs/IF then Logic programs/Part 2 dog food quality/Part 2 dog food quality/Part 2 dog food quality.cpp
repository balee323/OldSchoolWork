// Brian Lee

// C++ Programming, Jim Shain 

// Homework #3, Part2  

//This program will calculate the quality of dog food based on protein and fat content.

#include <iostream>
using namespace std;

int main() {



cout << endl;
cout << "// Brian Lee" << endl;
cout << "// C++ Programming, Jim Shain" << endl;
cout << "// Homework #3, Part 2 " << endl;


//variable section. 2 numbers are entered and calulations done  
double protein;  
double fat; 


//section asks for input and then assigns the input to varibles

cout << " his program will calculate the quality of dog food based on protein and fat content. " << endl << endl;
cout << " Please enter the fat and protein content (percentage without %) with a space between:  ";
cin >> fat >> protein;


if (fat < 18, protein > 23) cout << " Super-Premium dog food " << endl;
else
if (fat < 20, protein > 20) cout << " Premium dog food " << endl;
else
if (fat < 25, protein > 16) cout << " Normal dog food " << endl;
else
if (fat < 40, protein > 8) cout << " No-so-great dog food " << endl;


system("pause");


return 0;

}
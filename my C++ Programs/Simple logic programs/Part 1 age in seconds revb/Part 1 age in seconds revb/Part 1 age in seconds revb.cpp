// Brian Lee

// C++ Programming, Jim Shain 

// Homework #2, Part1  

// This program converts your age to seconds. 

#include <iostream>
using namespace std;

int main() {
  
double ageyears; //this varible is for age in years
double agesec; 
double sec_year = 3.156e7;

cout.setf(ios::fixed);  //This is where I set my decimal points
//cout.setf(ios::showpoint);  I decided I did not want to show the decimal
cout.precision(0);


cout << endl;
cout << "// Brian Lee" << endl;
cout << "// C++ Programming, Jim Shain" << endl;
cout << "// Homework #2, Part 1 " << endl;


//this section describes what the program does, and asks from input for age in years.

cout << "This program requests for age in years and converts to age in seconds. " << endl << endl;

cout << "please enter your age in years:  " ;
cin >> ageyears;


// this section verifies what you entered.

cout << "You entered " << ageyears << endl << endl;

//calculations section

agesec = ageyears * sec_year;  //calculates age in seconds

cout << "You are: " << agesec << " seconds old as of today. " << endl;   //outputs to screen age in seconds


system("pause");


return 0;
}


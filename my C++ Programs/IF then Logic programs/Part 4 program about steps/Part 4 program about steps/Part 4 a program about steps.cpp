// Brian Lee

// C++ Programming, Jim Shain 

// Homework #3, Part4  

//This program will calculate the rise and run of a stair step and output error messages if the specifications are out of range.

#include <iostream>
using namespace std;

int main() {



cout << endl;
cout << "// Brian Lee" << endl;
cout << "// C++ Programming, Jim Shain" << endl;
cout << "// Homework #3, Part 4 " << endl;


//variable section. rise and run.

double rise;
double run;
//double riseandrun;  I am not using this. I did not need it.


//section asks for input and then assigns the input to varibles rise and run.

cout << " This program determines if the rise \n"; cout << " and run (in inches) of a stair step is within specifications. " << endl << endl;
cout << " Please enter a rise and run with a space between:  ";
cin >> rise >> run;

//riseandrun = rise + run;  not needed.


//else statment moves program to next if statment "if" criteria not met for output.
//many if and else if statements.



if (rise <= 0) cout << " Sorry, The rise is less than or equal to 0 inches. " << endl;  //rise must be greater than 0

else
if(run <= 0) cout << " Sorry, the run is less than or equal to 0 inches. " << endl; //if rise is greater than 0, then run must be greater than 0


else
if (rise < 5) cout << " Sorry, the rise is less than 5 inches. " <<endl;  //checks if rise is greater than 5

else
if (rise > 12) cout << " Sorry, the rise is more than 12 inches. " << endl;  //checks if rise is less than 12

else
if (run < 6) cout << " Sorry, the run cannot be less than 6 inches. " << endl; //checks if run is less than 6

else
if (run > 13) cout << " Sorry, the run cannot be more than 13 inches. " << endl;  //checks if run is greater than 13.

if ((rise + run) > 18) cout << "Sorry, the rise + run must be less than 18 inches." << endl;  //rise and run cannot be more than 18 combined.

else cout << " The measurements seem to be within specificiations. " << endl;  //if everything is ok, this message pops up.



system("pause");


return 0;

}

// Brian Lee
// C++ Programming, Jim Shain
// Homework #5, Part 1


#include <iostream>
using namespace std;

double input();  //here are my user-defined functions 
double calc();
double output();
double num1, num2, num3, num4, num5; // Here are my global varibles for the 5 numbers
double sum, avg, n=5;  //here are the rest of the golobal varibles.  sum is for all 5 numbers, and n is a tally of the numbers set to 5.

char decision;

double input() {

cout << endl;
cout << "// Brian Lee" << endl;
cout << "// C++ Programming, Jim Shain" << endl;
cout << "// Homework #5, Part 1" << endl;
cout << "This Program asks for 5 numbers and computes their average. " << endl << endl;

cout << " " << endl;
cout << "Please 5 numbers :" << endl;   // program asks for 5 numbers
cin >> num1 >> num2 >> num3 >> num4 >> num5;
cout << endl;
//cout << num1 << " " << num2 << " " << num3 << " " << num4 << " " << num5;
cout << endl;
return(num1, num2, num3, num4, num5);  //all 5 numbers are returned.
}

double calc() {

//cout << "The values are being calculated " << endl << endl;     //don't need this.  it was fun for a second.
avg = (num1 + num2 + num3 + num4 + num5) / n;   //calculation for average

return(avg);  //average is returned
}


double output() {
cout << "The average of those 5 numbers is:  ";  //this is the output for the average of the 5 numbers
cout << avg << endl;
cout << endl;
//system ("pause");
return(0);
}


int main() {

do{   //for the while loop.

input();
calc();
output();


cout << endl << endl;
	cout << "Press Y and enter to repeat or any key and enter to exit program. " << endl;  //I have been adding this loop to all my programs to help with de-bugging.
    cin >> decision;
	cout << endl;

}while (decision =='y' || decision =='Y' );  //if decision is not equal to "lowercase n" then repeat program.  

return(0);
} 
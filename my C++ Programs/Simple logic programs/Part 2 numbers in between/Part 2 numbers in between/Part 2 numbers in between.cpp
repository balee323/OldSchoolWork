// Brian Lee

// C++ Programming, Jim Shain 

// Homework #2, Part2  

// This program will generate a preceding and succeeding number for any choosen number 


#include <iostream>
using namespace std;

int main() {

//variable section. Any number is input and then simply 1 is added or subtracted.    
int selected_num;  
int generated_numLess; // = (1 - selected_num) subtracted variable
int generated_numMore; // = (1 + selected_num) added variable.  too bad I cannot say n+1.

cout.setf(ios::fixed);  //This is where I set my decimal points
//cout.setf(ios::showpoint);  I decided I did not want to show the decimal
cout.precision(0);


//section acts for input and then assigns the integer input to varible selected_num
//Then 3 numbers are printed to the screen n-1, n, and n+1.

cout << endl;
cout << "// Brian Lee" << endl;
cout << "// C++ Programming, Jim Shain" << endl;
cout << "// Homework #2, Part 2 " << endl;


cout << " This program will generate a preceding and succeeding number for any #. " << endl;
cout << " Please enter any integer:  ";
cin >> selected_num;
cout << "The numbers are: " << (generated_numLess = selected_num - 1) << " " << selected_num << " " << (generated_numMore = 1 + selected_num);
cout << endl;

system("pause");


return 0;

}
// Brian Lee

// C++ Programming, Jim Shain 

// Homework #2, Part3 

// This program will calculate area for any square or rectangle.


#include <iostream>
using namespace std;

int main() {

//variable section. Any 2 measurements are collected and area is calculated.    
double length;  
double width;
//double area; // area = L*W   Note-seems liked I did not need this varible.  

cout.setf(ios::fixed);  //This is where I set my decimal points
//cout.setf(ios::showpoint);  I decided I did not want to show the decimal
cout.precision(0);


cout << endl;
cout << "// Brian Lee" << endl;
cout << "// C++ Programming, Jim Shain" << endl;
cout << "// Homework #2, Part 3 " << endl;


//section acts for input and then assigns the integer input to varible selected_num
//Then 3 numbers are printed to the screen n-1, n, and n+1.

cout << " This program calculate area squared for length and width " << endl << endl;
cout << " Please enter length and width followed by 1 space:  ";
cin >> length >> width;
cout << "The area is: " << (length * width) << endl;        //Is this acceptable to calculate area like this without a 3rd variable?

system("pause");


return 0;

}
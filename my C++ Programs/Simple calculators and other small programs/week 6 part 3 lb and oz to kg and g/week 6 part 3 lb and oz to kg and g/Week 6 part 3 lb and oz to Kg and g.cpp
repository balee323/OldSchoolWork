
// Brian Lee
// C++ Programming, Jim Shain
// Homework #6, Part 3


#include <iostream>

using namespace std; 


void readdata(double& num1, double& num2);   //readdata function declared

void docalc(double num1, double num2, double& result1, double& result2); //docalc function declared

void printresults(double result1, double result2); //printresults function declared


int main() {


cout << endl;
cout << "// Brian Lee" << endl;
cout << "// C++ Programming, Jim Shain" << endl;
cout << "// Homework #6, Part 3" << endl;


char decision;  // for program loop

do{   //for the while loop.

double input1 =0, input2=0; //local varibles for main function declared

double output1=0, output2=0; //output varible for functions.


cout << " This program concerts pounds and ounces to \n"
" to kilograms and grams" << endl << endl;



readdata(input1, input2); //local varibles are sent to readdata function

docalc(input1, input2, output1, output2); //local variables are sent to docalc funtion

printresults(output1, output2); //varible is printed by print function

//system ("pause");



cout << endl << endl;
	cout << "Press Y and enter to repeat or any key and enter to exit program. " << endl;  //I have been adding this loop to all my programs to help with de-bugging.
    cin >> decision;
	cout << endl;

}while (decision =='y' || decision =='Y' );  //if decision is not equal to "lowercase n" then repeat program.  


return(0);

} 



//functions defined section



void readdata(double& num1, double& num2) { // 2 numbers are entered by the user 

cout << "Please enter pounds and ounces with a space between: " << endl; 

cin >> num1 >> num2;  // 2 numbers stored into the variables


} 

void docalc(double num1, double num2, double& result1, double& result2) { // calculations are done on the passed through
	                                                                                           // variables.

result1 = (num1 / 2.2046);  // pounds to kilograms.
result2 = ((num2 / 16) / 2.2046 * 1000);  //conversion of ounces to pounds, then pounds to kilograms, and finally kilos to grams.

} 


void printresults(double result1, double result2) { // the result of the average is printed

cout.setf(ios::fixed);  //This is where I set my decimal points
//cout.setf(ios::showpoint);  I decided I did not want to show the decimal
cout.precision(2);  //set to 2 decimal places.


cout << endl;
cout << "Conversion is: " << result1 << " kilograms and " << result2 << " grams." << endl;


} 


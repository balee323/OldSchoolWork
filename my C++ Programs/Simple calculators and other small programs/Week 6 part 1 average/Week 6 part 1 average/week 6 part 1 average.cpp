
// Brian Lee
// C++ Programming, Jim Shain
// Homework #6, Part 1


#include <iostream>

using namespace std; 


void readdata(double& num1, double& num2, double& num3, double& num4, double& num5);   //readdata function declared

void docalc(double num1, double num2, double num3, double num4, double num5, double& result); //docalc function declared

void printresults(double result); //printresults function declared


int main() {


cout << endl;
cout << "// Brian Lee" << endl;
cout << "// C++ Programming, Jim Shain" << endl;
cout << "// Homework #6, Part 1 " << endl;



char decision;  // for program loop

do{   //for the while loop.

	double input1 =0, input2=0, input3=0, input4=0, input5=0; //local varibles for main function declared

	double output=0; //output varible for functions.


	readdata(input1, input2, input3, input4, input5); //local varibles are sent to readdata function

	docalc(input1, input2, input3, input4, input5, output); //local variables are sent to docalc funtion

	printresults(output); //varible is printed by print function

	//system ("pause");


		cout << endl << endl;
		cout << "Press Y and enter to repeat or any key and enter to exit program. " << endl;  //I have been adding this loop to all my programs to help with de-bugging.
		cin >> decision;
		cout << endl;

}while (decision =='y' || decision =='Y' );  //if decision is not equal to "lowercase n" then repeat program.  


	return(0);

} 



//functions defined section



void readdata(double& num1, double& num2, double& num3, double& num4, double& num5) { // 5 numbers are entered by the user 

cout << "Please enter 5 numbers:" << endl; 

cin >> num1 >> num2 >> num3 >> num4 >> num5;  // 5 numbers stored into the variables


} 

void docalc(double num1, double num2, double num3, double num4, double num5, double& result) { // calculations are done on the passed through
	                                                                                           // variables.
	//the result gets "outed" as output variable.
	//no wonder this confused the shit out of me back then
	result = ((num1+num2+num3+num4+num5)/ 5);  // average of 5 numbers

} 


void printresults(double result) { // the result of the average is printed

	cout << endl;
	cout << "The average is: " << result << endl;


} 


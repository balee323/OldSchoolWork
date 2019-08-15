// Brian Lee

// C++ Programming, Jim Shain 

// Homework #3, Part3  

//This program will calculate food cholesterol content and output quanity phrases.

#include <iostream>
using namespace std;

int main() {



cout << endl;
cout << "// Brian Lee" << endl;
cout << "// C++ Programming, Jim Shain" << endl;
cout << "// Homework #3, Part 3 " << endl;


//variable section. Cholesterol variable
double chol;  



//section asks for input and then assigns the input to varible chol.

cout << " This program will calculate food cholesterol content and output phrases. " << endl << endl;
cout << " Please enter the food cholesterol content (percentage without %):  ";
cin >> chol;

//My if statements for cholesterol content.
//else statment moves program to next if statment if criteria not met for output.

if (chol < 5) cout << " There is hardly any cholesterol in that food. " << endl;  //statment evaluates if less than 5%
else  //else statment moves program to next if statment, if more than 5%.  same with other 2 else statements.

if (chol >= 5 && chol <= 9 ) cout << " There is some cholesterol in that food. " << endl;  //statement determines between 5 and 9%
else  

if (chol >= 15 && chol <= 19) cout << " There is not too much cholesterol in that food. " << endl;  //statement determines between 15 and 19%.

else
if (chol >= 20 && chol <= 24) cout << " There is very little cholesterol. " << endl;  //statement determines between 25 and 30%.

else
if (chol >= 25 && chol <= 30) cout << " Still less cholesterol than our competition. " << endl;  //statement determines between 25 and 30%.


system("pause");


return 0;

}
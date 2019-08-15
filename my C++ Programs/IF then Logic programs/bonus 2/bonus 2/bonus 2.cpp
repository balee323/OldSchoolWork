//Brian Lee
//C++ programming, Jim Shain
//homework 3 bonus 2
//this program takes 3 numbers entered by a user and outputs them in order of smallest to largest.


#include <iostream>
using namespace std;

int main (){
//char decision;
//do{


cout << endl;
cout << "// Brian Lee" << endl;
cout << "// C++ Programming, Jim Shain" << endl;
cout << "// Homework 3 bonus 2 " << endl;
cout << "// This program arranges 3 numbers from smallest to greatest. " << endl;

char decision;
do{

double num1 = 0, num2 = 0, num3 = 0;


cout << " please enter any three numbers using a space between each and press enter." << endl;
cin >> num1 >> num2 >> num3;
cout << endl;


if (num1 < num2 && num2 < num3){
	cout << num1 << " " << num2 << " " << num3 << endl;   //   1, 2, 3  works
}


else
if (num1 < num3 && num2 < num3){
	cout << num2 << " " << num1 << " " << num3 << endl;    //   2, 1, 3  works
}



else
if (num1 > num2 && num2 < num3){
	cout << num2 << " " << num3 << " " << num1 << endl;   //  3, 1, 2  works
}
	

else
if (num1 > num3 && num2 > num3){
	cout << num3 << " " << num2 << " " << num1 << endl;  //  3, 2 , 1 works
}

else
if (num1 < num2 && num2 > num3){
	cout << num1 << " " << num3 << " " << num2 << endl;    //   1, 3, 2
}

else
if (num1 < num2 && num2 > num3){
	cout << num3 << " " << num1 << " " << num2 << endl;   //    2, 3, 1
}




cout << endl;

	system("pause");

	
	cout << "would you like to continue? Press (y or n). " << endl;
    cin >> decision;
	cout << endl;
}while (decision !='n');


return 0;


}

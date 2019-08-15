//Brian Lee
//C++ programming, Jim Shain
//homework 4 part 1
//this program takes 3 numbers entered by a user and outputs them in order of smallest to largest.


#include <iostream>
using namespace std;

int main (){


cout << endl;
cout << "// Brian Lee" << endl;
cout << "// C++ Programming, Jim Shain" << endl;
cout << "// Homework week4 part 1" << endl << endl;
cout << "// This program prints out 19 to 65 except for number 46. " << endl;

char decision;
do{

int i = 19;  //I set i to 19 from the start.



while (i < 46){               //will print 19 to 45 here.
	cout << i++ << " ";  //for i being less than 46 print all numbers staring with 19, since I primed i as 19.
	 


if (i == 46)
	while (i < 65) cout << (i++ +1) << " ";  // i++ is a shortcut for i + 1 and stores it in the variable i. (does double duty of adding 1 + i and storing it.
}                                            // adding +1 to i++ makes it start at 47. 
	//system("pause");  //dont need this for now.

	cout << endl << endl;
	cout << "would you like to continue? Press any key or 'n' and enter to exit. " << endl;  //I have been adding this loop to all my programs to help with de-bugging.
    cin >> decision;
	cout << endl;

}while (decision !='n');  //if decision is not equal to "lowercase n" then repeat program.  


return 0;
}
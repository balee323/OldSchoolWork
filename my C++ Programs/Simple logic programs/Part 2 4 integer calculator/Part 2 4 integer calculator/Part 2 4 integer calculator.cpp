//Brian Lee
//C++ programming, Jim Shain
//homework 4 part 2
//this program asks for 4 integers and outputs the sum.


#include <iostream>
using namespace std;

int main (){


cout << endl;
cout << "// Brian Lee" << endl;
cout << "// C++ Programming, Jim Shain" << endl;
cout << "// Homework week4 part 2" << endl << endl;
cout << "// This program prints out the sum of 4 integers. " << endl;

char decision;  //this is for my program repeat loop.
do{    //this do is for my program repeat while loop at the end.

int score;  //this variable is for the scores.
int n = 0;  //this variable is for the number of scores
int total_score=0;  //this tallies the scores



cout << "How many tests do you want sums for? ";  //I know you wanted just 4, but know you can have as many as you like.
	cin >> n;
	cout << endl;



while (n > 0){                 //as long as n is not zero, the while loop executes.
    cout << "Please enter score: " << endl;  //asks for a score.  this is repeated for whatever the value of n is.
	cin >> score;
	n = n -1;     //n is subtracted each turn so the loop stops once n = 0.
	total_score = score + total_score;
}    
	

	cout << endl;
	cout << total_score << endl;  //I finally got wise and brought this statement outside of the loop.
 
	

	cout << endl << endl;
	cout << "would you like to continue? Press any key or 'n' and enter to exit. " << endl;  //I have been adding this loop to all my programs to help with de-bugging.
    cin >> decision;
	cout << endl;

}while (decision !='n');  //if decision is not equal to "lowercase n" then repeat program.  


	//system ("pause");  //Don't need this.  I used it while de-bugging.  I am trying not to use it in the final code.

return 0;
}
//Brian Lee
//C++ programming, Jim Shain
//homework 5 part 4
//this program has a number from 1 to 10 and has you guess.


#include <iostream>
#include <cstdlib>
#include <time.h>  //included this so I could set up the random function.  no luck yet.
using namespace std;




int main (){
srand(time(0));


cout << endl;
cout << "// Brian Lee" << endl;
cout << "// C++ Programming, Jim Shain" << endl;
cout << "// Homework week 5 part 4" << endl << endl;

cout << " What is your name?" << endl;

int guess;  //this is the variable for a player's guess
char name [25];

cin >> name;
cout <<endl;
cout << name << " we are going to play a guessing game. " << endl;

char decision;  //for the program restart loop.
do{

int right_num = (rand() % 10)+1; //I was playing around with the random number generator.  It always says 8, so it is not set-up right.


cout  << "Please guess a number between 1 and 10 : ";
cin >> guess;  //enter a guess

//cout << endl << right_num << endl;


do{

if (guess < right_num) {    //guess is too low
	cout << " Your guess is low." ;
	cout << " Guess again.";
	cin >> guess;
}

if (guess > right_num) {
	cout << "Your guess is too high. " ;  //guess is too high
	cout << " Guess again.";
	cin >> guess;
}





}while (guess != right_num);   //triggers if the guess was correct

	cout << "You're right " << name << "!!" << endl;

	cout << endl << endl;
	cout << "Press 'y' to continue or any other key to exit. " << endl;  //I have been adding this loop to all my programs to help with de-bugging.
    cin >> decision;
	cout << endl;

  
}while (decision =='y'); 


return 0;
}
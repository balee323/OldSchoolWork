// Brian Lee

// C++ Programming, Jim Shain 

// Homework #1, Part 4 

// This program prints my address. 
// This program took me a while.  I kept looking at my book to find an easy way to enter text, but strings are beyond me right now
// But I did see a few if statements that looked easy, so I played around until I got the desired results
// And I am a total newbie at C++, so please don't expect too much from me at first.




#include <iostream>
using namespace std;

int main ()
{
  
  int number1;
  int number2;
  
  cout << "Please press 1 to see my name";
  cin >> number1;                                //suprised this works!!  takes input as an integer
  if (number1 == 1) cout << "Brian" << endl;     //if statement checks if the number is 1
  
  cout << "press 2 to see my address";
  cin >> number2;
  if (number2 == 2) cout << "Middlebury Vermont" << endl;    //if statement checks it the number is 2
  
  system("pause");
  
  return 0;
}
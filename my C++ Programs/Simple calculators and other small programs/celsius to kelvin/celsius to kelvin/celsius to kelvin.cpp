// Brian Lee

// C++ Programming, Jim Shain 

// Homework #1, Part 5 

// This program converts celsius to kelvin. 

#include <iostream>
using namespace std;

int main ()
{
  double celsius, kelvin;
  
  cout << "this program converts celsius to kelvin" << endl;
  cout << "Enter a temperature in celsius and press enter ";
  cin >> celsius;  // cin command is requesing temp input
  kelvin = celsius +273;    //calculating celcius to kelvin
  
  cout << "kelvin conversion is "<< kelvin << " ";  //cout command reports kelvin temp

  system("pause");
  
  return 0;
}
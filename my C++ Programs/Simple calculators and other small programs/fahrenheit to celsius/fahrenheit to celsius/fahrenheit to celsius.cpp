// Brian Lee

// C++ Programming, Jim Shain 

// Homework #1, Part 2 

// This program converts fahrenheit to celsius. 

#include <iostream>
using namespace std;

int main ()
{
  double celcius, fahrenheit;

  cout << "Enter a temperature in fahrenheit and press enter ";
  cin >> fahrenheit;  // cin command is requesing fahrenheit input
  celcius = (fahrenheit -32) / 1.8;    //I kept getting weird results until I subtracted 32 first, duh!
  cout << "celsius conversion is "<< celcius << " ";  //cout command prints celcius result to the screen

  system("pause");
  
  return 0;
}
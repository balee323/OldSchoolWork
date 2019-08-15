// Brian Lee

// C++ Programming, Jim Shain 

// Homework #1, Part 1 

// This program converts celcius to fahrenheit. 

#include <iostream>
using namespace std;

int main ()
{
  double celcius, fahrenheit;

  cout << "Enter a temperature in celsius and press enter ";
  cin >> celcius;
  fahrenheit = (celcius *1.8) +32;     //calculation factor used is *1.8 + 32
  cout << "fahrenheit conversion is "<< fahrenheit << " ";  //I added an extra blank output so the temp would not be bunchy

  system("pause");
  
  return 0;
}
#include <cstdlib>
using namespace std;
#include <iostream>
 #include <fstream>
 
  int main()
  {
  ifstream instream; // input file stream
  ofstream outstream; // output file stream
  int value;
 
 instream.open("infile.dat");
 outstream.open("outfile.out");
 
 instream >> value;
 outstream << (value * 2);

 instream.close();
 outstream.close();
 return(0);  
 }
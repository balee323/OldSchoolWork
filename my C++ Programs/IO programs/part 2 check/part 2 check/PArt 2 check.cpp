#include <cstdlib>
using namespace std;
#include <iostream>
 #include <fstream>
 
  int main()
  {
  ifstream instream; // input file stream
  ofstream outstream; // output file stream

  
  
cout << endl;
cout << "// Brian Lee" << endl;
cout << "// C++ Programming, Jim Shain" << endl;
cout << "// Homework #7, Part 2" << endl;

cout << "This program reads in numbers from an input file and \n"  //explains what program does
	<< "and results the numbers from smallest to largest \n"
	<< "to an output file." << endl << endl;

===========================================================



  int num[15], largest, smallest; //variable declared  I set my array to 15 numbers max (or is that 16)? 
  int i=0;       //array countdown
 
 instream.open("numbers.dat");  //input file opened
 outstream.open("output.out");  //output file created
 
 

 if (instream.fail()){   //this section checks for existence of input file.
cout << "Input file opening failed\n" << endl;  //This is displayed if input file is missing.
system ("pause");
exit (1);
 }


 


					
while (instream >> num[0]){
	cin >> num[0];
}





smallest = num[0];  //set smallest to memory location 0.
largest = num[0]; //array sets largest to first number at memory location 0.


 outstream << num;  //sum and average written to output file
 cout << num << endl;    //I was using this for verification
 instream.close();
 outstream.close();
 
 system("pause");
 
 return(0);  
 
}
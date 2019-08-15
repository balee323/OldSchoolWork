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
cout << "// Homework #7, Part 1" << endl;

cout << "This program reads in numbers from an input file and \n"  //explains what program does
	<< "and results an average to an output file." << endl << endl;


  double next, avg=0, sum = 0.0;  //variables declared
  int n=0;   //my counting variable for use in average calculation.
 
 instream.open("numbers.dat");  //input file opened
 outstream.open("average.out");  //output file created
 
 

 if (instream.fail()){   //this section checks for existence of input file.
cout << "Input file opening failed\n" << endl;  //This is displayed if input file is missing.
system ("pause");
exit (1);

}

  //instream >> next;   //the output file kept leaving out the first number from the input file
                        //And I finally figured out why.  Because of this line. 


  
  while (instream >> next) {   //this loop works by retrieving numbers while numbers are present in the file. Nice
 sum = sum + next;   //summation of input numbers
 n=n++;                //my counting function
 }
  
 
avg=(sum/n);  //calculation for average


 outstream << (sum) << "   " << (avg);  //sum and average written to output file
 //cout << sum << " " << avg << endl;    //I was using this for verification
 instream.close();
 outstream.close();
 
 //system("pause");
 
 return(0);  
 
  }
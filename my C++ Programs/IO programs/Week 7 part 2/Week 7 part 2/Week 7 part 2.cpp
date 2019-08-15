
// Brian Lee
// C++ Programming, Jim Shain
// Homework #7, Part 2 


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

//============================================================
 
 instream.open("numbers.dat");  //input file opened
 outstream.open("output.out");  //output file created
 
 

 if (instream.fail()){   //this section checks for existence of input file.
cout << "Input file opening failed\n" << endl;  //This is displayed if input file is missing.
system ("pause");
exit (1);
}

//================================================================
 
 //variables
  int num[6], largest, smallest=0; //variable declared  I set my array to 15 numbers max (or is that 16)? 
  int i = 0;       //array countdown
 

				
while(instream >> num[i]){  //brings in all values from file
	i=i++;
}


largest = num[0]; //array sets largest to first number at memory location 0.

smallest = num[0];  //set smallest to memory location 0.


{
	for (int i=1; i < 6; i++) // this for statement works with the below if statement (i++ is added to each array number).  
                       
	
	if (num[i] > largest) //if the next number in the array is larger than int largest then that number is set to int largest
	  largest = num[i];  //this sets int largest to whatever the next largest number is.
}



{
for (int i=1; i < 6; i++)  //Not sure why I need this again, but I guess the above for statement does not carry over.
	if(num[i] < smallest)  // if the next number is smaller, set int smallest to that number 
	smallest = num[i];        
}




//================================================================

 outstream << (largest) << " " << (smallest);  //sum and average written to output file
 cout << largest << " " << smallest << endl << endl;    //I was using this for verification
 
 instream.close();  
 outstream.close();
 
 system("pause");
 
 return(0);  
}
  
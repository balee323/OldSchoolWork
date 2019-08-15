
// Brian Lee
// C++ Programming, Jim Shain
// Homework #8, Topic 9 Part1 


#include <cstdlib>
#include <iostream>
#include <fstream>
using namespace std;


void sortem(int num_[]);						//my declared function for sorting from smallest to largest


 


  int main()
  {
  ifstream instream;						// input file stream (instream is the name of the created stream file).
  ofstream outstream;						// output file stream (outstream is the name of the created outstream file).
	
   //variables
  int largest=0, smallest=0;					//variable declared 
  
  int num[100];									//an array variable with 100 assignments


//============================================================
//File stream activity section 

 instream.open("numberlist.dat");								//input file opened
 outstream.open("output.out");									//output file created
 
 

 if (instream.fail()){											//this section checks for existence of input file.
cout << "Input file opening failed\n" << endl;				    //This is displayed if input file is missing.
system ("pause");
exit (1);
}

//================================================================

//Programmer Identification and program explaination section.
  
cout << endl;
cout << "// Brian Lee" << endl;
cout << "// C++ Programming, Jim Shain" << endl;
cout << "// Homework #8, Topic 9 Part1" << endl;

cout << "This program reads in numbers from an input file and \n"  //explains what program does
	<< "and results the numbers from smallest to largest \n"
	<< "to an output file." << endl << endl;

//================================================================

// data instreamed and assigned, and main funtion section:		


int i = 0;                                                 //array countdown
while(instream >> num[i]){                                 //brings in all values from file
	//cout << num[i] << " ";	                           //proof that all the numbers were streamed in and assigned.
	i=i++;                                                 //assigs each streamed input a one of the declared variables from one
	                                                       //of the above num[100].

}

sortem(num);                                               //functon call  

//cout << endl;
//cout  << num[0] << " " << num[1] << " " << num[2] << " " << " " << num[75] << " " << num[99] << endl; //proof that the sort works

smallest = num[0];
largest = num[99];


 
outstream  << "Largest #: " << (largest) << " and Smallest #: " << (smallest);					                                 //sum and average written to output file
cout << "Largest #: " << largest << " and Smallest #: "<< smallest << endl << endl;				//I was using this for verification
 
 instream.close();  
 outstream.close();
 
 system("pause");
 
 return(0);  

  }

//================================================================

 

  

//functions defined:

void sortem(int num_[])						//function brings in whole array for num
{
 int i, j, temp;							//local array variables declared
 for(i = 0; i < 100; i++) {                 //while counting loop starting at 0, and ends at 99 for i.
 for (j = i+1; j < 100; j++) {              //while counting loop sarting at i+1 or (1) and set to j.
 if (num_[j] < num_[i]) {                   //the meat of the function, if num_[j] is less than num_[i] then                                         // set temp equal to num_[i]
 temp = num_[i];							//set temp equal to num_[i].
num_[i] = num_[j];                          // swap num_i with num_[j].  There must be a 3rd temp varible for swapping.
num_[j] = temp;                             // finally set num_[j] equal to temp's value. And we are sorting                     

 }
}
}
}




// Brian Lee
// C++ Programming, Jim Shain
// Homework #8, Topic 9 Part2 


#include <cstdlib>
#include <iostream>
#include <fstream>
using namespace std;

 


  int main()
  {
  ifstream instream;						// input file stream (instream is the name of the created stream file).
  ofstream outstream;						// output file stream (outstream is the name of the created outstream file).
	
   //variables
    
  char names[25];           //an array variable with at least 25 assignments
  int num_of_names=0;
  int i=0;

//============================================================
//File stream activity section 

 instream.open("names.dat");						         	//input file opened
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
cout << "// Homework #8, Topic 9 Part2" << endl;

cout << "This program reads in names from an input file and \n"            //explains what program does
	<< "and results number of names to the screen. " << endl << endl;

//================================================================

// data instreamed and assigned, and main funtion section:		



	
while (instream >> names[i]) {                   //this loop works by retrieving numbers while numbers are present in the file. Nice
  num_of_names=num_of_names++;                //my counting function.  Works!!!!  Names are displayed funny on the screen though.
 i=num_of_names;
 }

  






 
outstream  << "number of names :" << num_of_names << endl;
cout << "number of names :" << num_of_names << endl << endl;				
 cout << names[25] << endl;

 instream.close();  
 outstream.close();
 
 system("pause");
 
 return(0);  

  }

//================================================================

 

  





// Brian Lee
// C++ Programming, Jim Shain
// Homework #11 , Topic 10 Part1 


#include <cstdlib>
#include <iostream>
#include <fstream>
#include <cctype>
#include <string>  //I left this off, and had a lot of problems.. hours wasted
using namespace std;

 




  int main()
  {


//================================================================

//Programmer Identification and program explaination section.
  
cout << endl;
cout << "// Brian Lee" << endl;
cout << "// C++ Programming, Jim Shain" << endl;
cout << "// Homework #11, Topic 10 Part1" << endl;

cout << "This program reads in names from an input file and \n"            //explains what program does
	<< "searches for a name as directed by the user. " << endl << endl;

//================================================================


  char decision;  // for program loop
  do{  // program repeat loop.
	  
       

  ifstream instream;						// input file stream (instream is the name of the created stream file).
  ofstream outstream;						// output file stream (outstream is the name of the created outstream file).
	
  

   //variables
    

  string names[1000];           //string with 1000 characters.   I had this set as char at first.  Headache!!!
  int num_of_names=1;           // dont need this now.
  int i=1;                       // my string counter
  string user_name;
  


//============================================================
//File stream activity section 

 instream.open("names.dat");						         	//input file opened
 outstream.open("output.out");									//output file created
 
 

 if (instream.fail()){											//this section checks for existence of input file.
cout << "Input file opening failed\n" << endl;				    //This is displayed if input file is missing.
system ("pause");
exit (1);
}

//========================================================

// data instreamed and assigned, and main funtion section:		
 	  

while (instream >> names[i]) {                   //this loop works by retrieving numbers while numbers are present in the file. Nice
i++;
num_of_names++;                //my counting function.  Works!!!!  Names are displayed funny on the screen though.
string str(names[i]);
}


cout << endl;
cout << " Please enter a name to locate. " << endl;
cout << " No response indicates name not found. " << endl;
cin >> user_name;
cout << endl << endl;


for(i; i > 0; i--){
if(user_name == names[i])
	cout << "Found!" << endl;
}





while(i > 0 ){                                  //this is the loop for displaying and creating all names while i is greater than 0.
outstream  << "names: " << names[i] << endl;
cout << "names :" << names[i] << endl << endl;				   //I cannot seem to get rid of that first blank space. tried for a while.
i--;
}





 instream.close();  
 outstream.close();
 
 
 
 cout << endl << endl;
	cout << "Press Y and enter to repeat or any key and enter to exit program. " << endl;  //I have been adding this loop to all my programs to help with de-bugging.
    cin >> decision;
	cout << endl;

  }while (decision == 'y' || decision == 'Y' );  //if decision is not equal to "lowercase n" then repeat program.
 
 return(0);  


  

//================================================================

 


  }


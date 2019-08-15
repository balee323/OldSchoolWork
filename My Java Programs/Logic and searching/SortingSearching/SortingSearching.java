/* Program: This program reads String data from a user selected file
 * Programmer: Brian Lee
 * 17 Sept 12
 * 
*/

import javax.swing.JOptionPane;
import java.io.*;


public class SortingSearching{

	public static void main(String []args) throws IOException{
	

  
  
  String[] FileData = new String[40];  //user selected file data stored in a string array.
  //String[] AlphaSort = new String[20];  //new string for alphabetical sorted string array 
  
  String SelectedFile;  //user infile name
  String SelectedOutFile;  // user outfile name
 		

   //functions being used
	
	SelectedFile = getInName();
	
	SelectedOutFile = getOutName();
	
	FileData = getFile(SelectedFile, SelectedOutFile);
   
	//AlphaSort = getSort(UserFile);
	
	getSort(FileData, SelectedOutFile);
	
				
  }//main
		
		

//==============================================================================
//********************************************************************************
//function1  input name 
//==============================================================================	
			

	/* Function asks for input file.
	   Pre: 
	   post: input file name.
	 */	
		
	
	public static  String getInName() {
	
		
		String inputStr;  //variable used as temporary string reference 
		String filename; //string used to reference user entered file name
	
		
		
		
		do{
		
		
		  filename = JOptionPane.showInputDialog("Plese enter a file to open including the .txt extension or enter 'stop': "); //getting file name from user
		   
	   
				
		   	
				while (filename == ("stop")){   //loop for stopping filename input request.
				 
				 System.exit(0);   //stops program
				 
				 }//close of termination loop.
				
		}while(filename == null);  //choose do while loop so the inputStr is referenced to the first line of data before comparison.
		
		
		
		
return (filename);
	
		
}// close funtion inFile			
		
					
		

//==============================================================================
//********************************************************************************
//function2   output name
//==============================================================================		
		
	
	/* Function asks for input file.
	   Pre: 
	   post: input file name.
	 */	


		public static  String getOutName() {
	
		
		String inputStr;
		String filenameOut; //string used to reference user entered file name
		
		
		
 		do{
		
		filenameOut = JOptionPane.showInputDialog("Plese create a new file including the .txt extension or enter 'stop': "); //getting file name from user
		   
	   

		
		   	
				while (filenameOut == ("stop")){   //loop for stopping filename input request.
				 
				 System.exit(0);   //stops program
				 
				 }//close of termination loop.
				
		}while(filenameOut == null);  //choose do while loop so the inputStr is referenced to the first line of data before comparison.
		
	return (filenameOut);
	
		
}// close funtion outfile		
		
//==============================================================================
//********************************************************************************
//function3   read in data and put in string array
//==============================================================================	
			
		
		
	/* Function reads in file and stores data in a string array.
	   Pre: user select file is opened
	   post: String Array containing data from user selected file
	*/	
		
	
	public static  String[] getFile(String filename,String filenameOut) throws IOException{
	
		
		String[] FileData = new String [40];
		String inputStr;
		File OpenFile;
		
				
	   int i=0;
		
				
		
		
		 BufferedReader inFile= new BufferedReader( new FileReader(filename));  //infile parameters set using filename as variable
	
		
		 inputStr = inFile.readLine();  //inputStr is set equal to the first line of the input file

		
		
			for(i=0; inputStr != null; i=i+1){
	
		
			     FileData[i] = inputStr; 	
		
		
		        		
	           System.out.println(FileData[i]+"\n");   //string array data shown in console window. 
		
		       inputStr = inFile.readLine();//must set inputStr to next data as indicated by the pointer.

		
		         }//close input loop
		
		
		
		
		   for(i=0; FileData[i] != null; i=i+1){
		
		       System.out.println(FileData[i]+"\n");   //string array data shown in console window. 
		
		      }// close loop.
		
											
			
		
	    	inFile.close();  //closes infile.  This statement must be before return statement.
					
					
	  return (FileData);  //FileData string is returned
	  		
		
		
		
		}//close function getUserFile
		
	




//==============================================================================
//********************************************************************************
//function 4  alphabetical sort string array
//==============================================================================	
			
		
		
	/* Function sorts alphabetically the string data from the User selected file.
	   Pre: 
	   post: String Array data is returned in alphabetical order.
	*/ 	
		
	
	// public static  String[] getSort(String UserFile_func) throws IOException{
	
	
	 public static  void getSort(String[] UserFile_func, String userOutfile) throws IOException{
	
	
	
	
	   
		String Temp;  //store temp sorted file
		String[] SortedArray = new String[40]; //store sorted array
		
		char word1;
		char word2;
			
	   int i;  //general purpose counting variable
		int m;
		int j;  //for letter increment
		int k; //for letter increment	
				
			
		PrintWriter outFile = new PrintWriter( new FileWriter (userOutfile));  //creates new file

		
		//outFile.println("hello");		
		
			
			
		
		
		for (i=0; UserFile_func[i] != null; i++){  //loop 1 for increment array elements starting at 0.
																		   																 			 
					  for (m=1; UserFile_func[m] != null; m++){  //loop 2 for incrementing array elements starting at 1.
					  
					     for (j=0; j < UserFile_func[i].length(); j++){ //Loop 3 for incrementing first letter									
					     						 																									 													
														 
							               	
												word1 = UserFile_func[i].charAt(j);
												
												word2 = UserFile_func[m].charAt(j);
																
																
											System.out.println(word1+" "+word2);  //string array data shown in console window			 				 
											
												  									      																														 
									//if ((UserFile_func[i].charAt(j)) > (UserFile_func[i+1].charAt(j))){ //for comparing characters in strings
		         
					           
								   if (word1 > word2){ //for comparing characters in strings

					                           			 								 
										 Temp = UserFile_func[i];  // set word at position i to temp.   (i to temp)
										 										 									 
										 UserFile_func[m] = UserFile_func[i];  //set word at position m to i.  (m to i)
										 
										 Temp = UserFile_func[m]; 		       // set word at temp position to m. (temp to m)               			          
																									
											System.out.println(UserFile_func[i]+UserFile_func[m]);  //string array data shown in console window.
											
											
											    //if (UserFile[i].charAt(j) == UserFile[i+1].charAt(j)){
											   
												  		//if(UserFile[i].charAt(j) > UserFile[i+1].charAt(j)){
												    													    
																
															       //   }
														  	  //  }	
																
																														       	 											
											              }//close if statement
											
											
																																   																																					 											 
											   } //close loop 3
											  										  										  	
										   	//  BuffTemp[i] = BuffTemp[i];
											  
						           }  //close loop 2									  
									  
				                     
				          outFile.println(UserFile_func[i]);	
				          System.out.println(UserFile_func[i]);   //string array data shown in console window.		  
	
				}// close loop 1		
						
		
		
			
		
	
					
		 
		 outFile.close();			
	  		
		
		
		
		}//close function


 


//**************************************************



		
}//class
		
		
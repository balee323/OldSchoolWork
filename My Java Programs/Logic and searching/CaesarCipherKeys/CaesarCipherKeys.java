/* Program: This program reads String data from a user selected file
 * Programmer: Brian Lee
 * 17 Sept 12
 * 
*/

import javax.swing.JOptionPane;
import java.io.*;


public class CaesarCipherKeys{

	public static void main(String []args) throws IOException{
	

  
  
  String[] FileData = new String[10];  //file data stored in a string array.
  String[] TrimmedData = new String[15];  //file data stored in a string array.
 
   
  
   //functions being used
	
		
	FileData = getFile();
   
	
	TrimmedData = getTrim(FileData);
	
		
	PrintResults(TrimmedData); 
	
	
	System.exit(0);
	
				
  }//main
		
		

		

		
//==============================================================================
//********************************************************************************
//function1   read in data and put in string array
//==============================================================================	
			
		
		
	/* Function reads in file and stores data in a string array.
	   Pre: user select file is opened
	   post: String Array containing data from user selected file
	*/	
		
	
	public static  String[] getFile() throws IOException{
	
		
		String inputStr;
		String[] FileData = new String [10];
		int i;
					
		
		
		 BufferedReader inFile= new BufferedReader( new FileReader("keys.txt"));  //infile parameters set using filename as variable
						
		 inputStr = inFile.readLine();  //inputStr is set equal to the first line of the input file and is used by for loop to check for null
      	
		
		  for (i=0; inputStr != null; i=i+1){ //The first line of input is checked for null value
		  
		 		      FileData[i] = inputStr;	  //numlist array position i is set to the value of inputStr
		  		    	
           		
		      inputStr = inFile.readLine();//must set inputStr to next data as indicated by the pointer.
		
          				     
			   System.out.println(FileData[i]);   //string array data shown in console window
			                
			    
			}//close input loop
		
	          
		System.out.println("The count is: "+i);		 
				 				 
		
		//System.out.println(FileData.length);  this value cannot be changed p.464
	
															
		
		inFile.close();  //closes infile.  This statement must be before return statement.
					
					
	return (FileData);  //FileData string is returned
	  		
		
		
		
		}//close function
		
	

//==============================================================================
//********************************************************************************
//function 2  trim spaces and duplicate letters out of strings 
//==============================================================================	
					
		
	/* Function removes white spaces and duplicate letters from infile array
	   Pre: String array required
	   post:white spaces and duplicate letters removed from infile array and returned to main
	*/ 	
		
	
		
	 public static  String[] getTrim(String[] FileData_func) throws IOException{
		
		String[] DataTrim_func = new String[20];
		StringBuffer[] BuffTemp = new StringBuffer[20];
			
	   int i;  //general purpose counting variable
		int j;  //for letter increment
		int k; //for letter increment
	
	
		
					
	 for (i=0; FileData_func[i] != null; i++){
		
				DataTrim_func[i]=FileData_func[i].replace(" ", "");  //this function call removes all the white spaces
												
				System.out.println(DataTrim_func[i]);   //string array data shown in console window.
				
				  					 }//close loop										
																																														
								
				
				for (i=0; DataTrim_func[i] != null; i++){  //loop 1 for incrementing string array
																	
					  BuffTemp[i] = new StringBuffer(DataTrim_func[i]);  //string converted to stringbuffer type					   																 
					 
					  for (j=0; j < BuffTemp[i].length()-1; j++){ //Loop 2 for incrementing first letter									
					     						 																									 													
							 for (k=j+1; k < BuffTemp[i].length(); k++){  //Loop 3 for incrementing second letter							 				 
												  									      																														 
									if (BuffTemp[i].charAt(j) == BuffTemp[i].charAt(k)){ //for comparing characters in strings
		                                    			 								 
										    BuffTemp[i] = BuffTemp[i].deleteCharAt(k);  //char at postion k deleted from stringBuffer object   		                      			          
																									
											System.out.println(BuffTemp[i]);  //string array data shown in console window.
																														       	 											
											   }//close if statement
																																					 											 
											 } //close loop 3
											  										  										  	
											  BuffTemp[i] = BuffTemp[i];
											  
						           }  //close loop 2									  
									  
				          DataTrim_func[i] = BuffTemp[i].toString();	//stringbuffer converted to string            
				  
				         // System.out.println(DataTrim_func[i]);   //string array data shown in console window.		  
	
				}// close loop 1

							 
							//performing this nested loop twice to remove remaining duplicate letters.
							
			for (i=0; DataTrim_func[i] != null; i++){  //loop 1 for incrementing string array
																	
					  BuffTemp[i] = new StringBuffer(DataTrim_func[i]);  //string converted to stringbuffer type					   																 
					 
					  for (j=0; j < BuffTemp[i].length()-1; j++){ //Loop 2 for incrementing first letter									
					     						 																									 													
							 for (k=j+1; k < BuffTemp[i].length(); k++){  //Loop 3 for incrementing second letter							 				 
												  									      																														 
									if (BuffTemp[i].charAt(j) == BuffTemp[i].charAt(k)){ //for comparing characters in strings
		                                    			 								 
										    BuffTemp[i] = BuffTemp[i].deleteCharAt(k);  //char at postion k deleted from stringBuffer object   		                      			          
																									
											System.out.println(BuffTemp[i]);  //string array data shown in console window.
																														       	 											
											   }//close if statement
																																					 											 
											 } //close loop 3
											  										  										  	
											  BuffTemp[i] = BuffTemp[i];
											  
						           }  //close loop 2									  
									  
				          DataTrim_func[i] = BuffTemp[i].toString();	//stringbuffer converted to string            
				  
				          System.out.println(DataTrim_func[i]+"\n");   //string array data shown in console window.		  
	
				}// close loop 1				
							
	
		return (DataTrim_func);
				
		}//close function 


//==============================================================================
//********************************************************************************
//function 3  create cipher
//==============================================================================	


	
	/* Function creates and saves to file a translation table based on the cipher keys..
	   Pre: File read into string array
	   post: String data is converted to a translation table and saved to a file
	*/	
		

	
	 public static  void PrintResults(String[] DataTrim_func) throws IOException{
		
		String[] TempStr = new String [10];  //temporary string array to store edited strings
	   int i; //general counter
		int j;  //for letter increment
		int k; //for letter increment
		
				
	   int[] length = new int [10];  //array for length of strings
		int[] fillLength = new int [10]; //array for the length of filler alphabet needed to comlete cipher table
		char[] lastLetter = new char [10]; //array for storing the last letter in each string
		
			
		StringBuffer[] cipher = new StringBuffer [10];  // used to add alphabet to end of keyword
		
		StringBuffer[] BuffTemp = new StringBuffer[20];// used to temporary store string while duplicate letters are removed (from adding alphabet).
		
		String Alphabet =("ABCDEFGHIJKLMNOPQRSTUVWXYZ");  //string to hold alphabet
		
		
		
		PrintWriter outFile = new PrintWriter( new FileWriter ("translations.txt"));  //creates new file

			
			
		for (i=0; DataTrim_func[i] != null; i++){

			length[i] = DataTrim_func[i].length(); //calcuilates the 
			
			fillLength[i] = 26 - length[i];  //calculates how much filler is needed
 			
			lastLetter[i] = DataTrim_func[i].charAt(length[i]-1);
			
			System.out.print("length is: "+length[i]+"\n");
			System.out.print("filler is: "+fillLength[i]+"\n");
			System.out.print("last char is: "+lastLetter[i]+"\n"+"\n");
			
			}
			
			
		for (i=0; i <= fillLength[i]; i++){
			
			   
			   cipher[i] = new StringBuffer(DataTrim_func[i]);
				
				cipher[i] = cipher[i].insert(length[i], Alphabet);
			
			
			System.out.print("Cipher is: "+cipher[i]+"\n"+"\n");
			
			DataTrim_func[i] = cipher[i].toString();
			
			}
			
			
			
			//performing this nested loop twice to remove remaining duplicate letters.
							
			for (i=0; DataTrim_func[i] != null; i++){  //loop 1 for incrementing string array
																	
					  BuffTemp[i] = new StringBuffer(DataTrim_func[i]);  //string converted to stringbuffer type					   																 
					 
					  for (j=0; j < BuffTemp[i].length()-1; j++){ //Loop 2 for incrementing first letter									
					     						 																									 													
							 for (k=j+1; k < BuffTemp[i].length(); k++){  //Loop 3 for incrementing second letter							 				 
												  									      																														 
									if (BuffTemp[i].charAt(j) == BuffTemp[i].charAt(k)){ //for comparing characters in strings
		                                    			 								 
										    BuffTemp[i] = BuffTemp[i].deleteCharAt(k);  //char at postion k deleted from stringBuffer object   		                      			          
																									
											System.out.println(BuffTemp[i]);  //string array data shown in console window.
																														       	 											
											   }//close if statement
																																					 											 
											 } //close loop 3
											  										  										  	
											  BuffTemp[i] = BuffTemp[i];
											  
						           }  //close loop 2									  
									  
				          DataTrim_func[i] = BuffTemp[i].toString();	//stringbuffer converted to string            
				  
				          System.out.println(DataTrim_func[i]+"\n");   //string array data shown in console window.		  
	
				}// close loop 1				

			
			   outFile.println("\n"+"\n");
				outFile.println("Caesar Cipher Keys"+"\n"); //header sent to file
				outFile.println("\n"+"\n");
		
			
			
			for (i=0; DataTrim_func[i] != null; i++){
		
				
				TempStr[i]=DataTrim_func[i].replace("", " ");  //this function call adds the white spaces between each letter

				TempStr[i] = TempStr[i].trim();  //removes all leading and trailing white spaces
				
				System.out.println("A B C D E F G H I J K L M N O P Q R S T U V W X Y Z");			
				
					outFile.println("A B C D E F G H I J K L M N O P Q R S T U V W X Y Z");  //sent to file
				
			 
			   System.out.println(TempStr[i]);   //string array data shown in console window.
				
				System.out.print("\n"+"\n");		
            
					outFile.println(TempStr[i]);  //string array sent to file.
			 
			 		outFile.println("\n"+"\n");
																
					
				}// loop
			
			
			
			
			
							
		 
		 outFile.close();			
	  		
		
		
		//return(DataTrim_func);
		
		
		}//close function 





  


//**************************************************



		
}//class
		
		
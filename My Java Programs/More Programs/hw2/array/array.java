/* Program: This program reads integers from a file and saves altered data to a new file
 * Programmer: Brian Lee
 * 6 Sept 12
 * 
*/

import javax.swing.JOptionPane;
import java.io.*;


public class array{

	public static void main(String []args) throws IOException{
	

  //list of integer arrays to store integers read in from 3 files
  
  int[] randomNums = new int[10];
  int[] tripleNums = new int[10];
  int[] sums = new int[10];
  
 		
 
 //3 functions for reading in files.  I was unable to use 1 function to read in all 3 files.
	
	randomNums = getRandomNums();
   tripleNums = getTripleNums(randomNums);
	sums = getSums();
	printAll(randomNums, tripleNums, sums);
	
				
		}//main
		
		
//==============================================================================
//********************************************************************************
//function1
//==============================================================================	
			
		
		
	/* Function reads in file from randomNums.txt, puts the data into an integer array.
	   Each number in the integer array is then tripled.
	   Pre: randomNums.txt is opened
	   post: outfile to tripleNums, numlist1 returned
	*/	
		
	
	public static  int[] getRandomNums() throws IOException{
	
		
		
		
		String inputStr;  //this reference variable will be a temporary holder for the read in integers
		int[] numlist1 = new int [10];  //integer numlist1 is an integer array that will be used to store values read in.
		
						
		PrintWriter outFile = new PrintWriter( new FileWriter ("tripleNums.txt"));  //creates new file
	
		BufferedReader inFile= new BufferedReader( new FileReader("randomNums.txt"));  //opens file
		
					
					
		
	   inputStr = inFile.readLine();  //inputStr is set equal to the first line of the input file "numlist1.txt"

 //==============loop 1===================================		
		
		int i = 0;  // the counter , i, is set to zero.
		while (inputStr != null){  
				
													
					numlist1[i] = Integer.parseInt(inputStr);  //numlist array position i is set to the value of inputStr.
				
				
					i=i+1;  //each pass through the loop increase the value of i.
							
							
			inputStr = inFile.readLine();	
							
					}//close loop		
				
					
 //==============loop 2===================================					
					
			//this segment of code will display all the value of the integer array in console window.		
		 	
			
			int j;  //counting variable for system println loop
			
			for(j=0; j < 10; j++){  //counting loop for console display to verify array data
	                                           
			
				//JOptionPane.showMessageDialog(null,numlist1[j]); //used message box when troubleshooting 
			
				System.out.println(numlist1[j]); //displays the array list in the console screen.
	              				
			}//close loop
			
  
 //==============loop 3===================================
		 		 
				 int k; //counting variable for calculation and outfile loop
				 
				 for (k=0; k < 10; k++){ //counting loop for trippling the integer array values.
				 int triple = 0;  //trippling variable.
				 
				    triple = numlist1[k] * 3;  //multiplies random number list by 3
				 				 
				 outFile.println(triple);  //an integer array is not needed since on variable at a time is going to the file
				 
				 }//closes loop
				 
//====================================================			 
		 
		 inFile.close();  //closes infile.
		 outFile.close(); //closes outfile.
		 
 return (numlist1);	//returns random number list
	

	}//function inputData
	
	
	
//==============================================================================
//********************************************************************************
//function2
//==============================================================================	
 /* Function reads in file from tripleNums puts the data into an integer array.
    Summation of randomNums and tripleNums.
	   Pre:  tripleNums.txt is opened
	   post: numlist2 returned
	*/	
			
	
	
	public static  int[]  getTripleNums (int[] randomNums_func) throws IOException{
		
		
		
		String inputStr;  //this reference variable will be a temporary holder for the read in integers
		int[] numlist2 = new int [10];  //integer numlist2 is an integer array that will be used to store values read in.
	
						
		PrintWriter outFile = new PrintWriter( new FileWriter ("sums.txt"));
		BufferedReader inFile= new BufferedReader( new FileReader("tripleNums.txt"));
	
							
					
		
	   inputStr = inFile.readLine();  //inputStr is set equal to the first line of the input file "numlist2.txt"
		
		
  //==============loop 1===================================
		
		int i = 0;  // the counter , i, is set to zero.
		while (inputStr != null){  
				
													
					numlist2[i] = Integer.parseInt(inputStr);  //numlist array position i is set to the value of inputStr.
				
				
					i=i+1;  //each pass through the loop increase the value of i.
							
							
			inputStr = inFile.readLine();	
							
					}//close loop		
				
					
 //============ loop2==============================					
					
			//this segment of code will display all the value of the integer array in console window.		
		 	
			
			int j = 0;  //counting variable
			
			for(j=0; j <10 ; j++){  
	                                           
			
				//JOptionPane.showMessageDialog(null,numlist1[j]); //used message box when troubleshooting 
			
				System.out.println(numlist2[j]); //displays the array list in the console screen.
	      
			}
  
 //==============loop3=========================== 
		 	
			int k; //counting variable for calculation and outfile loop
				 
				 for (k=0; k < 10; k++){ //counting loop for trippling the integer array values.
				 
				 int sums = 0; //variable to store the sum of triple and random each pass through loop
				 int random = randomNums_func[k];  //int random is set equal to postion k of array randomNums_func
				 int triple = numlist2[k];         //int triple is set equal to postion k of array numlist2
				 
				 
				 
				 sums = (triple + random);  //addition of triple and random = sum
				 				 
				 outFile.println(sums);
				 
				 }//closes loop
				 
//==============================================
						 
		 
		 inFile.close();  //closes infile.
		 outFile.close(); //closes outfile.
		 
 return (numlist2);  //returns triple number list.
	

	}//function inputData

  

//==============================================================================
//********************************************************************************\
//function 3
//==============================================================================	
	

/* Function reads in file from sums puts the data into an integer array.
	   Pre:  sums.txt is opened
	   post: numlist3 returned
	*/	
		
	
	public static  int[] getSums() throws IOException{
	
		
		
		
		String inputStr;  //this reference variable will be a temporary holder for the read in integers
		int[] numlist3 = new int [10];  //integer numlist1 is an integer array that will be used to store values read in.
		
						
			
		BufferedReader inFile= new BufferedReader( new FileReader("sums.txt"));  //opens file
									
	   inputStr = inFile.readLine();  //inputStr is set equal to the first line of the input file "numlist1.txt"
		
	
	
//=============loop1=================================================================	
	
		
		int i = 0;  // the counter , i, is set to zero.
		while (inputStr != null){  
				
													
					numlist3[i] = Integer.parseInt(inputStr);  //numlist array position i is set to the value of inputStr.
				
				
					i=i+1;  //each pass through the loop increase the value of i.
							
							
			inputStr = inFile.readLine();	
							
					}//close loop		
				
					
//===================loop2===========================================================	
					
					
			//this segment of code will display all the value of the integer array in console window.		
		 	
			
			int j;  //counting variable for system println loop
			
			for(j=0; j < 10; j++){  //counting loop for console display to verify array data
	                                           
			
				//JOptionPane.showMessageDialog(null,numlist1[j]); //used message box when troubleshooting 
			
				System.out.println(numlist3[j]); //displays the array list in the console screen.
	              			
				
			}//close loop
  		 		 
				 								 
		 
		 inFile.close();  //closes infile.  No outfile created since just loading sums list into an array.
		 
		 
 return (numlist3);	
	

	}//function inputData
	



//==============================================================================
//********************************************************************************
//==============================================================================	
	

public static void printAll(int[] randomNums_func, int[] tripleNums_func, int[] sums_func) throws IOException{


										
		PrintWriter outFile = new PrintWriter( new FileWriter ("outputfile.txt"));
		
		
		
			//print heading to outputfile
 
		outFile.printf("%10s%10s%10s%10s","array","random","triple","sums");
		outFile.println("");
		outFile.print("__________________________________________________________________________");
		outFile.println("");
		outFile.println("");
			         	 	
						
		
		
				 	int k = 0; //counting variable for outfile loop column 2
				 
				 for (k=0; k < 10; k++){ //counting loop for trippling the integer array values.
				 
						 				 
		outFile.println("       "+k+"       "+randomNums_func[k]+"         "+tripleNums_func[k]+"          "+sums_func[k]);
				      
				    
				 

				 
					 }//closes loop

	
	outFile.close(); //closes outfile.
	
	

}//closes function

//==============================================================================


}//class
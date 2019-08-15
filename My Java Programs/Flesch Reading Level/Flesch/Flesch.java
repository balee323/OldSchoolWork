/* Program: This program determines the reading comprehension level for written documents.
 * Programmer: Brian Lee
 * 1 Oct 12
 * 
*/

import javax.swing.JOptionPane;
import java.io.*;
import java.lang.Object;
import java.util.StringTokenizer;


public class Flesch{

	public static void main(String []args) throws IOException {
	
	
	
	

    
  String[] FileData = new String[300];  //file data stored in a string array.
  
  String[] SingleWords = new String[800];
  
  int ReadingLevel;
  
   
  //testing ==================
  
 //  String[] TestWords = {"Four", "score", "and", "seven", "years", "ago", "our", "fathers", null};
   		

 // String TestSent = "BY a great forest dwelt a poor wood-cutter with his wife and his two children.  " 
              //       + "The boy was called Hansel and the girl Gretel. ";

 //==================================
 
 
        //functions being used
	
	

	
	FileData = getFile();


  SingleWords = getWords(FileData);
  
  
  ReadingLevel = getReadingLevel(SingleWords);
  
  
 //==testing calls ======= 
  
  
// SingleWords = getWords(TestSent);
  
 //ReadingLevel = getReadingLevel(TestWords);  
 	
	
 //============================	
	
	
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
	
		
		String[] FileData = new String [300];
		String inputStr;	//
	   int i;   //general counting variable
		String filename; //string used to reference user entered file name
	
	
		do{
		
		
		       filename = JOptionPane.showInputDialog("Plese enter a file to open including the .txt extension or enter 'stop': "); //getting file name from user
		     				
		   	
				 while (filename == ("stop")){   //loop for stopping filename input request.
				 
				    System.exit(0);   //stops program
				 
				     }//close of termination loop.
				 
				
	   	}while(filename == null);  //choose do while loop so the inputStr is referenced to the first line of data before comparison.
		
		 
		 BufferedReader inFile= new BufferedReader( new FileReader(filename));  //infile parameters set using filename as variable
			
		 inputStr = inFile.readLine();  //inputStr is set equal to the first line of the input file


		for (i = 0; inputStr != null; i = i + 1){
		    	 				
		     inputStr = inFile.readLine();//must set inputStr to next data as indicated by the pointer.
		
		     FileData[i] = inputStr; 		
		
	       	}//close input loop
		
	
		for (i = 0; FileData[i] != null; i = i + 1){
		
		   System.out.println(FileData[i]);   //string array data shown in console window.
			 
			    }// close loop.
			
		
		inFile.close();  //closes infile.  This statement must be before return statement.
					
					
	return (FileData);  //FileData string is returned
	  		
		
		
		}//close function getUserFile		
		

//==============================================================================	


public static String[] getWords(String[] FileData_func){



	String[] DataTrim = new String[500];
	String tempTrim;
	String[] Words = new String[800];
 
   int i;
   
   for (i=0; FileData_func[i] != null; i = i +1){

		tempTrim = FileData_func[i].replace(".", "");  //this function call removes all the white spaces
		DataTrim[i] = tempTrim;
		
		tempTrim = DataTrim[i].replace(",", "");  //this function call removes all the white spaces
		DataTrim[i] = tempTrim;
		
		tempTrim = DataTrim[i].replace("(", "");  //this function call removes all the white spaces
		DataTrim[i] = tempTrim;
	  
	   tempTrim = DataTrim[i].replace(")", "");  //this function call removes all the white spaces
		DataTrim[i] = tempTrim;
	  
	   tempTrim = null;

   }//for
 
    
 //StringTokenizer[] docTokenized = new StringTokenizer(DataTrim[i])[800];
 
 // StringTokenizer[] docTokenized ;
 	
	   
		for (i=0; DataTrim[i] != null; i = i + 1){
	      
				   StringTokenizer[] docTokenized;
					docTokenized[i] = new StringTokenizer(DataTrim[i]);
			  
      
		while (docTokenized[i].hasMoreTokens()){
					  Words[i] = docTokenized[i].nextToken();
					  System.out.println("tokens: " + Words[i]);
					  i = i + 1;
					  }
		
		//docTokenized = null;

      }

  /*

				String DataTrim;
				String tempTrim;
				String[] Words = new String[800];
			
				tempTrim=FileData_func.replace(".", "");  //this function call removes all the white spaces
				DataTrim = tempTrim;
				
				tempTrim=DataTrim.replace(",", "");  //this function call removes all the white spaces
				DataTrim = tempTrim;
				
				tempTrim=DataTrim.replace("(", "");  //this function call removes all the white spaces
				DataTrim = tempTrim;
			  
			   tempTrim=DataTrim.replace(")", "");  //this function call removes all the white spaces
				DataTrim = tempTrim;
			  


 
 StringTokenizer docTokenized = new StringTokenizer(DataTrim);
 	    
		  int i = 0;
		while (docTokenized.hasMoreTokens()){
		  Words[i] = docTokenized.nextToken();
		  System.out.println("tokens: " + Words[i]);
		  i = i + 1;
		  }
		

  */



 

   



  return (Words);


  }//function




















//==============================================================================		


/*
public static int getReadingLevel(String[] TestWords){ 

   int syllables;
	
   
   
	getSyllables(TestWords);
	
  //syllables = getSyllables(TestWords);
  
   
  
  //JOptionPane.showMessageDialog(null,"Number of Syllables: " + totalSyll);

  return (50);

 */




public static int getReadingLevel(String[] singleWord_func){ 

  	 int syllables;
	
   
   
			//getSyllables(singleWords);
	
  	syllables = getSyllables(singleWord_func);
  
   
  
  //JOptionPane.showMessageDialog(null,"Number of Syllables: " + totalSyll);

  return (50);

}//function


//==============================================================================		




 public static int getSyllables(String[] Words_func){


  Word[] MyWord = new Word[800];   //create a word object


	   int syllCount = 0;
		int tempCount;
	   
	   int i;


  // /*

  for (i = 0; Words_func[i] != null; i = i + 1){
	 
			tempCount = 0;
			 
		   System.out.println("test words: " + Words_func[i]);
			 
			MyWord[i] = new Word();
			  	
			MyWord[i].setWord(Words_func[i]);
			
			MyWord[i].isVowel();
			
			tempCount = MyWord[i].countSyllables();
				
			//System.out.println("syllables: " + tempCount);
				
			syllCount = syllCount + tempCount;
				
			System.out.println("syllables: " + tempCount);

	
	}// for
	
 System.out.println("total syllables: " + syllCount);
	
	 // */
 
 
   /*	
	
	
	String Word1 = "helllooooooo"; 	
	
	Word MyWord = new Word();  
	 	
	MyWord.setWord(Word1);
	
	tempCount = MyWord.countSyllables();
	
	JOptionPane.showMessageDialog(null,"here is the returned word: " + MyWord.getWord());
	
	MyWord.isVowel());
	
	JOptionPane.showMessageDialog(null,"Number of Syllables: " + MyWord.countSyllables());
	
	System.out.println("syllables: " + tempCount);
 
   */
	
	
	

	
	 // JOptionPane.showMessageDialog(null,"here is the returned word: " + MyWord.getWord());
	

	
	// JOptionPane.showMessageDialog(null,"Are any Vowels present: " + MyWord.isVowel());
	 
	 
	// JOptionPane.showMessageDialog(null,"Number of Syllables: " + MyWord.countSyllables());
	
	




	
	return (syllCount);



}//close syllable Count



//==============================================================================		



		
}//class


import javax.swing.JOptionPane;
import java.io.*;
import java.lang.Object;


public class WordTest{

	public static void main(String []args) {
	


   
	//here are all my test words!  So far so good.
	
	
	String Word1 = "Four"; 	
	
//	String[] TestWords = {"Four", "score", "and", "seven", "years", "ago", "our", "fathers", null};
	
//	String Word1 = "Cancelled";  // counted as 2  Correct!!!!

	
	//  String Word1 = "Caeled";  // counted as 1  Correct!!!!

	
 //  String Word1 = "CountED";  //still counted 2 (ignores case).

 // String Word1 = "Countle";  //counted 3 so this is almost right.
  
// String Word1 = "Counted";   // still need to work on this. counted 2, should be 1 according to the spec 
  
 // String Word1 = "Canned";   //counted 1 correct
  
 // String Word1 = "Heelloes";   // still need to work on this.  counts 3 should be 2
  
// String Word1 = "Helloes";   //counted 2 
  
 // String Word1 = "Hello";  //counted 2
  
  // String Word1 = "Hee";  //counted 1
	
	// String Word1 = "eee";  //counted 1
	
  
  
 //create a word object
 
 	Word MyWord = new Word();
	
	
	MyWord.setWord(Word1);
	
	

	
	  JOptionPane.showMessageDialog(null,"here is the returned word: " + MyWord.getWord());
	

	
	 JOptionPane.showMessageDialog(null,"Are any Vowels present: " + MyWord.isVowel());
	 
	 
	 JOptionPane.showMessageDialog(null,"Number of Syllables: " + MyWord.countSyllables());
	
	


    

	
	System.exit(0);
	
	
	
	}//main
	
}//class
  
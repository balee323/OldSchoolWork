

import javax.swing.JOptionPane;
import java.io.*;
import java.lang.Object;


public class WordTest{

	public static void main(String []args) {
	

  
  
  String Word1 = "Hello";
  
 //  String Word1 = "Hel";
  
  String Word2 = "Letter";
  
  
  
 //create a word object
 
 	Word MyWord = new Word();
	
	
	MyWord.setWord(Word1);
	
	

	
	  JOptionPane.showMessageDialog(null,"here is the returned word: " + MyWord.getWord());
	

	
	 JOptionPane.showMessageDialog(null,"Are any Vowels present: " + MyWord.isVowel());
	 
	 
	 JOptionPane.showMessageDialog(null,"Number of Syllables: " + MyWord.countSyllables());
	
	




	
	System.exit(0);
	
	
	
	}//main
	
}//class
  
/* Program: This program randomly choose any amount of vowels.
 * Programmer: Brian Lee
 * 6 Sept 12
 * 
*/

import javax.swing.JOptionPane;
import java.util.Random;




public class vowels{




	public static void main(String []args){
	
	int UserChoice;               //variable for user to enter how many random vowels will be displayed
	String VowelStr;                //variable random vowel returned from function getVowelRand

	
	
	
		UserChoice = getCurrentChoice ();   //function for user input on number of vowels to display
		
		 VowelStr = getVowelRand (UserChoice);  //calculation to deterime random vowel and return a string of vowels
		
		showDisplay (UserChoice, VowelStr);  //function displaying output. no value returned
	
		
		
		//JOptionPane.showMessageDialog(null, "Current Tuition, rate, and years are : "+tuition+"  "+rateIncrease+" "+years);
		
		//JOptionPane.showMessageDialog(null, "Projected Tuition for "+years+" years is : " +totalCost);

		
		
		}//main
		


//==============================================================================
//********************************************************************************
//function1
//==============================================================================	
 /* Function asks user for input on number of randomly generated vowels to display.
   	Pre: none
	   post: user choosen value
	*/	
		
		
		
	public static int getCurrentChoice (){
		
		
		String input;  //reference variable for user input
			
		input = JOptionPane.showInputDialog("Please enter the amount of random vowels to be shown. ");  //gets user info
	
			

		   int getCurrentChoice_func;  // local variable declared. user entered tuition.

		getCurrentChoice_func = Integer.parseInt(input);  //user data converted from sting to double.
		
		return getCurrentChoice_func;  //user entered data is returned to main function.

 	

	}//function inputData
	
	
//==============================================================================
	
//==============================================================================
//********************************************************************************
//function2
//==============================================================================	
 /* Function generates random variable
    	Pre: none
	   post: returns random vowel string
	*/		
	
	
	
	
	
  
public static String getVowelRand (int choice){  //function for generating a random number based on user endered number
		
	int random1;	
	String S ="AEIOU";  //string that contains "AEIOU"
	char letter;	     //reference variable to link randomly choosen number to corresponding placement on the sting AEIOU
	String letterStr =" ";
	
		
  
 
 while(choice > 0){
  
  Random randomVowels = new Random();  //random value initialized
  
  random1 = randomVowels.nextInt(4);  //random value is of integer format and choice is from 0-4 (5 choices)
  
  System.out.println(random1);
		
	letter = S.charAt(random1);  //random interger is used to selected corresponding character in the string AEIOU
	
	System.out.println(letter);
		
	choice = choice -1;
	
		
	letterStr = letter + letterStr;
	
	
	
	System.out.println(letter);
	
	}
		
					

  //JOptionPane.showMessageDialog(null,letterStr);  //used
		 
return(letterStr);  //variable letter is returned to main.
 	


	}//function inputData




//====================================================


public static void showDisplay (int UserChoice_func, String VowelStr_func){
		





	JOptionPane.showMessageDialog(null, "You choose to display AEIOU randomly " + UserChoice_func+" times. Enjoy!");
		
	JOptionPane.showMessageDialog(null, VowelStr_func);

		
		 
	
   



	}//function inputData


//============================================================================








}//class
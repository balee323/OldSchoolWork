/* Program: Tuition cost Calculator.
 * Programmer: Brian Lee
 * 6 Sept 12
 * 
*/

import javax.swing.JOptionPane;




public class tuition{




	public static void main(String []args){
	
	double tuition;               //local variable for tuition
	double rateIncrease;          // local variable for yearly tuition rate increase
	int years;                    // local variable for years planned to attend
	double totalCost;             // local variable for total cost of tuition for years attended
	
	
	
		tuition = getCurrentTuition ();   //function for user input on yearly tuition cost
		
		rateIncrease = getIncreasedRate ();  //function for user input on rate increase
		
		years = getYears ();                // function for planned years of attending
		
		totalCost = getCompute (tuition, rateIncrease, years);  //function for calculating 
	
		
		
		JOptionPane.showMessageDialog(null, "Current Tuition, rate, and years are : "+tuition+"  "+rateIncrease+" "+years);
		
		JOptionPane.showMessageDialog(null, "Projected Tuition for "+years+" years is : " +totalCost);

		
		
		}//main
		
		
//====================================================================		

		
	public static double getCurrentTuition (){
		

		
		String input;
			
		input = JOptionPane.showInputDialog("Please enter tuition amount or press ! to exit: ");  //gets user info

					while ( input == ("!")){    //loop continues until "!" is pressed.
					
						return 0;
						}//exits subprogram	
		
		
					while ( input.equals ("0")) {  //loop will repeatedly ask for input if 0 is entered.

					input = JOptionPane.showInputDialog("Please enter tuition amount: ");


			}//while loop

			

		   double tuition_func;  // local variable declared. user entered tuition.

		tuition_func = Double.parseDouble(input);  //user data converted from sting to double.
		
		return tuition_func;  //user entered data is returned to main function.

 	

	}//function inputData
	
	
//==============================================================================
	
	
  
public static double getIncreasedRate (){
		

		
		String input;
			
		input = JOptionPane.showInputDialog("Please enter increased tuition rate as decimal precent or press ! to exit: ");

					while ( input == ("!")){  
					
						return 0;
						}//exits subprogram	
		
		
					while ( input.equals ("0")) { //loop will repeatedly ask for input if 0 is entered.

					input = JOptionPane.showInputDialog("Please enter increased tuition rate as decimal precent or press ! to exit: ");


			}//while loop

			

		   double rateIncrease_func;

		rateIncrease_func = Double.parseDouble(input);
		
		return rateIncrease_func;

 	

	}//function inputData


//=========================================



public static int getYears (){
		

		
		String input;
			
		input = JOptionPane.showInputDialog("Please enter the years planned to attend or press ! to exit: ");

					while ( input == ("!")){
					
						return 0;
						}//exits subprogram	
		
		
					while ( input.equals ("0")) { //loop will repeatedly ask for input if 0 is entered.

					input = JOptionPane.showInputDialog("Please enter the years planned to attend or press ! to exit: ");


			}//while loop

			

		   int years_func;

		years_func = Integer.parseInt(input);
		
		return years_func;

 	

	}//function inputData



//====================================================


public static double getCompute (double tuition_func, double rateIncrease_func, int years_func){
		

	
	double cost_func=0;  //local viable for total tuition cost.
	
		
	
	 while (years_func > 0){  //loop is set to run for years planned to attend school.
		
			   
		 		 cost_func = ((cost_func + tuition_func) * (rateIncrease_func+1)); //calculation for tuition including compounding interest
		
								 			  		  
		years_func = years_func - 1;  //1 is subtracted from years attended for each run.
				 
								 
		 }//while
	
		 
	

		return cost_func;


	}//function inputData


//============================================================================








}//class
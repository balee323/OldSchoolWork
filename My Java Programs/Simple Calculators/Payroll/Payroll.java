//HW1 Brian Lee

//collaborators/references: none

/*
	This program calculates payroll
*/

import javax.swing.JOptionPane;


public class Payroll
{

	public static void main(String[] args)
	{
		
		String inputString;	// For reading input
		String name;			// For user's name
		int hours;				// The number of hours worked
		double payRate;		// The user's hourly pay rate
		double grossPay;		// The user's gross pay
		
		//get the user's name
		
		name = JOptionPane.showInputDialog("What is " + "your name? ");
		
		//get the hours worked
		
		inputString = JOptionPane.showInputDialog("How many hours " + "did you work this week? ");
		
		//convet the input to an int
		
		hours = Integer.parseInt(inputString);
		
		//get the hourly pay rate
		
		inputString = JOptionPane.showInputDialog("What is your " + "hourly pay rate? ");
		
		//convert input to a double
		
		payRate = Double.parseDouble(inputString);
		
		//calculate gross pay
		
		grossPay = hours * payRate;
		
		//display the results
		
		JOptionPane.showMessageDialog(null, "Hello " + name + ". Your gross pay is $" + grossPay);
		
		//End the Program
		
		System.exit(0);
		}
		
}
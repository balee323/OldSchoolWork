

//collaborators/references: none

/*
	This program calculates the total tip for 15% gratuity
*/

import javax.swing.JOptionPane;


public class Tips
{

	public static void main(String[] args)
	{
		
		String inputString;		// For reading input
		double subtotal;			// The subtotal before gratuity
		double gratuity_rate;	// The gratuity rate
		double gratuity;			// The calculated gratuity based on subtotal
		double total;				// The total includes subtotal + gratuity 
		//HW1 Brian Lee
		
		//get the subtotal
		
		inputString = JOptionPane.showInputDialog("What is the subtotal ?");
		
		//convet the input to an int
		
		subtotal = Double.parseDouble(inputString);
		
		//get the gratuity rate
		
		inputString = JOptionPane.showInputDialog("What is the gratuity rate ?" + "  Please enter in decimal form.");
		
		//convert input to a double
		
		gratuity_rate = Double.parseDouble(inputString);
		
		//calculate the gratuity
		
		gratuity = subtotal * gratuity_rate;
		
		//display the results
		
		JOptionPane.showMessageDialog(null, " The gratuity is $" + gratuity);
		
		//calculate the total (gratuity + subtotal).
		
		total = subtotal + gratuity;
		
		//display the results for total
		
		JOptionPane.showMessageDialog(null, " The total is $" + total);
		
		
		//End the Program
		
		System.exit(0);
		}
		
}
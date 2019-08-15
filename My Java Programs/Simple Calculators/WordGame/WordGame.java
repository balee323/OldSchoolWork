
//HW1 Brian Lee
//collaborators/references: none

/*
	This program calculates the total tip for 15% gratuity
*/

import javax.swing.JOptionPane;


public class WordGame
{
	public static void main(String[] args)
	{
		
		String inputString;		// For reading input
		String name;				// user's name
		int age;						// user's age
		String city;				// city name
		String college;			// name of a college
		String profession;		// name of a profession
		String animal;				// type of animal
		String pet_name;			// name of a pet
		
		
		
		//get user's name
		
		name = JOptionPane.showInputDialog("What is your name ?");
		
		
		//get user's age
		
		inputString = JOptionPane.showInputDialog("What is your age ?");

				
		//convet the input to an int
		
		age = Integer.parseInt(inputString);
		
		
		//get a name of a city
		
		city = JOptionPane.showInputDialog("Please enter the name of any city. ");
		
	
		//get a name of a college
		
		college = JOptionPane.showInputDialog("Please enter the name of any college. ");
		
		//get a name of a profession
		
		profession = JOptionPane.showInputDialog("Please enter the name of any profession. ");
		
		//get type of any animal
		
		animal = JOptionPane.showInputDialog("Please the name of any type of animal. ");
		

		//get a name of a pet
		
		pet_name = JOptionPane.showInputDialog("Please enter the name of any pet. ");
		

		
		
		
		
		//display the results
		
		JOptionPane.showMessageDialog(null, " There was once a person named " + name + " who lived in " + city + ".");
		
		JOptionPane.showMessageDialog(null, " At the age of " + age + "," + name + " went to college at " + college + ".");
		
		JOptionPane.showMessageDialog(null, name + " graduated and went to work as a " + profession +" .");
		
		JOptionPane.showMessageDialog(null, " Then, " + name + " adopted a(n) " + animal + " named " + pet_name +".");
		
		JOptionPane.showMessageDialog(null, " They both lived happily ever after! ");
		
		
		
		
		//End the Program
		
		System.exit(0);
		}
		
}
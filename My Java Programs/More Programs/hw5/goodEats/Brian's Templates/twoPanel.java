import javax.swing.*;
import java.awt.*;
import java.awt.event.*;


/**
   The BagelPanel class allows the user to select either
   a white or whole wheat bagel.
*/

public class twoPanel extends JPanel
{
   // The following constants are used to indicate
   // the cost of each type of foods.
	
	//probably wont use this
	
  // public final double WHITE_BAGEL = 1.25;
 //   public final double WHEAT_BAGEL = 1.50;


    


   private JRadioButton button1;  // To 
   private JRadioButton button2;  // To 
   private ButtonGroup bg;           // Radio button group
   
 /*

	private String foodItem1;
	private String foodItem2;


   public void setGenPanel(String food1, String food2){
			  
			  foodItem1 = food1;
			  foodItem2 = food2;
			  
			 }//set panel

  */
  
 
   public twoPanel(String foodItem1, String foodItem2, String category)
   {
	
	
	    
		JPanel panel = new JPanel(); 
	
	
      // Create a GridLayout manager with 
      // two rows and one column.
      setLayout(new GridLayout(2, 1));

      // Create the radio buttons.
      button1 = new JRadioButton(foodItem1, true);  //should make an argument to send food name variable
      button2 = new JRadioButton(foodItem2);           //send a string argument

      // Group the radio buttons.
      bg = new ButtonGroup();
      bg.add(button1);
      bg.add(button2);

      // Add a border around the panel.
      setBorder(BorderFactory.createTitledBorder(category));

      // Add the radio buttons to the panel.
      add(button1);
      add(button2);
   	   
	}

  

   /**
      getBagelCost method
      @return The cost of the selected bagel.
   */
 
 
 
 
   /* not sure if I am using this 
	 
   public double getBagelCost()
   {
      double bagelCost = 0.0;

      if (whiteBagel.isSelected())
         bagelCost = WHITE_BAGEL;
      else
         bagelCost = WHEAT_BAGEL;

      return bagelCost;
   }

  
  */


  
	 //gPanel.setVisible(true);




}



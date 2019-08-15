import javax.swing.*;
import java.awt.*;

/**
   The BagelPanel class allows the user to select either
   a white or whole wheat bagel.
*/

public class GenPanel extends JPanel
{
   // The following constants are used to indicate
   // the cost of each type of foods.
	
	//probably wont use this
	
   public final double WHITE_BAGEL = 1.25;
   public final double WHEAT_BAGEL = 1.50;


     /*  
	
			 private int WinWidth;
			 private int WinHeight;
			 private String WinTitle;
			 
			  
			 public void setWin(int width, int height, String title) {
			  
			  WinWidth = width;
			  WinHeight = height;
			  WinTitle = title;
			 }//set windows


       */




   private JRadioButton food1;  // To 
   private JRadioButton food2;  // To 
   private ButtonGroup bg;           // Radio button group

   /**
      Constructor
   */

   public GenPanel()
   {
      // Create a GridLayout manager with 
      // two rows and one column.
      setLayout(new GridLayout(2, 1));

      // Create the radio buttons.
      whiteBagel = new JRadioButton("food1", true);  //should make an argument to send food name variable
      wheatBagel = new JRadioButton("food2");           //send a string argument

      // Group the radio buttons.
      bg = new ButtonGroup();
      bg.add(food1);
      bg.add(food2);

      // Add a border around the panel.
      setBorder(BorderFactory.createTitledBorder("Food category"));

      // Add the radio buttons to the panel.
      add(food1);
      add(food2);
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


}



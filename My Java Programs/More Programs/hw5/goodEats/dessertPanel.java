import javax.swing.*;
import java.awt.*;
import java.awt.event.*;


/**
   The BagelPanel class allows the user to select either
   a white or whole wheat bagel.
*/

public class dessertPanel extends JPanel
{
     

	
	private JRadioButton button3;
	private JRadioButton button4;  
	private ButtonGroup bg;           // Radio button group
  
   private final double cotton_1 = 3.50;
   private final double mushroom_1 = 3.50;
   private double Dess_Cost;
	public double  TotalCost;
  
 
   public dessertPanel(String foodItem1,String foodItem2,String category)
   {
	

		JPanel panel1 = new JPanel(); 
	     
			
		 panel1.setPreferredSize(new Dimension(250, 300));  //contains the buttons
		  
		 ImageIcon image1 = new ImageIcon("image/cotton1.jpg");
		 ImageIcon image2 = new ImageIcon("image/mushroom1.jpg");
		 
		 button3 = new JRadioButton(foodItem1, image1);
		 button4 = new JRadioButton(foodItem2, image2);
	

     // Create a BorderLayout manager
        panel1.setLayout(new BorderLayout(5,5));
    //  panel1.setLayout(new GridLayout(2, 1));
	

      	// Add the radio buttons to the panel.
      	   panel1.add(button3, BorderLayout.NORTH);   
	         panel1.add(button4, BorderLayout.SOUTH);
   
			    //create one actionlistener object	
			    DessButtonListener listener1 = new DessButtonListener();
			
				// Register the action listeners.
		      button3.addActionListener(listener1);
				button4.addActionListener(listener1);
			  

			 //create panel2 to store panel1
			JPanel panel2 = new JPanel();		

			panel2.setBackground(Color.GREEN);
			
			panel2.setPreferredSize(new Dimension(300, 525));
			
			
			 // Add a border around the panel.
        panel2.setBorder(BorderFactory.createTitledBorder(category));	
		
		  panel2.add(panel1); 
			 

			 // add(panel1);
			  add(panel2);
			  
			  
			  //set panel visible
		  panel2.setVisible(true);	  
	     panel1.setVisible(true);

	
	
	
	
	
	  }//constructor
	

      
		
		  /**
      setCost method allows the item Cost to be determined by the actionListner class
      @sets cost to selected item
   */
	
   private void setCost(double price)
	{
	  
	
	  //Entree_Cost = 0;
	  
	  Dess_Cost = price;
	  
	  TotalCost = price + TotalCost;
	  
	  // JOptionPane.showMessageDialog(null, "setCost: " + price); //works
	  
	  //JOptionPane.showMessageDialog(null, "setCost: " + Entree_Cost); //works
   
    }  

  
       
   /**
      getDessCost method
      @return The cost of the selected Entree.
   */


  	  public double getDessCost()
		{
		      
			
			double DessPrice;
				
			DessPrice = Dess_Cost;
							
							
			JOptionPane.showMessageDialog(null, "Item Costs: $ " + DessPrice); //	
							
	     return DessPrice;
	  }
			
						
				
		 public double getDessTotal()
		{
		      
			
			double DessTotal = 5;
				
			DessTotal = TotalCost;
			
	
	//	JOptionPane.showMessageDialog(null, "Running Total: $ " + DessTotal); //	
							
	     return DessTotal;
	  }
		
			 
  

 
    public class DessButtonListener implements ActionListener
   {
      public void actionPerformed(ActionEvent e)
      {
         double Cost =0;  	
			double totalCost =0;	
			   	
				
	      if (button3.isSelected()){
         Cost = cotton_1;
			setCost(Cost);
			getDessCost();
			getDessTotal();
			}

    else if (button4.isSelected()){
         Cost = mushroom_1;
			setCost(Cost);
			getDessCost();
			getDessTotal();
			}
 
		
					           
       }//method
			  
   }//listener class  

  
  
  
  
  
  
  


}



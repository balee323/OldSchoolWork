import javax.swing.*;
import java.awt.*;
import java.awt.event.*;


/**
   The Beverage class allow the user to select from 2 beverages
*/

public class bevPanel extends JPanel
{
   	
	private JRadioButton button3;
	private JRadioButton button4;  
  

   private final double turp_1 = 1.50;
   private double Bev_Cost;
	public double  TotalCost;


 
   public bevPanel(String foodItem1,String foodItem2,String category)
   {
	
	
	    
		JPanel panel1 = new JPanel(); 
		
		panel1.setPreferredSize(new Dimension(220, 300));

		 
		 ImageIcon image1 = new ImageIcon("image/turp1.jpg");
		 
		 button3 = new JRadioButton(foodItem1, image1);
		 button4 = new JRadioButton(foodItem2, image1);
	

      // Create a BorderLayout manager
        panel1.setLayout(new BorderLayout(5,5));
     

      	// Add the radio buttons to the panel.
      	   panel1.add(button3, BorderLayout.NORTH);   
	         panel1.add(button4, BorderLayout.SOUTH);
 
				    //create one actionlistener object	
			    BevButtonListener listener1 = new BevButtonListener();
			
				// Register the action listeners.
		      button3.addActionListener(listener1);
				button4.addActionListener(listener1);
		  
		  
		   //create panel2 to store panel1
		   JPanel panel2 = new JPanel();	
		  
		   panel2.setBackground(Color.GREEN);
			
			panel2.setPreferredSize(new Dimension(250, 525));
			
			
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
      setCost method allows the bevCost to be determined by the actionListner class
      @sets cost to selected item
   */

    
   private void setCost(double price)
	{
	  
	
	  //Entree_Cost = 0;
	  
	  Bev_Cost = price;
	  
	  TotalCost = price + TotalCost;
	  
	  // JOptionPane.showMessageDialog(null, "setCost: " + price); //works
	  
	  //JOptionPane.showMessageDialog(null, "setCost: " + Entree_Cost); //works
   
    }  
	 


       
   /**
      getBevCost method
      @return The cost of the selected Entree.
   */


  	  public double getBevCost()
		{
		      
			
			double BevPrice;
				
			BevPrice = Bev_Cost;
							
							
			JOptionPane.showMessageDialog(null, "Item Costs: $ " + BevPrice); //	
							
	     return BevPrice;
	  }
			
						
				
		 public double getBevTotal()
		{
		      
			
			double BevTotal = 5;
				
			BevTotal = TotalCost;
			
	
   //		JOptionPane.showMessageDialog(null, "Running Total: $ " + BevTotal); //	
							
	     return BevTotal;
	  }
		
			 
  

 
    public class BevButtonListener implements ActionListener
   {
      public void actionPerformed(ActionEvent e)
      {
         double Cost =0;  	
			double totalCost =0;	
			   	
			
			if (button3.isSelected()){  //if true then:
         Cost = turp_1;        //cost set equal to constant
			setCost(Cost);         //SetCost method is passed Cost Argument
			getBevCost();       //entree cost is returned
			getBevTotal();        //total cost is returned
			}	
				
	    
    else if (button4.isSelected()){
         Cost = turp_1;
			setCost(Cost);
			getBevCost();
			getBevTotal();
			}
 
		
					           
       }//method
			  
   }//listener class  




}//class



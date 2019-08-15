import javax.swing.*;  //for Jpanel and buttons
import java.awt.*;    //for layout managers
import java.awt.event.*;  //for action listener
import java.text.DecimalFormat;



/**
   The EntreePanel class allows the user to select
   5 different Entrees.
	BagelPanel class was modified to create the EntreePanel.
	
*/

  public class EntreePanel extends JPanel{
  
  
  
   // The following constants are used to indicate
   // the cost of each type of foods.
	
   private final double sock_1 = 3.50;
	private final double spring_1 = 2.00;
	private final double spider_1 = 1.75;
	private final double mat_1 = 4.25;
	private final double bolts_1 = 3.25;
   private double Entree_Cost;
	public double  TotalCost;

 
	
	private JRadioButton button1;
	private JRadioButton button2;
	private JRadioButton button3;
	private JRadioButton button4;
	private JRadioButton button5;
	
	private ButtonGroup bg;           // Radio button group (used to group buttons)
   


        //constructor
   public EntreePanel(String foodItem1, String foodItem2, String foodItem3, String foodItem4, 
	String foodItem5, String category){


	    JPanel panel1 = new JPanel();
		 
	   ImageIcon image1 = new ImageIcon("image/sock1.jpg");
		ImageIcon image2 = new ImageIcon("image/springs1.jpg");
      ImageIcon image3 = new ImageIcon("image/spider1.jpg");
      ImageIcon image4 = new ImageIcon("image/mat1.jpg");
      ImageIcon image5 = new ImageIcon("image/bolts1.jpg");

		 
		 button1 = new JRadioButton(foodItem1,image1);
       button2 = new JRadioButton(foodItem2,image2);
		 button3 = new JRadioButton(foodItem3,image3);
		 button4 = new JRadioButton(foodItem4,image4);
		 button5 = new JRadioButton(foodItem5,image5);


       
      /*
         // Group the radio buttons.
		      bg = new ButtonGroup();
		      bg.add(button1);
		      bg.add(button2);
				bg.add(button3);
				bg.add(button4);
		    	bg.add(button5);
		*/

	
	  // Create a GridLayout manager with 
      // 5 rows and one column.
	    panel1.setLayout(new GridLayout(5,1));  

		  
	      //create one actionlistener object	
	    EntreeButtonListener listener1 = new EntreeButtonListener();
	
	
		// Register the action listeners.
      button1.addActionListener(listener1);
		button2.addActionListener(listener1);
		button3.addActionListener(listener1);
		button4.addActionListener(listener1);
		button5.addActionListener(listener1);
     	
		
		panel1.setPreferredSize(new Dimension(300, 460));  //inner panel holding buttons
		
           		
		    // Add the radio buttons to the panel.
	      panel1.add(button1);
	      panel1.add(button2);
	   	panel1.add(button3);
			panel1.add(button4);
			panel1.add(button5);
	   
				
	      JPanel panel2 = new JPanel();		
		
		   panel2.setBackground(Color.GREEN);
			
			panel2.setPreferredSize(new Dimension(400, 525));  //outer panel to hold panel with buttons
			
			// Add a border around the panel.
      	panel2.setBorder(BorderFactory.createTitledBorder(category));
		
		   
		  // panel2.setLayout(new BorderLayout());	
		
		  panel2.add(panel1); 
			 

			 // add(panel1);
			  add(panel2);
			  
			  
			  //set panel visible
		  panel2.setVisible(true);	  
	     panel1.setVisible(true);
		  
 
	
   
	   }//constructor


 
    /**
      setCost method allows the EntreeCost to be determined by the actionListner class
      @sets cost to selected item
   */

 
 
   private void setCost(double price)
	{
	  
	
	  //Entree_Cost = 0;
	  
	  Entree_Cost = price;
	  
	  TotalCost = price + TotalCost;
	  
	  // JOptionPane.showMessageDialog(null, "setCost: " + price); //works
	  
	  //JOptionPane.showMessageDialog(null, "setCost: " + Entree_Cost); //works
   
    }//	   
 
  
 
    
   /**
      getEntreeCost method
      @return The cost of the selected Entree.
   */
 
 
	  public double getEntreeCost()
		{
		      
			
			double EntreePrice;
				
			EntreePrice = Entree_Cost;
							
							
			JOptionPane.showMessageDialog(null, "Item Costs: $ " + EntreePrice); //	
							
	     return EntreePrice;
	  }
			
						
	/**
      getEntreeCost method
      @return The total cost of all selected entrees.
   */
 
				
				
		 public double getEntreeTotal()
		{
		      
			
			double EntreeTotal = 5;
				
			EntreeTotal = TotalCost;
			
	
	//	JOptionPane.showMessageDialog(null, "Running Total: $ " + EntreeTotal); //works, but annoying
							
	     return EntreeTotal;
	  }
		
			 
  
  
	 //gPanel.setVisible(true);

 
    public class EntreeButtonListener implements ActionListener
   {
      public void actionPerformed(ActionEvent e)
      {
         double Cost =0;  	
			double totalCost =0;	
			   	
				
	      if (button1.isSelected()){  //if true then:
         Cost = sock_1;        //cost set equal to constant
			setCost(Cost);         //SetCost method is passed Cost Argument
			getEntreeCost();       //entree cost is returned
			getEntreeTotal();        //total cost is returned
			}

    else if (button2.isSelected()){  //if true then:
         Cost = spring_1;          //cost set equal to constant
			setCost(Cost);        //SetCost method is passed Cost Argument
			getEntreeCost();
			getEntreeTotal();
			}
      
	 else if (button3.isSelected()){  //if true then:
         Cost = spider_1;           //cost set equal to constant
			setCost(Cost);    //SetCost method is passed Cost Argument
			getEntreeCost();
			getEntreeTotal();
			}
			
			
		else if (button4.isSelected()){  //if true then:
         Cost = mat_1;		              //cost set equal to constant
		   setCost(Cost);        //SetCost method is passed Cost Argument
			getEntreeCost();
			getEntreeTotal();
			   }
		
		else if (button5.isSelected()){  //if true then:
         Cost = bolts_1;               //cost set equal to constant
         setCost(Cost);        //SetCost method is passed Cost Argument
			getEntreeCost();
			getEntreeTotal();
						}
			

	
					           
           }//method
			  
			}//listener class  
                    



public static void main(String[] args) {   //test program 

       JFrame Win1 = new JFrame();
	 	Win1.setBackground(Color.GREEN);
	   Win1.setSize(1024,768);


       EntreePanel frame3 = new EntreePanel("Sock Sandwich","Spring Salad","Spider Soup","Gym-Mat Sausage","bolts and cheese","Entrees");
		
		   Win1.add(frame3);
			
			frame3.setVisible(true);

          //Window parameters
			 Win1.setTitle("Brienz Bistro");
		      //closes program when window is closed
		  	 Win1.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);  
		  	 Win1.setVisible(true);



}//



}//class



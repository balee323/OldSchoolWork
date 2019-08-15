import java.awt.GridLayout;
import java.awt.Container;
import javax.swing.*;
import java.awt.*;
import java.awt.event.*;
import java.text.DecimalFormat;


public class BrienzBistro extends JFrame { 


   double TotalCost = 0.0;
	bevPanel frame1;
	dessertPanel frame2;
	EntreePanel frame3;
	twoButtonPanel frame4;
	JPanel Panel2;
	JPanel Panel1;
	JTextField textBox;
	JFrame Win1;
	

	       //constructor
    public BrienzBistro(){
	 
	
	  
	     //create a window, set resolution, and color
	 	Win1 = new JFrame();
	 	Win1.setBackground(Color.GREEN);
	   Win1.setSize(1024,768);
	  
	     //create a panel
	 	Panel1 = new JPanel();
	    Panel1.setPreferredSize(new Dimension(700, 600));
		 
	  // JPanel Panel2 = new JPanel();
	  //  Panel2.setPreferredSize(new Dimension(100, 75));

       Panel2 = new JPanel();
	     Panel2.setPreferredSize(new Dimension(100, 75));


 
	    // Create a BorderLayout manager for 1 Window and 2 panels
      Win1.setLayout(new BorderLayout(5,5));	 
      
		Panel1.setLayout(new BorderLayout(5,5));
		
		Panel2.setLayout(new BorderLayout(5,5));
		

	   	//creating frames 
		 frame1 = new bevPanel("Full-Turpentine $1.50","Decaf-Turpentine $1.50","Beverages"); 	
	  	 frame2 = new dessertPanel("Cotton-ball Cake $3.50","Mushroom Cake $3.50", "Desserts"); 
		 frame3 = new EntreePanel("Sock Sandwich $3.50","Spring Salad $2.00","Spider Soup $1.75","Gym-Mat Sausage $4.25","bolts and cheese $3.25","Entrees");    	
		 frame4 = new twoButtonPanel("Total", "Exit"); //will use inner class instead.
		 JLabel label = new JLabel("     Welcome to Brian's Bistro. Let's Eat!"); //create a label
		 		 			
		   // Panel2.add(new JTextField("Total:"+TotalCost),BorderLayout.CENTER);
		  textBox = new JTextField("Total: $"+TotalCost);
		  Panel2.add(textBox ,BorderLayout.CENTER);
              textBox.setPreferredSize(new Dimension(250,50));  //set size of label 

	    //Add the components to the content pane of Panel1.  //everything must be put into a content pane.
      Panel1.add(frame1, BorderLayout.WEST);
      Panel1.add(frame2, BorderLayout.EAST);
		Panel1.add(frame3, BorderLayout.CENTER);
		Panel1.add(frame4, BorderLayout.SOUTH);		
		Panel2.add(label,  BorderLayout.WEST);
		   label.setPreferredSize(new Dimension(250,50));  //set size of label 
		

		  //add colors to panels
		frame1.setBackground(Color.LIGHT_GRAY);
		frame2.setBackground(Color.LIGHT_GRAY);
		frame3.setBackground(Color.LIGHT_GRAY);

	    //make both panels visible
      Panel1.setVisible(true);
	   Panel2.setVisible(true);  
	 
	    //adding panels to Window 
		 Win1.add(Panel1,BorderLayout.CENTER);	
		 Win1.add(Panel2,BorderLayout.NORTH);
			
		 
			   //Window parameters
			 Win1.setTitle("Brienz Bistro");
		      //closes program when window is closed
		  	 Win1.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);  
		  	 Win1.setVisible(true);
 
  }//main

 //=========================================================


		 /**
		      Private inner class that handles the event when
		      the user clicks the Calculate button.
		   */
		
			
			private class CalcButtonListener implements ActionListener
		   {
		      public void actionPerformed(ActionEvent e)
		      {
		         
		          //Calculate the total.
		       
								 
				 TotalCost = frame3.getEntreeTotal() + frame1.getBevTotal() + frame2.getDessTotal(); 
		         
				  
	            textBox = new JTextField("Total: $"+TotalCost);	  
				  
				   JLabel label = new JLabel("     Welcome to Brian's Bistro. Let's Eat!"); //create a label
				  
				  
				     
					   JPanel Panel3 = new JPanel(); //panel3 will override panel2.
					  		Panel3.setPreferredSize(new Dimension(100, 75)); //creating Panel3 using same specs as panel2.
					  
					   
					  Panel3.setLayout(new BorderLayout(5,5));//creating Panel3 using same specs as panel2.
					  
					  
					    Panel3.add(label,  BorderLayout.WEST);//creating Panel3 using same specs as panel2.
		                 label.setPreferredSize(new Dimension(250,50));  //set size of label
 
                    Panel3.add(textBox, BorderLayout.CENTER);//creating Panel3 using same specs as panel2.
						      
						  

						  Win1.add(Panel3, BorderLayout.NORTH);//creating Panel3 using same specs as panel2.
						  
						 
						  Panel3.setVisible(true);  //setting new window to visible
						  Panel2.setVisible(false); //set previous panel to non-visible
						
								
	
								
					//	JOptionPane.showMessageDialog(null, "Total Cost: $"+TotalCost); //			
				 				
				 }    
			 
			 }//calcbuttonlistener
		


   //===================================================================
		
				   /**
				      Private inner class that handles the event when
				      the user clicks the Exit button.
				   */

		   private class ExitButtonListener implements ActionListener
		   {
		      public void actionPerformed(ActionEvent e)
		      {
		          System.exit(0);
		      }
		   }//close exitlistener
		
		
		
  //====================twoButtonPanel Class======================//			
			
			 /**
			      The buildButtonPanel method builds the button panel
			   */
	  
			 public class twoButtonPanel extends JPanel
			{ 
			  
			  
			   private JButton Button1;    // To calculate the cost
			   private JButton Button2;    // To exit the application
			   
			           //constructor
			   public twoButtonPanel(String name1, String name2)
			   {
			       
			          JPanel panel1 = new JPanel();
				
			      // Create the buttons.
			      Button1 = new JButton(name1);  
			      Button2 = new JButton(name2);
			
			
				   // Register the action listeners.
			      Button1.addActionListener(new CalcButtonListener());  //for calculation listener
			      Button2.addActionListener(new ExitButtonListener());  //to exit program
			  
						  Button1.setPreferredSize(new Dimension(70, 40));
						  Button2.setPreferredSize(new Dimension(70, 40));   
			   
				   setLayout(new GridLayout(2, 1));
				
				    // Add the buttons to the button panel.
			       panel1.add(Button1);
			       panel1.add(Button2);
					
					
				    panel1.setVisible(true);
				
			           add(panel1); //adding to Window
	  
			 }//constructor	

    }//twoButtonPanel Inner Class



}//main public class







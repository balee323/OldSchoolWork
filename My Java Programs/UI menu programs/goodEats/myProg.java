import java.awt.GridLayout;
import java.awt.Container;
import javax.swing.*;
import java.awt.*;
import java.awt.event.*;
import java.text.DecimalFormat;


public class myProg { 



   

  /** Main method */
  public static void main(String[] args) {
    
	 
	      double TotalCost = 0.0;
	 


	     //create a window, set resolution, and color
	 	JFrame Win1 = new JFrame();
	 	Win1.setBackground(Color.GREEN);
	   Win1.setSize(1024,768);
	  
	     //create a panel
	 	JPanel Panel1 = new JPanel();
	    Panel1.setPreferredSize(new Dimension(700, 600));
		 
	   JPanel Panel2 = new JPanel();
	    Panel2.setPreferredSize(new Dimension(100, 75));
	  
	  
	  
 
	    // Create a BorderLayout manager for 1 Window and 2 panels
      Win1.setLayout(new BorderLayout(5,5));	 
      
		Panel1.setLayout(new BorderLayout(5,5));
		
		Panel2.setLayout(new BorderLayout(5,5));
		
		
		  	 		 
	 
      	//creating frames 
		 bevPanel frame1 = new bevPanel("Full-Turpentine","Decaf-Turpentine","Beverages"); 
			
	  	 dessertPanel frame2 = new dessertPanel("Cotton-ball Cake","Mushroom Cake", "Desserts"); 

		 EntreePanel frame3 = new EntreePanel("Sock Sandwich","Spring Salad","Spider Soup","Gym-Mat Sausage","bolts and cheese","Entrees");
		   
		   		 		
		// twoButtonPanel frame4 = new twoButtonPanel("Total","Exit"); //will create in main instead.
		
				
		 JLabel label = new JLabel("           "+"Welcome to Brian's Bistro. Let's Eat!"); //create a label
	
		 		 			
		 Panel2.add(new JTextField("Total:"+TotalCost),BorderLayout.CENTER);
    
	 
	 //=======create panel, buttons, listener for exit and total buttons====//
	 
		
		JPanel frame4 = new JPanel();
		
		 JButton Button1;    // To calculate the cost
       JButton Button2;    // To exit the application

		
		
		
		   // Create the buttons.
      Button1 = new JButton("TOTAL");  
      Button2 = new JButton("EXIT");


	   // Register the action listeners.
      Button1.addActionListener(new CalcButtonListener());  //for calculation listener
      Button2.addActionListener(new ExitButtonListener());  //to exit program

           
			  Button1.setPreferredSize(new Dimension(70, 40));
			  Button2.setPreferredSize(new Dimension(70, 40));
			    
   
	   setLayout(new GridLayout(2, 1));
	
	    // Add the buttons to the button panel.
       frame4.add(Button1);
       frame4.add(Button2);
		
	
	 
	 //====================================================================//
	 
	 
	 
	 

	
	    //Add the components to the content pane of Panel1.  //everything must be put into a content pane.
      Panel1.add(frame1, BorderLayout.WEST);
      
		Panel1.add(frame2, BorderLayout.EAST);
		
		Panel1.add(frame3, BorderLayout.CENTER);
		
		Panel1.add(frame4, BorderLayout.SOUTH);
   	  		
		Panel2.add(label,  BorderLayout.WEST);
		   label.setPreferredSize(new Dimension(250,50));  //set size of label

	    
		Panel2.add(new JTextField("Total:"),BorderLayout.CENTER);
		      				

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
		
			
	    //  double EntreeCost;
			 
		   EntreeCost = frame3.getEntreeTotal(); 
			
			
			Panel2.add(new JTextField("Total:"+EntreeCost),BorderLayout.CENTER);
			
	
	
	
	
	
	
	
	
	
	
			 
  	}//main



 /**
      Private inner class that handles the event when
      the user clicks the Calculate button.
   */

   private class CalcButtonListener implements ActionListener
   {
      public void actionPerformed(ActionEvent e)
      {
         
         	

          //Calculate the total.
       TotalCost = frame3.getEntreeTotal(); 
                   						  
						  

       }
	 
	 }//calcbuttonlistener


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
	
           add(panel1);
	
 }//constructor	
	













}//main public class







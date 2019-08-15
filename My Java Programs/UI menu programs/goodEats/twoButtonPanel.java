import javax.swing.*;
import java.awt.*;
import java.awt.event.*;
import java.text.DecimalFormat;




//==================NOT BEING USED, USING THE INNERCLASS METHOD AS OF: 20OCT12 ==============//



 /**
      The buildButtonPanel method builds the button panel and constructs listener
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
	  

    
public static void main(String[] args) {

     JFrame Win1 = new JFrame();
	 	Win1.setBackground(Color.GREEN);
	   Win1.setSize(1024,768);


        twoButtonPanel frame4 = new twoButtonPanel("Total","Exit");

            Win1.add(frame4);
			
			frame4.setVisible(true);


          //Window parameters
			 Win1.setTitle("Brienz Bistro");
		      //closes program when window is closed
		  	 Win1.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);  
		  	 Win1.setVisible(true);



}//main



  }//close class
  
  
  
  
 

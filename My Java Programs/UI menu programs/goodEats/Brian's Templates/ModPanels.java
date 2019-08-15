// TestPanels.java: Use panels to group components
import java.awt.*;
import javax.swing.*;

public class ModPanels extends JFrame {
  /** Default constructor */
 


 
  public ModPanels() {
    // Get the content pane of the frame
    Container container = getContentPane();


  
   // Set BorderLayout for the frame
    container.setLayout(new BorderLayout());
	 
 
 
    // Create panel p1 for the buttons and set GridLayout
    JPanel p3 = new JPanel();   
	 
	 p3.add(new JTextField("Mod this"), BorderLayout.NORTH);  
	 
	 container.add(p3, BorderLayout.NORTH);
	  

 

    // Create panel p1 for the buttons and set GridLayout
    JPanel p1 = new JPanel();
    
	 
	
	 
	 
	 p1.setLayout(new GridLayout(2, 3));
	 
   
	 
   	 

    // Add buttons to the panel
    
    ImageIcon image1 = new ImageIcon("image/burger1.jpg");  //1
    p1.add(new JButton("burger1", image1));
	 
	 
	 ImageIcon image2 = new ImageIcon("image/burger1.jpg");  //2
    p1.add(new JButton("burger1", image1));
	 
	 
	 ImageIcon image3 = new ImageIcon("image/burger1.jpg");  //3
    p1.add(new JButton("burger1", image1));
	 
	 
	 ImageIcon image4 = new ImageIcon("image/burger1.jpg");  //4
    p1.add(new JButton("burger1", image1));
	 
	 
	 ImageIcon image5 = new ImageIcon("image/burger1.jpg");  //5
    p1.add(new JButton("burger1", image1));
	 
	 
	 ImageIcon image6 = new ImageIcon("image/burger1.jpg");   //6
    p1.add(new JButton("burger1", image1));
	  
	 
	container.add(p1, BorderLayout.CENTER);
	 
	 
	 //================================================
    
	 
	 
	 
	 
	 // Create panel p2 to hold a text field and p1
    JPanel p2 = new JPanel();  //creates new panel
    p2.setLayout(new BorderLayout());  //new border
   
	
	
    
	 // Add p2 and a button to the frame
    container.add(p2, BorderLayout.SOUTH);
    container.add(new Button("Get Bill"), BorderLayout.SOUTH);


  }//close method





}//close class



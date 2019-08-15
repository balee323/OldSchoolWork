

/**
   This class creates a simple window.
   Pre: width, height, and title:
	post: creates window with program set width, height and title.
*/


import java.awt.*;
import javax.swing.*;

public class PriPanel extends JFrame {
  /** Default constructor */
 
 
 
  private int WinWidth;
 private int WinHeight;
 private String WinTitle;
 
  
 public void setWin(int width, int height, String title) {
  
  WinWidth = width;
  WinHeight = height;
  WinTitle = title;
 }//set windows
 
 
 
  public void PriPanels(){
 
    JFrame window = new JFrame();
	 
	 
	 
	 window.setTitle(WinTitle);
    window.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    window.setSize(WinWidth, WinHeight);
    window.setVisible(true);

  

  }//close method





}//close class


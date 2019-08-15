  

import javax.swing.*;
import java.awt.*;
import java.awt.event.*;
import java.text.DecimalFormat;
  
  
  
   /**
      Private inner class that handles the event when
      the user clicks the Exit button.
   */

   public class ExitButtonListener implements ActionListener
   {
      public void actionPerformed(ActionEvent e)
      {
          System.exit(0);
      }
		
		
		}//close exit class
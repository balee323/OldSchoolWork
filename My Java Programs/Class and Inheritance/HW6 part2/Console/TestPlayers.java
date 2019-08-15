
import javax.swing.*;
import java.lang.*;

	
	
	 public class TestPlayers
	 {
	

	
		public static void main(String[]args)
		{
		
				  
             int players;
		       String Input;
				 Input = JOptionPane.showInputDialog("How Many players (max 3)? Press ! to exit.");  //gets user info
	
						while ( Input == ("!")){    //loop continues until "!" is pressed.
						
							 System.exit(0);	
							}//exits subprogram	
			
		
				  	players = Integer.parseInt(Input); 
			
				
				 	  if(players > 3){
							JOptionPane.showMessageDialog(null, "Error, max of 3 players.");
					  
				  			 System.exit(0);	
					
				   		 }//if
				 
					 if(players < 1){
						JOptionPane.showMessageDialog(null, "Error, min of 1 player.");
				  
				  	 	 System.exit(0);	
					 
							  }//if
 
		  
		    else{
		    
		            createPlayers(players);		
				 
			}//	 
				 
			
					
					 
			 System.exit(0);			
						
				}//main
			
			
			
			//method
			
			public static void createPlayers(int numPlayers)
			{
			
					Player testPlayers = new Player(numPlayers);  //create new hand (also creates deck)
			
					System.out.println(testPlayers.toString()+"\n");
					
					for(int i=1;i <= numPlayers; i++){ 
					System.out.println(testPlayers.playerHand(i));
					}//for
					
					
			}//
			
			
		//	public static void showCard(Card test_Card){
			  
		//	     System.out.println(test_Card.toString() +"\n");
						
			//			}//
			
			
			
			
			
   }//class			
	
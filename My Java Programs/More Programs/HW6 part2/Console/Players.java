/*
player class automatically creates a deck and hands according to the selected amount of players
*/

import javax.swing.*;
import java.lang.*;

	
	
	 public class Players
	 {
	
	
	  	
		private int players;
		private Hand[] testHands;  //declare variable
		//testHands = new testHands[3];  //3 slots created for player hands
		//private Hand testHand;
		
		
	//	Person[] personArray;  // declares a variable 'personArray' of type Person array.

    // personArray = new Person[7]; 
		
		
		
		private int i=0;

	
		     //contructor
		 public Players()    
		 {
 

			 NumOfPlayers();
			 
						
		}//constructor				
						
									 
			public void NumOfPlayers()
			 {

			 testHands = new Hand[3];  //3 slots created for player hands
			 players =0;
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
				 
	         
				
					for(i=0; i <= players; i++){  
					 
					 //testHand = new Hand();  //create new hand (also creates deck)
					 
					   testHands[i] = new Hand();
					 
				    }//for
			
			 
		//	 System.out.println("number of players: "+players); //	
						
					 
			 }//players method
			
			
			
					 public String toString() 
					  {
					 
					  	    for(i=0;i<=players;i++)
							 {    		
								public String testHands[i].toString();
														
						    	}//for
								
					 
					  
					  
					  return ("Number of players :"+players);   //HandCount()
															  
					  
				//	  return ("Number of players :"+players+"\n");
					  
					  
					  }//toString 

			
				
			
   }//class			
	
/*
player class automatically creates a deck and hands according to the selected amount of players
*/

import javax.swing.*;
import java.lang.*;

	
	
	 public class Player
	 {

	  	
		private int players;  //number of players
		private static Hand[] playerHand;  //declare variable  (makes one hand for each player).
	
		private int Hands = 0;  //variable for the number of player hands
		private int i=0;
		private int playerScore=0;  //player 1 score
	

//==============================================================================	

	
		     //*contructor with parameters
		 public Player(int numPlayers)    
		 {
 
           players = numPlayers; //creates players
			  NumOfHands();  //creates hands
			
	   	}//close-constructor				
				
//==============================================================================	
				
				
				//*default constructor
			public Player()
			{	
				
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
				           
							        
				            createPlayers(players);		//uses players method to create players once parameters are met.
						 
								}//else	
								
				}//*close default constructor
		
//==============================================================================	
				
			
		//==============================================================================	
		
				     //default Create player method (used with default constructor)
				public static void createPlayers(int numPlayers)
		    	{
			
					Player testPlayers = new Player(numPlayers);  //create new hand (also creates deck)
			
					System.out.println(testPlayers.toString()+"\n");
					
					for(int i=1;i <= numPlayers; i++){ 
					System.out.println(testPlayers.playerHand(i));
					}//for

				  }//*close - default create player method
				
				
		//==============================================================================	
		
						
					//*method to create hands (both constructors use)				 
			public void NumOfHands()
			 {
		
				 	  if(players == 1){
						 
						 playerHand = new Hand[1]; //array created with 1 slots.	
					    playerHand[0] = new Hand();
						 Hands = 1;  //only 1 hand created
														
				   		 }//if
				 
				 
					 if(players == 2){
						
						playerHand = new Hand[2]; //array created with 1 slots.
						playerHand[0] = new Hand();
						playerHand[1] = new Hand();
						Hands = 2;  //2 hands created
						
												 
							  }//if
				 
	            			
					 if(players == 3){
						
						playerHand = new Hand[3]; //array created with 1 slots.
						playerHand[0] = new Hand();
						playerHand[1] = new Hand();
					  	playerHand[2] = new Hand();
					   Hands = 3; //3 hands created
						
							  }//if
			 
    	 		  }//*close - NumOfHands method
			
			//==============================================================================	

						
			    //*Start method gives each player 3 consecutive top cards
			public void Start(int players)
			{
			  int temp1=0;
			  int temp2=0;
			 
				for(i=0; i <= players-1; i++)//loop controls card adding for certain number of players
				{
					for(int j=0;j<3;j++)//adds 3 cards to specific player
					{
					playerHand[i].Add();
					 }//inner for

				}//outer for
				
			}//*close - Start		
			
		
		//==============================================================================	
			   
				 //method give a specific player one top card or bottom card
			public void HaveIt(int player)
			{
			 
				//playerHand[player].Add();  //top
				playerHand[player].AddBottom(); //
					
			}//close - HaveIt	
			
			
		//==============================================================================	


			     //score method shows player score (counts all cards ranks)
			public int Score(int player)
			{
			  
 			  
				  playerScore = playerHand[player].HandScore(); 
				  
			
			  
			  return playerScore;
			
			}
			

		//==============================================================================	
	
			
			
		//	 public String toString() 
			// {		 
					  
			//  return ("Number of players :"+players+" Number of hands: "+Hands);   //  													    
			//   }//toString method
         
			  
		//==============================================================================	
	  
			   
				  //method shows the status of a particular players hand and the deck
			public String playerHand(int player) 
			{
         
				return("Player "+(player+1)+" hand: "+playerHand[player].HandToString()+"\n");
				}
	
		//==============================================================================	
	
	
				public String seeDeck() 
			   {
         
				return(playerHand[0].toString()+"\n");
				}
			
		//==============================================================================	
	
			
  }//class			
	
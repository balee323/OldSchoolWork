
import javax.swing.*;
import java.lang.*;

	
	
	 public class TestPlayers
	 {
	   
		
	
		public static void main(String[]args)
		{
		
				  
             int Players=2;    //
				 
				// Player testPlayers;  //initialze player class
		       
				 					
				  
				   Player testPlayers = new Player(Players);  //create new hand (also creates deck)
	
				   System.out.println(testPlayers.toString()+"\n");
					
					for(int i=1;i <= Players; i++){                //once player class created with 2 handclasses
					System.out.println(testPlayers.playerHand(i));  //playerhand is a method in Player Class
					}//for

		   
			        // createPlayers(players);		//does more than
						
						testPlayers.HaveIt(0);  //one card added to player 1 hand. 
						System.out.println(testPlayers.playerHand(1)); 
	               
						
						//testPlayers.HandScore(0);
						
						System.out.println("Player 1 Score: "+testPlayers.Score(0)); 
			
					
					 
			 System.exit(0);			
						
				}//main
			
			
			
			//method  does not do much, just creates instance of Player Class
		
		/*	         
			public static void createPlayers(int numPlayers)
			{
			
					testPlayers = new Player(numPlayers);  //create new hand (also creates deck)
			
									
					
				   System.out.println(testPlayers.toString()+"\n");
					
					for(int i=1;i <= numPlayers; i++){                //once player class created with 2 handclasses
					System.out.println(testPlayers.playerHand(i));  //playerhand is a method in Player Class
					}//for
				
									
			}//
      */			
			
			
			
   }//class			
	
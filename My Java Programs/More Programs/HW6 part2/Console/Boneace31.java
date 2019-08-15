
import javax.swing.*;
import java.lang.*;

	
	
	 public class Boneace31
	 {
	

	
		public static void main(String[]args)
		{
		
		 // Player Currentgame = new Player(); //use default constructor
		  
		  Player Currentgame = new Player(2); //use 2 player constructor

		 // int players = 2;
		  
		   StartGame(Currentgame,2);  //sends the object and the number of players to the method
		  
		  
		    
			 String Input = JOptionPane.showInputDialog("Enter player to see status. ");  //gets user info
			 			
			 int playerStatus = Integer.parseInt(Input);       
			 		 		 		 
			 gameStatus(playerStatus, Currentgame); 
	     
          
			 
			 
			 
			 
			 
					 
			 System.exit(0);			
						
				}//main
			
			
    		public static void  StartGame(Player Current_Game, int players)
			{
  
         	 Current_Game.HaveIt(players); 
			           
		   	 for(int i=1;i <= players; i++){ 
				 System.out.println(Current_Game.playerHand(i));  
			    }//for
         }
			
			

			
			
			
			public static void gameStatus(int player, Player Current_Game)
			{
			 
		 // Current_Game.Score(player);
			  
  			 System.out.println(Current_Game.playerHand(player));
			  
				
			}
			
			
			
			
			
			
			
			
   }//class			
	
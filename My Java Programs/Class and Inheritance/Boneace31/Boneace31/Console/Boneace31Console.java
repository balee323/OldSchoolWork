//Brian A Lee
//CS 110 Boneace program

//Works.   Some of the test programs maynot work anymore now, but main console game works.


import javax.swing.*;
import java.lang.*;

               //to sort some of the confusion
	  //player1  = int 1    hand1 = int 0
	  //player2  = int 2    hand2 = int 1
	
	 public class Boneace31Console
	 {
	 
	             
		
			public static void main(String[]args)
			{
			
				      
					
					
							boolean stickPlayer1 =false;
							boolean stickPlayer2 =false;
							
											
						   boolean continueGame = true;
							int players = 2;
			
		//=========================================================================================					
					  //Method calls
					
					 // Player Currentgame = new Player(); //use default constructor (asks number of players)
					  
					 	Player CurrentGame = new Player(2); //use 2 player constructor
	 		
					 	StartGame(CurrentGame,2);  //sends the object and the number of players to the startGame method
			  
				 
				 //creating a CheckWin method here//
			   	continueGame=CheckWin(CurrentGame, continueGame); //method returns boolean for gameContinue
			  
					 		
		//=========================================================================================												  
						  
					
					
					do{
					
					String Input = JOptionPane.showInputDialog("Enter 1 to see player1 Status.\n"+"Enter 2 to see player2 Status.\n"+
						  "or press 3 for more options");  //gets user info
						 			
						 int Option = Integer.parseInt(Input);       
						 	
								//String Option = Input1;	 		 		 
						  
						    
							   
								//while(Option == 1 || Option == 2){
								
							   if(Option == 1){
		      			  	 
									int playerStatus = Option;  //selects game status for player1 or player2
									gameStatus(playerStatus, CurrentGame); //gamestatus method call
					        
								   }//if statement
									
								if(Option == 2){
		      			  	 
									int playerStatus = Option;  //selects game status for player1 or player2
									gameStatus(playerStatus, CurrentGame); //gamestatus method call
					        
								   }//if statement
								 

					
				 
				 		     if(Option == 3){
						  
						    	//	 while(continueGame == true){
						      
	
										String Input2 = JOptionPane.showInputDialog("Player1 score: "+CurrentGame.Score(0)
													+"\n"+"Enter Y or N to Stick player1\n"+"Or press Q to quit.");
									  		 
																			
											 if(Input2.equals("Q")||Input2.equals("q")){
											  		System.exit(0);
													}
											
											else if(Input2.equals("Y")||Input2.equals("y")){
													JOptionPane.showMessageDialog(null, "We will see player1.");
												   stickPlayer1 = true;
												   }	
											
																					
											
									 	 String Input3 = JOptionPane.showInputDialog("Player2 score: "+CurrentGame.Score(1)
										 			+"\n"+"Enter Y or N to Stick player2\n"+"Or press Q to quit.");
									  			 
											 if(Input3.equals("Y")||Input3.equals("y")){
												JOptionPane.showMessageDialog(null, "We will see player2.");
													stickPlayer2 = true;
												
												}//inner if	
									
												else if(Input3.equals("Q")||Input3.equals("q")){
											  		System.exit(0);
													}
		
																					 
										 
										    if(stickPlayer1  != true){
										  //if(stickPlayer1  == false || GameOverPly1  == false ){
									String Input4 = JOptionPane.showInputDialog("Enter Y or N to HaveIt player1");
									  		 if(Input4.equals("Y")||Input4.equals("y")){
													CurrentGame.HaveIt(0); //add 1 bottom card to player1 hand
													JOptionPane.showMessageDialog(null, "Player1 score: "+CurrentGame.Score(0));//score player1
			
													 //add checkWin method call here
													continueGame=CheckWin(CurrentGame, continueGame); //method returns boolean for gameContinue.
													
													JOptionPane.showMessageDialog(null, "We will see player1.");
												}//inner if	
										}//outer if
			
										
										  if(stickPlayer2  != true){
										String Input5 = JOptionPane.showInputDialog("Enter Y or N to HaveIt player2");
									  		 if(Input5.equals("Y")||Input5.equals("y")){
													CurrentGame.HaveIt(1); //add 1 bottom card to player2 hand
													JOptionPane.showMessageDialog(null, "Player2 score: "+CurrentGame.Score(1));//score player2
			
													   //add checkWin method call here
														continueGame=CheckWin(CurrentGame, continueGame); //method returns boolean for gameContinue.
			
													JOptionPane.showMessageDialog(null, "We will see player2.");
												}//inner if	
										}//outer if
										
									//	else{
									//		System.exit(0);	
									//		}		
	
							//	}//while
								
				        }//else statement
						  
						  
						
						//if nobody busts or gets 31
					 if(stickPlayer1 == true||stickPlayer2 == true){
					 	
						if(CurrentGame.Score(0) > CurrentGame.Score(1)){
							JOptionPane.showMessageDialog(null, "Player1 Wins!.");
							continueGame = false;
							
							}
					 	else{
						JOptionPane.showMessageDialog(null, "Player2 Wins!.");	
				 	    continueGame = false;
						 }//else	
						
						}//close catch-all loop
						 
			 
										 
										 
										 
										 
				    }while(continueGame == true);
					 
					 	
						
										      
					
					 System.exit(0);			
							
					}//main
//=========================================================================================			
//=========================================================================================			
//=========================================================================================			
			
			      //method used to start game
    		public static void  StartGame(Player Current_Game, int players)
			{
   
					 System.out.println(Current_Game.seeDeck());	
						
         	 Current_Game.Start(players); 
			    		System.out.println("Start Game ============== ");       
		   	 	for(int i=1;i <= players; i++){ 
				 
				 							 		
						 System.out.println(Current_Game.playerHand(i-1));  //should show only deck
						 
						//  //shows player's hand
					    
						 System.out.println("Player "+(i)+" Score: "+Current_Game.Score(i-1)+"\n"); //shows player's score
						 
						// JOptionPane.showMessageDialog(null, "3 cards dealed to Player "+(i)+" Score: "+Current_Game.Score(i-1)+"\n"); //shows player's score
						 
				 	}//for
 						 System.out.println("======================== ");  
	      }
			
			
//=========================================================================================			

			public static void gameStatus(int player, Player Current_Game)
			{
			 
		    //Current_Game.Score(player);
			 System.out.println("Player "+(player)+" Score: "+Current_Game.Score(player-1)+"\n");
			  
  			 System.out.println(Current_Game.playerHand(player-1));
			  
			  JOptionPane.showMessageDialog(null, "Player "+(player)+" Score: "+Current_Game.Score(player-1)
			  				+"\n"+Current_Game.playerHand(player-1));
				
			}//close game status method
			
			
			
//=========================================================================================			
			
			
			public static boolean CheckWin(Player Current_Game, boolean continue_Game)
			{
   
			   
			
			if(Current_Game.Score(0) > 31){  //checks if player1's hand is over 31 
		 		  JOptionPane.showMessageDialog(null, "game over player1\n"+"Win Player2!");
					//GameOverPly1 = true;
					continue_Game = false;
			 }//gameOverPly1, WinPly2
					
			else if(Current_Game.Score(1) > 31){	 //checks if player2's hand is over 31 	
				  JOptionPane.showMessageDialog(null, "game over player2 \n"+"Win Player1!");
				  // GameOverPly2  = true;
					continue_Game = false;
			 }//gameOverPly2, WinPly1
				
			
			 else if(Current_Game.Score(0) == 31){  //checks if player1's hand is exactly 31 
		 		  JOptionPane.showMessageDialog(null, "Win player1!");
					//GameOverPly1 = true;
					continue_Game = false;
			 }//WinPly1
					
			 else if (Current_Game.Score(1) == 31){	 //checks if player2's hand is exactly 31	
				  JOptionPane.showMessageDialog(null, "Win player2!");
				  // GameOverPly2 = true;
					continue_Game = false;
			 }//WinPly2
	
				else{
					continue_Game = true;
					}	
	
	
	
				if(continue_Game == false){
					 System.exit(0);	
					}//exits game
	       
				return (continue_Game);

		    }//close CheckWin	
		
//=========================================================================================
//=========================================================================================
//=========================================================================================
//=========================================================================================			
			
			
   }//class			
	
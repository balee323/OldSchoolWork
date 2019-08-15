import java.awt.GridLayout;
import java.awt.Container;
import javax.swing.*;
import java.awt.*;
import java.awt.event.*;
import java.text.DecimalFormat;


public class BoneAceGUI extends JFrame { 


    boolean stickPlayer1 =false;
	 boolean stickPlayer2 =false;
							
											
    boolean continueGame = true;
	 int players = 2;

	JRadioButton button1;

	



   double TotalCost = 0.0;
	
	
	twoButtonPanel frame4;
	JPanel Panel2;
	JPanel Panel1;
	JTextField textBox;
	JFrame Win1;
	

	       //constructor
    public BoneAceGUI(){
	   	
 //=========================================================================================					
					  //Method calls
					
					 // Player Currentgame = new Player(); //use default constructor (asks number of players)
					  
					 	Player CurrentGame = new Player(2); //use 2 player constructor
	 		
					 	StartGame(CurrentGame,2);  //sends the object and the number of players to the startGame method
			  
				 
				 //creating a CheckWin method here//
			   	continueGame=CheckWin(CurrentGame, continueGame); //method returns boolean for gameContinue
			  
					 		
		//=========================================================================================												  
						  
	
	
				//SetPictureName()
				
				//Rank = Hand1.get(i).SetPictureName(i);
				
				ImageIcon image1 = new ImageIcon("cards/2C.gif");
				
				button1 = new JRadioButton(image1);
	  
	     //create a window, set resolution, and color
	 	Win1 = new JFrame();
	 	Win1.setBackground(Color.GREEN);
	   Win1.setSize(800,600);
	  
	     //create a panel
	 	Panel1 = new JPanel();
	    Panel1.setPreferredSize(new Dimension(700, 600));
		 
	  // JPanel Panel2 = new JPanel();
	  //  Panel2.setPreferredSize(new Dimension(100, 75));

       Panel2 = new JPanel();
	     Panel2.setPreferredSize(new Dimension(100, 75));


 
	    // Create a BorderLayout manager for 1 Window and 2 panels
      Win1.setLayout(new BorderLayout(5,5));	 
      
		Panel1.setLayout(new BorderLayout(5,5));
		
		Panel2.setLayout(new BorderLayout(5,5));
		

	   	//creating frames 
		   	
		 frame4 = new twoButtonPanel("HaveIt", "Stick"); //will use inner class instead.
		 JLabel label = new JLabel("     Let's Play Boneace.  Created by Brian Lee"); //create a label
		 		 			
		   // Panel2.add(new JTextField("Total:"+TotalCost),BorderLayout.CENTER);
		  textBox = new JTextField();
		  Panel2.add(textBox ,BorderLayout.CENTER);
              textBox.setPreferredSize(new Dimension(250,50));  //set size of label 

	    //Add the components to the content pane of Panel1.  //everything must be put into a content pane.
    //  Panel1.add(frame1, BorderLayout.WEST);
     // Panel1.add(frame2, BorderLayout.EAST);
	//	Panel1.add(frame3, BorderLayout.CENTER);
		Panel1.add(button1, BorderLayout.EAST);
		Panel1.add(frame4, BorderLayout.SOUTH);		
		Panel2.add(label,  BorderLayout.WEST);
		   label.setPreferredSize(new Dimension(250,50));  //set size of label 
		

		  //add colors to panels
	//	frame1.setBackground(Color.LIGHT_GRAY);
	//	frame2.setBackground(Color.LIGHT_GRAY);
	//	frame3.setBackground(Color.LIGHT_GRAY);

	    //make both panels visible
      Panel1.setVisible(true);
	   Panel2.setVisible(true);  
	 
	    //adding panels to Window 
		 Win1.add(Panel1,BorderLayout.CENTER);	
		 Win1.add(Panel2,BorderLayout.SOUTH);
			
		 
			   //Window parameters
			 Win1.setTitle("BoneAce31");
		      //closes program when window is closed
		  	 Win1.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);  
		  	 Win1.setVisible(true);
 
  }//main

 //=========================================================


		 /**
		      Private inner class that handles the event when
		      the user clicks the Calculate button.
		   */
		
			
			private class CalcButtonListener implements ActionListener
		   {
		      public void actionPerformed(ActionEvent e)
		      {
		         
		          //Calculate the total.
		       
								 
				// TotalCost = frame3.getEntreeTotal() + frame1.getBevTotal() + frame2.getDessTotal(); 
		         
				  
	            textBox = new JTextField("??: $"+TotalCost);	  
				  
				   JLabel label = new JLabel("     Let's Play Boneace.  Created by Brian Lee"); //create a label
				  
				  
				     
					   JPanel Panel3 = new JPanel(); //panel3 will override panel2.
					  		Panel3.setPreferredSize(new Dimension(100, 75)); //creating Panel3 using same specs as panel2.
					  
					   
					  Panel3.setLayout(new BorderLayout(5,5));//creating Panel3 using same specs as panel2.
					  
					  
					    Panel3.add(label,  BorderLayout.WEST);//creating Panel3 using same specs as panel2.
		                 label.setPreferredSize(new Dimension(250,50));  //set size of label
 
                    Panel3.add(textBox, BorderLayout.CENTER);//creating Panel3 using same specs as panel2.
						      
						  

						  Win1.add(Panel3, BorderLayout.NORTH);//creating Panel3 using same specs as panel2.
						  
						 
						  Panel3.setVisible(true);  //setting new window to visible
						  Panel2.setVisible(false); //set previous panel to non-visible
						
								
	
								
					//	JOptionPane.showMessageDialog(null, "Total Cost: $"+TotalCost); //			
				 				
				 }    
			 
			 }//calcbuttonlistener
		


   //===================================================================
		
				   /**
				      Private inner class that handles the event when
				      the user clicks the Exit button.
				   */

		   private class ExitButtonListener implements ActionListener
		   {
		      public void actionPerformed(ActionEvent e)
		      {
		          System.exit(0);
		      }
		   }//close exitlistener
		
		
		
  //====================twoButtonPanel Class======================//			
			
			 /**
			      The buildButtonPanel method builds the button panel
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
				
			           add(panel1); //adding to Window
	  
			 }//constructor	

    }//twoButtonPanel Inner Class



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
				 
				 							 		
						 System.out.println(Current_Game.playerHand(i-1));  //shows players hand
						 
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
			
			public static String setPicture(int which_player, Player Current_Game)
			{
			
			for(int i ;i <= which_players; i++){ 
				 
				 							 		
						 System.out.println(Current_Game.playerHand(which_player));  //shows players hand
				
				
				
			
		       
			
					 if(Current_Game.playerHand(player-1).get(size()).contains("2")){
							   
								image ="2";
								}
								
					else if(CardName.contains("3")){
							   Rank = 3;
								faceCard ="3";
								}
			
					else if(CardName.contains("4")){
							   Rank = 4;
								faceCard ="4";
								}
			
			     else if(CardName.contains("5")){
							   Rank = 5;
								faceCard ="5";
								}
			
					else if(CardName.contains("6")){
							   Rank = 6;
								faceCard ="6";
								}
		
			    else if(CardName.contains("7")){
					 	   Rank = 7;
							faceCard ="7";
							}
		
				else if(CardName.contains("8")){
						    Rank = 8;
							 faceCard ="8";
							 }
		
				else if(CardName.contains("9")){
						   Rank = 9;
							faceCard ="9";
							}
		
				else if(CardName.contains("10")){
						   Rank = 10;
							faceCard ="10";
							}
				
				else if(CardName.contains("A")){
						  // Rank = 1;
							Rank = 11;  //changed value to 11 for chance instant win.
							faceCard = "ACE";
							}
								
				else if(CardName.contains("J")){
						  Rank = 10;
						  faceCard = "JACK";
					    	}
											
				else if(CardName.contains("Q")){
						   Rank = 10;  
							faceCard = "QUEEN";
							 }
						
				else if(CardName.contains("K")){
							 Rank = 10;
							 faceCard = "KING";
						    }
			     
				  
				  else{
				       faceCard = "Houston We have a Problem!";
				  
				   }//if
				
				
				
			}//for	
			
			
			
		}//method	
			
			
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
			





}//main public class







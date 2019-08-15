import java.util.ArrayList;
import javax.swing.*;
import java.lang.*;
import java.util.*;




/**
   The Hand Class
*/

	public class Hand
	{

         
	  
	  private static Deck Deck1;  //initializes a static 52 card deck
	  
	      //initialze the card objects
	//  private Card Card1,Card2,Card3,Card4,Card5,Card6,Card7,CheckCard;
	  
	  					
	         //create an array list for card objects
	  private ArrayList<Card> Hand1;  //ArrayList for player's hand
	  
	  private int HandSize;  //variable for number of card objects in player's hand
	 
	
  
        		//contructor
		 public Hand()    
		 {
	   		
				CreateDeck();  //creates deck (already initialized as static)
		
				 CreateHand(); //creates an card object arraylist with zero card objects
			  
			    HandCount();  //generates an integer value for the number of card objects in hand arrayList.
	    
		  
		  }//constructor
 
	
			  	
				
				 public void CreateDeck()
			  {
			   
			        Deck1 = new Deck();  //new deck objected created			  
					  Deck1.DeckShuffle();//shuffle deck method
  			
                }//CreateDeck	
						

							
							
			  public void CreateHand()
			  {
			   
			      Hand1 = new ArrayList<Card>(10);  //new empty hand created with 10 positions
  			
								}//Create Hand		
						
		
				
				      public void Add()
						{
						
		
						Hand1.add(Deck1.getCard());  //adding top card from deck
						Deck1.delCard();
						
					   	}//Add (deal)
								
										
										
						  public void AddBottom()
						{
						
		
						Hand1.add(Deck1.getCard(Deck1.CardCount()-1));  //adding bottom card from deck
						Deck1.delCard(Deck1.CardCount()-1);
						
					   	}//Add (deal)
												
						 
				  //show card count
				public int HandCount()
				{	 
						 
						HandSize = Hand1.size();
						
						return HandSize;
						 
						 
						 }//CardCount
						 
						 
					 
					 public String toString() 
					  {
					 
					  return ("\n"+"Hand has :"+HandCount()+ " Cards. " +Hand1+"\n"+Deck1.toString());   //HandCount()
					  
					//  return ("card of " + Suit);
					  
					  }//toString 
					  
					  

             //method for getting score of cards in Hand
			public int HandScore()
			{
			
			   int Rank =0;
				int Score =0;	
			//   Card CheckCard = new Card(); //don't need
				
			   for(int i = 0; i < Hand1.size(); i++)//runs through each card in hand
				{   
					 						 
								Rank = Hand1.get(i-0).getRank(); //reurns rank for selected card
							
						//	System.out.println("card checked: "+Hand1.get(i).toString()+"\n"); 
							 
							 
						//	 System.out.println("card copied: "+CheckCard.toString()+"\n");
						//	 System.out.println("card rank: "+Rank+"\n");		//score	

				        
				    	     Score = Rank + Score;  //tallies all the scores based on rank of cards in hand
									 
			    	}//for  
				 
			 
				 
			  return Score;  //returns the tallied score.

        }//HandScore 
					 
				
					 		  
}//Deck Class
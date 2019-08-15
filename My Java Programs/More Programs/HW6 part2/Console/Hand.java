import java.util.ArrayList;
import javax.swing.*;
import java.lang.*;
import java.util.*;




/**
   The Hand Class
*/

	public class Hand
	{

      //initialze the card objects
     //private Deck Deck1;  //creates 52 card deck
	  
	  private static Deck Deck1;  //creates 52 card deck
	  
	  
	  private Card Card1,Card2,Card3,Card4,Card5,Card6,Card7;
	  
	  					
	
	  private ArrayList<Card> Hand1;  //ArrayList for player's hand
	  
	  private int HandSize;
	 
	
  
        		//contructor
		 public Hand()    
		 {
	   		
				CreateDeck();
		
				
				 CreateHand(); 
			  
			    HandCount();
	    
		  
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
						
					/*	
						Card1 = Deck1.getCard(0); //card 1 reference is set to object in deck array at position 0
					 Deck1.delCard(0);   //delete from deck
					 
					 Card2 = Deck1.getCard(0); //card 2
					 Deck1.delCard(0);  //delete from deck
					 
					 Card3 = Deck1.getCard(0); //card 3
					 Deck1.delCard(0);  //delete from deck
					 
					 Card4 = Deck1.getCard(0); //card 4
					 Deck1.delCard(0);  //delete from deck
					 
					 Card5 = Deck1.getCard(0); //card 5
					 Deck1.delCard(0);  //delete from deck
					 
					 Card6 = Deck1.getCard(0); //card 6
					 Deck1.delCard(0);  //delete from deck
					 
					 Card7 = Deck1.getCard(0); //card 7
					 Deck1.delCard(0);  //delete from deck
						
				  */
				
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
					  

			
		  
		  
		  
		  
}//Deck Class
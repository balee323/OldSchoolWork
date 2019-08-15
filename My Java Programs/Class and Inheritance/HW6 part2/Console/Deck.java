import java.util.ArrayList;
import javax.swing.*;
import java.lang.*;
import java.util.*;




/**
   The Deck Class
*/

	public class Deck
	{

      //initialze the card objects
   
  
	  private static Card Card1,Card2,Card3,Card4,Card5,Card6,Card7,Card8,Card9,
	  					Card10,Card11,Card12,Card13;
	
	  private static Card Card14,Card15,Card16,Card17,Card18,Card19,Card20,Card21,Card22,
	  					Card23,Card24,Card25,Card26;
						 
	  private static Card Card27,Card28,Card29,Card30,Card31,Card32,Card33,Card34,Card35,
	  					Card36,Card37,Card38,Card39; 
						
	  private static Card Card40,Card41,Card42,Card43,Card44,Card45,Card46,Card47,Card48,
	  					Card49,Card50,Card51,Card52; 
	 

	   

	  private ArrayList<Card> Deck1;
	  
	  private int DeckSize;
	  
	    //for shuffling
	  private Random Shuffle1 = new Random();  //random number1
	  private Random Shuffle2 = new Random();  //random number2
	  private int randomNum1, randomNum2;
	  
	  
  
        		//contructor
		 public Deck()    
		 {
	   
			  CreateCards();
			 
			  CreateDeck(); 
			  
			//  DeckShuffle();
			  
			  CardCount();
			       
		 
		 
		  
		  }//constructor
 
	
			   public void CreateCards()
				{
				
				Card1 = new Card("AH");
				Card2 = new Card("2H");
				Card3 = new Card("3H");
				Card4 = new Card("4H");
				Card5 = new Card("5H");
				Card6 = new Card("6H");
				Card7 = new Card("7H");
				Card8 = new Card("8H");
				Card9 = new Card("9H");
				Card10 = new Card("10H");
				Card11 = new Card("JH");
				Card12 = new Card("QH");
				Card13 = new Card("KH");
				
				Card14 = new Card("AD");
				Card15 = new Card("2D");
				Card16 = new Card("3D");
				Card17 = new Card("4D");
				Card18 = new Card("5D");
				Card19 = new Card("6D");
				Card20 = new Card("7D");
				Card21 = new Card("8D");
				Card22 = new Card("9D");
				Card23 = new Card("10D");
				Card24 = new Card("JD");
				Card25 = new Card("QD");
				Card26 = new Card("KD");
				
				Card27 = new Card("AS");
				Card28 = new Card("2S");
				Card29 = new Card("3S");
				Card30 = new Card("4S");
				Card31 = new Card("5S");
				Card32 = new Card("6S");
				Card33 = new Card("7S");
				Card34 = new Card("8S");
				Card35 = new Card("9S");
				Card36 = new Card("10S");
				Card37 = new Card("JS");
				Card38 = new Card("QS");
				Card39 = new Card("KS");
				
				Card40 = new Card("AC");
				Card41 = new Card("2C");
				Card42 = new Card("3C");
				Card43 = new Card("4C");
				Card44 = new Card("5C");
				Card45 = new Card("6C");
				Card46 = new Card("7C");
				Card47 = new Card("8C");
				Card48 = new Card("9C");
				Card49 = new Card("10C");
				Card50 = new Card("JC");
				Card51 = new Card("QC");
				Card52 = new Card("KC");		
				
			  }//createCards
		

				
			  public void CreateDeck()
			  {
		  			
					Deck1 = new ArrayList<Card>(104);
				  
				     Deck1.add(Card1);
					  Deck1.add(Card2);
					  Deck1.add(Card3);
					  Deck1.add(Card4);
					  Deck1.add(Card5);
					  Deck1.add(Card6);
					  Deck1.add(Card7);
					  Deck1.add(Card8);
					  Deck1.add(Card9);
					  Deck1.add(Card10);
					  Deck1.add(Card11);
					  Deck1.add(Card12);
					  Deck1.add(Card13);
					  
					  Deck1.add(Card14);
					  Deck1.add(Card15);
					  Deck1.add(Card16);
					  Deck1.add(Card17);
					  Deck1.add(Card18);
					  Deck1.add(Card19);
					  Deck1.add(Card20);
					  Deck1.add(Card21);
					  Deck1.add(Card22);
					  Deck1.add(Card23);
					  Deck1.add(Card24);
					  Deck1.add(Card25);
					  Deck1.add(Card26);
				    
					  Deck1.add(Card27);
					  Deck1.add(Card28);
					  Deck1.add(Card29);
					  Deck1.add(Card30);
					  Deck1.add(Card31);
					  Deck1.add(Card32);
					  Deck1.add(Card33);
					  Deck1.add(Card34);
					  Deck1.add(Card35);
					  Deck1.add(Card36);
					  Deck1.add(Card37);
					  Deck1.add(Card38);
					  Deck1.add(Card39);
				  
		           Deck1.add(Card40);
					  Deck1.add(Card41);
					  Deck1.add(Card42);
					  Deck1.add(Card43);
					  Deck1.add(Card44);
					  Deck1.add(Card45);
					  Deck1.add(Card46);
					  Deck1.add(Card47);
					  Deck1.add(Card48);
					  Deck1.add(Card49);
					  Deck1.add(Card50);
					  Deck1.add(Card51);
					  Deck1.add(Card52);
				
				}//CreateDeck		
						
	
						
				public void DeckShuffle()
				{		
						
						
				for(int i=0; i <200; i++){
					randomNum1 = Shuffle1.nextInt(52);   //pick one random card from deck 
					randomNum2 = Shuffle2.nextInt(52);   //pick second random card number from deck
				  		 Collections.swap(Deck1,randomNum1,randomNum2);  //swap both random cards
					    
				 }//for	 
					 
		
						Deck1.toString();  //to show the shuffled cards.
						
						
				}//shuffle		
						
						
						 
				  //show card count
				public int CardCount()
				{	 
				      DeckSize = 0;
						 
						DeckSize = Deck1.size();
						
						return DeckSize;
						 
						 
						 }//CardCount
						 
						 
						 
						 
						 
				public Card getCard()
			   {
			     
				   System.out.println("Top Card: "+Deck1.get(0));  //top most card
				  return Deck1.get(0);
				  
				  }
			 		
					//overloaded function
				public Card getCard(int cardPosition)
			   {
			     
				   System.out.println("Card: "+Deck1.get(cardPosition));
				  return Deck1.get(cardPosition);
				  
				  }
	
					
					
					
				public void delCard()
				{
				 System.out.println("removing top Card: "+Deck1.get(0)+"\n");
				 Deck1.remove(0);
				  }	
					
					
				public void delCard(int cardPosition)
				{
				 System.out.println("removing Card at position: "+Deck1.get(cardPosition)+"\n");
				 Deck1.remove(cardPosition);
				  }	
	
				 
					 
					 
					 public String toString() 
					  {
					 
					  return ("Deck contains :"+CardCount() + " "+Deck1);
					  
					//  return ("card of " + Suit);
					  
					  }//toString 
					  

			
		  
		  
		  
		  
}//Deck Class
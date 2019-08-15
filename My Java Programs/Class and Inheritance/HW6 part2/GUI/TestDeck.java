
import javax.swing.*;
import java.lang.*;

	
	
	 public class TestDeck
	 {
	

	
		public static void main(String[]args)
		{
		
				  
		  
         Deck testDeck1 = new Deck();
			
 
			 System.out.println(testDeck1.toString()+"\n");
			 
			 testDeck1.DeckShuffle();
		    
			 System.out.println(testDeck1.toString()+"\n");
						
			 
			 for(int i=0;i<4;i++){
			 testDeck1.getCard();  //default card at position 0.
			 testDeck1.delCard();
			 }
			 
			 System.out.println(testDeck1.toString()+"\n");
			 
			 testDeck1.getCard(4);  //select which card to remove (overloaded function).
			 testDeck1.delCard(4);
			 
			  System.out.println(testDeck1.toString()+"\n");  //total of 5 cards removed from deck.
			 
			 System.exit(0);			
						
				}//main
			
			
			
			
		//	public static void showCard(Card test_Card){
			  
		//	     System.out.println(test_Card.toString() +"\n");
						
			//			}//
			
			
			
			
			
   }//class			
	
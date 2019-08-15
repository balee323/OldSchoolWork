
import javax.swing.*;
import java.lang.*;

	
	
	 public class TestHand
	 {
	

	
		public static void main(String[]args)
		{
		
				  

		  
          
			 Hand testHand1 = new Hand();  //create new hand (also creates deck)
			
			 Hand testHand2 = new Hand();  //should only create an additional hand since deck is static
 
			// System.out.println(testHand1.toString()+"\n"); //shows empty hand and shuffled deck
			 
	       testHand1.Add();  //top card from deck added to hand (and removed from deck)
			 
			 testHand1.Add();  //top card from deck added to hand (and removed from deck
			 
			 
			 testHand2.Add();
			 
			 
			 
			 
			  System.out.println("testHand1 " +testHand1.toString()+"\n");
			  System.out.println("testHand2" +testHand2.toString()+"\n");
						
						
			System.out.println("testHand1 score: "+testHand1.HandScore()+"\n");		//score	
					 
			 System.exit(0);			
						
				}//main
			
			
			
			
		//	public static void showCard(Card test_Card){
			  
		//	     System.out.println(test_Card.toString() +"\n");
						
			//			}//
			
			
			
			
			
   }//class			
	
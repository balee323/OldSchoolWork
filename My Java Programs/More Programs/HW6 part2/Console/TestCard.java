
import javax.swing.*;
import java.lang.*;

	
	
	 public class TestCard
	 {
	

	
		public static void main(String[]args)
		{
		
				  
		  
         Card testCard1 = new Card("AH");
			Card testCard2 = new Card("AD");
			Card testCard3 = new Card("AS");
			Card testCard4 = new Card("AC");
			
		   Card testCard5 = new Card("KC");
			Card testCard6 = new Card("QH");
			Card testCard7 = new Card("JS");
			
			Card testCard8 = new Card("Wrong");
		
			
			
			
			showCard(testCard1);
			testCard1.getPictureName();	
			showCard(testCard2);	
			showCard(testCard3);	
			showCard(testCard4);	
			showCard(testCard5);	
			showCard(testCard6);	
			showCard(testCard7);
			showCard(testCard8);	
		
			
		  
	
			  
			  
			// System.out.println(testCard1.toString() +"\n"+ testCard2.toString() +"\n"+ 
			 //		testCard3.toString() +"\n"+ testCard4.toString());
						
						
						
						
				}//main
			
			
			
			
			public static void showCard(Card test_Card){
			  
			     System.out.println(test_Card.toString() +"\n");
						
						}//
			
			
			
			
			
   }//class			
	
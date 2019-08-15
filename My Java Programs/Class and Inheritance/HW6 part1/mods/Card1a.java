
import javax.swing.*;
import java.lang.*;



/**
   The Card Class
*/

	public class Card
	{


    private String Suit;
	 private int Rank;
	 private String PictureName;
	 private String CardName;
	 private String faceCard;


      //(PicName +".jpg") = CardName;

    // public Card(String cardSuit,String CardRank, String CardpicName)
      
		 public Card(String Card_Name)    
		 {
	   
		     CardName = Card_Name;
		
			  Suit = SetSuit();
			  
			  Rank = SetRank();
			  
			  PictureName = SetPictureName();
	
        }//
  
  
	
	  public String SetSuit()
	  {
	   
				if(CardName.contains("H")){
				   Suit = "HEARTS";
					}
			  
			  	if(CardName.contains("D")){
				   Suit = "DIAMONDS";
					}
		
				if(CardName.contains("S")){
				   Suit = "SPADES";
					}
		
				if(CardName.contains("C")){
				   Suit = "CLUBS";
					}
	
	       return (Suit);
      
      }//CardSuit
	  


	   public int SetRank()
		 {
			
					 if(CardName.contains("2")){
							   Rank = 2;
								faceCard ="2";
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
						   Rank = 1;
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
			
		       
			  return Rank;

        }//CardRank

		
		  
		  public String SetPictureName()
	      {
					String CardFile;
					
					PictureName = (CardName +".jpg");
					
					//CardFile = picFile;
					
					return (PictureName);
					
					}//CardPicture
	
	
		
		
		// SetPictureName
		 
		 
		 
		 public String toString() 
		  {
		 
		  return (faceCard + " of " + Suit+"  value of: "+Rank);
		  
		//  return ("card of " + Suit);
		  
		  }//toString 
		  
		  
		  
		  public String getSuit()
		   {
			  return Suit;
			 }
			 
			 
			 public int getRank()
		   {
			  return Rank;
			 }
			 
			
			
			public String getPictureName()
		   {
			  System.out.println("card image file: "+PictureName+"\n");
			  
			  return PictureName;
			 }
			 
			 
			 
		
		  
		  
		  
		  
}//card Class

 /**
   Word Class

 */
 
   public class Word {
	
	
	
	
		private String Word;
	
		private int Count = 0;
		private int tempCount = 0;
			
		private static boolean Vowel = false;
		
		char[] letterArray = new char[20];
		
		
		
	
	
	public void setWord(String Word_method) {
		
		 Word = Word_method;
		 
		 } //close method
		 
		 
		 
	 public String getWord() {
		
		 return Word;
		 
		 } //close method
		 
		 
		 
		 
		 
	   
		 
		 
		 
	public boolean isVowel() {
	
     int i;	
	           			   
	  
	     for (i = 0; i < Word.length(); i = i + 1){        //converts word to char array
		    letterArray[i] = new Character(Word.charAt(i));
			 }
	  
	  
	  
  		
			
		  for (i = 0; i < Word.length(); i = i + 1){   //checks each char for vowel
		     
			  
			  if (letterArray[i]==('a')|| letterArray[i]==('A')){
			   Vowel = true;
				 tempCount = tempCount + 1;
			    	}//if
			   		 
			
		     if (letterArray[i]==('e')|| letterArray[i]==('E')){
			   Vowel = true;
				  tempCount = tempCount + 1;
			      }//if
			  
		
		     if (letterArray[i]==('i')|| letterArray[i]==('I')){
			   Vowel = true;
				  tempCount = tempCount + 1;
				   }//if
			   
	
		     if (letterArray[i]==('o')|| letterArray[i]==('O')){
			   Vowel = true;
				  tempCount = tempCount + 1;
				   }//if
			   
	
		     if (letterArray[i]==('u')|| letterArray[i]==('U')){
			   Vowel = true;
				  tempCount = tempCount + 1;
				    }//if
			
   
		     if (letterArray[i]==('y')|| letterArray[i]==('Y')){
			   Vowel = true;
				  tempCount = tempCount + 1;
				  	 }//if	        	      
		  
			 Count = tempCount;  


				
		  }//for
				  
      System.out.println("simple vowel Count: "+Count);
 	 
    	 return (Vowel);
	 
		 
  }//closes isVowel


 
		 
	
		 
	public int countSyllables(){
	
	   if ((Word.length()) <= 3){
		    Count = 1;
		  }
	
		else if (Vowel == true && Word.length() > 3){
		   
			// for (i = 0; i < Word.length(); i = i + 1){   //checks each char for vowel
		     			  
			//  if (letterArray[i]==('a')|| letterArray[i]==('A')){
		  

		
		
		  
		//  Count = 55;
		  
		  	}
				 
	return (Count);
	
}// countSyllables	
		 
		 
  
  

	  
	
	
	
	
	
	
}//close class word
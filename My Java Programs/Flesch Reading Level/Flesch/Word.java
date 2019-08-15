
 /**
   Word Class

 */
 
   public class Word {
	

		private String Word;  //string referenced to lowercased string object
	
		private int Count = 0;  //final vowel count
		private int tempCount = 0;  //temporay vowel count
			
		private static boolean Vowel = false;
		
		private static boolean Present = false;
		
		private char[] letterArray = new char[20];  //Char Array to store lowerCase converted characters
		
		char[] vowelArray = { 'a', 'e', 'i', 'o', 'u', 'y'};
		
	//	private String VowelList = "aeiouy";
		
		
	
		
		
		
//==========================================	
	
	public void setWord(String Word_method) {
		
		 Word_method = Word_method.toLowerCase();
		
		 Word = Word_method;
		 
		 } //close method
		 
	
//=========================================		 
		 
	 public String getWord() {
		
						
		 return Word;
		 
		 } //close method
		 
		 
	 
//==========================================		 
		 
	public boolean isVowel() {
	
     int i;	
	           			   
	  
	     for (i = 0; i < Word.length(); i = i + 1){        //converts word to char array
		    letterArray[i] = new Character(Word.charAt(i));
						
			 }
		
		  for (i = 0; i < Word.length(); i = i + 1){   //checks each char for vowel
		     
			  
			  if (letterArray[i]==('a') || letterArray[i]==('A')){  //actually don't need to compare to uppercase anymore
				  Vowel = true;                                     //since I converted the string to lowercase.
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
				  
   //   System.out.println("simple vowel Count: "+Count);
 	 
    	 return (Vowel);
	 
		 
  }//closes isVowel


//============================================
 
 
 
		 
	public int countSyllables(){
	
	int i = 0;
	int j = 0;
	
	
	   if ((Word.length()) <= 3){
		    Count = 1;
		  }
	
		else if (Vowel == true && Word.length() > 3){  //counts syllables for all words greater than 3 characters.
		   	  		 
						 
			  		 if (Word.endsWith("es")){  //if es is at end of word, subtract 1 from syllable count.
				 	  Count = Count - 1;
						}
				
		  
		      	 if (Word.endsWith("ed")){  //if ed is at end of word, subtract 1 from syllable count.
					   Count = Count - 1;
						}
							
					 if (Word.endsWith("e")&&(!Word.endsWith("le"))){ //if e is at end of word, subtract 1 from syllable count, but ignore le.
					   Count = Count - 1;
						}
					
	 			    
 	           for (i = 0; i < Word.length() - 2; i = i + 1){   //[1] checks each char of the "word" against a, e, i, o, u, and y.
	                
						 for (j=0; j < 6; j = j + 1){  //[2] letterArray at position i is compared to a, e, i, o, u, and y

			          
					          if (letterArray[i] == vowelArray[j]){  //check the first char in word for equality against aeiou.
								   								 
								      if (letterArray[i+1] == vowelArray[j]){  //checks for double vowels
										     Count = Count - 1;
											    }//if
											  
											 
											   if (letterArray[i+1] == ('a')){ //checks for second letter to be 'a'
												    Count = Count - 1;
												      }//IF
														
											   if (letterArray[i+1] == ('e')){  //checks for second letter to be 'e'
												    Count = Count - 1;
												      }//IF
														
												if (letterArray[i+1] == ('i')){  //checks for second letter to be 'i'
												    Count = Count - 1;
												      }//IF
														
												if (letterArray[i+1] == ('o')){ //checks for second letter to be  'o'
												    Count = Count - 1;
												      }//IF
														
												if (letterArray[i+1] == ('u')){ //checks for second letter to be 'u'
												    Count = Count - 1;
												      }//IF
														
												if (letterArray[i+1] == ('y')){ //checks for second letter to be 'y'
												    Count = Count - 1;
												      }//if										
											
											   else{
												return (Count);
												}//else
												
												
			             }//if
				   	 }//[2]for	 
				   }//[1]for


				
		  				  
		  	}//else if
				 
	return (Count);
	
}// countSyllables	
		 
		 
  
  

//====================================	  
	
	
	
	
	
	
}//close class word
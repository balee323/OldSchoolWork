#include <iostream>
#include <cmath>
using namespace std;


void difficulty_1(int game_1);
void difficulty_2(int game_2);
void difficulty_3(int game_3);

int main()
{



char decision;  // for program loop
do{ // for program repeat loop.

int option;
int game1 =1;
int game2 =2;
int game3 =3;



cout << endl;
cout << "  Brian Lee" << endl;
cout << "  C++ Programming, Jim Shain" << endl;
cout << "  Hangman Project " << endl << endl;

cout << "   _     _   \n";  //my very basic graphic
cout << "   O     O   \n";
cout << "      ^      \n";
cout << "     ___     \n";
cout << "    |___|    \n";
cout<< endl << endl;
cout << "  This is a game of hangman!\n";
cout << "  Please Choose an option" << endl << endl;




	cout << endl;  //This is my menu section for the 4 game options.
	cout << "  Choose 1 for easy difficulty. \n";
	cout << "  Choose 2 for medium difficulty. \n";
	cout << "  Choose 3 for hard difficulty. \n";
	cout << "  Choose 4 to exit. \n";
	cin >> option;
	
		

	{
	if(option==1)
		
		
		difficulty_1(game1);
	}

		
	{

	if(option==2)
		

		difficulty_2(game2);
	
	}



		{
		if(option==3)
		
		difficulty_3(game3);
		}


		{
		if(option==4)
		return 0;
		}

	

cout << endl << endl;
	cout << "Press Y and enter to repeat or any key and enter to exit program. " << endl;  //I have been adding this loop to all my programs to help with de-bugging.
    cin >> decision;
	cout << endl;

}while (decision =='y' || decision =='Y' );  //if decision is not equal to "lowercase n" then repeat program.



return 0;

}

//--------------------------------------------------functions defined:

void difficulty_1(int game_1)					
{
 
	
	cout << " You have 12 guesses." << endl << endl;

	char word[11]="everything";   // and array with 11 characters preset to "everything"
	char blanks[30];        //an array that holds 30 characters which will be spaces
    int i = 0;      //counter
    char guess;   
	int i_g = 0;  //guessing counter  12 tries for guessing. Game ends after 
    int i_cg1 = 0;  //correct guess counter.    
    int total_letters = strlen(word);        //total_letters is an interger for the total number of characters in the "Char word"

	

        //the words must be converted to uppercase for the string functions to work.
    for (i = 0; i < total_letters; i++){  //use of counter to exit uppercase loop
        word[i] = toupper(word[i]);  //toupper converts to uppercase.  Still not sure why I need it, but do.  I tried without, program won't work.
    }
   







    strcpy_s(blanks, word);                //string copy copies the "Word" array  to the "blanks" array

    for (i=0; i < total_letters; i++) {        //converts characters to underscores

        if (word[i])    //this is if statement works for as long as an array of word is present.  Ex. Word[1], word[2], etc.
			blanks[i] = '_';   //this process sets blanks array to underscores. 
        //else blanks[i] = word[i];  //dont need this.
	}   
	
	
	i=0;
    while (i_g < 12) {                //play while incorrect guesses is less than 12. Have 12 tries

        cout<<"Here is unknown word. "<<blanks<<"."<<endl;  //blanks are displayed that are equal to uknown word
        cout<<"Please enter 1 letter at a time and press enter."<<endl;
        cin>>guess;
        guess = toupper(guess); //converts guess to uppercase.

		i_g++; //guessing counter.  
		cout << " Guesses left: " << (abs(i_g-12)) << endl;  //displays guesses left before game over.
        
        for (i = 0; i <= total_letters; i++) {   //here is the core of the hangman code.  Loop runs until the counter is equal to the word.

                if (guess == word[i]) {          //if guess is equal to the word in the array, as the loop runs, then 
                    blanks[i] = guess;        //blanks[i], (is at same location as word[i]) is filled in with the letter at the correct location
					//i_cg1++;  //trying to use this counter as a correct guess counter for the win phrase... trial and error
                }


        }
		
//------------------------------------------
	//{
					//if (i_cg1 == 11)
//cout<<" What!!!  You WON??? HOW???  :>  " << endl << endl;   //Ok, think this works now....
			//	i=11;
				//i_g=0;
	//}
//------------------------------------------------------


	}    

	



    cout<<"game over";
    
	//system("pause");
  
              
 }

void difficulty_2(int game_2)					
{
 
	cout << " You have 17 guess. " << endl << endl;

	char word[16]="congratulations";   // and array with 11 characters preset to "everything"
	char blanks[30];        //an array that holds 30 characters which will be spaces
    int i = 0;      //counter
    char guess;   
	int i_g = 0;  //guessing counter  17 tries for guessing. Game ends after 
    int i_cg2 = 0;  //correct guess counter.      
    int total_letters = strlen(word);        //String-length is set equal to the total letters of the word.

	

        //the words must be converted to uppercase for the string functions to work.
    for (i = 0; i < total_letters; i++){  //use of counter to exit uppercase loop
        word[i] = toupper(word[i]);  //toupper converts to uppercase.
    }
   

	

    strcpy_s(blanks, word);                //string copy copies the "Word" array  to the "blanks" array

    for (i=0; i < total_letters; i++) {        //converts characters to underscores

        if (word[i])    //this is if statement works for as long as an array of word is present.  Ex. Word[1], word[2], etc.
			blanks[i] = '_';   //this process sets blanks array to underscores. 
        //else blanks[i] = word[i];  //dont need this.
	}   
	

       
	i=0;
    while (i_g < 17) {                //play while less than 17 tries

        cout<<"Here is the blank word! "<<blanks<<"."<<endl;
        cout<<"Please enter 1 letter and press enter."<<endl;
        cin>>guess;
        guess = toupper(guess); //converts guess to uppercase.

		i_g++; //guessing counter
		cout << " Guesses left: " << (abs(i_g-17)) << endl;  //used absolute value function to display countdown in positive number



        //cbeck guess!
        for (i = 0; i < total_letters; i++) { 

                if (guess == word[i]) {
                    blanks[i] = guess;        //fill in the puzzle with the letter
					//i_cg2++;  //trying to use this counter as a correct guess counter for the win phrase... trial and error
                }

        }
			
  	
	}    
//------------------------------------------
		//	{
				//	if (i_cg2 == 15)
//cout<<" What!!!  You WON??? HOW???  :>  " << endl << endl;   //Ok, think this works now....
		
		//	}

//------------------------------------------------------
    cout<<"game over";
    
	//system("pause");
   
		                   
 }

void difficulty_3(int game_3)					
{
 
	cout << " You have 18 guesses. " << endl << endl;

	char word[23]="reinstitutionalization";   // and array with 11 characters preset to "everything"
	char blanks[30];        //an array that holds 30 characters which will be spaces
    int i = 0;      //counter
    char guess;   
	int i_g = 0;  //guessing counter  18 tries for guessing. Game ends after 
    int i_cg3 = 0;  //correct guess counter.      
    int total_letters = strlen(word);        //String-length is set equal to the total letters of the word.

	

        //the words must be converted to uppercase for the string functions to work.
    for (i = 0; i < total_letters; i++){  //use of counter to exit uppercase loop
        word[i] = toupper(word[i]);  //toupper converts to uppercase.
    }
   




    strcpy_s(blanks, word);                //string copy copies the "Word" array  to the "blanks" array

    for (i=0; i < total_letters; i++) {        //converts characters to underscores

        if (word[i])    //this is if statement works for as long as an array of word is present.  Ex. Word[1], word[2], etc.
			blanks[i] = '_';   //this process sets blanks array to underscores. 
        //else blanks[i] = word[i];  //dont need this.
	}   
	
       
	i=0;
    while (i_g < 18) {                //play while less than 18 tries

        cout<<"Here is the blank word! "<<blanks<<"."<<endl;
        cout<<"Please enter 1 letter and press enter."<<endl;
        cin>>guess;
        guess = toupper(guess); //converts guess to uppercase.

	

		i_g++; //guessing counter
		cout << " Guesses left: " << (abs(i_g-18)) << endl;


        //cbeck guess!
        for (i = 0; i < total_letters; i++) { 

                if (guess == word[i]) {
                    blanks[i] = guess;        //fill in the puzzle with the letter
				//i_cg3++;  //trying to use this counter as a correct guess counter for the win phrase... trial and error

        }
			
  	
	}    


			}



	//------------------------------------------
			//{
					//if (i_cg3 == 22)
//cout<<" What!!!  You WON??? HOW???  :>  " << endl << endl;   //Ok, think this works now....
		
		//	}

//------------------------------------------------------
		
   cout<<"game over";
    
	//system("pause");
}
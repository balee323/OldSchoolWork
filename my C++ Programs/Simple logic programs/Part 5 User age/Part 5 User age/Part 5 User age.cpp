// Brian Lee

// C++ Programming, Jim Shain 

// Homework #2, Part 5

// This program calculate your age... I have been working on this forever!!!!!!!!!!!!


#include <iostream>
using namespace std;

int main() {

cout.setf(ios::fixed);  //This is where I set my decimal points
//cout.setf(ios::showpoint);  I decided I did not want to show the decimal
cout.precision(0);

int birthday;  //asks for your birthday ex. 15th or 22nd.
int birthyear;  //asks for your birthyear.
int birthmonth;  //asks for your birthmonth.
int nowmonth, nowday, nowyear;  //these are my varibles for today's date

int age_year;  //more variables. Shows my age in years, approximated.
int age_year_months;  //Converts my age in years to months. Approximated.
int total_age_months; //adds the remainder of months age to the approximate age in months
int age_days; //justs shows how many days old in relation to the current month.
int remainder_months;

cout << endl;
cout << "// Brian Lee" << endl;
cout << "// C++ Programming, Jim Shain" << endl;
cout << "// Homework #2, Part 5 " << endl << endl;

cout << "This program calculates your age. " << endl << endl;
cout << "please enter your bithday in this format: MM DD YYYY \n";
cin >> birthmonth >> birthday >> birthyear;   //all there variables are entered into the program.
cout << "You entered " << birthmonth << " " <<  birthday << " " <<  birthyear << endl << endl;  //just verifies what was entered

cout << "Please enter today's date as MM DD YYYY " << endl;
cin >> nowmonth >> nowday >> nowyear;  //all there date components are entered into the program.
cout << "You entered " << nowmonth << " " <<  nowday << " " <<  nowyear << endl << endl;  //just verifies what was entered

//calculations section

age_year = nowyear - birthyear;  //will make you slightly older or younger depending on your birthmonth.
age_year_months = age_year * 12;  //converts years old to months old.

cout << " You will be: " << age_year << "  old this year.. or will you? Continue to find out." << endl << endl;

system("pause");

//this section is tricky.  You will either be less old than the current year or older
//depending on your birthmonth.

if (nowmonth < birthmonth) total_age_months = age_year_months - (birthmonth - nowmonth);  //calculates months old before birthmonth using if statement
if (nowmonth > birthmonth) total_age_months = (nowmonth - birthmonth) + age_year_months;  //calculates months old after birthmonth  using if statement

//if (nowday < birthday) nowday == age_days;   I decided this is too complicated.. I need to focus on calculus II.
//if (nowday > birthday) nowday - birthday == age_days;


cout << "You are: " << total_age_months << "  total months old. " << endl;
cout << "you are: " << (total_age_months / 12) << "  years and: " << (remainder_months = total_age_months % 12) << " months old" << endl;

//cout << "And: " << age_days << " old. " << endl;




system("pause");


return 0;
}

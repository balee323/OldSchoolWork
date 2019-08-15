// Brian Lee

// C++ Programming, Jim Shain 

// Homework #2, Part1  (don't grade this one, see revB)

// This program converts your age to seconds. 
// I went to much over my head on this one, plus I am not sure if my math is right.  Please grade revB.
// I still wanted to show this one to you.


#include <iostream>
#include <ctime>
using namespace std;

int main() {


cout << endl;
cout << "// Brian Lee" << endl;
cout << "// C++ Programming, Jim Shain" << endl;
cout << "// Homework #2, Part1 (don't grade this one, use revB) " << endl;

char date [10];  //I tried to use system date to subtract from birthdate, but cannot subtract a char from int.
_strdate_s(date);

int birthday;  //these are my variables for birthdate in month, day, and year.
int birthyear;
int birthmonth;
int nowmonth, nowday, nowyear;  //these are my varibles for today's date

double sec_day = 86400;

cout.setf(ios::fixed);  //This is where I set my decimal points
//cout.setf(ios::showpoint);  I decided I did not want to show the decimal
cout.precision(0);

int age_year;  //more variables. Shows my age in years.
int age_year_days;  //Converts my age in years to days.
int true_day_age;  //shows my true age in days (birth month + birthday minus age in years)
double age_sec;    // declairs the variable for my true age in seconds



cout << "This program converts your age in years and months to seconds. " << endl << endl;
cout << "please enter your bithday in this format: MM DD YYYY \n";
cin >> birthmonth >> birthday >> birthyear;
cout << "You entered " << birthmonth << " " <<  birthday << " " <<  birthyear << endl << endl;

cout << "Please enter today's date as MM DD YYYY " << endl;
cin >> nowmonth >> nowday >> nowyear;
cout << "You entered " << nowmonth << " " <<  nowday << " " <<  nowyear << endl << endl;

//calculations section

age_year = nowyear - birthyear;
age_year_days = age_year * 365;


true_day_age = age_year_days - ((birthmonth * 30) + birthday); 

age_sec = true_day_age * sec_day;

cout << "You are: " << true_day_age << " days old as of today. " << endl;
cout << "And " << age_sec << "  seconds old." << endl;

system("pause");


return 0;
}

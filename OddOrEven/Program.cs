﻿

Console.WriteLine("Enter a number:");
int userNum = Convert.ToInt32(Console.ReadLine());

//kas kasutaja arv on paaris või paaritu

int result = userNum % 2;

if (result != 0) //!= - ei ole võrdne 
{
    Console.WriteLine("User numer is odd.");
}else 
{
    Console.WriteLine("User number is even.");
}
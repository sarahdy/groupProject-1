using System;
public class Test
{
public static void Main()
{
double payment;
string name;
int ssn;
char typeOfLoan = 'b';
char creditRating = 'c';
double baseInterestRate = 0.04;
double downPayment = 3000;
double propertyValue = 48000;
double interestRate;
int years=3;

double loanAmount;
if(downPayment < Math.Round((propertyValue/10), 2)){
interestRate = baseInterestRate+0.01;
}
else{
interestRate = baseInterestRate;
}
Console.WriteLine("Interest rate is: "+ interestRate);
switch(creditRating){
case 'a':
interestRate = interestRate;
break;
case 'b':
interestRate = interestRate + 0.01;
break;
case 'c':
interestRate = interestRate + 0.02;
break;
case 'd':
interestRate = interestRate + 0.3;
break;
}
Console.WriteLine("Interest rate is: "+ interestRate);
switch(typeOfLoan){
case 'r':
interestRate = interestRate;
break;
case 'b':
interestRate = interestRate + 0.005;
break;
case 'h':
interestRate = interestRate + 0.01;
break;
case 'e':
interestRate = interestRate + 0.025;
break;
case 'a':
interestRate = interestRate + 0.035;
break;
}
Console.WriteLine("Interest rate is: "+ interestRate);
loanAmount = propertyValue-downPayment;
double totalCost = loanAmount + (loanAmount * interestRate)*years;
Console.WriteLine("Interest rate is: "+ totalCost);
}
}

    

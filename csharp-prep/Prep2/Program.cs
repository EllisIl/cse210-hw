using System;

class Program
{
    static void Main(string[] args)
    {


        int grade;
        char letterGrade, gradeSign;

        Console.Write("What was your grade? ");
        grade = int.Parse(Console.ReadLine());

        if (grade >= 90){
            letterGrade = 'A';
        }
        else if (grade >= 80){
            letterGrade = 'B';
        }
        else if (grade >= 70){
            letterGrade = 'C';
        }
        else if (grade >= 60){
            letterGrade = 'D';
        }
        else{
            letterGrade = 'F';
        }

        int lastDigit = grade % 10;

        if (letterGrade != 'F' && grade < 100){
            if (lastDigit >= 7 && letterGrade != 'A'){
                gradeSign = '+';
            }
            else if (lastDigit < 3){
                gradeSign = '-';
            }
            else{
                gradeSign = ' ';
            }
        } else {
            gradeSign = ' ';
        }
            
        Console.WriteLine("Your letter grade is " + letterGrade + gradeSign);
    }
}
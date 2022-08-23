using System;

namespace MoodAnalyzerReflection
{
  public  class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("::::::::::Welcome To Mood Analyzer Program Of Reflection Topic:::::::::::::");
            Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");

            Console.WriteLine("Please Enter The Message For E.g- Happy or Sad Mood");
            string message = Console.ReadLine();
            //Creating Instance Of Class.
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer(message);
            //Referance stored in result .
           string result =  moodAnalyzer.AnalyseMood(message);
            Console.WriteLine(result + " " + "MOOD");
        }
    }
}

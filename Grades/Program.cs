using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace Grades
	{
	class Program
		{
		static void Main(string[] args)
			{

			

			
			SpeechSynthesizer synth = new SpeechSynthesizer();
			//synth.Speak("Hello This is the grade book program");

			GradeBook book = new GradeBook();
			book.Name = "Dave's gradwbook";
			book.AddGrade(91);
			book.AddGrade(89.5f);
			book.AddGrade(75);
			Console.Write(book.Name);
			GradeStatistics stats = book.ComputeStatistics();
			WriteResult("Average",stats.AverageGrade);
			Console.WriteLine(stats.LowestGrade);
			Console.WriteLine(stats.HighestGrade);
			




			}
		static void WriteResult(string description,int result)
		{
			Console.WriteLine(description + ": " + result);
		}
		static void WriteResult(string description, float result)
		{
			Console.WriteLine($"{description}: {result:F2}",description , result);
		}







	}

		

	}

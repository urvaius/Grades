using System;
using System.Collections.Generic;
using System.IO;
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

			GetBookName(book);
			AddingGrades(book);
			SaveGrades(book);
			WriteResults(book);



		}

		private static void WriteResults(GradeBook book)
		{
			GradeStatistics stats = book.ComputeStatistics();
			WriteResult("Average", stats.AverageGrade);
			Console.WriteLine(stats.LowestGrade);
			Console.WriteLine(stats.HighestGrade);
			WriteResult(stats.Description, stats.LetterGrade);
		}

		private static void SaveGrades(GradeBook book)
		{
			using (StreamWriter outputFile = File.CreateText("grades.txt"))
			{
				book.WriteGrades(outputFile);

			}
		}

		private static void AddingGrades(GradeBook book)
		{
			book.AddGrade(91);
			book.AddGrade(89.5f);
			book.AddGrade(75);
		}

		private static void GetBookName(GradeBook book)
		{
			try
			{
				Console.WriteLine("Enter a name");
				book.Name = Console.ReadLine();
			}
			catch (ArgumentException ex)
			{
				Console.WriteLine(ex.Message);

			}
			catch (NullReferenceException ex)
			{
				Console.WriteLine(" something wrong");
			}
		}


		static void WriteResult(string description, float result)
		{
			Console.WriteLine($"{description}: {result:F2}", description, result);
		}

		static void WriteResult(string description, string result)
		{
			Console.WriteLine($"{description}: {result}", description, result);
		}







	}



}

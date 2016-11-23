using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Tests
{
	[TestClass]
	public class GradeBookTests
	{
		[TestMethod]
		public void ComputesHighestGrade()
		{
			GradeBook gradeBook = new GradeBook();
			gradeBook.AddGrade(10);
			gradeBook.AddGrade(90);

			GradeStatistics results = gradeBook.ComputeStatistics();
			Assert.AreEqual(90, results.HighestGrade);
			

		}
		[TestMethod]
		public void ComputesLowestGrade()
		{
			GradeBook gradeBook = new GradeBook();
			gradeBook.AddGrade(10);
			gradeBook.AddGrade(90);

			GradeStatistics results = gradeBook.ComputeStatistics();
			Assert.AreEqual(10, results.LowestGrade);


		}
		[TestMethod]
		public void ComputesAverageGrade()
		{
			GradeBook gradeBook = new GradeBook();
			gradeBook.AddGrade(91);
			gradeBook.AddGrade(89.5f);
			gradeBook.AddGrade(75);

			GradeStatistics results = gradeBook.ComputeStatistics();
			Assert.AreEqual(85.16, results.AverageGrade,0.01);


		}

	}
}

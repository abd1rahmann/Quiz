using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
	
		public class Player
		{
			public string Name { get; set; }
			public int Score { get; set; }

			public Player(string name)
			{
				Name = name;
				Score = 0;
			}

			public void AnswerQuestion(Question question)
			{
				Console.WriteLine($"{Name}, Question: {question.QuestionText}");
				Console.WriteLine("Your options:");
				foreach (var option in question.Options)
				{
					Console.WriteLine(option);
				}

				Console.Write("Enter your answer: ");
				var answer = Console.ReadLine();

				if (answer?.ToLower() == question.CorrectAnswer.ToLower())
				{
					Console.WriteLine("Correct!");
					Score++;
				}
				else
				{
					Console.WriteLine("Incorrect!");
				}
			}
		}
	}


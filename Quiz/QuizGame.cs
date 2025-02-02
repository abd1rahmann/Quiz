using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
	public class QuizGame
	{
		private Dictionary<Category, List<Question>> _questions;

		public QuizGame()
		{
			_questions = new Dictionary<Category, List<Question>>
		{
			{ Category.Football, new List<Question>
				{
					new Question("Who won the 2018 FIFA World Cup?", new List<string> { "Germany", "Brazil", "France", "Argentina" }, "France", Category.Football),
					new Question("Who is known as 'The King of Football'?", new List<string> { "Pele", "Messi", "Cristiano Ronaldo", "Maradona" }, "Pele", Category.Football),
					new Question("Which country has won the most World Cups?", new List<string> { "Brazil", "Italy", "Germany", "Argentina" }, "Brazil", Category.Football),
					new Question("Which team did Lionel Messi play for before moving to Paris Saint-Germain?", new List<string> { "Barcelona", "Real Madrid", "Manchester United", "Juventus" }, "Barcelona", Category.Football),
					new Question("Which player is known as 'CR7'?", new List<string> { "Cristiano Ronaldo", "David Beckham", "Neymar", "Kylian Mbappé" }, "Cristiano Ronaldo", Category.Football),
					new Question("Who won the Ballon d'Or in 2020?", new List<string> { "Lionel Messi", "Cristiano Ronaldo", "Robert Lewandowski", "No winner" }, "No winner", Category.Football),
					new Question("Which country is hosting the 2022 FIFA World Cup?", new List<string> { "Qatar", "Russia", "Brazil", "United States" }, "Qatar", Category.Football),
					new Question("What is the nickname of the French national football team?", new List<string> { "Les Bleus", "The Three Lions", "La Roja", "Azzurri" }, "Les Bleus", Category.Football),
					new Question("Which football club does Neymar play for?", new List<string> { "Paris Saint-Germain", "Barcelona", "Real Madrid", "Juventus" }, "Paris Saint-Germain", Category.Football),
					new Question("What is the maximum number of players on a football team during a match?", new List<string> { "10", "12", "11", "14" }, "11", Category.Football),
					new Question("Which country won the 1998 FIFA World Cup?", new List<string> { "Brazil", "France", "Italy", "Argentina" }, "France", Category.Football),
					new Question("Who is the all-time top scorer in the Premier League?", new List<string> { "Wayne Rooney", "Alan Shearer", "Sergio Agüero", "Thierry Henry" }, "Alan Shearer", Category.Football),
					new Question("Which country is known as the 'Land of the Rising Sun'?", new List<string> { "Japan", "China", "South Korea", "Thailand" }, "Japan", Category.Football),
					new Question("Which football team is nicknamed 'The Red Devils'?", new List<string> { "Manchester United", "Liverpool", "Arsenal", "Chelsea" }, "Manchester United", Category.Football),
					new Question("Who won the Golden Boot in the 2018 World Cup?", new List<string> { "Kylian Mbappé", "Cristiano Ronaldo", "Harry Kane", "Eden Hazard" }, "Harry Kane", Category.Football)
				}
			},
			{ Category.Geography, new List<Question>
				{
					new Question("What is the capital of Japan?", new List<string> { "Beijing", "Seoul", "Tokyo", "Bangkok" }, "Tokyo", Category.Geography),
					new Question("Which continent is the Sahara Desert located on?", new List<string> { "Asia", "Africa", "South America", "North America" }, "Africa", Category.Geography),
					new Question("What is the largest country in the world by area?", new List<string> { "Canada", "China", "Russia", "United States" }, "Russia", Category.Geography),
					new Question("Which river is the longest in the world?", new List<string> { "Amazon", "Nile", "Yangtze", "Mississippi" }, "Nile", Category.Geography),
					new Question("What is the tallest mountain in the world?", new List<string> { "K2", "Mount Kilimanjaro", "Mount Everest", "Mount Fuji" }, "Mount Everest", Category.Geography),
					new Question("Which ocean is the largest?", new List<string> { "Atlantic", "Indian", "Pacific", "Arctic" }, "Pacific", Category.Geography),
					new Question("Which country is the smallest by land area?", new List<string> { "Monaco", "Vatican City", "Nauru", "San Marino" }, "Vatican City", Category.Geography),
					new Question("Which U.S. state is known as 'The Sunshine State'?", new List<string> { "California", "Florida", "Texas", "Hawaii" }, "Florida", Category.Geography),
					new Question("What is the capital of Australia?", new List<string> { "Sydney", "Melbourne", "Canberra", "Brisbane" }, "Canberra", Category.Geography),
					new Question("Which country is the Great Barrier Reef located in?", new List<string> { "Australia", "Mexico", "India", "South Africa" }, "Australia", Category.Geography),
					new Question("Which is the largest island in the world?", new List<string> { "Greenland", "New Guinea", "Borneo", "Madagascar" }, "Greenland", Category.Geography),
					new Question("Which country has the most official languages?", new List<string> { "Switzerland", "India", "South Africa", "Canada" }, "India", Category.Geography),
					new Question("What is the capital of Italy?", new List<string> { "Rome", "Milan", "Florence", "Venice" }, "Rome", Category.Geography),
					new Question("Which continent is known as the 'Dark Continent'?", new List<string> { "Africa", "Asia", "Europe", "Australia" }, "Africa", Category.Geography),
					new Question("Which country has the largest population in the world?", new List<string> { "India", "United States", "China", "Indonesia" }, "China", Category.Geography)
				}
			},
			{ Category.Politics, new List<Question>
				{
					new Question("Who is the current President of the United States?", new List<string> { "Barack Obama", "Donald Trump", "Joe Biden", "George W. Bush" }, "Joe Biden", Category.Politics),
					new Question("Who is the Chancellor of Germany?", new List<string> { "Angela Merkel", "Emmanuel Macron", "Olaf Scholz", "David Cameron" }, "Olaf Scholz", Category.Politics),
					new Question("What is the capital of Canada?", new List<string> { "Toronto", "Vancouver", "Ottawa", "Montreal" }, "Ottawa", Category.Politics),
					new Question("Which country is the United Kingdom made up of?", new List<string> { "Three", "Four", "Five", "Six" }, "Four", Category.Politics),
					new Question("Which party did Winston Churchill belong to?", new List<string> { "Conservative", "Labour", "Liberal Democrats", "UK Independence" }, "Conservative", Category.Politics),
					new Question("Which country did the United States fight in the Vietnam War?", new List<string> { "China", "North Korea", "South Vietnam", "Vietnam" }, "Vietnam", Category.Politics),
					new Question("Which country is led by a Prime Minister?", new List<string> { "Canada", "United States", "Russia", "China" }, "Canada", Category.Politics),
					new Question("Who was the first female Prime Minister of the UK?", new List<string> { "Margaret Thatcher", "Theresa May", "Elizabeth II", "Nicola Sturgeon" }, "Margaret Thatcher", Category.Politics),
					new Question("Who was the first Black president of South Africa?", new List<string> { "Nelson Mandela", "Jacob Zuma", "Thabo Mbeki", "Desmond Tutu" }, "Nelson Mandela", Category.Politics),
					new Question("What is the United Nations?", new List<string> { "A Military Alliance", "A Humanitarian Organization", "A Political Party", "An Economic Union" }, "A Humanitarian Organization", Category.Politics),
					new Question("Which country is known for the political policy of 'Perestroika'?", new List<string> { "China", "Russia", "Poland", "Czech Republic" }, "Russia", Category.Politics),
					new Question("What is the headquarters of the European Union?", new List<string> { "Brussels", "Strasbourg", "Luxembourg", "Berlin" }, "Brussels", Category.Politics),
					new Question("Which country has the world's largest communist party?", new List<string> { "China", "Cuba", "Vietnam", "North Korea" }, "China", Category.Politics),
					new Question("Who was the first President of the United States?", new List<string> { "George Washington", "Abraham Lincoln", "Thomas Jefferson", "John Adams" }, "George Washington", Category.Politics),
					new Question("Which political party is associated with the symbol of an elephant?", new List<string> { "Democratic", "Republican", "Green", "Libertarian" }, "Republican", Category.Politics)
				}
			},
			{ Category.Movies, new List<Question>
				{
					new Question("Who directed the movie 'Titanic'?", new List<string> { "Steven Spielberg", "James Cameron", "Martin Scorsese", "Ridley Scott" }, "James Cameron", Category.Movies),
					new Question("What is the highest-grossing film of all time?", new List<string> { "Avatar", "Titanic", "The Avengers", "Star Wars: The Force Awakens" }, "Avatar", Category.Movies),
					new Question("Which movie features a character named 'Forrest Gump'?", new List<string> { "Forrest Gump", "The Green Mile", "Saving Private Ryan", "Catch Me If You Can" }, "Forrest Gump", Category.Movies),
					new Question("Who played the character of Jack Dawson in Titanic?", new List<string> { "Tom Hanks", "Leonardo DiCaprio", "Brad Pitt", "Johnny Depp" }, "Leonardo DiCaprio", Category.Movies),
					new Question("Which movie won the Academy Award for Best Picture in 2020?", new List<string> { "Joker", "Once Upon a Time in Hollywood", "Parasite", "1917" }, "Parasite", Category.Movies),
					new Question("Which movie is about a group of superheroes known as 'The Avengers'?", new List<string> { "Justice League", "The Avengers", "X-Men", "Guardians of the Galaxy" }, "The Avengers", Category.Movies),
					new Question("Which actor played Iron Man in the Marvel Cinematic Universe?", new List<string> { "Chris Hemsworth", "Chris Evans", "Robert Downey Jr.", "Mark Ruffalo" }, "Robert Downey Jr.", Category.Movies),
					new Question("Who directed 'The Dark Knight'?", new List<string> { "Christopher Nolan", "Zack Snyder", "Joss Whedon", "Sam Raimi" }, "Christopher Nolan", Category.Movies),
					new Question("Which movie features a famous scene with a glass slipper?", new List<string> { "Cinderella", "Snow White", "Beauty and the Beast", "Sleeping Beauty" }, "Cinderella", Category.Movies),
					new Question("Who played the character of 'Darth Vader' in Star Wars?", new List<string> { "Harrison Ford", "Mark Hamill", "Alec Guinness", "James Earl Jones" }, "James Earl Jones", Category.Movies),
					new Question("Which movie was released first?", new List<string> { "Star Wars: A New Hope", "Star Wars: The Empire Strikes Back", "Star Wars: Return of the Jedi", "Star Wars: The Phantom Menace" }, "Star Wars: A New Hope", Category.Movies),
					new Question("Which 2019 film features a character named 'The Joker'?", new List<string> { "The Dark Knight", "Joker", "Batman Begins", "Suicide Squad" }, "Joker", Category.Movies),
					new Question("Who won the Academy Award for Best Director in 2019?", new List<string> { "Quentin Tarantino", "Martin Scorsese", "Bong Joon-ho", "Todd Phillips" }, "Bong Joon-ho", Category.Movies),
					new Question("Which movie features a character called 'The Terminator'?", new List<string> { "Total Recall", "The Matrix", "Terminator 2: Judgment Day", "Blade Runner" }, "Terminator 2: Judgment Day", Category.Movies),
					new Question("In which film does the phrase 'Here's looking at you, kid' appear?", new List<string> { "Casablanca", "Gone with the Wind", "Citizen Kane", "The Godfather" }, "Casablanca", Category.Movies)
				}
			}
		};
		}

		public void StartGame(Player player1, Player player2)
		{
			Console.WriteLine("Welcome to the Quiz Game!");
			Console.WriteLine($"Player 1: {player1.Name} vs Player 2: {player2.Name}");

			var random = new Random();
			for (int i = 0; i < 5; i++)
			{
				var category = (Category)random.Next(0, 4); // Randomly select category
				var questions = _questions[category];
				var question = questions[random.Next(questions.Count)];

				player1.AnswerQuestion(question);
				player2.AnswerQuestion(question);
			}

			Console.WriteLine("\nFinal Scores:");
			Console.WriteLine($"{player1.Name}: {player1.Score} points");
			Console.WriteLine($"{player2.Name}: {player2.Score} points");

			if (player1.Score > player2.Score)
			{
				Console.WriteLine($"{player1.Name} wins!");
			}
			else if (player2.Score > player1.Score)
			{
				Console.WriteLine($"{player2.Name} wins!");
			}
			else
			{
				Console.WriteLine("It's a tie!");
			}
		}
	}
}

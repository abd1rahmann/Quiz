using Quiz;
using System.Numerics;

class Program
{
	static void Main(string[] args)
	{
		Console.Write("Enter Player 1 name: ");
		var player1Name = Console.ReadLine();
		Console.Write("Enter Player 2 name: ");
		var player2Name = Console.ReadLine();

		var player1 = new Player(player1Name);
		var player2 = new Player(player2Name);

		var quizGame = new QuizGame();
		quizGame.StartGame(player1, player2);
	}
}
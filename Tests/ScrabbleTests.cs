using Xunit

namespace Scrabble.Objects
{
	public class ScrabbleTests
	{

		[FACT]
		public void Is_Letter_Equal_To_K_True()
		{
			// Assign
			string userInput = "k"
			Scrabble testScrabble = new Scrabble();

			// Act


			//Assert
			Assert.Equal(true, testScrabble.IsLetterK("k"));
		}
	}
}

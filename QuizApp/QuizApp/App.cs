using Domain;
using Infi.Dojo.Xamarin.QuizApi;
using Xamarin.Forms;

namespace Infi.Dojo.Xamarin.QuizApp
{
	public class App : Application
	{
		private static readonly QuizApiClient QuizApiClient = new QuizApiClient("http://infi-dojo-quizapi.azurewebsites.net/");

		public App()
		{
			DisplayQuestionPage();
		}

		protected void DisplayQuestionPage()
		{
			Question question = QuizApiClient.GetRandomQuestion();

			QuestionPage questionPage = new QuestionPage(question)
			{
				ValidateAnswer = (questionId, answerKey) => QuizApiClient.CheckAnswer(questionId, answerKey).IsCorrect,
				ShowNextQuestion = DisplayQuestionPage
			};

			MainPage = questionPage;
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}

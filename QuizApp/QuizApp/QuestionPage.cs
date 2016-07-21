using System;
using System.Collections.Generic;
using Domain;
using global::Xamarin.Forms;

namespace Infi.Dojo.Xamarin.QuizApp
{
	public class QuestionPage : ContentPage
	{
		private readonly Question question;

		public QuestionPage(Question question)
		{
			if (question == null)
			{
				throw new ArgumentNullException(nameof(question));
			}

			this.question = question;

			CreateLayout();
		}

		public Action ShowNextQuestion { get; set; }

		public Func<int, string, bool> ValidateAnswer { get; set; }
		
		private async void AnswersViewItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			if (ValidateAnswer != null && e.SelectedItem != null)
			{
				KeyValuePair<string, string> selectedAnswer = (KeyValuePair<string, string>)e.SelectedItem;

				string message = ValidateAnswer(question.Id, selectedAnswer.Key) ? "You rock!" : "You suck!";
				await DisplayAlert("Result", message, "OK");

				OnShowNextQuestion();
			}
		}

		private void CreateLayout()
		{
			StackLayout stackLayout = new StackLayout { VerticalOptions = LayoutOptions.Center };

			stackLayout.Children.Add(new Label
			{
				HorizontalTextAlignment = TextAlignment.Start,
				FontSize = 20,
				Text = question.Text
			});

			ListView answersListView = new ListView();

			DataTemplate answersTemplate = new DataTemplate(typeof(AnswerCell));
			answersTemplate.SetBinding(AnswerCell.AnswerProperty, "Value");
			answersTemplate.SetBinding(AnswerCell.AnswerIdProperty, "Key");

			answersListView.ItemTemplate = answersTemplate;
			answersListView.ItemsSource = question.Answers;

			answersListView.ItemSelected += AnswersViewItemSelected;

			stackLayout.Children.Add(answersListView);

			Content = stackLayout;
		}

		private void OnShowNextQuestion()
		{
			ShowNextQuestion?.Invoke();
		}
	}
}

using System;
using global::Xamarin.Forms;

namespace Infi.Dojo.Xamarin.QuizApp
{
	public class AnswerCell : ViewCell
	{
		public static readonly BindableProperty AnswerProperty = BindableProperty.Create("Answer", typeof(string), typeof(AnswerCell), string.Empty);

		public static readonly BindableProperty AnswerIdProperty = BindableProperty.Create("AnswerId", typeof(int), typeof(AnswerCell), 0);

		private readonly Label answerLabel;

		public AnswerCell()
		{
			answerLabel = new Label { FontSize = 20 };

			StackLayout cellLayout = new StackLayout { VerticalOptions = LayoutOptions.Center };
			cellLayout.Children.Add(answerLabel);

			View = cellLayout;
		}

		public string Answer
		{
			get { return (string)GetValue(AnswerProperty); }
			set { SetValue(AnswerProperty, value); }
		}

		public int AnswerId
		{
			get { return (int)GetValue(AnswerIdProperty); }
			set { SetValue(AnswerIdProperty, value); }
		}

		public Func<int, string, bool> ValidateAnswer { get; set; }

		protected override void OnBindingContextChanged()
		{
			base.OnBindingContextChanged();

			if (BindingContext != null)
			{
				answerLabel.Text = Answer;
			}
		}
	}
}

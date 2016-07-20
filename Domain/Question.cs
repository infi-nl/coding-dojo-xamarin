using System.Collections.Generic;

namespace Domain
{
	public class Question
	{
		/// <summary>
		/// Question ID
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// Question text
		/// </summary>
		public string Text { get; set; }

		/// <summary>
		/// Possible answers [{answerKey, answerText}]
		/// </summary>
		public Dictionary<string, string> Answers { get; set; }

	}
}

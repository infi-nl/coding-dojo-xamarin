using Domain;
using RestSharp;

namespace Infi.Dojo.Xamarin.QuizApi {

    public class QuizApiClient : RestClient {

        public QuizApiClient(string baseUrl) : base(baseUrl) { }

        /// <summary>
        /// Get a random question from the Quiz API
        /// </summary>
        /// <returns>Question text and available answers</returns>
        public Question GetRandomQuestion() {
            return Get<Question>($"question/random");
        }

        /// <summary>
        /// Get a specific question from the Quiz API
        /// </summary>
        /// <param name="questionId">ID of the question</param>
        /// <returns>Question text and available answers</returns>
        public Question GetQuestion(string questionId) {
            return Get<Question>($"question/{questionId}");
        }

        /// <summary>
        /// Check given answer at the Quiz API
        /// </summary>
        /// <param name="questionId">ID of the question</param>
        /// <param name="answerKey">Key of the given answer</param>
        /// <returns>Is answer correct?</returns>
        public CheckedAnswer CheckAnswer(int questionId, string answerKey) {
            return Get<CheckedAnswer>($"answer/{questionId}/{answerKey}");
        }

        private T Get<T>(string url) where T : new() {
            var request = new RestRequest(url);
            var response = Execute<T>(request);
            return response.Data;
        }

    }

}

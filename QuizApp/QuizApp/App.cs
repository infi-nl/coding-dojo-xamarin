using Domain;
using Infi.Dojo.Xamarin.QuizApi;
using Xamarin.Forms;

namespace Infi.Dojo.Xamarin.QuizApp {

    public class App : Application {

        private static readonly QuizApiClient QuizApiClient = new QuizApiClient("http://infi-dojo-quizapi.azurewebsites.net/");

        public App() {
            MainPage = new ContentPage {
                Content = new StackLayout {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = "Hello Dojo!"
                        }
                    },
                }
            };
        }

        protected override void OnStart() {
            // Handle when your app starts
        }

        protected override void OnSleep() {
            // Handle when your app sleeps
        }

        protected override void OnResume() {
            // Handle when your app resumes
        }
        
    }

}

using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace QuizApp
{
    public partial class MainWindow : Window
    {
        
        public ObservableCollection<Question> Questions { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            LoadQuestions(); 
            DataContext = this;
        }

        
        private void LoadQuestions()
        {
         
            Questions = new ObservableCollection<Question>
            {
                new Question { QuestionText = "What is 2+2?", OptionA = "3", OptionB = "4", OptionC = "5", OptionD = "6", CorrectAnswer = "B", Marks = 1, TimeLimit = 30, Topic = "Math", DifficultyLevel = "Easy" },
                new Question { QuestionText = "What is the capital of France?", OptionA = "Berlin", OptionB = "Madrid", OptionC = "Paris", OptionD = "Rome", CorrectAnswer = "C", Marks = 1, TimeLimit = 30, Topic = "Geography", DifficultyLevel = "Medium" }
            };

            
            QuizDataGrid.ItemsSource = Questions;
        }

        
        private void TopicComboBox_SelectionChanged(object sender, RoutedEventArgs e)
        {
            FilterQuestions();
        }

        
        private void DifficultyComboBox_SelectionChanged(object sender, RoutedEventArgs e)
        {
            FilterQuestions();
        }

       
        private void FilterQuestions()
        {
            var topic = TopicComboBox.SelectedItem?.ToString();
            var difficulty = DifficultyComboBox.SelectedItem?.ToString();

            
            var filteredQuestions = Questions.Where(q =>
                (string.IsNullOrEmpty(topic) || q.Topic == topic) &&
                (string.IsNullOrEmpty(difficulty) || q.DifficultyLevel == difficulty)
            ).ToList();

            QuizDataGrid.ItemsSource = filteredQuestions;
        }

        
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            var addWindow = new AddEditQuestionWindow(); 
            if (addWindow.ShowDialog() == true)
            {
                Questions.Add(addWindow.Question); 
            }
        }

        
        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            if (QuizDataGrid.SelectedItem is Question selectedQuestion)
            {
                var editWindow = new AddEditQuestionWindow(selectedQuestion);
                if (editWindow.ShowDialog() == true) 
                {
                    QuizDataGrid.Items.Refresh(); 
                }
            }
        }

       
        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (QuizDataGrid.SelectedItem is Question selectedQuestion)
            {
                Questions.Remove(selectedQuestion); 
            }
        }

        
        private async void ShowLoadingProgressBar()
        {
            LoadingProgressBar.Visibility = Visibility.Visible; 
            StatusLabel.Text = "Loading questions...";

            await Task.Delay(3000); 

            LoadingProgressBar.Visibility = Visibility.Hidden; 
            StatusLabel.Text = "Ready";
        }
    }

    
    public class Question
    {
        public string QuestionText { get; set; }
        public string OptionA { get; set; }
        public string OptionB { get; set; }
        public string OptionC { get; set; }
        public string OptionD { get; set; }
        public string CorrectAnswer { get; set; }
        public int Marks { get; set; }
        public int TimeLimit { get; set; }
        public string Topic { get; set; }
        public string DifficultyLevel { get; set; }
    }
}



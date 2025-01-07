using System.Windows;

namespace QuizApp
{
    public partial class AddEditQuestionWindow : Window
    {
        public Question Question { get; private set; }

        public AddEditQuestionWindow(Question question = null)
        {
            InitializeComponent();
            if (question != null)
            {
                Question = question;
                QuestionTextBox.Text = question.QuestionText;
                TopicComboBox.SelectedItem = question.Topic;
                DifficultyComboBox.SelectedItem = question.DifficultyLevel;
            }
            else
            {
                Question = new Question();
            }
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            Question.QuestionText = QuestionTextBox.Text;
            Question.Topic = TopicComboBox.SelectedItem?.ToString();
            Question.DifficultyLevel = DifficultyComboBox.SelectedItem?.ToString();
            DialogResult = true;
            Close();
        }
    }
}
// GIVE ME xaml code of user interface of quiz app dont add grid in this 
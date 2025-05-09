namespace MySimpleProject
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnEmojiBtnClicked(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                BackgroundColor = btn.BackgroundColor;
                switch (btn.Text)
                {
                    case "happy!":
                        MoodImage.Source = "happy_emoji.png";
                        break;
                    case "cool!":
                        MoodImage.Source = "cool_emoji.png";
                        break;
                    case "shy!":
                        MoodImage.Source = "shy_emoji.png";
                        break;
                    case "angry!":
                        MoodImage.Source = "mad_emoji.png";
                        break;
                    case "in love!":
                        MoodImage.Source = "heart_eyes_emoji.png";
                        break;
                    case "sick!":
                        MoodImage.Source = "sick_emoji.png";
                        break;
                    case "lucky!":
                        MoodImage.Source = "money_face_emoji.png";
                        break;
                    case "awkward!":
                        MoodImage.Source = "ugh_emoji.png";
                        break;
                }
            }
        }
    }

}

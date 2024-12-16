namespace lista
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            string inputText = input.Text;


            var newLabel = new Label
            {
                TextColor = Colors.Crimson,
                Text = inputText
            };

           
            var newBoxView = new BoxView
            {
                Color = Colors.Crimson,
                HeightRequest = 1,
               
            };

            
            dynamicStackLayout.Children.Add(newLabel);
            dynamicStackLayout.Children.Add(newBoxView);

            
            input.Text = string.Empty;






        }
    }

}

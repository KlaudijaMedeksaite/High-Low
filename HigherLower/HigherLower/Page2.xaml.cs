using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HigherLower
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page2 : ContentPage
	{

        int score = 3;

        public Page2()
        {
            InitializeComponent();
            randomNumber();
        }

        private void higherBtn_Clicked(object sender, EventArgs e)
        {
            int lastNum = int.Parse(numDisplay.Text);

            randomNumber();
            int newNum = int.Parse(numDisplay.Text);

            if (newNum > lastNum)
            {
                statusLbl.Text = "You win";
                score++;
                scoreLbl.Text = "Lives: " + score.ToString();
            }
            else if (newNum == lastNum)
            {
                statusLbl.Text = "Go Again";
                scoreLbl.Text = "Lives: " + score.ToString();
            }
            else
            {
                statusLbl.Text = "You lose";
                score--;
                scoreLbl.Text = "Lives: " + score.ToString();
            }

            if (score == 0)
            {
                Navigation.PushAsync(new GameOver());
            }
            else if (score == 50)
            {
                Navigation.PushAsync(new Page3());
            }
        }

        private void lowerBtn_Clicked(object sender, EventArgs e)
        {
            int lastNum = int.Parse(numDisplay.Text);

            randomNumber();
            int newNum = int.Parse(numDisplay.Text);

            if (newNum < lastNum)
            {
                statusLbl.Text = "You win";
                score++;
                scoreLbl.Text = "Lives: " + score.ToString();

            }
            else if (newNum == lastNum)
            {
                statusLbl.Text = "Go Again";
                scoreLbl.Text = "Lives: " + score.ToString();
            }
            else
            {
                statusLbl.Text = "You lose";
                score--;
                scoreLbl.Text = "Lives: " + score.ToString();
            }
            if (score == 0)
            {
                Navigation.PushAsync(new GameOver());
            }
            else if (score == 50)
            {
                Navigation.PushAsync(new Page3());
            }
        }
        private void randomNumber()
        {
            //random number
            Random generator = new Random();
            numDisplay.Text = generator.Next(0, 51).ToString();
        }
        private void redoBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page1());
        }
    }
}
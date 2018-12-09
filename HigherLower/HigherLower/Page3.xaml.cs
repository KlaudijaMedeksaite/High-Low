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
	public partial class Page3 : ContentPage
    {

        int score = 1;

        // first number generated on start up of level three page
        public Page3()
        {
            InitializeComponent();
            randomNumber();
        }

        //when the higher button is clicked
        private void higherBtn_Clicked(object sender, EventArgs e)
        {
            int newNum;
            int lastNum = int.Parse(numDisplay.Text);
            do
            {
                randomNumber();
                newNum = int.Parse(numDisplay.Text);
            } while (newNum == lastNum);

            if (newNum > lastNum)
            {
                statusLbl.Text = "You win";
                score++;
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
            else if (score == 100)
            {
                Navigation.PushAsync(new youWin());
            }
        }

        //when the lower button is clicked
        private void lowerBtn_Clicked(object sender, EventArgs e)
        {
            int newNum;
            int lastNum = int.Parse(numDisplay.Text);
            do
            {
                randomNumber();
                newNum = int.Parse(numDisplay.Text);
            } while (newNum == lastNum);

            if (newNum < lastNum)
            {
                statusLbl.Text = "You win";
                score++;
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
            else if (score == 100)
            {
                Navigation.PushAsync(new youWin());
            }
        }
        //random number generator
        private void randomNumber()
        {
            Random generator = new Random();
            numDisplay.Text = generator.Next(0, 100).ToString();
        }

        //redo button
        private void redoBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page1());
        }
    }
}
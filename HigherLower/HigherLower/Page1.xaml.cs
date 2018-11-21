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
	public partial class Page1 : ContentPage
	{
        int score = 5;

        public Page1 ()
		{
            InitializeComponent ();
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
            else if(newNum == lastNum)
            {
                statusLbl.Text = "";
                scoreLbl.Text = "Lives: " + score.ToString();
            }
            else
            {
                statusLbl.Text = "You lose";
                score--;
                scoreLbl.Text = "Lives: " + score.ToString();
            }
        }

        private void lowerBtn_Clicked(object sender, EventArgs e)
        {
            int lastNum = int.Parse(numDisplay.Text);

            randomNumber();
            int newNum = int.Parse(numDisplay.Text);

            if(newNum < lastNum)
            {
                statusLbl.Text = "You win";
                score++;
                scoreLbl.Text = "Lives: " + score.ToString();

            }
            else if (newNum == lastNum)
            {
                statusLbl.Text = "";
                scoreLbl.Text = "Lives: " + score.ToString();
            }
            else
            {
                statusLbl.Text = "You lose";
                score--;
                scoreLbl.Text = "Lives: " + score.ToString();
            }
        }
        private void randomNumber()
        {
            //random number
            Random generator = new Random();
            numDisplay.Text = generator.Next(0, 21).ToString();
        }
    }
}
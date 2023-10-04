using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

//Task 2=>
// Qachan button tapshirigi ,
//form mouse hover event istifade edin
//her defe button qachir bashqa yerde peyda olsun
//ekranin arxa rengi her defe deyishsin random olaraq

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        private Button button = new Button();
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            InitializeMyCatchButton();
        }

        private void InitializeMyCatchButton()
        {
            button.Text = "Cath me";
            button.AutoSize = true;
            button.Font = new Font("Comic Sans MS", 25, FontStyle.Italic);
            button.ForeColor = Color.Red;
            button.Location = GetRandomButtonLocation();
            this.button.MouseEnter += Button_MouseEnter;
            this.Controls.Add(button);
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            MoveButtonRandomLocation();
            ChangeBackgroundColorRandom();
        }

        private Point GetRandomButtonLocation()
        {
            int x = random.Next(Width - button.Width);
            int y = random.Next(Height - button.Height);
            return new Point(x, y);
        }

        private void MoveButtonRandomLocation()
        {
            button.Location = GetRandomButtonLocation();
        }

        private void ChangeBackgroundColorRandom()
        {
            BackColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
        }
    }
}
namespace CS311_Project2_ETC
{
    public partial class Form1 : Form
    {
        double bank;
        int throwNum = 0;
        double bet;
        int point;
        public Form1()
        {
            InitializeComponent();
        }//end Form1()

        private void Form1_Load(object sender, EventArgs e)
        {
            bank = 100.00;
        }//end Form1_Load()

        private void btnRoll_Click(object sender, EventArgs e)
        {
            bet = Convert.ToDouble(txtBet.Text);
            if (bet <= bank)
            {
                throwNum++;
                lblRollNumber.Text = "Roll Number: " + throwNum.ToString();
                calculate_score(throwNum);
            }
        }//end btnRoll_Click()
        private void calculate_score(int num)
        {
            Random random = new Random();
            int die1 = random.Next(6) + 1;
            switch (die1)
            {
                case 1:
                    picDie1.Image = Image.FromFile("..//..//..//Resources//one.png");
                    break;
                case 2:
                    picDie1.Image = Image.FromFile("..//..//..//Resources//two.png");
                    break;
                case 3:
                    picDie1.Image = Image.FromFile("..//..//..//Resources//three.png");
                    break;
                case 4:
                    picDie1.Image = Image.FromFile("..//..//..//Resources//four.png");
                    break;
                case 5:
                    picDie1.Image = Image.FromFile("..//..//..//Resources//five.png");
                    break;
                case 6:
                    picDie1.Image = Image.FromFile("..//..//..//Resources//six.png");
                    break;
                default:
                    break;
            }
            
            //lblDie1.Text = die1.ToString();
            int die2 = random.Next(6) + 1;
            switch (die2)
            {
                case 1:
                    picDie2.Image = Image.FromFile("..//..//..//Resources//one.png");
                    break;
                case 2:
                    picDie2.Image = Image.FromFile("..//..//..//Resources//two.png");
                    break;
                case 3:
                    picDie2.Image = Image.FromFile("..//..//..//Resources//three.png");
                    break;
                case 4:
                    picDie2.Image = Image.FromFile("..//..//..//Resources//four.png");
                    break;
                case 5:
                    picDie2.Image = Image.FromFile("..//..//..//Resources//five.png");
                    break;
                case 6:
                    picDie2.Image = Image.FromFile("..//..//..//Resources//six.png");
                    break;
                default:
                    break;
            }
            int sum = die1 + die2;
            if (throwNum == 1)
            {
                switch (sum)
                {
                    case 2:
                        lose();
                        break;
                    case 3:
                        lose();
                        break;
                    case 4:
                        make_your_point(sum);
                        break;
                    case 5:
                        make_your_point(sum);
                        break;
                    case 6:
                        make_your_point(sum);
                        break;
                    case 7:
                        win();
                        break;
                    case 8:
                        make_your_point(sum);
                        break;
                    case 9:
                        make_your_point(sum);
                        break;
                    case 10:
                        make_your_point(sum);
                        break;
                    case 11:
                        win();
                        break;
                    case 12:
                        lose();
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (sum)
                {
                    case 7:
                        lose();
                        break;
                    default:
                        if (sum == point)
                        {
                            win();
                            break;
                        }
                        else
                        {
                            break;
                        }
                }
            }
        }//end calculate_score()

        private void win()
        {
            bank += bet;
            lblBank.Text = "$" + bank.ToString();
            lblResult.Text = "You won!";
            throwNum = 0;
        }//end win()

        private void lose()
        {
            bank -= bet;
            lblBank.Text = "$" + bank.ToString();
            lblResult.Text = "You lost!";
            throwNum = 0;
        }//end lose()

        private void make_your_point(int num)
        {
            point = num;
            lblResult.Text = "Your point is: " + point.ToString() + ". Roll a " + point.ToString() + " to win! Roll a 7 and you lose!";
        }//end make_your_point()

    }//end class
}//end namespace
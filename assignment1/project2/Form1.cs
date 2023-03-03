namespace project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void caculate_Click(object sender, EventArgs e)
        {
            int value1 = Convert.ToInt32(operateNum1.Text);
            int value2 = Convert.ToInt32(operateNum2.Text);
            switch (calOperator.Text)
            {
                case "+":
                case "-":
                case "*":
                case "/":
                    {
                        switch (calOperator.Text)
                        {
                            case "+":
                                int resultplus = value1 + value2;
                                result.Text = Convert.ToString(resultplus);
                                break;
                            case "-":
                                int resultminus = value1 - value2;
                                result.Text = Convert.ToString(resultminus);
                                break;
                            case "*":
                                int resultmulti = value1 * value2;
                                result.Text = Convert.ToString(resultmulti);
                                break;
                            case "/":
                                int resultdivision = value1 / value2;
                                result.Text = Convert.ToString(resultdivision);
                                break;
                            default:
                                break;
                        }
                        break;
                    }

                default:
                    result.Text = "‘ÀÀ„ ß∞‹";
                    break;
            }

        }
    }
}
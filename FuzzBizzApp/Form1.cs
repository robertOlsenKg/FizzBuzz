using FizzBuzz;

namespace FuzzBizzApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SUbutton_Click(object sender, EventArgs e)
        {
            int start, stop;
            start = Convert.ToInt32(tbStart.Text);
            stop=Convert.ToInt32(tbStopp.Text);
            CFizzBuzz fb= new CFizzBuzz();

            while(start <= stop) 
            {
               if (fb.fizz(start))
                    tbUt.AppendText("fizz ");
                else if (fb.buzz(start))
                    tbUt.AppendText("buzz ");
                else if (fb.FizzBuzz(start))
                    tbUt.AppendText("fizzbuzz ");
                else
                    tbUt.AppendText(start.ToString()+" ");
               start++;
                
            }
        }
    }
}
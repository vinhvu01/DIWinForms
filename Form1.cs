using Microsoft.Extensions.DependencyInjection;
using System.Windows.Forms;

namespace DIWinForms
{
    public partial class Form1 : Form
    {
        public Form1(IHelloService helloService)
        {
            InitializeComponent();
            // If you need multiple instances of Form2 or you need to initialize it multiple times, then you may get an instance of it like this
            using (var form2 = Program.ServiceProvider.GetRequiredService<Form2>())
            {
                //form2.ShowDialog();
            }
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            // when you want to change the currently visible form, you can create a new form with the same service instance or a different one
            var form5 = Program.ServiceProvider.GetRequiredService<Form5>();
            //form5.ShowDialog();
        }

        private void tabControl1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            // Determine the selected tab index and create the corresponding form
            int selectedIndex = tabControl1.SelectedIndex;
            if (selectedIndex == 0)
            {
                // Create a form for the first tab and inject the same service
                using (var form5 = Program.ServiceProvider.GetRequiredService<Form5>())
                {
                    //form5.ShowDialog();
                }
            }
            else
            {
                // Create a form for the first tab and inject the same service
                using (var form4 = Program.ServiceProvider.GetRequiredService<Form4>())
                {
                    //form4.ShowDialog();
                }
            }
        }
    }
}

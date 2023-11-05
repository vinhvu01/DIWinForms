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
                form2.ShowDialog();
            }
        }
    }
}

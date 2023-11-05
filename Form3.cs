using System.Windows.Forms;

namespace DIWinForms
{
    public partial class Form3 : Form
    {

        public Form3(IHelloService helloService, Form2 form2)
        {
            InitializeComponent();
            // iF only need a single instance of Form2 in the whole life time of Form3,
            // then you can inject it as a dependency to the constructor of Form3 and store the instance and show it whenever you want.
            form2.ShowDialog();
        }
    }
}

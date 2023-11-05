using System.Windows.Forms;

namespace DIWinForms
{
    public partial class Form1 : Form
    {
        private readonly IHelloService helloService;

        public Form1(IHelloService helloService)
        {
            InitializeComponent();
            this.helloService = helloService;
            MessageBox.Show(helloService.SayHello("Form1"));
        }
    }
}

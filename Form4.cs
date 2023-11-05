using System.Windows.Forms;

namespace DIWinForms
{
    public partial class Form4 : Form
    {
        private readonly IHelloService helloService;

        // Inject IHelloService in Form1 and use it
        public Form4(IHelloService helloService)
        {
            InitializeComponent();
            this.helloService = helloService;
            MessageBox.Show(helloService.SayHello("Form4"));
        }
    }
}

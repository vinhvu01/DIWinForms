using System.Windows.Forms;

namespace DIWinForms
{
    public partial class Form5 : Form
    {
        private readonly IHelloService helloService;

        // Inject IHelloService in Form5 and use it
        public Form5(IHelloService helloService)
        {
            InitializeComponent();
            this.helloService = helloService;
            MessageBox.Show(helloService.SayHello("Form5"));
        }
    }
}

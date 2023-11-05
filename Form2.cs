using System.Windows.Forms;

namespace DIWinForms
{
    public partial class Form2 : Form
    {
        private readonly IHelloService helloService;

        public Form2(IHelloService helloService)
        {
            InitializeComponent();
            this.helloService = helloService;
            MessageBox.Show(helloService.SayHello("Form2"));
        }
    }
}

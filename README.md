# DIWinForms
Research Dependency Injection for WinForms
1. Inject IHelloService in Form1

	    private readonly IHelloService helloService;
	
	    public Form1(IHelloService helloService)
	    {
	        InitializeComponent();
	        this.helloService = helloService;
	        MessageBox.Show(helloService.SayHello());
	    }
   
2. Need to register the form if you want to use DI

		return Host.CreateDefaultBuilder()
	            .ConfigureServices((context, services)=>{
	                services.AddTransient<IHelloService, HelloService>();
	                services.AddTransient<Form1>();
	            });
   
3. If you only need a single instance of Form2 in the whole lifetime of Form1, then you can inject it as a dependency to the constructor of Form1 store the instance, and show it whenever you want. It will be initialized just once when you open Form1 and it will not be initialized again. It would help if you also did not dispose of it because it's the only instance passed to Form1.
   
				public Form1(IHelloService helloService, Form2 form2)
				{ 
				     InitializeComponent();
   					form2.ShowDialog();
				}
   
4. If you need multiple instances of Form2 or you need to initialize it multiple times, then you may get an instance of it like this:
   
	     using (var form2 = Program.ServiceProvider.GetRequiredService<Form2>())
	     form2.ShowDialog();

- When a new Window is created for new forms
  
        	 public Form1(IHelloService helloService)
        	 {
        	     InitializeComponent();
        	     // If you need multiple instances of Form2 or you need to initialize it multiple times, then you may get an instance of it like this
        	     using (var form2 = Program.ServiceProvider.GetRequiredService<Form2>())
        	     {
        	         form2.ShowDialog();
        	     }
        	 }
  
- When the current visible form is changed

         private void button1_Click(object sender, System.EventArgs e)
         {
             // When you want to change the currently visible form, you can create a new form with the same service instance or a different one
             var form5 = Program.ServiceProvider.GetRequiredService<Form5>();
             form5.ShowDialog();
         }
 
- When the tab control changes the visible form

        private void tabControl1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            // Determine the selected tab index and create the corresponding form
            int selectedIndex = tabControl1.SelectedIndex;
            if (selectedIndex == 0)
            {
                // Create a form for the first tab and inject the same service
                using (var form5 = Program.ServiceProvider.GetRequiredService<Form5>())
                {
                    form5.ShowDialog();
                }
            }
            else
            {
                // Create a form for the first tab and inject the same service
                using (var form4 = Program.ServiceProvider.GetRequiredService<Form4>())
                {
                    form4.ShowDialog();
                }
            }
        }


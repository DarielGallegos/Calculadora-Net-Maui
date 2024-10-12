namespace Calculadora
{
    public partial class MainPage : ContentPage
    {
        int result = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void btnSuma_Clicked(object sender, EventArgs e)
        {
            String[] conve = validate(num1.Text, num2.Text, "+");
            if (conve[1] == "true")
            {
                Application.Current.MainPage = new ResultView(conve[0]);
            }
            else
            {
                showErr(conve[0]);
            }
        }

        private void btnResta_Clicked(object sender, EventArgs e) {
            String[] conve = validate(num1.Text, num2.Text, "-");
            if (conve[1] == "true")
            {
                Application.Current.MainPage = new ResultView(conve[0]);
            }
            else
            {
                showErr(conve[0]);
            }
        }

        private void btnMult_Clicked(object sender, EventArgs e)
        {
            String[] conve = validate(num1.Text, num2.Text, "*");
            if (conve[1] == "true")
            {
                Application.Current.MainPage = new ResultView(conve[0]);
            }
            else
            {
                showErr(conve[0]);
            }
        }

        private void btnDiv_Clicked(object sender, EventArgs e)
        {
            String[] conve = validate(num1.Text, num2.Text, "/");
            if (conve[1] == "true")
            {
                Application.Current.MainPage = new ResultView(conve[0]);
            }
            else {
                showErr(conve[0]);   
            }
        }

        private void showErr(string msg) {
            lblErr.Text = "\nAsegurese de ingresar números correctamente.\nEjemplo: 12, 14.33, 2, 123.34, etc...";
            SemanticScreenReader.Announce(lblErr.Text);
        }
        static String[] validate(string a, string b, string operador)
        {
            double result = 0;
            try
            {
                if (a.TrimStart() == "" || b.TrimStart() == "") { 
                    return ["Por favor, ingrese un número en ambos campos", "false"];
                }
                switch (operador) {
                    case "+":
                        result = Convert.ToDouble(a) + Convert.ToDouble(b);
                        break;
                    case "-":
                        result = Convert.ToDouble(a) - Convert.ToDouble(b);
                        break;
                    case "*":
                        result = Convert.ToDouble(a) * Convert.ToDouble(b);
                        break;
                    case "/":
                        result = Convert.ToDouble(a) / Convert.ToDouble(b);
                        break;

                }
                return ["El resultado de la operacion es: " + Convert.ToString(result), "true"];
            }
            catch (System.Exception e) {
                return [e.ToString(), "false"];
            }
        }
    }

}

using System.Windows;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly MainViewModel _viewModel = new();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_ChangePolarityClick(object sender, RoutedEventArgs e)
        {
            _viewModel.ChangePolarity();
            TextBoxResult.Text = _viewModel.ShowNumber();
        }

        private void Button_ZeroClick(object sender, RoutedEventArgs e)
        {
            _viewModel.SetNumber((int)CalcEnumerationNumbers.zero);
            TextBoxResult.Text = _viewModel.ShowNumber();
        }

        private void Button_CommaClick(object sender, RoutedEventArgs e)
        {
            if (!_viewModel.WasSetComma)
            {
                if (!_viewModel.SwitchNumber)
                {
                    _viewModel.Number += ",";
                    TextBoxResult.Text = _viewModel.ShowNumber();
                    _viewModel.WasSetComma = true;
                }
                else
                {
                    _viewModel.SecondNumber += ",";
                    TextBoxResult.Text = _viewModel.ShowNumber();
                    _viewModel.WasSetComma = true;
                }
            }
        }

        private void Button_NumberOneClick(object sender, RoutedEventArgs e)
        {
            _viewModel.SetNumber((int)CalcEnumerationNumbers.one);
            TextBoxResult.Text = _viewModel.ShowNumber();
        }

        private void Button_NumberTwoClick(object sender, RoutedEventArgs e)
        {
            _viewModel.SetNumber((int)CalcEnumerationNumbers.two);
            TextBoxResult.Text = _viewModel.ShowNumber();
        }

        private void Button_NumberThreeClick(object sender, RoutedEventArgs e)
        {
            _viewModel.SetNumber((int)CalcEnumerationNumbers.three);
            TextBoxResult.Text = _viewModel.ShowNumber();
        }

        private void Button_NumberFourClick(object sender, RoutedEventArgs e)
        {
            _viewModel.SetNumber((int)CalcEnumerationNumbers.four);
            TextBoxResult.Text = _viewModel.ShowNumber();
        }

        private void Button_NumberFiveClick(object sender, RoutedEventArgs e)
        {
            _viewModel.SetNumber((int)CalcEnumerationNumbers.five);
            TextBoxResult.Text = _viewModel.ShowNumber();
        }

        private void Button_NumberSixClick(object sender, RoutedEventArgs e)
        {
            _viewModel.SetNumber((int)CalcEnumerationNumbers.six);
            TextBoxResult.Text = _viewModel.ShowNumber();
        }

        private void Button_NumberSevenClick(object sender, RoutedEventArgs e)
        {
            _viewModel.SetNumber((int)CalcEnumerationNumbers.seven);
            TextBoxResult.Text = _viewModel.ShowNumber();
        }

        private void Button_NumberEightClick(object sender, RoutedEventArgs e)
        {
            _viewModel.SetNumber((int)CalcEnumerationNumbers.eight);
            TextBoxResult.Text = _viewModel.ShowNumber();
        }

        private void Button_NumberNineClick(object sender, RoutedEventArgs e)
        {
            _viewModel.SetNumber((int)CalcEnumerationNumbers.nine);
            TextBoxResult.Text = _viewModel.ShowNumber();
        }

        private void Button_NumberRemoveClick(object sender, RoutedEventArgs e)
        {
            TextBoxResult.Text = "0";
            _viewModel.MakeDefaultValues();
        }

        private void Button_NumberDivideClick(object sender, RoutedEventArgs e)
        {
            _viewModel.SetMathMethod("/");
            TextBoxResult.Text = "/";
            _viewModel.WasSetComma = false;
        }

        private void Button_NumberResultClick(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(_viewModel.Number) && !string.IsNullOrEmpty(_viewModel.SecondNumber) && !string.IsNullOrEmpty(_viewModel.MathMethod))
            {
                TextBoxResult.Text = _viewModel.MakeCountNumbers();
            }
        }

        private void Button_NumberCompileClick(object sender, RoutedEventArgs e)
        {
            _viewModel.SetMathMethod("+");
            TextBoxResult.Text = "+";
            _viewModel.WasSetComma = false;
        }

        private void Button_NumberSubstractClick(object sender, RoutedEventArgs e)
        {

            _viewModel.SetMathMethod("-");
            TextBoxResult.Text = "-";
            _viewModel.WasSetComma = false;
        }

        private void Button_NumberMultipleClick(object sender, RoutedEventArgs e)
        {

            _viewModel.SetMathMethod("*");
            TextBoxResult.Text = "*";
            _viewModel.WasSetComma = false;
        }

        private void Button_NumberRemoveOneClick(object sender, RoutedEventArgs e)
        {
            _viewModel.RemoveLastElement();
            TextBoxResult.Text = _viewModel.ShowNumber();
        }

        private void Button_NumberProcentClick(object sender, RoutedEventArgs e)
        {
            _viewModel.SetMathMethod("%");
            TextBoxResult.Text = "%";
            _viewModel.WasSetComma = false;
        }

        private void TextBox_ChangeMessageResult(object sender, System.Windows.Controls.TextChangedEventArgs e) { }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KeyEventArgsHelperSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            maxChar.Text = "20";
            input.MaxLength = 20;

            maxChar.PreviewTextInput += MaxChar_PreviewTextInput;
            maxChar.TextChanged += MaxChar_TextChanged;

            input.TextChanged += Input_TextChanged;
            input.PreviewKeyDown += Input_PreviewKeyDown;

            clearButton.Click += ClearButton_Click;

            input.Focus();
        }

        private void Input_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            output.Clear();

            if (KeyEventArgsHelper.ModifierKey(e))
            {
                output.Text = "Modifier Key: " + Keyboard.Modifiers.ToString();
            }
            if (KeyEventArgsHelper.SystemKey(e))
            {
                if (output.Text != string.Empty)
                    output.Text += " + ";

                output.Text += "System Key: " + e.Key;
            }
            else
            {
                if (e.Key != Key.LeftAlt && e.Key != Key.RightAlt &&
                    e.Key != Key.LeftCtrl && e.Key != Key.RightCtrl &&
                    e.Key != Key.LeftShift && e.Key != Key.RightShift &&
                    e.Key != Key.LWin && e.Key != Key.RWin)
                {
                    if (output.Text != string.Empty)
                        output.Text += " + ";

                    output.Text += e.Key.ToString();

                    if (Keyboard.Modifiers.Equals(ModifierKeys.Control) && e.Key != Key.V)
                    {
                        // do nothing
                    }
                    else if (CheckMax())
                        output.Text += " || Beep boop. Max characters reached.";
                }
            }
        }
        public bool CheckMax()
        {
            if (input.Text.Length == input.MaxLength)
                return true;
            else
                return false;
        }

        private void Input_TextChanged(object sender, TextChangedEventArgs e)
        {
            counter.Text = input.Text.Length + " of " + maxChar.Text;
        }

        private void MaxChar_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1))
                e.Handled = true;
        }

        private void MaxChar_TextChanged(object sender, TextChangedEventArgs e)
        {
            input.MaxLength = Convert.ToInt32(maxChar.Text);
            counter.Text = input.Text.Length + " of " + maxChar.Text;
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            input.Clear();
            maxChar.Text = "20";
            input.MaxLength = 20;
            output.Clear();
        }
    }
}

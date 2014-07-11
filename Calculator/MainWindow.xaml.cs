using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Calculator
{
    /// <summary>
    /// Calculator window (currently basic mode)
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WorkBox.Focus();
        }

        private void EqualsClick(object sender, RoutedEventArgs e)
        {
            string v = Global.Calculate(WorkBox.Text);
            AnswerBox.Text = " = " + v.ToString();
        }

        private void RecordClick(object sender, RoutedEventArgs e)
        {
            ScratchPaper.Text += (WorkBox.Text + AnswerBox.Text + "\r\n");
            ScratchPaper.ScrollToEnd();
        }


        #region Toolbar Buttons
        private void UndoClick(object sender, RoutedEventArgs e)
        {
            WorkBox.Undo();
        }

        private void ClearClick(object sender, RoutedEventArgs e)
        {
            AnswerBox.Clear();
        }

        private void ExitClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        #endregion
        #region Basic Arithmetic Buttons
        private void AddClick(object sender, RoutedEventArgs e)
        {
            WorkBox.AppendText(" +");
        }

        private void SubtractClick(object sender, RoutedEventArgs e)
        {
            WorkBox.AppendText(" -");
        }

        private void MultiplyClick(object sender, RoutedEventArgs e)
        {
            WorkBox.AppendText(" *");
        }

        private void DivideClick(object sender, RoutedEventArgs e)
        {
            WorkBox.AppendText(" /");
        }
        #endregion
        #region Number buttons
        private void OneClick(object sender, RoutedEventArgs e)
        {
            WorkBox.AppendText("1");
        }
        private void TwoClick(object sender, RoutedEventArgs e)
        {
            WorkBox.AppendText("2");
        }
        private void ThreeClick(object sender, RoutedEventArgs e)
        {
            WorkBox.AppendText("3");
        }
        private void FourClick(object sender, RoutedEventArgs e)
        {
            WorkBox.AppendText("4");
        }
        private void FiveClick(object sender, RoutedEventArgs e)
        {
            WorkBox.AppendText("5");
        }
        private void SixClick(object sender, RoutedEventArgs e)
        {
            WorkBox.AppendText("6");
        }
        private void SevenClick(object sender, RoutedEventArgs e)
        {
            WorkBox.AppendText("7");
        }
        private void EightClick(object sender, RoutedEventArgs e)
        {
            WorkBox.AppendText("8");
        }
        private void NineClick(object sender, RoutedEventArgs e)
        {
            WorkBox.AppendText("9");
        }
        private void ZeroClick(object sender, RoutedEventArgs e)
        {
            WorkBox.AppendText("0");
        }
        private void DecimalClick(object sender, RoutedEventArgs e)
        {
            WorkBox.AppendText(".");
        }
        private void BackspaceClick(object sender, RoutedEventArgs e)
        {
            if (WorkBox.Text.Length > 0)
            {
                WorkBox.Text = WorkBox.Text.Substring(0, WorkBox.Text.Length - 1);
            }
            else
            { MessageBox.Show("Nothing to delete."); }
        }
        #endregion

        private void WorkBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Global.Work = WorkBox.Text;
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                string v = Global.Calculate(WorkBox.Text);

                AnswerBox.Text = " = " + v.ToString();
            }

        }

    }
}

using System.ComponentModel;
using System.Windows;

namespace Financial_Accounting.View.UserControl
{
    public partial class InputDataTextBox : System.Windows.Controls.UserControl, INotifyPropertyChanged
    {
        public InputDataTextBox()
        {
            DataContext = this;
            placeholder = string.Empty;
            InitializeComponent();
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        
        private string placeholder;
        public string Placeholder
        {
            get { return placeholder; }
            set 
            { 
                placeholder = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Placeholder"));
            }
        }

        private void txtInput_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtInput.Text))
            {
                placeHolder.Visibility = Visibility.Visible;
            }
            else
            {
                placeHolder.Visibility = Visibility.Hidden;
            }
        }
    }
}

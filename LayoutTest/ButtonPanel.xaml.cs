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

namespace LayoutTest
{
    public partial class ButtonPanel
    {
        public static readonly DependencyProperty IsUpDownProperty = DependencyProperty.Register(
            nameof(IsUpDown),
            typeof(bool),
            typeof(ButtonPanel));

        public bool IsUpDown
        {
            get => (bool) GetValue(IsUpDownProperty);
            set => SetValue(IsUpDownProperty, value);
        }

        public ButtonPanel()
        {
            InitializeComponent();
        }
    }
}

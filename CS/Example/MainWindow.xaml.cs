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

namespace Example {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
	    int t=100;
	    t++;
            var testObject = (object)new { pageIndex = 1, isSuggestedSearch = 123 };
	    System.Windows.Controls.Button btn = new Button();
            btn.Click += (sn, args) => {
                int t2 = 123456;
                t2++;
            };
        }
    }

    public interface ITest {
        void SomeMethod();
    }

    public class TestClass : ITest {
        public void SomeMethod() {

        }
    }
}

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
using System.Windows.Shapes;

namespace ST10026525.PROG6221.POE
{
    /// <summary>
    /// Interaction logic for RecipeDisplay.xaml
    /// </summary>
    public partial class RecipeDisplay : Window
    {
        public RecipeDisplay(recipeClass recipeDisplay)
        {
            InitializeComponent();

            // Set DataContext to the selected recipe
            DataContext = recipeDisplay;
        }
    }
}


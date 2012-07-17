
using System;

namespace MetroSlider_SL4
{
    public partial class MetroSliderObjectives
    {
        public MetroSliderObjectives()
        {
            InitializeComponent();
        }

        public int Value
        {
            get { return Convert.ToInt32(this.MySlider.Value); }
            set { MySlider.Value = value; }
        }

        private void Option1_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            this.MySlider.Value = 1;
        }

        private void Option2_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            this.MySlider.Value = 2;
        }

        private void Option3_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            this.MySlider.Value = 3;
        }
    }
}

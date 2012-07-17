
using System;
using System.Windows.Input;

namespace MetroSlider_SL4
{
    public partial class MetroSliderRisk
    {
        public MetroSliderRisk()
        {
            InitializeComponent();
        }

        public int Value
        {
            get { return Convert.ToInt32(this.MySlider.Value); }
            set { MySlider.Value = value; }
        }

        private void Option1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.MySlider.Value = 1;
        }

        private void Option2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.MySlider.Value = 2;
        }

        private void Option3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.MySlider.Value = 3;
        }

        private void UpArrow_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (Value == 1) return;
            Value--;
        }

        private void DownArrow_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (Value == 3) return;
            Value++;
        }
    }
}
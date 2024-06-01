namespace WinFormsControlLibrary1
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;


    [ToolboxBitmap(typeof(ColoredNumberTextBox), "APZ_Lab1_icon.ico")]
    public partial class ColoredNumberTextBox : TextBox
    {
        public Color PositiveColor { get; set; } = Color.LightGreen;
        public Color NegativeColor { get; set; } = Color.LightCoral;
        public Color ZeroColor { get; set; } = Color.LightYellow;

        public event EventHandler PositiveValueEntered;
        public event EventHandler NegativeValueEntered;
        public event EventHandler ZeroValueEntered;

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            if (int.TryParse(this.Text, out int value))
            {
                if (value > 0)
                {
                    this.BackColor = PositiveColor;
                    PositiveValueEntered?.Invoke(this, EventArgs.Empty);
                }
                else if (value < 0)
                {
                    this.BackColor = NegativeColor;
                    NegativeValueEntered?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    this.BackColor = ZeroColor;
                    ZeroValueEntered?.Invoke(this, EventArgs.Empty);
                }
            }
            else
            {
                this.BackColor = Color.White;
            }
        }
    }

}

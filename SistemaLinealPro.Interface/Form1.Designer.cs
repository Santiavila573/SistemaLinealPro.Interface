namespace SistemaLinealPro.Interface
{
    using System;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        private TextBox textBoxX;
        private TextBox textBoxM;
        private TextBox textBoxB;
        private TextBox textBoxY;
        private Button buttonCalculate;

        public void Form()
        {
            this.textBoxX = new TextBox();
            this.textBoxM = new TextBox();
            this.textBoxB = new TextBox();
            this.textBoxY = new TextBox();
            this.buttonCalculate = new Button();

            // Aquí puedes configurar las propiedades de los TextBox y el Button
            // como su ubicación, tamaño, etc.

            this.buttonCalculate.Click += new EventHandler(this.buttonCalculate_Click);

            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.textBoxM);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.buttonCalculate);
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(this.textBoxX.Text);
                double m = double.Parse(this.textBoxM.Text);
                double b = double.Parse(this.textBoxB.Text);

                double y = m * x + b;

                this.textBoxY.Text = y.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor, asegúrate de que 'x', 'm' y 'b' son números.");
            }
        }
    }
}
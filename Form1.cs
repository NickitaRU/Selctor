namespace Selctor
{
    public partial class FrVis : Form
    {
        public FrVis()
        {
            InitializeComponent();
        }

        private void txtText_Click(object sender, EventArgs e)
        {
            Image? image;
            switch (txtText.SelectedText.Trim().Trim('.'))
            {
                case "медведь":
                case "он":
                case "Мишка":
                case "ему":
                case "себе":
                    image = Properties.Resources.Bear;
                    break;
                case "Маши":
                case "Она":
                case "Маша":
                case "её":
                    image = Properties.Resources.Masha;
                    break;
                case "белку":
                    image = Properties.Resources.squirel;
                    break;
                case "трапинке":
                    image = Properties.Resources.Road;
                    break;
                case "поле":
                    image = Properties.Resources.Sunflower_field;
                    break;
                case "станцию":
                    image = Properties.Resources.station;
                    break;
                case "козлом":
                    image = Properties.Resources.goat;
                    break;
                case "свиньёй":
                    image = Properties.Resources.pig;
                    break;
                case "псом":
                    image = Properties.Resources.dog;
                    break;
                case "берлогу":
                    image = Properties.Resources.berloga;
                    break;
                case "ежа":
                    image = Properties.Resources.Hungedog;
                    break;
                case "зайца":
                    image = Properties.Resources.Rabit;
                    break;
                default:
                    image = null;
                    break;
            }
            picVis.Image = image;
        }
    }
}
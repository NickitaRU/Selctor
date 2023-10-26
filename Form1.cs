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
                case "�������":
                case "��":
                case "�����":
                case "���":
                case "����":
                    image = Properties.Resources.Bear;
                    break;
                case "����":
                case "���":
                case "����":
                case "�":
                    image = Properties.Resources.Masha;
                    break;
                case "�����":
                    image = Properties.Resources.squirel;
                    break;
                case "��������":
                    image = Properties.Resources.Road;
                    break;
                case "����":
                    image = Properties.Resources.Sunflower_field;
                    break;
                case "�������":
                    image = Properties.Resources.station;
                    break;
                case "������":
                    image = Properties.Resources.goat;
                    break;
                case "�������":
                    image = Properties.Resources.pig;
                    break;
                case "����":
                    image = Properties.Resources.dog;
                    break;
                case "�������":
                    image = Properties.Resources.berloga;
                    break;
                case "���":
                    image = Properties.Resources.Hungedog;
                    break;
                case "�����":
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
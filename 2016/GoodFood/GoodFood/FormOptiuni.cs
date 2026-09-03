namespace GoodFood;

public partial class FormOptiuni : Form
{
    public FormOptiuni()
    {
        InitializeComponent();
    }

    private void buttonCalcKcal_Click(object sender, EventArgs e)
    {
        int valAni = int.Parse(textBoxAni.Text);
        int valInaltime = int.Parse(textBoxInaltime.Text);
        int valGreutate = int.Parse(textBoxGreutate.Text);

        int suma = valAni + valInaltime + valGreutate;

        textBoxNecesarKcal.ReadOnly = true;

        if(suma < 250)
        {
            textBoxNecesarKcal.Text = "1800";
        }
        if (suma >= 250 && suma <= 275)
        {
            textBoxNecesarKcal.Text = "2200";
        }
        if (suma > 275)
        {
            textBoxNecesarKcal.Text = "2500";
        }
    }
}

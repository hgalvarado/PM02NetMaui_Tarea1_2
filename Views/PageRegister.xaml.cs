using System.Text.RegularExpressions;

namespace PM02NetMaui_Tarea1_2.Views;

public partial class PageRegister : ContentPage
{
	public PageRegister()
	{
		InitializeComponent();
	}

    private void btnRegister_Clicked(object sender, EventArgs e)
    {
        if (ValidateEmail() == 1)
        {
            DisplayAlert("�xito", "El correo electr�nico es v�lido", "OK");
        }
    }

	public int ValidateEmail()
	{
        string emailPattern = @"^[\w\.-]+@[\w\.-]+\.\w+$"; // Expresi�n regular para validar correos

		if(Regex.IsMatch(txtEmail.Text,emailPattern))
		{
            return 1;
        }
        else
        {
            // El correo electr�nico no es v�lido
            DisplayAlert("Error", "El correo electr�nico no es v�lido", "OK");
            return 0;
        }
    }
}

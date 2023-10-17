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
            DisplayAlert("Éxito", "El correo electrónico es válido", "OK");
        }
    }

	public int ValidateEmail()
	{
        string emailPattern = @"^[\w\.-]+@[\w\.-]+\.\w+$"; // Expresión regular para validar correos

		if(Regex.IsMatch(txtEmail.Text,emailPattern))
		{
            return 1;
        }
        else
        {
            // El correo electrónico no es válido
            DisplayAlert("Error", "El correo electrónico no es válido", "OK");
            return 0;
        }
    }
}

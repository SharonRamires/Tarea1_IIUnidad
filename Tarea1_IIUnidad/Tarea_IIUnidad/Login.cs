using Datos;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tarea_IIUnidad
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void iniciarbutton_Click(object sender, EventArgs e)
        {
            if (correotextBox.Text == String.Empty)
            {
                errorProvider1.SetError(correotextBox, "Ingrese un usuario");
                correotextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (contraseñatextBox.Text == string.Empty)
            {
                errorProvider1.SetError(contraseñatextBox, "Ingrese una contraseña");
                contraseñatextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            Usuario UserDatos = new Usuario();

            bool valido = await UserDatos.LoginAsync(correotextBox.Text, contraseñatextBox.Text);

            if (valido)
            {
                Inicio Formulario = new Inicio();
                Hide();
                Formulario.Show();
            }
            else
            {
                MessageBox.Show("Correo o contraseña incorrectos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
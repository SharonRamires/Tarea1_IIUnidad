using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Usuario
    {
        public async Task<bool> LoginAsync(string CorreoElectronico, string Contraseña)
        {
            bool valido = false;

            try
            {
                string sql = "SELECT 1 FROM usuario WHERE CorreoElectronico=@CorreoElectronico AND Contraseña=@Contraseña;";

                using (MySqlConnection _conexion = new MySqlConnection(Conexion.Cadena))
                {
                    await _conexion.OpenAsync();
                    using (MySqlCommand comando = new MySqlCommand(sql, _conexion))
                    {
                        comando.CommandType = System.Data.CommandType.Text;
                        comando.Parameters.Add("@CorreoElectronico", MySqlDbType.VarChar, 150).Value = CorreoElectronico;
                        comando.Parameters.Add("@Contraseña", MySqlDbType.VarChar, 120).Value = Contraseña;
                        valido = Convert.ToBoolean(await comando.ExecuteScalarAsync());
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return valido;
        }
    }
}

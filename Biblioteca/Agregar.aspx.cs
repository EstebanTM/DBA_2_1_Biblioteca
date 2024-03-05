using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Biblioteca
{
    public partial class Agregar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AgregarLibro_Click(object sender, EventArgs e)
        {
            string isbn = Request.Form["isbn"];
            string titulo = Request.Form["titulo"];
            string numeroEdicion = Request.Form["numeroEdicion"];
            string anioPublicacion = Request.Form["anioPublicacion"];
            string autores = Request.Form["autores"];
            string paisPublicacion = Request.Form["paisPublicacion"];
            string sinopsis = Request.Form["sinopsis"];
            string carrera = Request.Form["carrera"];
            string materia = Request.Form["materia"];

            string connectionString = @"Data Source=desktop-0ue61e7;Initial Catalog=Library;User ID=sa;Password=root;";
            string query = @"INSERT INTO libros (ISBN, Titulo, NumeroEdicion, AnioPublicacion, Autores, PaisPublicacion, Sinopsis, Carrera, Materia)
                     VALUES (@ISBN, @Titulo, @NumeroEdicion, @AnioPublicacion, @Autores, @PaisPublicacion, @Sinopsis, @Carrera, @Materia)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ISBN", isbn);
                command.Parameters.AddWithValue("@Titulo", titulo);
                command.Parameters.AddWithValue("@NumeroEdicion", numeroEdicion);
                command.Parameters.AddWithValue("@AnioPublicacion", anioPublicacion);
                command.Parameters.AddWithValue("@Autores", autores);
                command.Parameters.AddWithValue("@PaisPublicacion", paisPublicacion);
                command.Parameters.AddWithValue("@Sinopsis", sinopsis);
                command.Parameters.AddWithValue("@Carrera", carrera);
                command.Parameters.AddWithValue("@Materia", materia);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Response.Redirect("default.aspx");
                }
                else
                {
                }
            }
        }

    }
}
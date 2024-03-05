using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Biblioteca
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                MostrarLibros();
            }
        }

        private void MostrarLibros()
        {
            string connectionString = @"Data Source=desktop-0ue61e7;Initial Catalog=Library;User ID=sa;Password=root;";
            string query = "SELECT * FROM libros";

            StringBuilder htmlTable = new StringBuilder();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string isbn = reader["ISBN"].ToString();
                    string titulo = reader["Titulo"].ToString();
                    string numeroEdicion = reader["NumeroEdicion"].ToString();
                    string anioPublicacion = reader["AnioPublicacion"].ToString();
                    string autores = reader["Autores"].ToString();
                    string paisPublicacion = reader["PaisPublicacion"].ToString();
                    string sinopsis = reader["Sinopsis"].ToString();
                    string carrera = reader["Carrera"].ToString();
                    string materia = reader["Materia"].ToString();

                    htmlTable.Append("<tr>");
                    htmlTable.Append("<td>" + isbn + "</td>");
                    htmlTable.Append("<td>" + titulo + "</td>");
                    htmlTable.Append("<td>" + numeroEdicion + "</td>");
                    htmlTable.Append("<td>" + anioPublicacion + "</td>");
                    htmlTable.Append("<td>" + autores + "</td>");
                    htmlTable.Append("<td>" + paisPublicacion + "</td>");
                    htmlTable.Append("<td>" + sinopsis + "</td>");
                    htmlTable.Append("<td>" + carrera + "</td>");
                    htmlTable.Append("<td>" + materia + "</td>");
                    htmlTable.Append("<td>");
                    htmlTable.Append("<button class='edit-btn' onclick='EditarLibro(\"" + isbn + "\")'>Editar</button>");
                    htmlTable.Append("<button class='delete-btn' onclick='EliminarLibro(\"" + isbn + "\")'>Eliminar</button>");
                    htmlTable.Append("</td>");
                    htmlTable.Append("</tr>");
                }

                reader.Close();
            }

            ltlBooks.Text = htmlTable.ToString();
        }

        protected void EditarLibro_Click(object sender, EventArgs e)
        {
        }

        protected void EliminarLibro_Click(object sender, EventArgs e)
        {
            Button btnEliminar = (Button)sender;
            string isbn = btnEliminar.CommandArgument;
            string connectionString = @"Data Source=desktop-0ue61e7;Initial Catalog=Library;User ID=sa;Password=root;";
            string query = "DELETE FROM libros WHERE ISBN = @ISBN";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ISBN", isbn);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MostrarLibros();
                }
                else
                {
                }
            }
        }



    }
}
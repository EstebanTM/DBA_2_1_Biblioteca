<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Agregar.aspx.cs" Inherits="Biblioteca.Agregar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Agregar Nuevo Libro</title>
    <style>
        body {
            font-family: Arial, sans-serif;
        }

        .container {
            width: 50%;
            margin: 20px auto;
        }

        .form-group {
            margin-bottom: 20px;
        }

        .form-group label {
            display: block;
            margin-bottom: 5px;
        }

        .form-group input {
            width: 100%;
            padding: 8px;
            box-sizing: border-box;
        }

        .form-group textarea {
            width: 100%;
            height: 100px;
            padding: 8px;
            box-sizing: border-box;
        }

        .form-group button {
            padding: 10px 20px;
            background-color: #4CAF50;
            color: white;
            border: none;
            cursor: pointer;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="container">
        <h2>Agregar Nuevo Libro</h2>
        <div class="form-group">
            <label for="isbn">ISBN:</label>
            <input type="text" id="isbn" name="isbn" runat="server" />
        </div>
        <div class="form-group">
            <label for="titulo">Título:</label>
            <input type="text" id="titulo" name="titulo" runat="server" />
        </div>
        <div class="form-group">
            <label for="numeroEdicion">Número de Edición:</label>
            <input type="text" id="numeroEdicion" name="numeroEdicion" runat="server" />
        </div>
        <div class="form-group">
            <label for="anioPublicacion">Año de Publicación:</label>
            <input type="text" id="anioPublicacion" name="anioPublicacion" runat="server" />
        </div>
        <div class="form-group">
            <label for="autores">Autores:</label>
            <input type="text" id="autores" name="autores" runat="server" />
        </div>
        <div class="form-group">
            <label for="paisPublicacion">País de Publicación:</label>
            <input type="text" id="paisPublicacion" name="paisPublicacion" runat="server" />
        </div>
        <div class="form-group">
            <label for="sinopsis">Sinopsis:</label>
            <textarea id="sinopsis" name="sinopsis" runat="server"></textarea>
        </div>
        <div class="form-group">
            <label for="carrera">Carrera:</label>
            <input type="text" id="carrera" name="carrera" runat="server" />
        </div>
        <div class="form-group">
            <label for="materia">Materia:</label>
            <input type="text" id="materia" name="materia" runat="server" />
        </div>
        <div class="form-group">
            <asp:Button ID="btnAgregarLibro" runat="server" Text="Agregar Libro" OnClick="AgregarLibro_Click" />
        </div>

    </form>

</body>
</html>

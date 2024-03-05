<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Biblioteca._default" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Lista de Libros</title>
    <style>
        body {
            background-color: #f2f2f2; /* Color de fondo */
            font-family: Arial, sans-serif;
            margin: 0;
            padding: 0;
        }

        .topbar {
            background-color: #007bff; /* Color de fondo azul */
            color: white; /* Texto en blanco */
            padding: 10px;
            display: flex; /* Para alinear los elementos */
            justify-content: space-between; /* Para alinear los elementos al inicio y al final */
        }

        .topbar h1 {
            margin-left: 20px; /* Margen izquierdo para el título */
        }

        .topbar a {
            margin-right: 20px; /* Margen derecho para el enlace Agregar */
            color: white; /* Texto en blanco */
            text-decoration: none; /* Sin subrayado */
        }

        table {
            border-collapse: collapse;
            width: 100%;
        }

        th, td {
            padding: 8px;
            text-align: left;
            border-bottom: 1px solid #ddd;
        }

        th {
            background-color: #4CAF50; /* Color de fondo del encabezado de la tabla */
            color: white;
        }
    </style>

</head>
<body>
    <div class="topbar">
        <h1>Librería</h1>
        <a href="Agregar.aspx" class="button">Agregar</a>
    </div>
    <br></br>
    <form id="form1" runat="server">
        <div>
            <table border="1">
                <thead>
                    <tr>
                        <th>ISBN</th>
                        <th>Título</th>
                        <th>Número de Edición</th>
                        <th>Año de Publicación</th>
                        <th>Autores</th>
                        <th>País de Publicación</th>
                        <th>Sinopsis</th>
                        <th>Carrera</th>
                        <th>Materia</th>
                        <th>Acciones</th>
                    </tr>
                </thead>
                <tbody>
                    <asp:Literal ID="ltlBooks" runat="server"></asp:Literal>
                </tbody>
            </table>
        </div>
    </form>
<script src="default.js"></script>
</body>
</html>

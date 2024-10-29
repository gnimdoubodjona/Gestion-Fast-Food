<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AfficherMenu.aspx.cs" Inherits="GestionFastFood.AfficherMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Affichage du Menu</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
</head>

    <style>
        body{
            background-color:white; 
            color:Black;
        }

        h1{
            text-decoration:solid;
            color:black;
            font-family:'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
        }

        .contenu{
            padding:8em;
            margin: 10px;
        }

    </style>
<body>
    <div class="contenu">
        <form id="form1" runat="server">
    <div class="container text-center">
        <h1>Affichage des Données</h1>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CssClass="table table-striped">
            <Columns>
                    <asp:BoundField DataField="PlatsMenu" HeaderText="PlatsMenu" />
                    <asp:BoundField DataField="Prix" HeaderText="Prix" />
                    <asp:BoundField DataField="HeureDeDisponibiliteDuPlats" HeaderText="HeureDeDisponibiliteDuPlats" />   
            </Columns>
        </asp:GridView>
    </div>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="text-align: center" Text="Ajouter Plats" class="btn btn-primary"/>       
</form>
    </div>
</body>

</html>

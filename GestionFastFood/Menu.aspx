<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="GestionFastFood.Menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Ajouter Un Menu</title>

        <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/sweetalert2@11/dist/sweetalert2.min.css">
        <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">

    <style>
        body{
            background-color:white; 
            color:black;
           
        }

        .contenu{
            padding:8em;
            margin: 10px;
        }
        #txt{
            text-size-adjust:auto;
            font-family:'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
        }


    </style>
</head>
    
<body>
    <div class="contenu">
            <form id="form1" runat="server">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="txt" runat="server" Text="Menu Du FastFood" BackColor="White" BorderWidth="5px" Height="2em" Width="10em"></asp:Label>
        <div>
        </div>
        <table class="table">
            <tr>
                <td>Plat au Menu</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" Width="295px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>PrixDuPlat</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" Width="292px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Heure De Disponibilité Du Plats</td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server" Width="295px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Ajouter" class="btn btn-info"/>
                </td>
                <td>
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="text-align: center" Text="Afficher le Menu" class="btn btn-primary"/>
                </td>
            </tr>
        </table>

                <script src="https://cdn.jsdelivr.net/npm/sweetalert2@11"></script>
                <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>

    </form>
    </div>
</body>
</html>

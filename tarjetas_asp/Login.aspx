<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="tarjetas_asp.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Login</title>
    <script type="text/javascript">
        function validateForm() {
            var username = document.getElementById('<%= txtUsername.ClientID %>').value;
            var password = document.getElementById('<%= txtPassword.ClientID %>').value;
            if (username === "" || password === "") {
                alert("Ambos campos son obligatorios.");
                return false;
            }
            return true;
        }
    </script>
</head>
<body>
    <form id="form1" runat="server" onsubmit="return validateForm()">
        <div>
            <label for="txtUsername">Nombre de Usuario:</label>
            <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
        </div>
        <div>
            <label for="txtPassword">Contraseña:</label>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
        </div>
    </form>

</body>
</html>

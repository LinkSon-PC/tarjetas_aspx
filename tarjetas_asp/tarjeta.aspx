﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="tarjeta.aspx.cs" Inherits="tarjetas_asp.tarjeta" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Enviar Información de Tarjeta de Crédito</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblStatus" runat="server" Text=""></asp:Label>
            <br />
            <asp:Button ID="btnSendXml" runat="server" Text="Enviar Información 1" OnClick="ConsumeWebService" />

            <br />
            
            <asp:Label ID="lblStatus2" runat="server" Text=""></asp:Label>
            <br />
            <asp:Button ID="btnSendXml2" runat="server" Text="Enviar Información 2" OnClick="btnSendXml_Click" />
        </div>
    </form>
</body>
</html>
<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="WebRoamLab._Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            width: 1105px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TB1" TextMode="Email" runat="server" /><asp:TextBox ID="TB2" TextMode="Password" runat="server" />
            <br />
            <asp:Button Text="text" runat="server" OnClick="Unnamed1_Click" />
            <asp:Button Text="text" runat="server" OnClick="Unnamed_Click" />
        </div>
    </form>
</body>
</html>

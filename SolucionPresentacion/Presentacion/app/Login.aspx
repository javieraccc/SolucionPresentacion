<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Presentacion.app.site.template.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
     <form id="frm_login" runat="server">
    <div>
        <asp:label ID="lbl_usuario" runat="server" Text="Usiario " />
        <asp:TextBox ID="txt_usuario" runat="server" Text=""  />

        <asp:label ID="lbl_password" runat="server" Text="Contraseña " />
        <asp:TextBox ID="txt_password" runat="server" Text="" TextMode="Password"  />

        <asp:Button ID="btn_login" runat="server" Text="LOGIN" OnClick="btn_login_Click"/>
        <asp:label ID="lbl_mensaje_error" runat="server" Text="" />
    </div>
    </form>
</body>
</html>

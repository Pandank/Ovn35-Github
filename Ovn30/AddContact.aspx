<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddContact.aspx.cs" Inherits="Ovn30.AddContact" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="style/myStyle.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table style="width:50%;">
            <tr>
                <td><asp:Label ID="LabelFirstname" runat="server" Text="Firstname"></asp:Label></td>
                <td>
                    <asp:TextBox ID="TextBoxFirstname" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Firstname is required" ControlToValidate="TextBoxFirstname" EnableClientScript="False"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="LabelLastname" runat="server" Text="Label"></asp:Label></td>
                <td>
                    <asp:TextBox ID="TextBoxLastname" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="ButtonAddContact" runat="server" Text="Button" OnClick="ButtonAddContact_Click" />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>

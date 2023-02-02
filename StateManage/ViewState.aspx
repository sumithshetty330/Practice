<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewState.aspx.cs" Inherits="StateManage.ViewState" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server" enableviewstate="true">
        <asp:ListBox ID="lstCourse" EnableViewState="true" runat="server" OnSelectedIndexChanged="lstCourse_SelectedIndexChanged" Width="160px">
            <asp:ListItem></asp:ListItem>
        </asp:ListBox>
        <p>
            <asp:Button ID="btnSubmit" runat="server" Text="Button" OnClick="btnSubmit_Click" />
        </p>
      
    </form>
</body>
</html>

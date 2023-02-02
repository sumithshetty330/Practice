<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataHandling.aspx.cs" Inherits="WebApp.FetchingData" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Department
    </title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="gvdept" runat="server">
            <Columns>
                <asp:BoundField />
            </Columns>
        </asp:GridView>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        </p>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="StoredProcedures.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
   <center> <form id="form1" runat="server">
        <div>
            <asp:Button ID="ShowEmpName" runat="server" Text="Show Employee Names" Font-Bold="True" OnClick="ShowEmpName_Click" /><br /><br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView><br />
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </div>
    </form>
       </center>
</body>
</html>

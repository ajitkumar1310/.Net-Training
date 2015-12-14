<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="eMPtABLE.aspx.cs" Inherits="Session1.eMPtABLE" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:EmpDBConnectionString %>" SelectCommand="SELECT * FROM [Table]"></asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>

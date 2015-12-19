<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmpWebForm.aspx.cs" Inherits="WebAppWithStoredProc.EmpWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DataGrid ID="DataGrid1" runat="server" OnEditCommand="DataGrid1_EditCommand">
            <Columns>
                <asp:EditCommandColumn CancelText="Cancel" EditText="Edit" UpdateText="Update"></asp:EditCommandColumn>
            </Columns>
        </asp:DataGrid>
    </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditItem.aspx.cs" Inherits="NhibernateCRUD.EditItem" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Edit Item</title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/telerik-kendo-theme@latest/dist/all.css" />
    <script src="https://cdn.jsdelivr.net/npm/jquery@latest/dist/jquery.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/@progress/kendo-ui@latest/js/kendo.all.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">

        
         <telerik:RadScriptManager ID="RadScriptManager1" runat="server" />
        <div>
            <asp:HiddenField ID="hdnId" runat="server" />
            <label for="txtFirstName">First Name:</label>
            <telerik:RadTextBox ID="txtFirstName" runat="server"></telerik:RadTextBox><br />
            
            <label for="txtLastName">Last Name:</label>
            <telerik:RadTextBox ID="txtLastName" runat="server"></telerik:RadTextBox><br />
            
            <label for="txtDesignation">Designation:</label>
            <telerik:RadTextBox ID="txtDesignation" runat="server"></telerik:RadTextBox><br />
            
            <telerik:RadButton ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click"></telerik:RadButton>
        </div>
    </form>
</body>
</html>

<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="success.aspx.vb" Inherits="SQL_WebAssessment.success" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Search</title>
</head>
        <% Response.WriteFile("header_nav.html") %>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:PlaceHolder ID ="plhDataTable" runat="server"></asp:PlaceHolder>
        </div>
    </form>
</body>
    <% Response.WriteFile("footer.html") %>
</html>

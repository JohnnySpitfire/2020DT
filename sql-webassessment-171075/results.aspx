<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="results.aspx.vb" Inherits="SQL_WebAssessment.results" %>

<!DOCTYPE html>
<%-- The query results will appear here, from being built with a stringbuilder into the placeholder--%>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Query Results</title>

    <%Response.WriteFile("header_nav.html") %>

</head>
<body>
    <form id="main" runat="server">
        <div>
            <asp:PlaceHolder ID ="plhResults" runat ="server">

            </asp:PlaceHolder>
        </div>
        <% Response.WriteFile("footer.html") %>
    </form>
</body>
</html>

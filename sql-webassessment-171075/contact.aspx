<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="contact.aspx.vb" Inherits="SQL_WebAssessment.contact" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Contact</title>

    <%Response.WriteFile("header_nav.html") %>

</head>
<body>
    <form id="main" runat="server">
        <div>
            <%--Displays the contact information for the school and an interactve map of rathkeale--%>
            <h2>Contact Us:</h2>
            <p>Feel free to contact us at:</p>

             School Office:<br/>
             Phone:  (06) 370 0175<br/>
             Email:  <a href="mailto:office@rathkeale.school.nz">office@rathkeale.school.nz</a><br/>
             Fax:  (06) 377 9020<br/>
            <br />
            <h4>Location:</h4>
            <iframe src="https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d12063.065552278438!2d175.6860494!3d-40.8989391!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x0%3A0xe5a6933ad7025221!2sRathkeale%20College!5e0!3m2!1sen!2snz!4v1595476737878!5m2!1sen!2snz"
                style="border:0;"aria-hidden="false" tabindex="0" width="300" height="250"></iframe>
            
        </div>
        <% Response.WriteFile("footer.html") %>
    </form>
</body>
</html>.¿
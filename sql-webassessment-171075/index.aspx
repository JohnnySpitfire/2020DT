<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="index.aspx.vb" Inherits="SQL_WebAssessment.index" %>
<html>
 <% Response.WriteFile("header_nav.html") %>
<!-- Main content div starts below -->
<body>
    <div class="container">
	    <div class="main">
            <%--All insertion fields have validators--%>
	        <h1>Lost Property Form</h1>
            <%--Start of insertion form--%>
            <form id="insertForm" runat="server">

                <asp:Panel ID="pnlBookingForm" runat="server" BackColor="#9CA3DB">
                    <%--Name on Item insertion field--%>
                    Name On Item<br />
                    <asp:TextBox ID="txtNameOnItem" runat="server"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="revNameOnItem" runat="server" Display="Dynamic" ErrorMessage="Please enter a valid name (characters only)" ValidationExpression="^[A-Z a-z]*$" ValidationGroup="AllValidators" ControlToValidate="txtNameOnItem" ValidateRequestMode="Enabled"></asp:RegularExpressionValidator>
                    <br />
                    <br />
                    <%--Item name insertions field--%>
                    Item Name<sup>*</sup><br />
                    <asp:TextBox ID="txtItemName" runat="server"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="revItemName" runat="server" Display="Dynamic" ErrorMessage="Please enter a valid name (characters only)" ValidationExpression="^[A-Z a-z]*$" ValidationGroup="AllValidators" ControlToValidate="txtItemName" ValidateRequestMode="Enabled"></asp:RegularExpressionValidator>
                    <asp:RequiredFieldValidator ID="rfvItemName" runat="server" ControlToValidate="txtItemName" ErrorMessage="Please enter the name of the item" ValidationGroup="AllValidators" Display="Dynamic"></asp:RequiredFieldValidator>
                    <br />
                    <br />
                    
                    <%--Category insertion field--%>
                    Category<sup>*</sup><br />
                    <asp:RequiredFieldValidator ID="rfvCategory" runat="server" ControlToValidate="ddlCategory" ErrorMessage="Please select a category" ValidationGroup="AllValidators" Display="Dynamic" InitialValue="-Choose-"></asp:RequiredFieldValidator>
                    <br />
                    <asp:DropDownList ID="ddlCategory" runat="server" Height="19px">
                        <asp:ListItem Value="-Choose-">-Choose-</asp:ListItem>
                        <asp:ListItem>Electronics</asp:ListItem>
                        <asp:ListItem>Clothing</asp:ListItem>
                        <asp:ListItem>Stationary</asp:ListItem>
                        <asp:ListItem>Personal Item</asp:ListItem>
                        <asp:ListItem>Book</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <%--Color insertion field--%>
                    Colour<sup>*</sup><br />
                    <asp:DropDownList ID="ddlColour" runat="server">
                        <asp:ListItem Value ="-Choose-">-Choose-</asp:ListItem>
                        <asp:ListItem>Red</asp:ListItem>
                        <asp:ListItem>Orange</asp:ListItem>
                        <asp:ListItem>Yellow</asp:ListItem>
                        <asp:ListItem>Green</asp:ListItem>
                        <asp:ListItem>Blue</asp:ListItem>
                        <asp:ListItem>Cyan</asp:ListItem>
                        <asp:ListItem>Pink</asp:ListItem>
                        <asp:ListItem>Purple</asp:ListItem>
                        <asp:ListItem>Brown</asp:ListItem>
                        <asp:ListItem>Black</asp:ListItem>
                        <asp:ListItem>Grey</asp:ListItem>
                        <asp:ListItem>White</asp:ListItem>
                        <asp:ListItem>No Colour</asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="rfvColour" runat="server" ControlToValidate="ddlColour" Display="Dynamic" ErrorMessage="Please select a colour" ValidationGroup="AllValidators" InitialValue="-Choose-"></asp:RequiredFieldValidator>
                    <br />
                    <br />
                    <%--Time Found insertion field--%>
                    Time Found<sup>*</sup>:<br />
                    <asp:DropDownList ID="ddlTime" runat="server">
                        <asp:ListItem Value ="-Choose-">-Choose-</asp:ListItem>
                        <asp:ListItem>00:00</asp:ListItem>
                        <asp:ListItem>00:30</asp:ListItem>
                        <asp:ListItem>01:00</asp:ListItem>
                        <asp:ListItem>01:30</asp:ListItem>
                        <asp:ListItem>02:00</asp:ListItem>
                        <asp:ListItem>02:30</asp:ListItem>
                        <asp:ListItem>03:00</asp:ListItem>
                        <asp:ListItem>03:30</asp:ListItem>
                        <asp:ListItem>04:00</asp:ListItem>
                        <asp:ListItem>04:30</asp:ListItem>
                        <asp:ListItem>05:00</asp:ListItem>
                        <asp:ListItem>05:30</asp:ListItem>
                        <asp:ListItem>06:00</asp:ListItem>
                        <asp:ListItem>06:30</asp:ListItem>
                        <asp:ListItem>07:00</asp:ListItem>
                        <asp:ListItem>07:30</asp:ListItem>
                        <asp:ListItem>08:00</asp:ListItem>
                        <asp:ListItem>08:30</asp:ListItem>
                        <asp:ListItem>09:00</asp:ListItem>
                        <asp:ListItem>09:30</asp:ListItem>
                        <asp:ListItem>10:00</asp:ListItem>
                        <asp:ListItem>10:30</asp:ListItem>
                        <asp:ListItem>11:00</asp:ListItem>
                        <asp:ListItem>11:30</asp:ListItem>
                        <asp:ListItem>12:00</asp:ListItem>
                        <asp:ListItem>12:30</asp:ListItem>
                        <asp:ListItem>13:00</asp:ListItem>
                        <asp:ListItem>13:30</asp:ListItem>
                        <asp:ListItem>14:00</asp:ListItem>
                        <asp:ListItem>14:30</asp:ListItem>
                        <asp:ListItem>15:00</asp:ListItem>
                        <asp:ListItem>15:30</asp:ListItem>
                        <asp:ListItem>16:00</asp:ListItem>
                        <asp:ListItem>16:30</asp:ListItem>
                        <asp:ListItem>17:00</asp:ListItem>
                        <asp:ListItem>17:30</asp:ListItem>
                        <asp:ListItem>18:00</asp:ListItem>
                        <asp:ListItem>18:30</asp:ListItem>
                        <asp:ListItem>19:00</asp:ListItem>
                        <asp:ListItem>19:30</asp:ListItem>
                        <asp:ListItem>20:00</asp:ListItem>
                        <asp:ListItem>20:30</asp:ListItem>
                        <asp:ListItem>21:00</asp:ListItem>
                        <asp:ListItem>21:30</asp:ListItem>
                        <asp:ListItem>22:00</asp:ListItem>
                        <asp:ListItem>22:30</asp:ListItem>
                        <asp:ListItem>23:00</asp:ListItem>
                        <asp:ListItem>23:30</asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="rfvTime" runat="server" ControlToValidate="ddlTime" Display="Dynamic" ErrorMessage="Please select a time" ValidationGroup="AllValidators" InitialValue="-Choose-"></asp:RequiredFieldValidator>
                    <br />
                    <br />
                    <%--Date Found Field--%>
                    Date Found<sup>*</sup>: (dd/mm/yyyy)<br />
                    <asp:TextBox ID="txtDate" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvDate" runat="server" ControlToValidate="txtDate" ErrorMessage="Please enter a date" ValidationGroup="AllValidators" Display="Dynamic"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="revDate" runat="server" Display="Dynamic" ErrorMessage="Please enter a valid date" ValidationExpression="^(0?[1-9]|[12][0-9]|3[01])[- /.](0?[1-9]|1[012])[- /.](19|20)[0-9][0-9]$" ValidationGroup="AllValidators" ControlToValidate="txtDate" ValidateRequestMode="Enabled"></asp:RegularExpressionValidator>
                    <br />
                    <br />

                    <%--Form Submit Button--%>
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" ValidationGroup="AllValidators" ValidateRequestMode="Enabled" /><br />

                </asp:Panel>
            </form>
    
                  <!-- End booking form -->
	
	        </div> <!-- Main content end  -->
	   
         </div> <!-- container (around main div) end-->
    </body>
     <!-- Footer starts below -->
<% Response.WriteFile("footer.html") %>
    <!-- Footer ends above -->
 

<!-- Link to JavaScipt plugins, needed for things like the dropdown menu to work.  BOTH files are required. -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
      
    
   

</html>

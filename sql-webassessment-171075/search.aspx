    <%@ Page Language="vb" AutoEventWireup="false" CodeBehind="search.aspx.vb" Inherits="SQL_WebAssessment.search" %>

    <!DOCTYPE html>

    <html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title>Search</title>
        <style type="text/css">
            .auto-style1 {
                width: 725px;
                height: 643px;
            }
        </style>
    </head>
        <%--Search input page, gathers all information from the user, and displays the relevent results to the user on the results page--%>
    <% Response.WriteFile("header_nav.html") %>
    <body>
        <form id="mainsearch" runat="server">
            <div class="auto-style1">
                <div class ="one">
                <%--Name on item input and validators--%>
                    <p>&nbsp; Name On Item<sup>*</sup>:</p>
                    <asp:TextBox ID ="txtNameOnItem" runat="server" Width ="135px"></asp:TextBox>
                    &nbsp;&nbsp;
                    <asp:Button ID ="btnNameOnItemSearch" ValidationGroup="valINameOnItem" OnClick="btnNameOnItemSearch_Click" runat="server" Text="Search Name On Item" Width ="186px" />
                    <asp:RegularExpressionValidator ID="revNameOnItem" runat="server" Display="Dynamic" ErrorMessage="Please enter a valid name (characters only)" ValidationExpression="^[A-Z a-z]*$" ValidationGroup="valINameOnItem" ControlToValidate="txtNameOnItem" ValidateRequestMode="Enabled"></asp:RegularExpressionValidator>
                    <asp:RequiredFieldValidator ID="rfvNameOnItem" runat="server" ControlToValidate="txtNameOnItem" Display="Dynamic" ErrorMessage="Please enter a name" ValidateRequestMode="Enabled" ValidationGroup="valINameOnItem">A name is required</asp:RequiredFieldValidator>
                </div>
    <%--            Item Name input and validators--%>
                <div class ="two">
                    <p>&nbsp;Item Name<sup>*</sup>:</p>
                    <asp:TextBox ID ="txtItemName" runat="server" Width ="135px"></asp:TextBox>
                    &nbsp;&nbsp;
                    <asp:Button ID ="btnItemNameSearch" ValidationGroup="valItemName" OnClick="btnNameOnItemSearch_Click" runat="server" Text="Search Name On Item" Width ="186px" />
                    <asp:RegularExpressionValidator ID="revItemName" runat="server" Display="Dynamic" ErrorMessage="Please enter a valid name (characters only)" ValidationExpression="^[A-Z a-z]*$" ValidationGroup="valItemName" ControlToValidate="txtItemName" ValidateRequestMode="Enabled"></asp:RegularExpressionValidator>
                    <asp:RequiredFieldValidator ID="rfvItemName" runat="server" ControlToValidate="txtItemName" Display="Dynamic" ErrorMessage="Please enter the name of the item" ValidateRequestMode="Enabled" ValidationGroup="valItemName">A name is required</asp:RequiredFieldValidator>
                </div>
    <%--            Category input and validators--%>
                <div class ="one"> 
                     <p>Category<sup>*</sup>:</p>
                    <asp:DropDownList ID="ddlCategory" runat="server" Height="19px">
                            <asp:ListItem Value ="-Choose-">-Choose-</asp:ListItem>
                            <asp:ListItem>Electronics</asp:ListItem>
                            <asp:ListItem>Clothing</asp:ListItem>
                            <asp:ListItem>Stationary</asp:ListItem>
                            <asp:ListItem>Personal Item</asp:ListItem>
                            <asp:ListItem>Book</asp:ListItem>
                        </asp:DropDownList>
                        <asp:Button ID ="btnCategory" ValidationGroup="valCategory" OnClick="btnCategorySearch_Click" runat="server" Text="Search Category Of Item" Width ="186px" />
                      <asp:RequiredFieldValidator ID="rfvCategory" runat="server" ControlToValidate="ddlCategory" ErrorMessage="Please select a category" ValidationGroup="valCategory" Display="Dynamic" InitialValue="-Choose-"></asp:RequiredFieldValidator>
                </div>
                <%--Colour input and validators--%>
                <div class ="two">
                    <p>Colour<sup>*</sup>:</p>
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
                        <asp:Button ID ="btnColour" ValidationGroup="valColour" OnClick="btnColourSearch_Click" runat="server" Text="Search Colour Of Item" Width ="186px" />
                        <asp:RequiredFieldValidator ID="rfvColour" runat="server" ControlToValidate="ddlColour" Display="Dynamic" ErrorMessage="Please select a colour" ValidationGroup="valColour" InitialValue="-Choose-"></asp:RequiredFieldValidator>
                </div>
                <%--Time input and validators--%>
                <div class ="one">
                    <p>Time<sup>*</sup>:</p>
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
                        <asp:Button ID ="btnTime" ValidationGroup="valTime" OnClick="btnTimeSearch_Click" runat="server" Text="Search Time the item was found" Width ="249px" />
                        <asp:RequiredFieldValidator ID="rfvTime" runat="server" ControlToValidate="ddlTime" Display="Dynamic" ErrorMessage="Please select a time" ValidationGroup="valTime" InitialValue="-Choose-"></asp:RequiredFieldValidator>
                </div>
                <%--Date input and validators--%>
                <div class ="two">
                    <p>Date<sup>*</sup>:</p>
                      <asp:TextBox ID="txtDate" runat="server" Width="135px"></asp:TextBox>
                       <asp:Button ID ="btnDate" ValidationGroup="valDate" OnClick="btnDateSearch_Click" runat="server" Text="Search Date the item was found" Width ="246px" />
                        <asp:RequiredFieldValidator ID="rfvDate" runat="server" ControlToValidate="txtDate" ErrorMessage="Please enter a date" ValidationGroup="valDate" Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="revDate" runat="server" Display="Dynamic" ErrorMessage="Please enter a valid date" ValidationExpression="^(0?[1-9]|[12][0-9]|3[01])[- /.](0?[1-9]|1[012])[- /.](19|20)[0-9][0-9]$" ValidationGroup="valDate" ControlToValidate="txtDate" ValidateRequestMode="Enabled"></asp:RegularExpressionValidator>
                </div>
                <%--Special Query, search today--%>
                <div class ="one">
                    <p>Search Items Lost Today</p>
                    <asp:Button ID ="btnItemLostToday" ValidationGroup="" OnClick="btnItemLostToday_Click" runat="server" Text="Search Items Which Were Found Today" Width ="301px" />
 
                </div>
            </div>
        </form>
    </body>
    <% Response.WriteFile("footer.html") %>
    </html>

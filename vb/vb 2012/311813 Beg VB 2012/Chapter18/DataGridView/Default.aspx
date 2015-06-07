<%@ Page Language="VB" %>

<!DOCTYPE html>
<script runat="server">

</script>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Grid View</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:SqlDataSource ID="sdsAuthors" runat="server" ProviderName="System.Data.SqlClient"
            ConnectionString="Server=localhost\SQLEXPRESS; User ID=sa;
                      Password=wrox;Database=pubs;" SelectCommand="SELECT au_id, au_lname,
                      au_fname, phone,
                      address, city, state, zip FROM authors" UpdateCommand="UPDATE authors
                      SET au_lname = @au_lname,
                      au_fname = @au_fname, phone = @phone,
                      address = @address,
                      city = @city, state = @state, zip = @zip
                      WHERE au_id = @au_id"></asp:SqlDataSource>
        <asp:GridView ID="gdvAuthors" runat="server" DataSourceID="sdsAuthors" AllowPaging="True"
            AllowSorting="True" AutoGenerateColumns="false" DataKeyNames="au_id">
            <PagerStyle BackColor="Gray" ForeColor="White" HorizontalAlign="Center" />
            <HeaderStyle BackColor="Black" ForeColor="White" />
            <AlternatingRowStyle BackColor="LightGray" />
            <Columns>
                <asp:CommandField ButtonType="Button" ShowEditButton="true" />
                <asp:BoundField Visible="false" HeaderText="au_id" DataField="au_id" SortExpression="au_id">
                </asp:BoundField>
                <asp:BoundField HeaderText="Last Name" DataField="au_lname" SortExpression="au_lname">
                </asp:BoundField>
                <asp:BoundField HeaderText="First Name" DataField="au_fname" SortExpression="au_fname">
                </asp:BoundField>
                <asp:BoundField HeaderText="Phone" DataField="phone" SortExpression="phone"></asp:BoundField>
                <asp:BoundField HeaderText="Address" DataField="address" SortExpression="address">
                </asp:BoundField>
                <asp:BoundField HeaderText="City" DataField="city" SortExpression="city"></asp:BoundField>
                <asp:BoundField HeaderText="State" DataField="state" SortExpression="state"></asp:BoundField>
                <asp:BoundField HeaderText="Zip Code" DataField="zip" SortExpression="zip"></asp:BoundField>
            </Columns>
        </asp:GridView>
    </div>
    </form>
</body>
</html>

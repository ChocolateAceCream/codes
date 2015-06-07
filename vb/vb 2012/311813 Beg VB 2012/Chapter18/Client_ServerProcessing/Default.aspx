<%@ Page Title="My First Page" Language="VB" MasterPageFile="~/Site.Master" 
    AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<asp:Content runat="server" ID="HeadContent" ContentPlaceHolderID="HeadContent">
    <script lang="javascript" type="text/javascript">
        function btnClient_onclick() {
            document.getElementById("lblClient").innerText = "Changed";
            document.getElementById("lblServer").innerText = "Server";
        }
    </script>
</asp:Content>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1>
                    <%: Page.Title %>.</h1>
                <h2>Modify this template to jump-start your ASP.NET application.</h2>
            </hgroup>
            <p>
                To learn more about ASP.NET, visit <a href="http://asp.net" title="ASP.NET Website">
                    http://asp.net</a>. The page features <span class="highlight">videos, tutorials, and
                        samples</span>to help you get the most from ASP.NET. If you have any questions
                about ASP.NET visit <a href="http://forums.asp.net/18.aspx" title="ASP.NET Forum">our
                    forums</a>.
            </p>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <p>
        <br />
    </p>
    <p>
        <asp:Button ID="btnServer" runat="server" Text="Server" />
        &nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblServer" runat="server" ClientIDMode="Static" Text="Server"></asp:Label>
    </p>
    <p>
        <input id="btnClient" type="button" value="Client" onclick="return btnClient_onclick();" />&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblClient" runat="server" ClientIDMode="Static" Text="Client"></asp:Label>
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>

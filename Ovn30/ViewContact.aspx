<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="ViewContact.aspx.cs" Inherits="Ovn30.WebForm1" %>

<asp:Content ContentPlaceHolderID="head" ID="ContentHead" runat="server">
    <script>

        function GetSomePics() {
            $.getJSON("https://api.spotify.com/v1/search?q=" + $("#search").val() + "&type=artist")
            .done(function (data) {
                console.log(data);

                var htmlString = "";

                for (var i = 0; i < data.artists.items.length; i++) {

                    if (data.artists.items[i].images[0]) {
                        var src = data.artists.items[i].images[0].url;

                        htmlString += "<img style='width:150px; height:150px;' src='" + src + "' /><br />\n";
                    }
                }

                $("#images").html(htmlString);
            });
        }

    </script>
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    TODO - Form to view contact  
    <asp:Literal ID="infoLiteral" runat="server"></asp:Literal>

    <input type="text" id="search" />
    <input type="button" value="Search" onclick="GetSomePics()" />

    <div id="images">
    </div>
</asp:Content>

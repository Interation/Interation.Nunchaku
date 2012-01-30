<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ContentPlaceHolderID="TitleContent" runat="server">首页</asp:Content>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">

    <div class="index">
        
    </div>

</asp:Content>

<asp:Content ContentPlaceHolderID="HeaderContent" runat="server">
</asp:Content>

<asp:Content ContentPlaceHolderID="ScriptContent" runat="server">
    <% Html.Javascript("~/scripts/module/index.js"); %>
    <script type="text/javascript">$(document).ready(function () { index.ready(); });</script>
</asp:Content>

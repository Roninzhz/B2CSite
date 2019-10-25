<%@ Page Title="" Language="C#" MasterPageFile="~/B2CSite.Master" AutoEventWireup="true" CodeBehind="vote.aspx.cs" Inherits="B2CSite.vote" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

        .auto-style1 {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div>
            网站满意度调查</div>
        <table class="auto-style1">
            <tr>
                <td>
            <asp:Label ID="Label2" runat="server" Text="注意："></asp:Label>
            <asp:Label ID="lblState" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:RadioButtonList ID="rbtlVote" runat="server" AutoPostBack="True" CausesValidation="True" RepeatColumns="2">
                        <asp:ListItem>张玉杰</asp:ListItem>
                        <asp:ListItem>李明达</asp:ListItem>
                        <asp:ListItem>王瑜兰</asp:ListItem>
                        <asp:ListItem>赵志奇</asp:ListItem>
                        <asp:ListItem>马伟明</asp:ListItem>
                        <asp:ListItem>程超</asp:ListItem>
                        <asp:ListItem>刘平真</asp:ListItem>
                        <asp:ListItem>张群英</asp:ListItem>
                        <asp:ListItem>王子文</asp:ListItem>
                        <asp:ListItem>杨波</asp:ListItem>
                    </asp:RadioButtonList> 
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnVote" runat="server" OnClick="btnVote_Click" Text="投票" />
                    <asp:Button ID="btnView" runat="server" Text="查看" OnClick="btnView_Click1" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblView" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
</asp:Content>

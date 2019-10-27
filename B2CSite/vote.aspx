<%@ Page Title="" Language="C#" MasterPageFile="~/B2CSite.Master" AutoEventWireup="true" CodeBehind="vote.aspx.cs" Inherits="B2CSite.vote" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

        .auto-style1 {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <%--<div>
            网站满意度调查</div>--%>
        <table class="auto-style1" style="position:relative;left:35%; top:50px;">
            <tr>
                <td>
            <asp:Label ID="Label2" runat="server" Text="注意："></asp:Label>
            <asp:Label ID="lblState" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:RadioButtonList ID="rbtlVote" runat="server" AutoPostBack="True" CausesValidation="True" RepeatColumns="3">
                        <asp:ListItem>好</asp:ListItem>
                        <asp:ListItem>良</asp:ListItem>
                        <asp:ListItem>差</asp:ListItem>
                    </asp:RadioButtonList> 
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnVote" runat="server" OnClick="btnVote_Click" Text="投票" />
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
</asp:Content>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Mywebform.aspx.cs" Inherits="WebApplication1_CURD3.Mywebform" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Student Info</title>
    <style type="text/css">
        .auto-style1 {
            width: 37%;
        }
        .auto-style2 {
            width: 187px;
        }
        .auto-style3 {
            width: 285px;
        }
    </style>
</head>
<body style="height: 506px">
    <form id="form1" runat="server">
    <div>
    <div>
        <div style="font-size:x-large" align="center">Student Information</div>
    </div>
    </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Employee&nbsp; ID</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Employee Name</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Employee Age</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Employee Address</td>
                <td class="auto-style3">
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem>US</asp:ListItem>
                        <asp:ListItem>INDIA</asp:ListItem>
                        <asp:ListItem>UK</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
        </table>
        <asp:Button ID="Button1" runat="server" Text="Insert" OnClick="Button1_Click" />
        &nbsp;&nbsp;&nbsp;<asp:Button ID="Button2" runat="server" Text="Update" OnClick="Button2_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" Text="Delete" OnClick="Button3_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button4" runat="server" Text="Read" OnClick="Button4_Click" />
        <br />
        &nbsp;&nbsp;<asp:Label ID="Label1" runat="server"></asp:Label>
        <asp:Label ID="Label2" runat="server"></asp:Label>
        <asp:Label ID="Label3" runat="server"></asp:Label>
&nbsp;<asp:Label ID="Label4" runat="server"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:GridView ID="GridView1" runat="server" Width="342px">
        </asp:GridView>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;
        <br />
        <asp:GridView ID="GridView2" runat="server" Width="343px">
        </asp:GridView>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
&nbsp;&nbsp;
    </form>
</body>
</html>

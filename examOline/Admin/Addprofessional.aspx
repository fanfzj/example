<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Addprofessional.aspx.cs" Inherits="Admin_Addprofessional" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: left">
        <table style="width: 315px; height: 278px; text-align: center">
            <tr>
                <td>
                </td>
                <td>
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td style="height: 25px">
                    系名:</td>
                <td style="height: 25px">
                    <asp:DropDownList ID="DDldttID" runat="server" AutoPostBack="True" Width="154px">
                    </asp:DropDownList></td>
                <td style="height: 25px">
                </td>
            </tr>
            <tr>
                <td style="height: 25px">
                    专业编号:</td>
                <td style="height: 25px">
                    <asp:TextBox ID="txtID" runat="server"></asp:TextBox></td>
                <td style="height: 25px">
                </td>
            </tr>
            <tr>
                <td style="height: 26px">
                    专业名:</td>
                <td style="height: 26px">
                    <asp:TextBox ID="txtNum" runat="server"></asp:TextBox></td>
                <td style="height: 26px">
                </td>
            </tr>
            <tr>
                <td style="height: 27px">
                    教师名:</td>
                <td style="height: 27px">
                    <asp:DropDownList ID="DDltcrNum" runat="server" AutoPostBack="True" Width="152px">
                    </asp:DropDownList></td>
                <td style="height: 27px">
                </td>
            </tr>
            <tr>
                <td colspan="3" style="height: 29px; text-align: left">
                    描述: &nbsp; &nbsp;
                    <asp:TextBox ID="txtMrID" runat="server" Height="42px" Width="203px"></asp:TextBox></td>
            </tr>
            <tr>
                <td colspan="2" style="height: 22px">
                    <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="确定" />
                    &nbsp;
                    <asp:Button ID="btnEsc" runat="server" OnClick="btnEsc_Click" Text="重置" /></td>
                <td style="height: 22px">
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>

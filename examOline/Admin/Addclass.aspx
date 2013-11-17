<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Addclass.aspx.cs" Inherits="Admin_Addclass" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: left">
        <table style="width: 339px; height: 150px; text-align: center" border="1">
            <tr>
                <td colspan="2" style="height: 23px">
                    添加班级</td>
                <td style="width: 7px; height: 23px">
                </td>
            </tr>
            <tr>
                <td style="height: 29px">
                    年级:</td>
                <td style="height: 29px">
                    <asp:TextBox ID="txtge" runat="server"></asp:TextBox></td>
                <td style="width: 7px; height: 29px">
                </td>
            </tr>
            <tr>
                <td style="height: 30px">
                    系别:</td>
                <td style="height: 30px">
                    <asp:DropDownList ID="DDlatt" runat="server" AutoPostBack="True" Width="154px">
                    </asp:DropDownList></td>
                <td style="width: 7px; height: 30px">
                </td>
            </tr>
            <tr>
                <td style="height: 27px">
                    专业名:</td>
                <td style="height: 27px">
                    <asp:DropDownList ID="DDlpsl" runat="server" AutoPostBack="True" Width="152px">
                    </asp:DropDownList></td>
                <td style="width: 7px; height: 27px">
                </td>
            </tr>
            <tr>
                <td style="height: 32px">
                    班级编号:</td>
                <td style="height: 32px">
                    <asp:TextBox ID="txtclsID" runat="server"></asp:TextBox></td>
                <td style="width: 7px; height: 32px">
                </td>
            </tr>
            <tr>
                <td style="height: 32px">
                    班级名:</td>
                <td style="height: 32px">
                    <asp:TextBox ID="txtclsNum" runat="server"></asp:TextBox></td>
                <td style="width: 7px; height: 32px">
                </td>
            </tr>
            <tr>
                <td style="height: 30px">
                    人数:</td>
                <td style="height: 30px">
                    <asp:TextBox ID="txtNbr" runat="server"></asp:TextBox></td>
                <td style="width: 7px; height: 30px">
                </td>
            </tr>
            <tr>
                <td style="height: 28px">
                    教师名:</td>
                <td style="height: 28px">
                    <asp:DropDownList ID="DDltcr" runat="server" AutoPostBack="True" Width="154px">
                    </asp:DropDownList></td>
                <td style="width: 7px; height: 28px">
                </td>
            </tr>
            <tr>
                <td colspan="2" style="height: 44px">
                    班级描述:&nbsp;
                    <asp:TextBox ID="txtmrID" runat="server" Height="33px" Width="166px"></asp:TextBox></td>
                <td style="width: 7px; height: 44px">
                </td>
            </tr>
            <tr>
                <td colspan="2" style="height: 26px">
                    &nbsp;
                    <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="确定" />&nbsp; &nbsp;
                    <asp:Button ID="btnEsc" runat="server" OnClick="btnEsc_Click" Text="重置" /></td>
                <td style="width: 7px; height: 26px">
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>

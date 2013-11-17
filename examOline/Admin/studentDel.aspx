<%@ Page Language="C#" AutoEventWireup="true" CodeFile="studentDel.aspx.cs" Inherits="Admin_studentDel" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table align="center" bgcolor="#cccccc" width="200">
            <tr>
                <td colspan="2">
                    <div style="display: inline; width: 168px; height: 24px">
                        确定要删除以下记录吗?</div>
                </td>
            </tr>
            <tr>
                <td align="center" bgcolor="#99cccc" colspan="2">
                    <asp:Label ID="lbl_showDel" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="center">
                    &nbsp;<asp:Button ID="Button1" runat="server" Text="确定" />
                    </td>
                <td align="center">
                    &nbsp;<asp:Button ID="Button2" runat="server" Text="取消" /></td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>

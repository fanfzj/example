<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index2.aspx.cs" Inherits="信息抓取.Index2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="background:#bcc7d8; text-align:left;">
    <p>链接地址：<asp:TextBox ID="txturl" runat="server" Width="350px"></asp:TextBox></p>
    <p><asp:Button ID="btnok" runat="server" Text="提交" onclick="btnok_Click" /></p>
    </div>
    <hr />
    <div id="msg" runat="server" style="border:3px solid #293955"></div>
    </form>
</body>
</html>

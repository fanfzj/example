<%@ Page Language="C#" AutoEventWireup="true" CodeFile="student.aspx.cs" Inherits="Teacher_Teacher" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head>
<meta http-equiv="Content-Type" content="text/html; charset=gb2312" />
<title>学生考试管理</title>
<style type="text/css">
<!--
body {
	margin-left: 0px;
	margin-top: 0px;
	margin-right: 0px;
	margin-bottom: 0px;
}
-->
</style></head>

<body>
<table width="1010"  border="0" align="center" cellpadding="0" cellspacing="0">
  <tr>
    <td valign="top" style="width: 1021px"><table width="100%" border="0" cellspacing="0" cellpadding="0">
      <tr>
        <td style="height: 204px; width: 926px;"><img src="../images/5.jpg"  alt="图片位置"  width="1010" height="200"/>
                 
        
        </td>
      </tr>
    </table>
      <table width="100%" border="0" cellspacing="0" cellpadding="0">
        <tr>
          <td style="width: 230px">
          <table>
             <tr>
             <td>
          <iframe src="left.htm" style="width: 230px; height: 682px" frameborder="0" scrolling="no"></iframe>
              </td>
          </tr>
          </table>
          </td>
          <td>
              <span style="color: #ff0033">
                学生ID:</span><asp:Label id="lbl_Id" runat="server">未登录</asp:Label><span
                  style="color: #ff0033">
              &nbsp; &nbsp; &nbsp;&nbsp;
                 学生姓名:</span><asp:Label id="lbl_Name" runat="server">未登录</asp:Label><span style="color: #ff0033">
              &nbsp; &nbsp; &nbsp;&nbsp; 性别:</span><asp:Label ID="Label1" runat="server" Text="Label">未登录</asp:Label><span
                              style="color: #ff0033"> </span>
             <iframe name="menu" frameborder="0" scrolling="auto" style="width: 780px; height:682px" src="studentChangePWD.aspx" id="IFRAME1"></iframe></td>
        </tr>
      </table></td>
  </tr>
</table>
</body>
</html>
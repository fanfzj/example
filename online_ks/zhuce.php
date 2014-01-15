<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=gb2312" />
<title>无标题文档</title>
<style type="text/css">
<!--
.STYLE1 {font-size: 12px}
-->
</style>
</head>
<!--<script type="text/javascript" src="js/zhuce_js.js"></script>-->
<body>
<form name="form1" method="post" action="zhuce_ok.php">
<table width="500" height="50" border="0" cellpadding="0" cellspacing="0">
  <tr>
    <td>&nbsp;</td>
  </tr>
</table>
<table width="593" border="1" cellpadding="1" cellspacing="1" bordercolor="#FFFFFF" bgcolor="#676767">
  <tr>
    <td width="174" align="center" bgcolor="EEEEEE"><span class="STYLE1">姓&nbsp;&nbsp;&nbsp;&nbsp;名</span></td>
    <td width="406" bgcolor="#FFFFFF"><input name="username" type="text" id="username"></td>
    </tr>
  <tr>
    <td align="center" bgcolor="EEEEEE"><span class="STYLE1">联系电话</span></td>
    <td bgcolor="#FFFFFF"><input name="tel" type="text" id="tel" /></td>
    </tr>
  <tr>
    <td align="center" bgcolor="EEEEEE"><span class="STYLE1">联系地址</span></td>
    <td bgcolor="#FFFFFF"><input name="address" type="text" id="address"></td>
    </tr>
  <tr>
    <td bgcolor="EEEEEE">&nbsp;</td>
    <td bgcolor="#FFFFFF"><input type="button" name="Submit" value="注册" onClick="process()"></td>
    </tr>
</table>
</form>
<div id="divMessage" />
<script language="javascript">
function process(){
	if(form1.username.value==""){
		alert("请输入姓名！");
   		    form1.username.select();
			return(false);
		}
	if(form1.tel.value==""){
		alert("请输入电话号码！");
		form1.tel.select();
		return(false);
		}
	if(checkphone(form1.tel.value)!=true){
		alert("您输入的电话号码的格式不正确！");
		form1.tel.select();
		return(false);
		}	

	if(form1.address.value==""){
		alert("请输入联系地址！");
		form1.address.select();
		return(false);
		}
	return(true);
}

//验证电话号码的格式是否正确
function checkphone(tel){
	var str=tel;
	var Expression=/^(\d{3}-)(\d{8})$|^(\d{4}-)(\d{7})$|^(\d{4}-)(\d{8})$|^(\d{11})$/;  
	var objExp=new RegExp(Expression);
	if(objExp.test(str)==true){
		return true;
	}else{
		return false;
	}
}	
</script>
</body>
</html>

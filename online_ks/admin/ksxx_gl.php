<?php session_start();
if($_SESSION['admin_user']==true){
include("../conn/conn.php");?>
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=gb2312" />
<title>������Ϣ����</title>
<style type="text/css">
<!--
.STYLE1 {font-size: 12px}
-->
</style>
</head>
<body>
<form name="form1" method="post" action="index.php?htgl=������Ϣ����" >
<table width="608" height="35" border="1" cellpadding="1" cellspacing="1" bordercolor="#FFFFFF" bgcolor="#676767">
  <tr align="center" bgcolor="#EEEEEE">
    <td width="104" height="35"><span class="STYLE1">׼��֤�ţ�</span></td>
    <td width="157" height="35"><input name="online_numbers" type="text" id="online_numbers" size="20" /></td>
    <td width="120" height="35"><input name="Submit" type="submit" value="���ҿ���" /></td>
  </tr>
</table>
</form>
<table width="608" height="47" border="1" cellpadding="1" cellspacing="1" bordercolor="#FFFFFF" bgcolor="#676767">
  <tr bgcolor="#EEEEEE">
   <td width="82" align="center" class="STYLE1">׼��֤��</td>
    <td width="83" align="center" class="STYLE1">��������</td>
    <td width="204" align="center" class="STYLE1">�����绰</td>
    <td width="43" align="center" class="STYLE1">����</td>
    <td width="96" align="center" class="STYLE1">�������</td>
    <td width="60" align="center" class="STYLE1">����</td>
  </tr>
 
<?php
	 if($online_numbers==true){
	$query=mysql_query("select * from tb_user where number='".$_POST['online_numbers']."'");
	while($myrow=mysql_fetch_array($query)){  
  ?>
  <tr bgcolor="#FFFFFF">
    <td align="center" class="STYLE1"><?php echo $myrow['number']?></td>
    <td align="center" class="STYLE1"><?php echo $myrow['user']?></td>
    <td align="center" class="STYLE1"><?php echo $myrow['tel']?></td>
    <td align="center" class="STYLE1"><?php echo $myrow['grade'];?></td>
    <td align="center" class="STYLE1"><?php echo $myrow['subject'];?></td>
    <td align="center" class="STYLE1"><a href="ksxx_gl_ok.php?delete_ksxx=<?php echo $myrow['Id']?>">ɾ��</a></td>
  </tr>
  <?php }
}else{
$query=mysql_query("select * from tb_user");
	while($myrow=mysql_fetch_array($query)){ 
?>
<tr bgcolor="#FFFFFF">
    <td align="center" class="STYLE1"><?php echo intval($myrow['number'])?></td>
    <td align="center" class="STYLE1"><?php echo $myrow['user']?></td>
    <td align="center" class="STYLE1"><?php echo $myrow['tel']?></td>
    <td align="center" class="STYLE1"><?php echo intval($myrow['grade']);?></td>
    <td align="center" class="STYLE1"><?php echo intval($myrow['subject']);?></td>
    <td align="center" class="STYLE1"><a href="ksxx_gl_ok.php?delete_ksxx=<?php echo $myrow['Id']?>">ɾ��</a></td>
  </tr>
<?php }}?>
</table>
</body>
</html>

<?php 
}else{
echo "<script>alert('������ȷ��¼��'); window.location.href='checkadmin.php';</script>";
}

?>
<?php session_start(); include("conn/conn.php");
if($_SESSION['number']==true){

$number=$_POST['online_number'];
$pass=$_POST['online_pass'];
$passes=$_POST['online_pass2'];
	$query=mysql_query("select * from tb_user where number='$number' and pass='$pass'");
	if(mysql_num_rows($query)<1){
		echo "<script>alert('�������׼��֤��������벻�������������룡'); window.location.href='index.php?online=�޸�����';</script>";
	}else{
		$querys=mysql_query("update tb_user set pass='$passes' where number='$number'");
		if($querys){
			echo "<script>alert('������³ɹ���'); window.location.href='index.php?online=�޸�����';</script>";
		}
}

}else{
echo "<script> alert('������ȷ��¼!'); window.location.href='index.php?online=�û���¼';</script>";
}
?>
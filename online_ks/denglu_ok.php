<?php include("conn/conn.php");
$number=$_POST['online_number'];
$pass=$_POST['online_pass'];

$query=mysql_query("select * from tb_user where number='$number' and pass='$pass'");
if(mysql_num_rows($query)>0){
session_register("number");
echo "<script> alert('��¼�ɹ�!');window.location.href='index.php?online=���뿼��'; </script>";
}else{
echo "��¼ʧ��!";
}
?>
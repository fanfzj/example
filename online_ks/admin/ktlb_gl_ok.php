<?php session_start();
if($_SESSION['admin_user']==true){
include("../conn/conn.php");
if($Submit==true){
if($_POST[ktlb]==""){
	echo "<script>alert('�����뿼�����'); window.location.href='index.php?htgl=����������';</script>";
}else{
	$querys=mysql_query("insert into tb_ktlb (ktlb) values('".$_POST[ktlb]."')");
	if($querys){
		echo "<script>alert('���������ӳɹ���'); window.location.href='index.php?htgl=����������';</script>";
	}
}}

if($delete_ktlb==true){
	echo $delete_ktlbl;
$query=mysql_query("delete from tb_ktlb where id='".$delete_ktlb."'");
if($query){
echo "<script>alert('�������ɾ���ɹ���'); window.location.href='index.php?htgl=����������';</script>";

}
}
?>
<?php 
}else{
echo "<script>alert('������ȷ��¼��'); window.location.href='checkadmin.php';</script>";
}

?>
<?php session_start();
if($_SESSION['admin_user']==true){
include("../conn/conn.php");
if($Submit==true){
if($_POST[ktlb]==""){
	echo "<script>alert('请输入考题类别！'); window.location.href='index.php?htgl=考题类别管理';</script>";
}else{
	$querys=mysql_query("insert into tb_ktlb (ktlb) values('".$_POST[ktlb]."')");
	if($querys){
		echo "<script>alert('考题类别添加成功！'); window.location.href='index.php?htgl=考题类别管理';</script>";
	}
}}

if($delete_ktlb==true){
	echo $delete_ktlbl;
$query=mysql_query("delete from tb_ktlb where id='".$delete_ktlb."'");
if($query){
echo "<script>alert('考题类别删除成功！'); window.location.href='index.php?htgl=考题类别管理';</script>";

}
}
?>
<?php 
}else{
echo "<script>alert('请您正确登录！'); window.location.href='checkadmin.php';</script>";
}

?>
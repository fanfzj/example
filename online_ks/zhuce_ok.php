<?php 
/*//����һ��XML��ʽ���
header('Content-Type: text/xml');
//����XMLͷ
echo '<?xml version="1.0" encoding=gb2312" standalone="yes" ?>';
//����<response>Ԫ��
echo '<response>';*/
//��ȡ�û�����
$online_user=trim($_POST['username']);
$online_tel=trim($_POST['tel']);
$online_address=trim($_POST['address']);
$online_number=substr(mt_rand(100000,999999),0,11);
$online_pass=substr(mt_rand(100000,999999),0,6);
echo $online_address ."<br>".$online_number ."<br>".$online_pass ."<br>" . $online_tel ."<br>". $online_user;
//���ݴӿͻ��˻�ȡ���û��������
include("conn/conn.php");
$query=mysql_query("insert into tb_user(user,tel,address,number,pass) values('$online_user','$online_tel','$online_address','$online_number','$online_pass')");
if($query==true){
echo $online_user;
	echo "�û�ע��ɹ�����������׼��֤����".$online_number."������".$online_pass;
	echo "<script> alert('���뿼��!');window.location.href='index.php?online=���뿼��'; </script>";
}
 else echo  "<script> alert('������������!'); window.location.href='index.php?online=�û�ע��';</script>";
?>

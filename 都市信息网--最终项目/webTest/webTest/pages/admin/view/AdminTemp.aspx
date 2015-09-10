<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminTemp.aspx.cs" Inherits="webTest.pages.admin.view.AdminTemp" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>都市信息网-后台管理</title>
    <link type="text/css" rel="stylesheet" href="../../../css/style.css">
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <center>   
        <table border="0" width="920" cellspacing="0" height="auto" bgcolor="white">
            <tr>
                <td colspan="2">
				<!-- 页眉 -->
				    <iframe src="top.aspx" frameBorder="0" width="920" scrolling="no" height="100" ></iframe>
                </td>
             </tr>
            <tr height="10" bgcolor="lightgrey"><td colspan="2"></td></tr>
            <tr>
                <td width="700" align="center" valign="top">
                <!-- main -->
                <iframe src="main.aspx" frameBorder="0" width="688" scrolling="no" height="400" ></iframe>
                </td>
                <td width="200" align="center" valign="top">
				<!-- 右侧栏 -->
				<iframe src="right.aspx" frameBorder="0" width="240" scrolling="no" height="540" ></iframe>
                </td>
            </tr>
            <tr height="7" bgcolor="lightgrey"><td colspan="2"></td></tr>
            <tr>
                <td colspan="2">
                    <!-- 页脚 -->
		            <iframe src="end.aspx" frameBorder="0" width="920" scrolling="no" height="70" style="margin-top:0"></iframe>   
                </td>
            </tr>
        </table>        
    </center>
    </div>
    </form>
</body>
</html>

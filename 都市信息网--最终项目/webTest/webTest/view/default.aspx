<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="webTest.view._default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
     <title>都市信息网</title>
  <link type="text/css" rel="stylesheet" href="../css/style.css">
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <center>
        <table border="0" width="920" height="auto" cellspacing="0" cellpadding="0" bgcolor="white">
            <tr>
				<td colspan="2">
				<!-- 页眉 -->
				<iframe src="top.html" frameBorder="0" width="920" scrolling="no" height="200" ></iframe>
				</td>
			</tr>
			<tr>
				<td width="230" valign="top" align="center">
			<!-- 左边 -->
			<iframe src="left.html" frameBorder="0" width="225" scrolling="no" height="400" ></iframe>
			</td>
			<td width="690" height="400" align="center" valign="top" bgcolor="#FFFFFF">
				<!-- 列表显示付费信息 -->
						
				<table border="0" width="670" cellspacing="0" cellpadding="0" style="margin-top:5">
					<tr height="30"><td align="center">★★★ 缴费后，您发布信息就可在这里显示！★★★</td></tr>
				</table>
				<!-- 列表显示免费信息 -->
				
				<table border="0" width="670" cellspacing="0" cellpadding="0" style="margin-top:5" rules="rows">
					<tr height="30"><td align="center">★★★ 在这里显示免费发布的信息！★★★</td></tr>
				</table>
				<br>

			</td>
			</tr>
			<tr>
			<td colspan="2">
			</td>
			</tr>
		</table>
		<!-- 页脚 -->
		<iframe src="end.html" frameBorder="0" width="920" scrolling="no" height="70" style="margin-top:0"></iframe>        
    </center>
    </div>
    </form>
</body>
</html>

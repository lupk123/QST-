﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="listshow.aspx.cs" Inherits="webTest.pages.show.listshow" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>都市信息网</title>
  <link type="text/css" rel="stylesheet" href="../../css/style.css">
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <center>
        <table border="0" width="920" cellspacing="0" cellpadding="0" bgcolor="white">
            <tr><td colspan="2">
				<!-- 页眉 -->
				<iframe src="../../view/top.aspx" frameBorder="0" width="920" scrolling="no" height="200" ></iframe>
			</td></tr>
<tr>
	<td width="230" valign="top" align="center">
	<!-- 左侧 -->
	<iframe src="../../view/left.aspx" frameBorder="0" width="225" scrolling="no" height="400" ></iframe>
	</td>
   <td width="690" height="400" align="center" valign="top" bgcolor="#FFFFFF">        
        <table border="0" width="670" cellspacing="0" cellpadding="0" style="margin-top:5">
            
            
                <tr height="30"><td style="text-indent:5" valign="bottom"><font color="#004790"><b>■推荐XX信息</b>『缴费专区』</font></td></tr>
                
                     
                         <tr><td align="center" style="border:1 solid" bgcolor="#F0F0F0">
                     
                     
                             <table border="0" width="655" cellpadding="3" style="word-break:break-all">
                                 <tr height="30">
                                     <td colspan="2">【<asp:Label ID="title1" runat="server"></asp:Label>
                                         】</td>
                                     <td align="right">发布时间：『<asp:Label ID="time1" runat="server"></asp:Label>
                                         』&nbsp;</td>
                                 </tr>
                                 <tr height="80"><td colspan="3">
                                     <asp:Label ID="content1" runat="server"></asp:Label>
                                     </td></tr>
                                 <tr height="30" align="center">
                                     <td>联系电话：<asp:Label ID="phone1" runat="server"></asp:Label>
                                     </td>
                                     <td>联 系 人：<asp:Label ID="linkman1" runat="server"></asp:Label>
                                     </td>
                                     <td>E-mail：<asp:Label ID="email1" runat="server"></asp:Label>
                                     </td>
                                 </tr>                                 
                             </table>
                         </td>
                     </tr>
                     <tr height="1"><td></td></tr>
                
            
        </table>
        <!-- 列表显示免费信息 -->
        
        <table border="0" width="670" cellspacing="0" cellpadding="0" style="margin-top:5" rules="rows">
            
            
                <tr height="30"><td style="text-indent:5" valign="bottom"><font color="#004790"><b>■最新XX信息</b>『免费专区』</font></td></tr>
                
                     
                         <tr><td align="center" style="border:1 solid" bgcolor="#F0F0F0">
                     
                     
                             <table border="0" width="655" cellpadding="3" style="word-break:break-all">
                                 <tr height="30">
                                     <td colspan="2">【<asp:Label ID="title0" runat="server"></asp:Label>
                                         】</td>
                                     <td align="right">发布时间：『<asp:Label ID="time0" runat="server"></asp:Label>
                                         』&nbsp;</td>
                                 </tr>
                                 <tr height="80"><td colspan="3">
                                     <asp:Label ID="content0" runat="server" Text="conten0"></asp:Label>
                                     </td></tr>
                                 <tr height="30" align="center">
                                     <td>联系电话：<asp:Label ID="phone0" runat="server"></asp:Label>
                                     </td>
                                     <td>联系人：<asp:Label ID="linkman0" runat="server"></asp:Label>
                                     </td>
                                     <td>E-mail：<asp:Label ID="email0" runat="server"></asp:Label>
                                     </td>
                                 </tr>
                             </table>
                         </td>
                     </tr>
                     <tr height="1"><td></td></tr>
                
                <tr height="30">
				<td align="center">
				<html>
					<head><title>分页导航栏</title></head>
					<body>
						<table border="0" width="100%" cellspacing="0">
							<tr>
								<td width="60%"></td>
								<td align="center" width="40%"></td>
							</tr>
						</table>
					</body>
				</html>
				</td></tr>                
            
        </table>
        <br>
</td>
            </tr>
           
        </table>
		<!-- 页脚 -->
		<iframe src="../../view/end.aspx" frameBorder="0" width="920" scrolling="no" height="70" style="margin-top:0"></iframe>        
    </center>
    </div>
    </form>
</body>
</html>

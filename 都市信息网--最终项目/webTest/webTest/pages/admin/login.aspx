<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="webTest.pages.admin.login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>管理员登录</title>
    <link type="text/css" rel="stylesheet" href="../../../css/style.css;"/>
    <style type="text/css">
        .style1
        {
            height: 62px;
        }
        a
        {
        	text-decoration: none;
        	color: Black;
        }
    </style>
</head>
<body>
    <div style = "margin-top: 200px">
        <center>
            <form id="log_Login_action" runat="server">
            <table border="0" cellspacing="0" cellpadding="0" style="margin-top:130">
                <tr><td><img src="../../images/logon_top.gif"></td></tr>                
                <tr height="180">
                    <td background="../../images/logon_middle.gif" align="center" valign="top">
                         <table border="0" width="90%" cellspacing="0" cellpadding="0">
                             <tr height="50"><td colspan="2"></td></tr>
                             <tr height="30">
                                 <td align="right" width="40%">用户名：&nbsp;&nbsp;</td>
                                 <td style="text-indent:5">
                                     <asp:TextBox ID="userName" runat="server" Width="141px"></asp:TextBox>
                                 &nbsp;
                                 </td>
                             </tr>                
                             <tr height="30">
                                 <td align="right">密&nbsp;&nbsp;码：&nbsp;&nbsp;</td>
                                 <td style="text-indent:5">
                                     <asp:TextBox ID="password" runat="server"  Width="140px" Height="16px" 
                                         TextMode="Password"></asp:TextBox>
                                 </td>
                             </tr>
                             <tr>
                                 <td class="style1"></td>
                                 <td class="style1">								
                                     <asp:Button ID="Button1" runat="server" Text="登陆" style = "margin-right: 5px" 
                                         onclick="Button1_Click"/>								
                                     <input type="reset" value="重置"/>
                                     <a id="log_Login_action_" href="../../view/indextemp.html">  [返回首页]</a>
                                     <br />
                                     <asp:Label ID="alter" runat="server" Font-Overline="False" ForeColor="Red"></asp:Label>
                                 </td>
                             </tr>
                         </table>
                    </td>
                </tr>
                <tr><td id="login"><img src="../../images/logon_end.gif"/></td></tr>
            </table>
            </form>
    </center>
    </div>
</body>
</html>

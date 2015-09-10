<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="top.aspx.cs" Inherits="webTest.view.top" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=gbk">
    <title>页眉</title>
   <link type="text/css" rel="stylesheet" href="../css/style.css">
   <style>
        div
        {
        	margin: 0px;
        	padding: 0px;
            width: auto;
        }
        ul
        {
        	margin: 0px;
        	padding: 0px;
        }
        ul li
        {
        	margin: 0px;
        	padding: 0px;
        	padding-top: 4px;
        	list-style-type: none;
        	width: 100px;
        	height: 20px;
        	text-align: center;
        	float: left;
        	color: White;
        }
        a
        {
        	text-decoration: none;
        	color: White;
        }
        a:hover
        {
        	color:Blue;
        }
   </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <center>
        <table border="0" width="100%" cellspacing="0" cellpadding="0">
            <!-- 顶部菜单 -->
           <tr height="20">
                <td style="text-indent:10" valign="bottom">
                    <a href="../pages/add/addInfo.aspx"  target=_parent onclick="window.parent.location.href='../pages/add/addInfo.aspx'" style="color:gray">[发布信息]</a>
                    <a href="../pages/admin/login.aspx"  target =_parent  onclick="window.parent.location.href='../pages/admin/login.aspx'" style="color:gray">[进入后台]</a>
                </td>
                <td align="right" valign="bottom">
                    <a href="#"  style="color:gray" onclick="">设为主页 -</a>
                    <a href="javascript:window.external.AddFavorite('indextemp.aspx','都市供求信息网')" style="color:gray">收藏本页 -</a>
                    <a href="mailto:123@***.com.cn" style="color:gray">联系我们</a>
                    &nbsp;
                </td>
            </tr>
            <!-- 导航菜单 -->
            <tr height="56">
                <td align="center" width="220" background="../images/logo.gif"></td>
                <td align="right" background="../images/menu.gif">           
					
					<div>
					    <ul>
					        <li><a href = "indextemp.aspx" target =_parent>首&nbsp;&nbsp;&nbsp;&nbsp;页</a></li>
                            <asp:Repeater ID="rptTbType" runat="server">
                                <ItemTemplate>
                                    <li>
                                        <a href = '../pages/show/listshow.aspx?id=<%#Eval("Id")%>' target=_parent>
                                            <%#Eval("TypeIntro")%>
                                        </a>
                                    </li>
                                </ItemTemplate>
                            </asp:Repeater>		        
					    </ul>
					</div>                    
                </td>
            </tr>
        </table>
        <table border="0" width="100%" height="90" cellspacing="0" cellpadding="0" style="margin-top:1">
            <tr><td align="center"><img src="../images/pcard1.jpg"></td></tr>
        </table>
    </center>
    </div>
    </form>
</body>
</html>

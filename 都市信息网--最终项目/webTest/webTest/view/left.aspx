<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="left.aspx.cs" Inherits="webTest.view.left" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>侧栏</title>
	<link type="text/css" rel="stylesheet" href="../css/style.css">
</head>
<body>
    <form id="form1" runat="server">
   <div>
    <%--<a href = "javascript:;" onclick = "window.parent.location.href = '../pages/show/searchshow.aspx'">sdfalfd</a>--%>
        <table border="0" width="225" cellspacing="0" cellpadding="0" 
            style="height: 437px">
		<tr height="30"><td style="text-indent:5" valign="bottom"><font color="#004790"><b>■日历</b></font></td></tr>            
		<tr height="1"><td></td></tr>
		<tr height="215">
			<td valign="top" background="../images/leftD.jpg">
			</td>
		</tr>
		<tr height="1"><td></td></tr>
		<tr height="30"><td style="text-indent:5" valign="bottom"><font color="#004790"><b>■信息快速搜索<asp:Label 
                ID="alert" runat="server" Text="Label"></asp:Label>
            </b></font></td></tr>
		<tr height="1"><td></td></tr>
		<tr height="103">
			<td align="center" valign="top" background="../images/leftS.jpg">
				<table border="0" width="99%" height="100%" cellspacing="0">
				<form id="info_SearchShow_action" name="info_SearchShow_action" action="/web/info_SearchShow.action" method="post">                        
					<tr height="10">
					    <td align="right" width="70">类&nbsp;&nbsp;型：   <td colspan="3">
                            <asp:DropDownList ID="infoType" runat="server">
                            </asp:DropDownList>
                        </td>
					</tr>
					<tr>
						<td align="right" width="70">关键字：</td>
						<td colspan="2" width="200">
                            <asp:TextBox ID="keys" runat="server" Height="14px" Width="74px"></asp:TextBox>
                        </td>
					</tr>
					<tr>
						<td align="right">条&nbsp;&nbsp;件：</td>
						<td>
							<asp:DropDownList ID="searchType" runat="server" 
                                onselectedindexchanged="DropDownList1_SelectedIndexChanged">
                            </asp:DropDownList>

						</td>
						<td align="center" width="30">
							<asp:Button ID="search" runat="server" Text="搜索" onclick="search_Click" 
                                BorderStyle="NotSet" EnableViewState="True" />
						</td>
					</tr>
					<tr>
						<td align="right">搜索类型：</td>
						<td colspan="2">
							&nbsp;</td>
					</tr>
					<tr height="10"><td colspan="3"></td></tr>
				</form>




				</table>
			</td>
		</tr>
		<tr><td></td></tr>
	</table>                

    </div>
    </form>
</body>
</html>

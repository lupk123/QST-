<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="indextemp.aspx.cs" Inherits="webTest.view.indextemp" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>都市信息网</title>
    <link type="text/css" rel="stylesheet" href="../css/style.css">
    <style>
           div
           {
           	    width: 100%;
                margin: 0px;
                padding: 0px;
           }
           ul
           {
           	margin: 0px;
           	padding: 0px;
           }
           .display li
           {
           	width: 50%;
           	height: 23px;
           	float:left;
           }
           .ulli
           {
           	text-align:center;
           	list-style-type:none;
           }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <center>
        <table border="0" width="920" height="auto" cellspacing="0" cellpadding="0" bgcolor="white">
            <tr><td colspan="2">

			<!-- 页眉 -->
			<iframe src="top.aspx" frameBorder="0" width="920" scrolling="no" height="200" ></iframe>
			</td></tr>
            <tr>
                <td width="230" valign="top" align="center">
				<!-- 左侧 -->
				<iframe src="left.aspx" frameBorder="0" width="225" scrolling="no" height="400" ></iframe>
				</td>
                <td width="690" height="400" align="center" valign="top" bgcolor="#FFFFFF">


				<html>
				<head><title>首页</title></head>
				<body>
					<center>
						<!-- 缴费专区 -->
								
						<table border="0" width="670" cellspacing="0" cellpadding="5">
							<tr height="35"><td style="text-indent:5" valign="bottom"><font color="#004790"><b>■推荐信息</b>『缴费专区』</font></td></tr>
							<tr bgcolor="#FAFCF5">
								<td style="border:1 solid">
									<%--<table border="0" width="100%" cellspacing="0" cellpadding="0">
										 <tr height="23">
											<td width="50%">『<b>求职信息</b>』
												<a href="../pages/show/singleshow.aspx">求职信息标题</a>
											</td>
											<td width="50%">『<b>招聘信息</b>』
												<a href="../pages/show/singleshow.aspx">招聘信息标题</a>
											</td>
										 </tr>
									
										 <tr height="23">
											<td width="50%">『<b>培训信息</b>』
												<a href="../pages/show/singleshow.aspx">培训信息标题</a></td>
											<td width="50%">『<b>求购信息</b>』
												<a href="../pages/show/singleshow.aspx">求购信息标题</a></td>
										 </tr>
										 
										 <tr height="23">
											<td width="50%">『<b>求职信息</b>』
												<a href="../pages/show/singleshow.aspx">求职信息标题</a>
											</td>
											<td width="50%">『<b>招聘信息</b>』
												<a href="../pages/show/singleshow.aspx">招聘信息标题</a>
											</td>
										 </tr>
									
										 <tr height="23">
											<td width="50%">『<b>培训信息</b>』
												<a href="../pages/show/singleshow.aspx">培训信息标题</a></td>
											<td width="50%">『<b>求购信息</b>』
												<a href="../pages/show/singleshow.aspx">求购信息标题</a></td>
										 </tr>
										                
									</table>--%>
									<div>
									    <ul class = "display">
                                            <asp:Repeater ID="Repeater1" runat="server">
                                                <ItemTemplate>
                                                    <li>【<%#Eval("TbType.TypeIntro")%>】  <a href='../pages/show/singleshow.aspx?id=<%#Eval("Id") %>'><%#Eval("Info_title") %></a></li>
                                                </ItemTemplate>
                                            </asp:Repeater>
									    </ul>
									</div>
								</td>
							</tr>
						</table>
						<!-- 广告 -->
						<table border="0" width="670"cellspacing="0" cellpadding="0" style="margin-top:1">
							<tr><td align="center"><img src="../images/pcard2.jpg"></td></tr>
						</table>        
						<!-- 免费专区 -->
						
						<table border="0" width="670" cellspacing="2" cellpadding="0">
							<tr height="35"><td colspan="2" style="text-indent:5" valign="bottom"><font color="#004790"><b>■最新信息</b>『免费专区』</font></td></tr>            
							 
							<tr>
								<td align="center">
									<%--<table border="1" cellspacing="0" cellpadding="0" width="332" height="160" rules="none" bordercolor="lightgrey" bordercolorlight="lightgrey" bordercolordark="white">
									
									</table>--%>
								</td>                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        						
						
						 
							</tr>
						
							<tr>
								<td align="center">
									<table border="1" cellspacing="0" cellpadding="0" width="332" height="160" rules="none" bordercolor="lightgrey" bordercolorlight="lightgrey" bordercolordark="white">
									<tr bgcolor="#00B48F" height="30">
										<td style="text-indent:10"><b><font color="white">培训信息</font></b></td> </tr>
									<tr bgcolor="#FAFCF5">
									    <td style="text-indent:3">
									        <ul>
									            
									            <%--<li><a href="../pages/show/singleshow.html">发布培训信息标题</a></li>
									            <li><a href="../pages/show/singleshow.html">发布培训信息标题</a></li>
									            <li><a href="../pages/show/singleshow.html">发布培训信息标题</a></li>
									            <li><a href="../pages/show/singleshow.html">发布培训信息标题</a></li>--%>
                                                <asp:Repeater ID="Repeater2" runat="server">
                                                    <ItemTemplate>
                                                        <li class = "ulli"><a href='../pages/show/singleshow.aspx?id=<%#Eval("Id") %>'>★  <%#Eval("Info_title") %></a></li>
                                                    </ItemTemplate>
                                                </asp:Repeater>
									        </ul>
									    </td>
									</tr>
									<tr height="20" bgcolor="#FAFCF5"><td align="right"><a href="../pages/show/listshow.html">更多...</a>&nbsp;&nbsp;</td></tr>										
									</table>
								</td>
					 
								<td align="center">
									<table border="1" cellspacing="0" cellpadding="0" width="332" height="160" rules="none" bordercolor="lightgrey" bordercolorlight="lightgrey" bordercolordark="white">
										
										 <tr bgcolor="#00B48F" height="30">
											<td style="text-indent:10"><b><font color="white">求职信息</font></b></td>                                      
										 </tr>
									
										<tr bgcolor="#FAFCF5">
											<td style="text-indent:3">
											    <ul>
											        <asp:Repeater ID="Repeater3" runat="server">
                                                    <ItemTemplate>
                                                        <li class = "ulli"><a href='../pages/show/singleshow.aspx?id=<%#Eval("Id") %>'>★  <%#Eval("Info_title ")%></a></li>
                                                    </ItemTemplate>
                                                </asp:Repeater>
											    </ul>
											</td>
										</tr>
										<tr height="20" bgcolor="#FAFCF5">
											<td align="right"><a href="../pages/show/listshow.html">更多...</a>&nbsp;&nbsp;</td>
										</tr>                                    
									 
									</table>
								</td>
							</tr>
				  
						</table>
						<br>
					</center>
				</body>
				</html>
			</td>
		</tr>

       </table>
		<!-- 页脚 -->
		<iframe src="end.aspx" frameBorder="0" width="920" scrolling="no" height="70" style="margin-top:0"></iframe>	   
    </center>
    </div>
    </form>
</body>
</html>

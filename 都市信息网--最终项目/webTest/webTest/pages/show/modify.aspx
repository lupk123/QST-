<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="modify.aspx.cs" Inherits="webTest.pages.show.modify" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
    <link type="text/css" rel="stylesheet" href="../../css/style.css">
    <script type="text/javascript" src = "../../js/InputCheck.js" ></script>
</head>
<body>
    <form id="form1" runat="server">
    div>
    <center>
        <table border="0" width="920" cellspacing="0" cellpadding="0" bgcolor="white">
            <tr>
			<td colspan="2">
			<!-- 页眉 -->
			<iframe src="../../view/top.aspx" frameBorder="0" width="920" scrolling="no" height="200" ></iframe>

			</td>
			</tr>
            <tr>
                <td width="230" valign="top" align="center">
				<!-- 左边 -->
				<iframe src="../../view/left.aspx" frameBorder="0" width="225" scrolling="no" height="400" ></iframe>
				</td>
                <td width="690" height="400" align="center" valign="top" bgcolor="#FFFFFF">
				<table border="0" cellpadding="0" cellspacing="0" width="688" height="100%">
					<tr height="20"><td><img src="../../images/default_t.jpg"></td></tr>
					<tr>
						<td background="../../images/default_m.jpg" valign="top" align="center">
							<form id="info_Add_action" name="info_Add_action" action="/web/info_Add.action" method="post">
							<input type="hidden" name="addType" value="add"/>
							<table border="0" width="650" height="300" rules="all" cellspacing="0">
								<tr height="30"><td style="text-indent:10"><font color="#004790"><b>■发布信息</b></font></td></tr>
								<tr>
									<td align="center">
										<table border="0" width="650" rules="all" cellspacing="8">                    
											<tr>
												<td width="20%" style="text-indent:10">信息类别：</td>
												<td>
												   &nbsp;<asp:DropDownList ID="TbTypeList" runat="server">
                                                    </asp:DropDownList>
										
												</td>
												<td align="right"><font color="#7F7F7F">[信息标题最多不得超过 40 个字符]&nbsp;&nbsp;</font></td>
											</tr>
											<tr><td colspan="3"></td></tr>
											<tr>
												<td style="text-indent:10">信息标题：</td>
												<td colspan="2">
                                                    <asp:TextBox ID="infoTitle" runat="server" Height="16px" Width="370px"></asp:TextBox>
                                                </td>                        
											</tr>
											<tr><td colspan="3"></td></tr>
											<tr>
												<td style="text-indent:10">信息内容：</td> 
												<td>
													<<font color="#7F7F7F">
														已用：<input type="text" name="ContentUse" value="0" size="4" disabled style="text-align:center;border:0;"> 个&nbsp;&nbsp;
														剩余：<input type="text" name="ContentRem" value="500" size="4" disabled style="text-align:center;border:0;"> 个 
													</font>
												</td>
												<td align="right"><font color="#7F7F7F">[信息内容最多不得超过 500 个字符]&nbsp;&nbsp;</font></td>
											</tr>
											<tr><td colspan="3"></td></tr>
											<tr><td colspan="3" align="center">
                                                <asp:TextBox ID="txtContent" columns = "85" rows = "12" runat="server"                                                    
                                                    onkeydown="check(txtContent,ContentUse,ContentRem,500)" 
                                                    onkeyup="check(txtContent,ContentUse,ContentRem,500)" 
                                                    onchange="check(txtContent,ContentUse,ContentRem,500)" 
                                                    ontextchanged="txtContent_TextChanged" TextMode="MultiLine"></asp:TextBox>
                                                </td>
                                            </tr>
											<tr>
												<td style="text-indent:10">联系电话：</td>
												<td colspan="2">
                                                    <asp:TextBox ID="phone" runat="server" Width="110px"></asp:TextBox>
                                                    <font color="gray">&nbsp;[多个电话以逗号分隔！]</font></td>
											</tr>
											<tr><td colspan="3"></td></tr>
											<tr>
												<td style="text-indent:10">联 系 人：</td>
												<td colspan="2">
                                                    <asp:TextBox ID="linkman" runat="server" Width="110px"></asp:TextBox>
                                                </td>
											</tr>
											<tr><td colspan="3"></td></tr>
											<tr>
												<td style="text-indent:10">E - mail：</td>
												<td colspan="2">
                                                    <asp:TextBox ID="email" runat="server" Width="110px"></asp:TextBox>
                                                </td>                    
											</tr>
											<tr><td colspan="3"></td></tr>                        
										</table>                
									</td>
								</tr>
								<tr align="center" height="50">
									<td>
										&nbsp;<asp:Button ID="Ok" runat="server" onclick="Ok_Click" Text="修改" />

										<input type="reset" value="&#37325;&#22635;"/>

									</td>
								</tr>
							</table>
							</form>

						</td>
					</tr>
					<tr height="26"><td><img src="../../images/default_e.jpg"></td></tr>        
				</table>
				</td>
            </tr>
        </table>        
    </center>
    </div>
    </form>
</body>
</html>

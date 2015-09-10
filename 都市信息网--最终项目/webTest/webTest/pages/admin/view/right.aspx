<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="right.aspx.cs" Inherits="webTest.pages.admin.view.right" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>后台-侧栏</title>
  <link type="text/css" rel="stylesheet" href="../../../css/style.css">
  <script language="javascript" type="text/javascript" src="../../../My97DatePicker/WdatePicker.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <center>   
        <table border="1" width="220" height="auto" cellspacing="0" cellpadding="0" style="margin-top:7;background-color:white">
            <!-- 显示方式 -->
            <tr height="30" bgcolor="#F0F0F0"><td style="text-indent:5;border:1 solid"><font color="#004790"><b>■显示方式</b></font></td></tr>
            <tr height="1"><td></td></tr>
            <tr>
                <td align="center" valign="top" style="border:1 solid">
                    <table border="1" width="220" height="150" rules="all" cellspacing="0">
                        <tr>
                            <td align="center" colspan="2">
                                <fieldset style="height:60;width:210">
                                  <legend>★付费状态</legend>
                                    <asp:RadioButton ID="no_pay" runat="server" Text="未付费" />
                                    <asp:RadioButton ID="already_pay" runat="server" Text="已付费" />
                                    <asp:RadioButton ID="pay_all" runat="server" Text="全部" />
                                  <br>
                                  <%--<input type="radio" name="showType.payforType" id="admin_ListShow_action?_showType_payforType0" value="0"/>
								  <label for="admin_ListShow_action?_showType_payforType0">未付费</label>
								<input type="radio" name="showType.payforType" id="admin_ListShow_action?_showType_payforType1" value="1"/>
								<label for="admin_ListShow_action?_showType_payforType1">已付费</label>
								<input type="radio" name="showType.payforType" id="admin_ListShow_action?_showType_payforTypeall" value="all"/>
								<label for="admin_ListShow_action?_showType_payforTypeall">全部</label>--%>
								

                                </fieldset>
                                <fieldset style="height:60;width:210">
                                  <legend>★审核状态</legend>
                                    <asp:RadioButton ID="uncheck" runat="server" Text="未审查" />
                                    <asp:RadioButton ID="already_check" runat="server" Text="已审查" />
                                    <asp:RadioButton ID="check_all" runat="server" Text="全部" />
                                  <br>
                                  <%--input type="radio" name="showType.stateType" id="admin_ListShow_action?_showType_stateType0" value="0"/>
								  <label for="admin_ListShow_action?_showType_stateType0">未审核</label>
									<input type="radio" name="showType.stateType" id="admin_ListShow_action?_showType_stateType1" value="1"/>
									<label for="admin_ListShow_action?_showType_stateType1">已审核</label>
									<input type="radio" name="showType.stateType" id="admin_ListShow_action?_showType_stateTypeall" value="all"/>
									<label for="admin_ListShow_action?_showType_stateTypeall">全部</label>--%>
									

                                </fieldset>
                            </td>
                        </tr>
                        <tr align="center" height="30" bgcolor="lightgrey">
                            <td>
                               信息类别：
                               
                                   <select name="showType.infoType" id="admin_ListShow_action?_showType_infoType">
										<option value=""></option>
										<option value="0">暂时没有信息</option>
										<option value="1">招聘信息</option>
										<option value="2">培训信息</option>
										<option value="3">房屋信息</option>
										<option value="4">求购信息</option>
										<option value="5">招商引资</option>
										<option value="6">公寓信息</option>
										<option value="7">求职信息</option>
										<option value="8">家教信息</option>
										<option value="9">车辆信息</option>
										<option value="10">出售信息</option>
										<option value="11">寻找启示</option>
									</select>
                              <%-- <input type="submit" id="admin_ListShow_action?_0" value="显示"/>--%>
                                <asp:Button ID="display" runat="server" onclick="Button1_Click" Text="显示" />
                            </td>
                        </tr>                        
                    </table>
                </td>
            </tr>
            <tr height="5"><td></td></tr>
            <!-- 设置已付费信息 -->            
            <tr height="30" bgcolor="#F0F0F0"><td style="text-indent:5" style="border:1 solid"><font color="#004790"><b>■付费设置<br />
                </b></font></td></tr>
            <tr height="1"><td></td></tr>
            <tr>
                <td align="center" valign="top" style="border:1 solid">
                    <table border="1" width="220" height="80" cellspacing="0" rules="none">
                        <tr height="25"><td align="center" valign="bottom">请输入要设为已付费状态的信息ID：</td></tr>
                        <tr height="40">
                            <td align="center">
                               <%-- <input type="text" name="moneyID" value="" size="24"/>--%>
                                <%--<input type="submit" value="查询"/>--%>
                            <font color="#004790"><b>
            <asp:TextBox 
                    ID="pay_set" runat="server"></asp:TextBox>
                                <asp:Button ID="Button1" runat="server" onclick="Button1_Click1" Text="查询" />
                </b></font>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr height="5"><td></td></tr>
            <tr height="30" bgcolor="#F0F0F0"><td style="text-indent:5;border:1 solid"><font color="#004790"><b>■日历</b></font></td></tr>
            <tr height="1"><td></td></tr>
            <!-- 日历 -->            
            <tr height="130">
                <td valign="top" style="border:1 solid">
                <%--<img src=""/>--%>
                <input class="Wdate" type="text" onClick="WdatePicker()"> <font color=red>&lt;- 点我弹出日期控件</font>
                <script>
                    window.onload = WdatePicker();
                </script>
			        </td>
            </tr>
        </table>        
    </center>
    </div>
    </form>
</body>
</html>

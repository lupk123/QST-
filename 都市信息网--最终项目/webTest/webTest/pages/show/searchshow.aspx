<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="searchshow.aspx.cs" Inherits="webTest.pages.show.searchshow" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>都市信息网</title>
  <link type="text/css" rel="stylesheet" href="../../css/style.css">
  <script type ="text/javascript">
    function del(id)
    {
        if(confirm("确定删除这条记录吗?"))
        {
            location.href = "delete.aspx?id="+id;
        }        
    }
  </script>
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
       
            <tr height="30"><td style="text-indent:5" valign="bottom"><font color="#004790"><b>■查询结果<asp:DropDownList 
                    ID="DropDownList1" runat="server">
                </asp:DropDownList>
                <asp:TextBox ID="title" runat="server" Height="16px" Width="68px"></asp:TextBox>
                <asp:Label ID="Label1" runat="server" Text="标题"></asp:Label>
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="搜索" />
                </b></td></tr>
            <tr height="1"><td></td></tr>
            <tr>
                <td align="center" style="border:1 solid">   
                    
                    <asp:GridView ID="gdvInfo" runat="server" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" style="margin-left: 0px" Width="656px">
                        <RowStyle BackColor="#EFF3FB" />
                        <Columns>
                            <asp:BoundField DataField="id" HeaderText="序号" />
                            <asp:TemplateField HeaderText="信息类型">
                                <ItemTemplate>
                                    <%#Eval("Tbtype.TypeIntro") %>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField DataField="Info_title" HeaderText="信息标题" />
                            <asp:BoundField DataField="Info_linkman" HeaderText="联系人" />
                            <asp:BoundField DataField="Info_phone" HeaderText="电话号码" />
                            <asp:BoundField DataField="Info_email" HeaderText="邮箱" />
                            <asp:BoundField DataField="Info_date" HeaderText="添加时间" />
                            <asp:TemplateField HeaderText="编辑">
                                <ItemTemplate>
                                    <a href = 'modify.aspx?id=<%#Eval("Id")%>'>修改</a>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="删除">
                                <ItemTemplate>
                                    <a href = 'javascript:del(<%#Eval("Id")%>)'>删除</a>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <EditRowStyle BackColor="#2461BF" />
                        <AlternatingRowStyle BackColor="White" />
                    </asp:GridView>
                </td>
            </tr>
            <tr height="1"><td></td></tr>
            <tr height="30"><td align="center">


<html>
<head><title>分页导航栏</title></head>
<body>

    <table border="0" width="100%" cellspacing="0">
        <tr>
            <td width="60%"><table border='0' cellpadding='3'><tr><td>每页显示：8/22 条记录！当前页：1/3 页！</td></tr></table></td>
            <td align="center" width="40%"><table border='0' cellpadding='3'><tr><td><a href='info_SearchShow.action?searchInfo.subsql=info_phone&searchInfo.sqlvalue=1&searchInfo.type=like&showType=link&showpage=2'>下一页</a>&nbsp;<a href='info_SearchShow.action?searchInfo.subsql=info_phone&searchInfo.sqlvalue=1&searchInfo.type=like&showType=link&showpage=3'>尾页</a></td></tr></table></td>
        </tr>
    </table>

</body>
</html></td></tr>
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

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="stu_oauth_csharp_app_demo.Index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
      <div>
        <asp:Label ID="lb_info" runat="server"></asp:Label>
        <a href="?action=getCourseInfo">点击查看课程信息</a>
    </div>
    <asp:DataList ID="dl_courses" runat="server">
        <AlternatingItemTemplate>
            <asp:HyperLink ID="course" runat="server"><%#Eval("courseName")%></asp:HyperLink>
        </AlternatingItemTemplate>
        
    </asp:DataList>
    </form>
</body>
</html>

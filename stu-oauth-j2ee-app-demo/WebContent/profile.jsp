<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Insert title here</title>
</head>
<body>


${profile}
<hr/>
<div>
<p>
<a href="<%=application.getContextPath()%>/test/courses" target="_blank">查看课程</a>
</p>
<p>
查看课程成员： <%=application.getContextPath()%>/test/course/members?classId=?
<br/> classId 从上个测试例子中得到
</p>
<p>
查看课程课件或作业： <%=application.getContextPath()%>/test/course/activities?classId=?&filter=?
<br/>filer 为 resource,assignment,all 之一, 分别是课件、作业、全部
</p>
<p>
<a href="<%=application.getContextPath()%>/test/chengjibiao" target="_blank">查看成绩</a>
</p>
<p>
<a href="<%=application.getContextPath()%>/test/kechengbiao" target="_blank">查看20131课程表</a>
</p>
</div>
</body>
</html>
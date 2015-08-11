c#实现的 OAuth Demo 
====================

本实例通过HttpWebRequest和Json将stuapi提供的接口进行了封装，
在本地建立了对应的实体类映射，方便调用，具体见DataService.ashx

##1.部署说明
修改本地的hosts文件，增加如下映射

127.0.0.1       demo.stu.edu.cn

设置为IIS调试模式,建立虚拟目录oauthdemo指向demo程序

设置default.aspx为起始页

##2.接口调试

在浏览器输入以下的url查看各个api

####获取Profile 
http://demo.stu.edu.cn/oauthdemo/DataService.ashx?action=getProfile

####获取课程信息
http://demo.stu.edu.cn/oauthdemo/DataService.ashx?action=getCourseInfo

####获取开课班成员
http://demo.stu.edu.cn/oauthdemo/DataService.ashx?action=getCourseMember&classId=[开课班号]

####获取课程资料
http://demo.stu.edu.cn/oauthdemo/DataService.ashx?action=getCourseActivities&classId=[开课班号]

####获取课程表
http://demo.stu.edu.cn/oauthdemo/DataService.ashx?action=getKechengbiao&studentId=[学号]

####获取成绩表
http://demo.stu.edu.cn/oauthdemo/DataService.ashx?action=getChengjibiao&studentId=[学号]

####获取开课班成绩表
http://demo.stu.edu.cn/oauthdemo/DataService.ashx?action=getChengjibiao&classId=[开课班号]
STU API
=======

## 通用说明
* 如果访问API时，accessToken已过期，返回http status为401，用户需重新登录。

## 1.获取用户信息
* 方法名：获取当前用户信息
* URL：https://[domain]/services/api/profile/self
* 参数：无
* 返回值：
```{
	"id": "用户id",
	"username": "用户名",
	"email": "电子邮件",
	"fullName": "姓名",
	"englishName": "英文名",
	"logoUrl": "当前头像",
	"coverImage": "当前封面",
	“role”:”用户角色”, // student学生，faculty教师
	"studentId": "学号" //学生才有此字段
	“teacherId”:”教师编号” //教师才有此字段
}```
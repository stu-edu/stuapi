STU API
=======

## 通用说明
* 如果访问API时，accessToken已过期，返回http status为401，用户需重新登录。

## 1.获取用户信息
* 方法：GET
* URL：https://[domain]/services/api/profile/self
* 参数：无
* 返回值：
```
{
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
}
```

## 2.获取课程信息
* 方法：GET
* URL：https://[domain]/services/api/courses/self
* 参数：无
* 返回值：
```
        [
            {
              "id":" 06D131FB431A11E4B8450050568C74A4",
              "courseName":" MYSTU Help",
              "classId":"3527", 
              "role":" teacher",
              "url":"https://my.stu.edu.cn/courses/campus/course/view.php?id=3529",
              "attendanceYear":" 2014",
              "attendanceSemester":" 1"
            },
            {
              "id":"46E883CC461911E3A98400505699201D",
              "courseName":" MYSTU Team",
              "classId":"2369", 
              "role":" teacher",
              "url":"https://my.stu.edu.cn/courses/campus/course/view.php?id=2369",
              "attendanceYear":" 2013",
              "attendanceSemester":" 2"
            }
        ] 
```

## 3.获取课程成员
* 方法：GET
* URL：https://[domain]/services/api/courses/[classId]/members
* 参数：classId 即接口2里classId，开课班id
* 返回值：
```  
 [{
        "studentId": "2014101007",
        "username": "junweichen",
        "fullName": "陈俊伟",
        "englishName": "Andy Chen",
        "college":"工学院",
        "major":"计算机科学与技术",
        "attendanceYear":"2014",
        "role":"student"
    }]
```

## 4.获取课程活动
* 方法：GET
* URL：https://[domain]/services/api/courses/[classId]/activities/[filter]
* 参数：classId/filter->["resource","assignment","all"]
* 返回值： 
```
[
        {
            "id": "46E883CC461911E3A98400505699201D",
            "createdAt": 1343022549,
            "courseId": "629934F4420411E3A98400505699201D",
            "courseName": "MYSTU Team",
            "sectionId": 1235,
            "sectionName": "第一周",
            "activityId": 431265,
            "activityTitle": "第一周作业",
            "activityCategory": "assignment",
            "activityCategoryLogo": "活动图标",
            "activityDescription": "短描述，限制420字节。",
            "activityUrl": "https://my.stu.edu.cn/moodle/campus/assignment/view.php?id=431265",
            "attachmentUrl": [],
            "additionalUrl": [],
            "additionalStartDate": 1343022549,
            "additionalEndDate": 1343022549,
            "additionalDueDate": 1343022549
        },
        {
            "id": "46E883CC461911E3A98400505699201C",
            "createdAt": 1343022509,
            "courseId": "629934F4420411E3A98400505699201C",
            "courseName": "MYSTU Team",
            "sectionId": 1234,
            "sectionName": "第一周",
            "activityId": 431264,
            "activityTitle": "课件1.pdf",
            "activityCategory": "resource",
            "activityCategoryLogo": "活动图标",
            "activityDescription": "短描述，限制420字节。",
            "activityUrl": "https://my.stu.edu.cn/moodle/campus/resource/view.php?id=431264",
            "attachmentUrl": [
                "http://my.stu.edu.cn/course_campus/uuid.pdf"
            ],
            "additionalUrl": [
                "http://www.wikimedia.com"
            ],
            "additionalStartDate": 1343022549,
            "additionalEndDate": 1343022549,
            "additionalDueDate": null
        }
    ]
```

## 5.获取学生成绩
* 方法：GET
* URL：https://[domain]/services/api/xuefenzhi/chengjibiao/[studentId]
* 参数：    studentId 学号
* 返回值：  


## 6.获取课程表
* 方法：  获取课程表
* URL：    https://[domain]/services/api/xuefenzhi/kechengbiao/[studentIdOrTeacherId]/[term]
* 参数：    
 * studentIdOrTeacherId 学生学号或教师编号
 * term 学年学期 
* 返回值：  


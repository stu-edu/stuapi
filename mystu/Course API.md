MYSTU Course API
=================

## 1. 获取用户课程信息
* URL: /services/api/userCourse/query
* METHOD: GET
* 参数：

    ```
    attendancYear     学年(4位年份)
    attendancSemeter  学期(1:秋季学期 2:春季学期 3:夏季学期)
    orderStr          排序方式，值可为 courseName
    pageNo            指定返回分页数据的第几页，默认为1
    pageSize          指定返回分页数据条数，默认50，最大不超过500.
    ```

* 返回：
    ```
    {
        "additionalData": null,
        "countHeadsStr": "",
        "entityType": "UserCourse",                                     
        "fields":"id,
                  moodle,                        //id
                  moodleCourseId,                //Moodle
                  courseName,                    //Moodle课程Id
                  courseNameEn,                  //课程英文名 
                  attendanceYear,                //学年
                  attendanceSemester,            //学期 
                  role",                         //角色
        "items": [
            [
                "8410340D76C611E5B35F0050568C74A4",
                "bschool",
                "3529",
                "MYSTU Help",
                null,
                2015,
                1,
                "teacher"
            ] 
            ...
        ],
        "numFields": "",
        "orderByStr": "attendanceYear desc,attendanceSemester desc",
        "pageNo": 1,
        "pageSize": 500,
        "startIndex": 0,
        "totalNum": 4,
        "totalPage": 1
    }
    ```
  

## 2. 获取课程活动
* URL: /services/api/courseactivity/query
* METHOD: GET
* 参数：

    ```
    moodleCourseId    Moodle课程号(all:全部  或者具体的Moodle课程ID)
    category          类型(all：全部,assign:作业,resource：文件,quiz：测验,forum:讨论区 )
    ```

* 返回：

    ```
    {
    "courseActivities": [
        {
            "activityCategory": "活动类型",
            "activityCategoryLogo": "图标",
            "activityDescription": "描述",
            "activityId": 活动Id,
            "activityTitle": "活动名称",
            "activityUrl": "活动url",
            "additionalDueDate": 结束日期时间戳,
            "additionalStartDate": 开始日期时间戳,
            "additionalUrl": [外部链接],
            "attachmentUrl": [附件链接],
            "author": "作者",
            "courseId": Moodle课程Id,
            "courseName": "课程名",
            "createdAt": 创建日期时间戳,
            "id": Id,
            "important": false,
            "inReplaceActivityId": "",
            "inReplacedByCourseId": "",
            "replaced": false,
            "schoolId": "学校Id",
            "sectionId": "主题Id",
            "sectionName": "主题名称",
            "starred": 是否共享,
            "text": ""
        },
        ...
        ]
    }
    ```

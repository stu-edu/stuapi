MYSTU Profile API 
================================
##说明
* 如未特别说明，返回数据的content-type均为application/json
* post提交返回code为201
* put提交返回code为200
* 如未特别说明，无错误代码

  
##1. 个人中心

* URL:/v3/services/api/userProfile/0
* Method:GET
* 参数：无
* 返回：

   ```
   {
    "profileInfo": {
        "id": "948C4870DE8611E29B9900505699201D",
        "studentID": "201500007",
        "major": "应用化学",
        "minor": "",
        "checkEmail": [
        ],
        "biography": {
            "val": "",
            "open": false
        },
        "addresses": {
            "open": true,
            "val": []
        },
        "aspirations": {
            "open": false,
            "val": [
                "成为一个科学家"
            ]
        },
        "birthday": {
            "open": false,
            "val": {
                "year": 2010,
                "month": 11,
                "day": 30
            }
        },
        "emails": {
            "open": true,
            "val": []
        },
        "gender": {
            "open": true,
            "val": "m"
        },
        "nativePlace": {
            "val": "",
            "true": false,
            "original": ""
        },
        "phones": {
            "open": false,
            "val": [
                "+86 1374565543"
            ]
        },
        "websites": {
            "open": true,
            "val": []
        },
        "yearOfAttendance": {
            "open": true,
            "val": 0
        },
        "partyMember": {  },
        "mood": null,
        "nationality": null,
        "department": null,
        "politicalParty": null,
        "program": null,
        "stage": "本科",
        "studyStatus": null,
        "tenure": null,
        "school": "理学院",
        "studentOriginal": {
            
        },
        "educations": {
            "open": true,
            "val": []
        },
        "experiences": {
            "open": true,
            "val": [ ]
        },
        "achievements": {
            "open": true,
            "val": [   ]
        },
        "interests": {
            "open": true,
            "val": [   ]
        },
        "skills": {
            "open": true,
            "val": []
        },
        "schoolActivities": {
            "open": true,
            "val": [ ]
        },
        "countMap": {
            "thumbCount": 2,
            "likeCount": 13,
            "postCount": 25,
            "commentCount": 17
        }
    },
    "tuser": {
        "fullName": "林滨海",
        "id": "948C4870DE8611E29B9900505699201D",
        "logoUrl": "C47CE8E08A9811E4824D95A0A0C521F9",
        "owner": "47120150BC6411E294259A23F2480654",
        "password": "",
        "role": 0,
        "status": "ACTIVE",
        "teacher": false,
        "token": "",
        "traitsauth": "",
        "uri": "user/948C4870DE8611E29B9900505699201D",
        "usePersonal": false,
        "usePersonalTime": null,
        "username": "s_stu1@uat.stu.edu.cn",
    }
}
   ```
     
* 返回数据说明：
   ```   
    profileInfo：主要包含个人资质，如：教育经历、获奖,
    tuser：主要包含个人的信息，如：电话，邮件，生日，姓名，等内容
   ```


##2.编辑姓名

* URL:/v3/services/api/user/{0}
* Method:PUT
* 参数：

    ```    
    0：登陆人的id(String)
    ```    
* 提交数据结构：
    ```   
    {displayName: "林滨海1"} 
    ```  

##3.保存个人资料

* URL:/v3/services/api/userProfile/{0}
* Method:PUT
* 参数：
  
    ```
      0：登录人的id
   ```
* 提交数据结构：

   ```
   {
    id: "948C4870DE8611E29B9900505699201D",
    gender: {
        open: true,
        val: "f"
    },
    nativePlace: {
        val: "中国",
        open: true,
        original: ""
    }，birthday: {
        open: true,
        val: {
            day: 3,
            month: 2,
            year: 2013
        }
    }，yearOfAttendance: {
        open: true,
        val: 2014
    },
    partyMember: {
        open: true,
        val: "league"
    },
    addresses: {
        open: true,
        val: [
            {
                address: "高新区大新街xx号",
                city: "成都shi",
                provience: "四川sheng",
                country: "中国"
            },
            …
        ]
    },
    phones: {
        val: [
            "+86 123456",
            "+86 114"
        ],
        open: true
    },
    emails: {
        val: [
            "123@123.com",
            "1236@163.com"
        ],
        open: true
    },
    websites: {
        val: [
            "https://www.baidu.com",
            "https://www.qq.com"
        ],
        open: true
    },
    {
        open: true,
        val: [
            "当个科学家"
        ]
    },
    biography: {
        open: true,
        val: [
            "我出生于....."
        ]
    }....
}
   ```
      
* 提交数据说明：
   ```
    个人资料保存的每个字段都由open:是否公开，val:具体数据，组合的map。
    gender:性别(f,m),nativePlace：籍贯，birthday：生日，
    yearOfAttendance：入学年份，partyMember：政治面貌(league团员，
    probationary预备党员，party党员，masses群众)，address:地址
   ```


##4.邀请投票

* URL:/v3/services/api/userEndorsement/invite
* Method:POST
* 参数：无
* 提交数据结构：
  
  ```
    {users: ["948C4870DE8611E29B9900505699201D"]}
   ```
* 提交数据说明：
  ```
    邀请投票用户id的数组
   ```


##5.保存教育经历

* URL:/v3/services/api/userProfile/{0}/educations
* Method:PUT
* 参数：
  
  ```
    0：登录人的id
   ```
* 提交数据结构：
  
  ```
  {
    open: true,
    val: [
        {
            id: "4B24D870034911E5ADC240B0CE7F1F33",
            school: "汕头大学",
            major: "新闻传播",
            begin: {
                year: 2013,
                month: 1,
                end: {
                    year: 2014,
                    month: 1
                },
                onTheJob: false
            },
            …
        ]
    }
  ```
     
* 提交数据说明：
  ```
    onTheJob:至今(true)
   ```


##6.保存在校经历

* URL:/v3/services/api/userProfile/{0}/schoolActivities
* Method:PUT
* 参数:
   
   ```
    0：登录人的id
   ```
* 返回:
   ```
      {
    open: true,
    val: [
        {
            id: "4B24D870034911E5ADC240B0CE7F1F33",
            content: "参加划艇项目测试",
            begin: {
                year: 2013,
                month: 1,
                end: {
                    year: 2014,
                    month: 1
                }
            },
            …
        ]
    }
   ``` 
         
##7.保存工作经历

* URL:/v3/services/api/userProfile/{0}/experiences
* Method:PUT
* 参数：
   
   ```
    0：登录人的id
   ```
* 提交数据结构：

   ```
      {
    open: true,
    val: [
        {
            id: "4B24D870034911E5ADC240B0CE7F1F33",
            company: "所在公司"content: "内容描述",
            title: "职位",
            begin: {
                year: 2013,
                month: 1,
                end: {
                    year: 2015,
                    month: 1
                },
                onTheJob: false
            },
            …
        ]
    }
   ```
      
* 提交数据说明：
  ```
    onTheJob:至今(true)
   ```


##8.保存获奖情况

* URL:/v3/services/api/userProfile/948C4870DE8611E29B9900505699201D/achievements
* Method:PUT
* 参数：
  
    ```
    0：登录人的id
    ```
* 提交数据结构：

   ```
      {
    open: true,
    val: [
        {
            id: "4B24D870034911E5ADC240B0CE7F1F33",
            title: "奖项名称",
            issuer: "颁发机构",
            timePeriod: {
                month: 1,
                year: 2015
            }
        },
        …
    ]
  }
   ```
     
* 提交数据说明：
    ```
    boatType: (1,2,3,4,5) 不为空，表示海洋划艇项目获奖情况，并对应项目名称
    ```

##9.保存兴趣

* URL:/v3/services/api/userProfile/948C4870DE8611E29B9900505699201D/interests
* Method:PUT
* 参数：无 
* 提交数据结构:

   ```
      {
    open: true,
    val: [
        {
            id: "4B24D870034911E5ADC240B0CE7F1F33",
            interest: "兴趣"
        },
        ...
    ]
   }
   ```
    

##10.保存技能

* URL:/v3/services/api/userProfile/948C4870DE8611E29B9900505699201D/skills
* Method:PUT
* 参数：无
* 提交数据结构：

   ```  
   {
    open: true,
    val: [
        {
            id: "4B24D870034911E5ADC240B0CE7F1F33",
            skill: "技能"
        },
        ...
    ]
   }

       
   ```

##11.我的帖子

* URL:/v3/services/api/post/myPost?pageSize=5
* Method:GET
* 参数：

    ```                       
    pageSize 每次查询返回数   
    ```
* 返回：
    ```
      {"additionalData":{},field:"{"additionalData":{},
      field:"id,
             version,
             owner,
             creator,
             createTime,
             status,
             content,
             entityType,
             entityId,
             type,
             sticky,
             entityName,
             files,
             pollOptions,
             comments,
             likeds,
             thumbs,
             followings,
             courseGroupId,
             pollEndTime,
             entityCode,
             tagType,
             groupAttendanceYear,
             groupAttendanceSemester,
             likedHas,
             thumbHas,
             followingHas,
             inappHas,
             thumbAble,
             selectOptionId,
             postShutup",
      items[["00E54ED0AF5F11E5906186574088FD86",
            0,....]],
      "numFields":"",
      "orderByStr":"createTime desc",
      "pageNo":1,
      "pageSize":5,
      "startIndex":0,
      "totalNum":70,
      "totalPage":14
      } 
    ```
* 返回数据说明：
    ```
    fields与items的每一条数据的数组对应，如：id="00E54ED0AF5F11E5906186574088FD86", 
    pageNo:当前页，pageSize:数据返回条数，startIndex:分页开始数，
    totalNum:总条数，totalPage:总页数
    ```

##12.我的评论

* URL:/v3/services/api/post/myReplay?pageSize=5
* Method:GET
* 参数：

    ```                       
    pageSize 每次查询返回数   
    ```
* 返回：
    ``` 
      {"additionalData":{},field:"{"additionalData":{},
      field:"id,
             version,
             owner,
             creator,
             createTime,
             status,
             content,
             entityType,
             entityId,
             type,
             sticky,
             entityName,
             files,
             pollOptions,
             comments,
             likeds,
             thumbs,
             followings,
             courseGroupId,
             pollEndTime,
             entityCode,
             tagType,
             groupAttendanceYear,
             groupAttendanceSemester,
             likedHas,
             thumbHas,
             followingHas,
             inappHas,
             thumbAble,
             selectOptionId,
             postShutup",
      items[["00E54ED0AF5F11E5906186574088FD86",
            0,....]],
      "numFields":"",
      "orderByStr":"createTime desc",
      "pageNo":1,
      "pageSize":5,
      "startIndex":0,
      "totalNum":24,
      "totalPage":5
      } 
    ```

##13.我的收藏

* URL:/v3/services/api/post/following?pageSize=5
* Method:GET
* 参数：

    ```                       
    pageSize 每次查询返回数   
    ```
* 返回：
    ```
       {"additionalData":{},field:"{"additionalData":{},
      field:"id,
             version,
             owner,
             creator,
             createTime,
             status,
             content,
             entityType,
             entityId,
             type,
             sticky,
             entityName,
             files,
             pollOptions,
             comments,
             likeds,
             thumbs,
             followings,
             courseGroupId,
             pollEndTime,
             entityCode,
             tagType,
             groupAttendanceYear,
             groupAttendanceSemester,
             likedHas,
             thumbHas,
             followingHas,
             inappHas,
             thumbAble,
             selectOptionId,
             postShutup",
      items[["00E54ED0AF5F11E5906186574088FD86",
            0,....]],
      "numFields":"",
      "orderByStr":"createTime desc",
      "pageNo":1,
      "pageSize":5,
      "startIndex":0,
      "totalNum":24,
      "totalPage":5
      } 
    ```

##14.发布某一帖子的回复

* URL:/v3/services/api/comment
* Method:POST
* 参数：无 
* 提交数据结构：

  ```
     {
      content: "这是我的回复"，fileIds: [
        
    ]，groupId: "408519C44A8211E3BB42005056991A42"，
      postId: "76753C0076DE11E5A3E9D040C33EFCB5"
     }
  ```
      
* 提交数据说明：
  ```
    groupId：课程分组id，psotId：讨论id
   ```
* 错误代码：
  ```
    {status_code: 404, error_msg: "post is invisible"} ，
    {status_code: 400, error_msg: "你被禁言了" }
   ```   

##15.我参加的活动

* URL:/v3/services/api/event/myevents?pageSize=8&pageNo=1
* Method:GET
* 参数：
 
   ```
    pageNo 当前页
    pageSize 数据返回条数
   ```
* 返回：
   ``` 
      {fields:"id,
               name,
               createTime,
               creator,
               owner,
               eventStatus,
               version,
               coverImage,
               description,
               startTime,
               endTime,
               eventImage,
               link,
               location,
               updatedTime,
               venue,
               tags,
               code,
               privacy,
               organizer,
               project,
               isdel,
               eventImageSrc,
               joinStartTime,
               joinEndTime,
               eName,
               eDescription,
               eOrganizer,
               eVenue,
               joinState,
               eventViews,
               members,
               files,
               adminMemberIds",
               items:[["7C6BC7B07D1D11E5A3E433627F4D8823", 
                      "征文大赛活动", 
                     1446000129000,…],
                     [...]],
               pageNo: 1,
               pageSize: 8,
               startIndex: 0,
               totalNum: 60,
               totalPage: 8
               } 
     ```


##16.我创建的活动

* URL:/v3/services/api/event/createdevents?pageSize=8&pageNo=1
* Method:GET
* 参数：
 
   ```
    pageNo 当前页
    pageSize 数据返回条数
   ```
* 返回：
   ```
      {fields:"id,
               name,
               createTime,
               creator,
               owner,
               eventStatus,
               version,
               coverImage,
               description,
               startTime,
               endTime,
               eventImage,
               link,
               location,
               updatedTime,
               venue,
               tags,
               code,
               privacy,
               organizer,
               project,
               isdel,
               eventImageSrc,
               joinStartTime,
               joinEndTime,
               eName,
               eDescription,
               eOrganizer,
               eVenue,
               joinState,
               eventViews,
               members,
               files,
               adminMemberIds",
       items:[["7C6BC7B07D1D11E5A3E433627F4D8823", 
               "征文大赛活动", 
               1446000129000,…],
               [...]],
       pageNo: 1,
       pageSize: 8,
       startIndex: 0,
       totalNum: 60,
       totalPage: 8
       } 
   ```

##17.权限设置

* URL:/v3/services/api/userProfile/changeOpen/{0}
* Method:PUT
* 参数：
  
    ```
    0:登陆人的id
    ```
* 提交数据结构：
   ```
    {achievements: {open: true},
      biography: {open: true},
      educations: {open: true},
      ...}  
    ```
* 提交数据说明:每一项都可以设置是否公开，


##18.导出简历

* URL：
 
    ```
      /v3/profile_export_pdf?personalInfo=on&schoolActivities=on&educations=on
      &experiences=on&achievements=on&userLogoUrl=on&skills=on
      &interests=on&courses=on
    ```  
* Method:GET
* 参数：每有一项，表示需要导出该信息
* 返回：无 


##19.发送验证邮件

* URL:/v3/services/api/userProfile/email?email={0}
* Method:POST
* 参数：
  
    ```
    0:需验证的邮箱
    ```

##20.设置默认邮箱

* URL:/v3/services/api/userProfile/setDefaultEmail
* Method:POST
* 参数：无 
* 提交数据结构：
    
    ```
    {email: "s_stu1@uat.stu.edu.cn "} 
      ```
* 错误代码：
    ```
    {status_code: 400, error_msg: "email is null" }，
    {status_code: 400, error_msg: "UserCheckEmail is null" }
     ```

##21.修改密码

* URL:/v3/services/api/user/changePassword
* Method:POST
* 参数：无 
* 提交数据结构：
                  
  ```
  {
    id: "948C4870DE8611E29B9900505699201D",
    username: "s_stu1@uat.stu.edu.cn",
    oldpassword: "旧的密码",
    password: "新的密码`"
 }
  ```
      
* 错误代码： 
  ``` 
    旧密码不对{"success":false,"errorCode":1}
  ```

##22.成绩表

* URL:/v3/services/api/coursegrade/query
* Method:GET
* 参数：无
* 返回：
 
  ```
      {
    categories: [
        {
            color: "#0099cc",
            credits: 2.6,
            gpa: 3,
            id: "948C4870DE8611E29B",
            name: "英语"
        },
        …
    ],
    gpa: 2.44,
    credits: 7.1,
    semesters: [
        {
            courses: [
                {
                    code: "aaaa",
                    credits: 2.6,
                    grade: 4,
                    gradePoint: 3,
                    id: "948C4870DE8611E29B",
                    name: "英语"
                }
            ],
            creditsEnrolled: 2.5,
            creditsReceived: 2.5,
            gpa: 2.2,
            key: 2014105,
            name: "2014至2015秋季学期",
            startDate: 20140102,
            endDate: 2015101
        },
        …
    ]
}    
       
  ```
     
* 返回数据说明：
  ```
    categories:科目，gpa：综合gpa，
    credits：总学分，semesters：学期
    ``` 

##23.个人简历

* URL:/v3/services/api/userProfile/username={0}
* Method:GET
* 参数：
   
    ```
    0:该用户用户名(s_stu1@uat.stu.edu.cn)
    ```
* 返回：
     
     ```
     {
    "profileInfo": {
        "id": "948C4870DE8611E29B9900505699201D",
        "studentID": "201500007",
        "major": "应用化学",
        "minor": "",
        "checkEmail": [
        ],
        "biography": {
            "val": "",
            "open": false
        },
        "addresses": {
            "open": true,
            "val": []
        },
        "aspirations": {
            "open": false,
            "val": [
                "成为一个科学家"
            ]
        },
        "birthday": {
            "open": false,
            "val": {
                "year": 2010,
                "month": 11,
                "day": 30
            }
        },
        "emails": {
            "open": true,
            "val": []
        },
        "gender": {
            "open": true,
            "val": "m"
        },
        "nativePlace": {
            "val": "",
            "true": false,
            "original": ""
        },
        "phones": {
            "open": false,
            "val": [
                "+86 1374565543"
            ]
        },
        "websites": {
            "open": true,
            "val": []
        },
        "yearOfAttendance": {
            "open": true,
            "val": 0
        },
        "partyMember": {  },
        "mood": null,
        "nationality": null,
        "department": null,
        "politicalParty": null,
        "program": null,
        "stage": "本科",
        "studyStatus": null,
        "tenure": null,
        "school": "理学院",
        "studentOriginal": {
            
        },
        "educations": {
            "open": true,
            "val": []
        },
        "experiences": {
            "open": true,
            "val": [ ]
        },
        "achievements": {
            "open": true,
            "val": [   ]
        },
        "interests": {
            "open": true,
            "val": [   ]
        },
        "skills": {
            "open": true,
            "val": []
        },
        "schoolActivities": {
            "open": true,
            "val": [ ]
        },
        "countMap": {
            "thumbCount": 2,
            "likeCount": 13,
            "postCount": 25,
            "commentCount": 17
        }
    },
    "tuser": {
        "fullName": "林滨海",
        "id": "948C4870DE8611E29B9900505699201D",
        "logoUrl": "C47CE8E08A9811E4824D95A0A0C521F9",
        "owner": "47120150BC6411E294259A23F2480654",
        "password": "",
        "role": 0,
        "status": "ACTIVE",
        "teacher": false,
        "token": "",
        "traitsauth": "",
        "uri": "user/948C4870DE8611E29B9900505699201D",
        "usePersonal": false,
        "usePersonalTime": null,
        "username": "s_stu1@uat.stu.edu.cn",
    }
   }

  ```
      
* 返回数据说明：

  ```
    返回数据同个人中心，profileInfo：主要包含个人资质，如：教育经历、获奖,
    tuser主要包含个人的信息，如：电话，邮件，生日，姓名，等内容
 ```


##24.某用户的帖子

* URL:/v3/services/api/post/userPost/{0}?pageSize=5
* Method:GET
* 参数：

    ```                       
    pageSize 每次查询返回数
    0:该用户用户名   
    ```
     
* 返回：
    ```  
      {"additionalData":{},field:"{"additionalData":{},
      field:"id,
             version,
             owner,
             creator,
             createTime,
             status,
             content,
             entityType,
             entityId,
             type,
             sticky,
             entityName,
             files,
             pollOptions,
             comments,
             likeds,
             thumbs,
             followings,
             courseGroupId,
             pollEndTime,
             entityCode,
             tagType,
             groupAttendanceYear,
             groupAttendanceSemester,
             likedHas,
             thumbHas,
             followingHas,
             inappHas,
             thumbAble,
             selectOptionId,
             postShutup",
      items[["CACC62B0E31811E4BF2CD6B3F2EE5381",
            0,....]],
      "numFields":"",
      "orderByStr":"createTime desc",
      "pageNo":1,
      "pageSize:5 ,
      "totalNum":55,
      "totalPage":11
      }
 ```   
* 返回数据说明：
    ```  
    fields与items的每一条数据的数组对应，如：id="CACC62B0E31811E4BF2CD6B3F2EE5381", 
    pageNo:当前页，pageSize:数据返回条数，startIndex:分页开始数，
    totalNum:总条数，totalPage:总页数
    ```  

##25.某用户的评论

* URL:/v3/services/api/post/userReplay/{0}?pageSize=5
* Method:GET
* 参数：

    ```                       
    pageSize 每次查询返回数
    0:该用户用户名   
    ```
* 返回：
    ``` 
      {"additionalData":{},
      field:"id,
             version,
             owner,
             creator,
             createTime,
             status,
             content,
             entityType,
             entityId,
             type,
             sticky,
             entityName,
             files,
             pollOptions,
             comments,
             likeds,
             thumbs,
             followings,
             courseGroupId,
             pollEndTime,
             entityCode,
             tagType,
             groupAttendanceYear,
             groupAttendanceSemester,
             likedHas,
             thumbHas,
             followingHas,
             inappHas,
             thumbAble,
             selectOptionId,
             postShutup",
      items[],
      "numFields":"",
      "orderByStr":"createTime desc",
      "pageNo":1,
      "pageSize":5,
      "startIndex":0,
      "totalNum":0,
      "totalPage":1
      }  
    ``` 

##26.某用户的收藏

* URL:/v3/services/api/post/userFollowing/{0}?pageSize=5
* Method:GET
* 参数：

    ```                       
    pageSize 每次查询返回数
    0:该用户用户名   
    ```
* 返回：
    ``` 

      {"additionalData":{},
      field:"id,
             version,
             owner,
             creator,
             createTime,
             status,
             content,
             entityType,
             entityId,
             type,
             sticky,
             entityName,
             files,
             pollOptions,
             comments,
             likeds,
             thumbs,
             followings,
             courseGroupId,
             pollEndTime,
             entityCode,
             tagType,
             groupAttendanceYear,
             groupAttendanceSemester,
             likedHas,
             thumbHas,
             followingHas,
             inappHas,
             thumbAble,
             selectOptionId,
             postShutup",
      items[],
      "numFields":"",
      "orderByStr":"createTime desc",
      "pageNo":1,
      "pageSize":5,
      "startIndex":0,
      "totalNum":0,
      "totalPage":1
      } 



##27.某用户参加的活动

* URL:/v3/services/api/event/userEvents/{0}?pageSize=9&pageNo=1
* Method:GET
* 参数：

    ```                       
    pageSize 每次查询返回数
    pageNo 当前页
    0:该用户用户名   
    ```
* 返回：
    ``` 
      {fields:"id,
               name,
               createTime,
               creator,
               owner,
               eventStatus,
               version,
               coverImage,
               description,
               startTime,
               endTime,
               eventImage,
               link,
               location,
               updatedTime,
               venue,
               tags,
               code,
               privacy,
               organizer,
               project,
               isdel,
               eventImageSrc,
               joinStartTime,
               joinEndTime,
               eName,
               eDescription,
               eOrganizer,
               eVenue,
               joinState,
               eventViews,
               members,
               files,
               adminMemberIds",
         items:[],
         pageNo: 1,
         pageSize: 9,
         startIndex: 0,
         totalNum: 0,
         totalPage: 1
         }  


##28.某用户创建的活动

* URL：/v3/services/api/event/userCreatedevents/{0}?pageSize=8&pageNo=1
* Method:GET
* 参数：

    ```                       
    pageSize 每次查询返回数
    pageNo 当前页
    0:该用户用户名   
    ```
* 返回：
    ``` 

      {fields:"id,
               name,
               createTime,
               creator,
               owner,
               eventStatus,
               version,
               coverImage,
               description,
               startTime,
               endTime,
               eventImage,
               link,
               location,
               updatedTime,
               venue,
               tags,
               code,
               privacy,
               organizer,
               project,
               isdel,
               eventImageSrc,
               joinStartTime,
               joinEndTime,
               eName,
               eDescription,
               eOrganizer,
               eVenue,
               joinState,
               eventViews,
               members,
               files,
               adminMemberIds",
         items:[],
         pageNo: 1,
         pageSize: 8,
         startIndex: 0,
         totalNum: 0,
         totalPage: 1
      }  




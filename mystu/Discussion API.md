MYSTU Discussion API 
================================
##说明
* 如未特别说明，返回数据的content-type均为application/json
* post提交返回code为201
* put提交返回code为200
* 如未特别说明，无错误代码


##1.课程讨论

* URL:/v3/services/api/post/byCourse?pageSize=5   
* Method: GET        
* 参数：
 
    ```                       
    pageSize 每次查询返回数   
    ```
* 返回：

  ```
          {fields:            
            "id,
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
           items: [
           [ "9F8D6770AF5A11E5906186574088FD86",
             0,
             "948C4870DE8611E29B9900505699201D",
             ...],
             ....
          ],
         pageNo: 1,
         pageSize: 5,
         startIndex: 0,
         totalNum: 64,
         totalPage: 13
        }
    ``` 
        
 
* 返回数据说明：
 
     ```
       fields与items的每一条数据的数组对应，如：
       id="9F8D6770AF5A11E5906186574088FD86"，
       verson=0,回复：comments = items[14] , 
       entityType:帖子类别(Event,Project,Course,),
       entityId:类别id,
       sticky：置顶，
       pollOptions：投票类型，
       pollEndTime：投票结束日期，
       likeds：赞，
       thumbs：大拇指， 
       followings：收藏，
       postShutup：禁言
       pageNo:当前页，
       pageSize:数据返回条数，
       startIndex:分页开始数，
       totalNum:总条数，
       totalPage:总页数
     ```  

##2.课程列表
  
* URL:/v3/services/api/course/query
* Method: GET
* 参数：无
* 返回：

   ```
        {fields: "id,
                 name,
                 role,
                 attendanceYear,
                 attendanceSemester,
                 courseCode,
                 groupId,
                 groupName,
                 url,
                 startTime",
         items: [ 
       [ "0326F2BADBAF11E2BD8C00505699201D",
         "汕大之友",
         "visitor",
         2013,
         1,
         "MYSTU0008",
         "2AA8B98D4A8211E3BB42005056991A42",
         "1255",
         null,
         0],
         ...],
        numFields: "",
        orderByStr: "",
        pageNo: 1,
        pageSize: 800,
        startIndex: 0,
        totalNum": 4,
        totalPage": 1
        }
         
   ```
* 返回数据说明：

    ```
      role:角色，
      attendanceYear：学年，
      attendanceSemester：学期，（1/春季，2/秋季）
    ```

##3.某一课程的课程讨论

* URL:/v3/services/api/post/byCourseGroupId/{0}/{1}?pageSize=5
* Method: GET
* 参数：

```
      url 路径参数  
      0：课程id  String  
      1：课程分组id  String     

      url 请求参数  
      pageSize 每次查询返回数
```
* 返回：

    ```
    {fields:   "id,
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
        items: [],
        numFields: "",
        orderByStr: "createTime desc",
        pageNo: 1,
        pageSize: 5,
        startIndex: 0,
        totalNum: 0,
        totalPage: 1
         } 
    ```

##4.课程成员

* URL:/v3/services/api/course/courseGroupMemberTea/{0}
* Method: GET
* 参数：
   
   ```
      0：课程分组id(String)
   ```
* 返回：
   
   ```
      {fields:"id,
               user,
               role,
               shutupTime",
       items:
               [
               [
               "0: "1D196FFF590511E493160050568C74A4",
               {id: "262C5BE0BBCC11E2BEDE5CB5DFAE6554", 
               fullName: "黄嘉毅", 
               userName: 
               "karl",
               displayName: "黄嘉毅",
               …
               },
               "student",
               null
               ],
               [...]],
       pageNo: 1,
       pageSize: 800,
       startIndex: 0,
       totalNum: 19,
       totalPage: 1
       }
  ``` 
* 返回数据说明：
  
  ```
      shutupTime:禁言时间,role:角色
  ```   

##5.发布讨论

* URL:/v3/services/api/post
* Method: POST
* 参数:无 
* 提交数据结构：
     
   ```
       {
       content: "发布的讨论"，
       courseGroupId:"2597B9D2BEF411E3928B00505699201D"，
       entityId: "A06343E2BEF011E3928B00505699201D"，
       entityName: "Course"，
       fileIds:["4FDD1BE0B2BA11E5AE137D31B3B596B9"]
       }
   ```
* 提交数据说明：
   
   ```  
      content:讨论类容，
      courseGroupId：课程分组id，
      entityId：对应类型id，
      entityName：讨论类型（课程:Course、活动:Event、项目:Project、团体:EventGroup），
      fileIds：上传图片或文件返回id
   ```
* 错误代码：
  
  ```
      {status_code: 400, error_msg: "你被禁言了" }，  
      {status_code: 400, error_msg: "Content is null" }
  ```
 
   
##6.删除讨论

* URL:/v3/services/api/post/{0}
* Method:DELETE
* 参数：
   ```
    0：讨论id(String)
   ```

* 错误代码：
   
   ```
    {status_code: 403, error_msg: "你没有权限删除该条数据!"}
  ```

##7.发布讨论回复

* URL:/v3/services/api/comment
* Method:POST
* 参数：无
* 提交数据结构：

   ```       
      {
      content: "这是我的回复"，
      fileIds: []，
      groupId:"408519C44A8211E3BB42005056991A42",
      postId:"76753C0076DE11E5A3E9D040C33EFCB5"
      }

   ```
* 提交数据说明：

``` 
      groupId：课程分组id，
      psotId：讨论id
``` 
* 错误代码：
  
   ```
      {status_code: 404, error_msg: "post is invisible"} ，  
      {status_code: 400, error_msg: "你被禁言了" }
   ```

##8.删除讨论回复

* URL:/v3/services/api/comment/{0}
* Method:DELETE
* 参数：
   
   ```
      0：讨论回复id(String)
   ```

* 错误代码：
   
   ```
      {status_code: 403, error_msg: "你没有权限删除该条数据!"}
   ```


##9.项目/活动讨论

* URL:/v3/services/api/post/byEvent?pageSize=5
* Method:GET
* 参数：
 
    ```                       
      pageSize 每次查询返回数   
    ```
* 返回:

  ``` 
      {fields:"id,
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
               postShutup""",
      items:[
             ["9F8D6770AF5A11E5906186574088FD86",
               0,
              "948C4870DE8611E29B9900505699201D",
               ...],
              [...]
              ],
      pageNo: 1,
      pageSize: 5,
      startIndex: 0,
      totalNum: 64,
      totalPage: 13
      } 
``` 

##10.已参与活动

* URL:/v3/services/api/event/myeventList
* Method:GET
* 参数:无
* 返回：

    ```
    {
    fields: "id,name,isAdmin",
    items: [
        [
            "7C6BC7B07D1D11E5A3E433627F4D8823",
            "2015年毕业典礼活动",
            true
        ],
        [
            ...
        ]
    ],
    pageNo: 1,
    pageSize: 20,
    startIndex: 0,
    totalNum: 64,
    totalPage: 4
   }
     ```
* 返回数据说明：
  
   ```
    isAdmin：是否是管理员
   ```


##11.已参与项目

* URL:/v3/services/api/event/myprojectList
* Method:GET
* 参数：无
* 返回：

  ```
     {
    fields: "id,name,isAdmin",
    items: [
        [
            "F704BE90304811E599C5BD8E1307D421",
            "团体项目",
            true
        ],
        [
            ...
        ]
    ],
    pageNo: 1,
    pageSize: 20,
    startIndex: 0,
    totalNum: 64,
    totalPage: 4
} 
      
   ```
* 返回数据说明：
   
   ```
      isAdmin：是否是管理员
   ```



##12.某一活动讨论

* URL:/v3/services/api/post/byEventId/{0}?pageSize=5
* Method:GET
* 参数：
   
   ```                       
     url 路径参数
     0：活动id(String)   
     url 请求参数
     pageSize 每次查询返回数 
   ```
* 返回：
  
  ```
      {fields:"id,
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
               likedHas,thumbHas,
               followingHas,
               inappHas,
               thumbAble,
               selectOptionId,
               postShutup",
      items:[
              ["BA8A0AD0629B11E58B9E2BAFF77017F2", 
               0, 
               "948C2B38DE8611E29B9900505699201D",
               …],
               [...]
             ],
      pageNo: 1,
      pageSize: 5,
      startIndex: 0,
      totalNum: 64,
      totalPage: 4
      }  
     ```


##13.某一项目讨论

* URL:/v3/services/api/post/byProjectId/{0}?pageSize=5
* Method:GET
* 参数:
   
   ```                       
     url 路径参数
     0：项目id(String)   
     url 请求参数
     pageSize 每次查询返回数 
   ```
* 返回：

   ```
      {fields:"id,
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
      items:[["BA8A0AD0629B11E58B9E2BAFF77017F2", 
               0, 
              "948C2B38DE8611E29B9900505699201D",…],
             [...]],
      pageNo: 1,
      pageSize: 5,
      startIndex: 0,
      totalNum: 64,
      totalPage: 4
      }  
     ``` 



##14.分享讨论

* URL:/v3/services/api/post/notes?pageSize=5&tagType=new
* Method:GET
* 参数：
      
  ```                       
     tagType 热门标签，去掉tagType返回所有分享讨论
     pageSize 每次查询返回数
  ```
* 返回：
      
   ```
      {fields:"id,
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
      items:[["BA8A0AD0629B11E58B9E2BAFF77017F2",
              0, 
              "948C2B38DE8611E29B9900505699201D",…],
              [...]],
       pageNo: 1,
       pageSize: 5,
       startIndex: 0,
       totalNum: 64,
       totalPage: 4
       } 
     ```  

##15.发布分享讨论

* URL:/v3/services/api/post
* Method:POST
* 参数：无
* 提交数据结构：

   ```
     {
    content: "发布的分享讨论",
    fileIds: ["4FDD1BE0B2BA11E5AE137D31B3B596B9"],
    tagType: "new"
   }
    ```
* 提交数据说明：
  
   ``` 
    tagType:热门标签,
    fileIds:讨论提交的文件
   ```
* 错误代码：
   
   ```
    {status_code: 400, error_msg: "你被禁言了" }，
    {status_code: 400, error_msg: "Content is null" }
   ```

##16.收藏的讨论

* URL:/v3/services/api/post/following?pageSize=5
* Method:GET
* 参数：

    ```                       
        pageSize 每次查询返回数   
    ``` 
* 返回：

    ```
      {fields:"id,
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
      items:[
             ["BA8A0AD0629B11E58B9E2BAFF77017F2", 
              0, 
              "948C2B38DE8611E29B9900505699201D",…],
              [...]
           ],
      pageNo: 1,
      pageSize: 5,
      startIndex: 0,
      totalNum: 64,
      totalPage: 4
      } 

    ```

##17.我的团体讨论

* URL:/v3/services/api/post/byEventGroup?pageSize=5
* Method:GET
* 参数：

    ```                       
        pageSize 每次查询返回数   
    ```
* 返回：
   
    ``` 
      {fields:"id,
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
      items:[],
      pageNo: 1,
      pageSize: 5,
      startIndex: 0,
      totalNum:0,
      totalPage:1
      }
    ``` 

##18.我的团体

* URL:/v3/services/api/eventGroup/getMyGroupList
* Method:GET
* 参数：无 
* 返回：

   ```
   {
    groupList: [
        {
            id: "33",
            owner: "",
            parentId: "28",
            role: "President",
            ename: "jinrongxiehui",
            …
        },
        {
            ...
        }
    ]
}
   ```
* 返回数据说明：
  
  ```
  parentId:上一级id，
  role：角色
  ```

##19.我的团体成员

* URL:/v3/services/api/eventUserGroup/eventMembers/{0}
* Method:GET
* 参数：

    ``` 
    0：团体id(String)
    ``` 
* 返回：

    ```
      {
    fields: "id,user,role",
    items: [
        [
            "1424EC10C24A11E493F4842588D6046B"，{
                id: "fb83f467-ab66-11e2-b8db-005056991a43",
                fullName: "林滨海",
                userName: "joeyhu456",
                …
            }，"Normal"
        ],
        [
            ...
        ]
    ],
    pageNo: 1,
    pageSize: 800,
    startIndex: 0,
    totalNum: 4,
    totalPage: 1
   }
     ```


##20.某一我的团体讨论

* URL:/v3/services/api/post/byEventGroupId/{0}?pageSize=5
* Method:GET
* 参数：
    ```                       
     url 路径参数
     0：团体id  String       
     url 请求参数
     pageSize 数据返回条数     
    ```
* 返回：

   ``` 
      {fields:"id,
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
        items:[["BA8A0AD0629B11E58B9E2BAFF77017F2", 
               0,
               "948C2B38DE8611E29B9900505699201D",…],
               [...]],
        pageNo: 1,
        pageSize: 5,
        startIndex: 0,
        totalNum: 64,
        totalPage: 4
        }  

     ``` 

##21.我的图书

* URL:/v3/services/api/resources/getMyResources
* Method:GET
* 参数：无
* 返回：
 
   ```
      {fields:"id,
               resourcesId,
               owner,
               resourcesName,
               collectTime,
               introduce,
               contentUrl,
               imgUrl,
               author,
               resourcesType",
      items:[["BA8A0AD0629B11E58B9E2BAFF77017F2",
              "138D530061D711E5909117C3278B6DD1",
               "948C2B38DE8611E29B9900505699201D",                              
              …],
               [...]],
       pageNo: 1,
       pageSize: 1000,
       startIndex: 0,
       totalNum: 64,
       totalPage: 1
             } 
  ```

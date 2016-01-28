MYSTU Project API
================================
##说明
* 如未特别说明，返回数据的content-type均为application/json
* post提交返回code为201
* put提交返回code为200
* 如未特别说明，无错误代码

##1.最近项目

* URL:/v3/services/api/project/latest?pageSize=8&pageNo=1
* Method:GET
* 参数：

    ```                       
    pageSize 每次查询返回数
    pageNo 当前页   
    ```
* 返回：

   ```
    {fields:"id,
              name,
              createTime,
              creator,
              owner,
              projectStatus,
              version,
              coverImage,
              description,
              startTime,
              endTime,
              projectImage,
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
              projectImageSrc,
              joinStartTime,
              joinEndTime,
              eName,
              eVenue,
              eDescription,
              eOrganizer,
              faq,
              relatedEvent,
              joinState,
              projectViews,
              members,
              files,
              adminMemberIds",
       items:[["D32358A0ADD011E5906186574088FD86",
               "uat浏览",
               1451354811000,
                 …],
               [...]],
       pageNo: 1,
       pageSize: 8,
       startIndex: 0,
       totalNum: 67,
       totalPage: 9
       }
     ```  
* 返回数据说明：

  ```
     fields与items的每一条数据的数组对应：
     projectStatus:项目状态，
     description：项目描述，
     startTime：项目开始时间，
     endTime：结束时间
     link：项目链接，
     venue：场地，
     tags：标签，
     code：活动编码，
     privacy：隐私设置，
     projectImageSrc：项目封面图，
     joinStartTime：报名开始时间，
     joinEndTime：报名结束时间，
     faq：常见问题，
     relatedEvent：相关活动
     joinState：参加状态（0 没开始，1可以参加状态 ，2结束 ，3报名人数已满），
     projectViews：访问人数，
     members：成员，
     files：照片,
     adminMemberIds:管理员
    ```

##2.我的项目

* URL:/v3/services/api/project/myprojects?pageSize=8&pageNo=1
* Method:GET
* 参数：

    ```                       
    pageSize 每次查询返回数
    pageNo 当前页   
    ```
* 返回：
   
    ```
      {fields:"id,
              name,
              createTime,
              creator,
              owner,
              projectStatus,
              version,
              coverImage,
              description,
              startTime,
              endTime,
              projectImage,
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
              projectImageSrc,
              joinStartTime,
              joinEndTime,
              eName,
              eVenue,
              eDescription,
              eOrganizer,
              faq,
              relatedEvent,
              joinState,
              projectViews,
              members,
              files,
              adminMemberIds",
        items:[["D32358A0ADD011E5906186574088FD86",
                "uat浏览",
                1451354811000,
                 …],
                [...]],
        pageNo: 1,
        pageSize: 8,
        startIndex: 0,
        totalNum: 8,
        totalPage: 1
        }
    ```

##3.我创建的项目

* URL:/v3/services/api/project/createdprojects?pageSize=8&pageNo=1
* Method:GET
* 参数：

    ```                       
    pageSize 每次查询返回数
    pageNo 当前页   
    ```
* 返回：
    
    ```
       {fields:"id,
              name,
              createTime,
              creator,
              owner,
              projectStatus,
              version,
              coverImage,
              description,
              startTime,
              endTime,
              projectImage,
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
              projectImageSrc,
              joinStartTime,
              joinEndTime,
              eName,
              eVenue,
              eDescription,
              eOrganizer,
              faq,
              relatedEvent,
              joinState,
              projectViews,
              members,
              files,
              adminMemberIds",
       items:[["D32358A0ADD011E5906186574088FD86",
               "uat浏览",
               1451354811000,
               …],
              [...]],
       pageNo: 1,
       pageSize: 8,
       startIndex: 0,
       totalNum: 3,
       totalPage: 1
       }
    ```


##4.流行的项目

* URL:/v3/services/api/project/trending?pageSize=8&pageNo=1
* Method:GET
* 参数：

    ```                       
    pageSize 每次查询返回数
    pageNo 当前页   
    ```
* 返回：
    
    ```
      {fields:"id,
              name,
              createTime,
              creator,
              owner,
              projectStatus,
              version,
              coverImage,
              description,
              startTime,
              endTime,
              projectImage,
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
              projectImageSrc,
              joinStartTime,
              joinEndTime,
              eName,
              eVenue,
              eDescription,
              eOrganizer,
              faq,
              relatedEvent,
              joinState,
              projectViews,
              members,
              files,
              adminMemberIds",
     items:[["D32358A0ADD011E5906186574088FD86",
             "uat浏览",
             1451354811000,
             …],
            [...]],
     pageNo: 1,
     pageSize: 8,
     startIndex: 0,
     totalNum: 1,
     totalPage: 1
     }
   ``` 

##5.团体项目

* URL:/v3/services/api/project/byGroupId?pageSize=8&pageNo=1&groupId={0}
* Method:GET
* 参数：

    ```                       
    pageSize 每次查询返回数
    pageNo 当前页 
    0：团体id(String) 
    ```
* 返回：

   ```
   {
    additionalData: {
        admins: [
            [
                "948C4870DE8611E29B9900505699201D",
                "林滨海",
                "s_stu1@uat.stu.edu.cn",
                …
            ],
            …
        ],
        groupId: "33",
        groupName: "Mystu",
        ename: "mystu",
      
    },
    {fields:"id,
              name,
              createTime,
              creator,
              owner,
              projectStatus,
              version,
              coverImage,
              description,
              startTime,
              endTime,
              projectImage,
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
              projectImageSrc,
              joinStartTime,
              joinEndTime,
              eName,
              eVenue,
              eDescription,
              eOrganizer,
              faq,
              relatedEvent,
              joinState,
              projectViews,
              members,
              files,
              adminMemberIds",
     items:[["D32358A0ADD011E5906186574088FD86",
             "uat浏览",
             1451354811000,
             …],
            [...]],
     pageNo: 1,
     pageSize: 8,
     startIndex: 0,
     totalNum: 1,
     totalPage: 1
     }
   ```
     
* 返回数据说明：
   
   ```    
    additionalData:返回项目相关数据，admins：管理员，
    groupId：团体id，groupName：团体名称，ename：团体英文名称
   ```

##6.搜索项目

* URL:/v3/services/api/project/byName?pageSize=8&pageNo=1&name={0}&startTime={1}&endTime={2}
* Method:GET
* 参数：

    ```                       
    pageSize 每次查询返回数
    pageNo 当前页 
    0：团体id(String)
    1:项目开始时间(Long)
    2:项目结束时间(Long) 
    ```
* 返回：
    
    ```   
       {fields:"id,
              name,
              createTime,
              creator,
              owner,
              projectStatus,
              version,
              coverImage,
              description,
              startTime,
              endTime,
              projectImage,
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
              projectImageSrc,
              joinStartTime,
              joinEndTime,
              eName,
              eVenue,
              eDescription,
              eOrganizer,
              faq,
              relatedEvent,
              joinState,
              projectViews,
              members,
              files,
              adminMemberIds",
       items:[["032F3A1076D011E5B14779CD38DD193B",
               "Zoom项目新功能介绍",  …],
               [...]],
       pageNo: 1,
       pageSize: 8,
       startIndex: 0,
       totalNum: 105,
       totalPage: 14
       }
    ```   


##7.获取团体

* URL:/v3/services/api/eventGroup/getEventGroup
* Method:GET
* 参数：无
* 返回：

    ```
    {
    groupList: [
       {
            "createTime": "",
            "creator": "",
            "ename": "7 Campus Associations ",
            "fields":
            [
                "id",
                "groupName",
                "parentId",
                "status",
                "createTime"
            ],
            "groupName": "七大组织",
            "id": "1",
            "owner": "",
            "parentId": "",
            "role": "",
            "status": null,
            "uri": "eventGroup/1",
            "version": 1
        },
        …
    ]
}
    ```



##8.获取某一团体包含的组织

* URL:/v3/services/api/eventGroup/getEventOrganize?pageSize=100&parentId={0}
* Method:GET
* 参数：
 
 ``` 
    pageSize 每次查询返回数
    0：上层团体id
 ```      
* 返回：

   ```
    {
    groupList: [
       {
            "createTime": "",
            "creator": "",
            "ename": "7 Campus Associations ",
            "fields":
            [
                "id",
                "groupName",
                "parentId",
                "status",
                "createTime"
            ],
            "groupName": "七大组织",
            "id": "1",
            "owner": "",
            "parentId": "",
            "role": "",
            "status": null,
            "uri": "eventGroup/1",
            "version": 1
        },
        …
    ]
}
    ```


* 返回数据说明：
    ```
    parentId:上层团体id
   ``` 

##9.搜索团体项目

* url:/v3/services/api/project/byGroupId?pageSize=8&pageNo=1&groupId={0}
* Method:GET
* 参数：

    ```                       
    pageSize 每次查询返回数
    pageNo 当前页 
    0：团体id(String) 
    ```
* 返回：

     ```
    {
    groupList: [
       {
            "createTime": "",
            "creator": "",
            "ename": "7 Campus Associations ",
            "fields":
            [
                "id",
                "groupName",
                "parentId",
                "status",
                "createTime"
            ],
            "groupName": "七大组织",
            "id": "1",
            "owner": "",
            "parentId": "",
            "role": "",
            "status": null,
            "uri": "eventGroup/1",
            "version": 1
        },
        …
    ]
}
    ```

      
* 返回数据说明:同第5点，团体项目

##10.创建项目

* URL:/v3/services/api/project
* Method:POST
* 参数：无 
* 提交数据结构：

   ```
   {
    code: "A50B23C",
    description: "项目描述",
    eDescription: ,
    "英文项目描述",
    eName: "英文项目名称",
    eOrganizer: "英文项目主办人",
    eVenue: "英文场地",
    endTime: 1453226400065,
    faq: "常见问题问答",
    groupId: null,
    isAddSpace: "no",
    isPost: 0,
    isVisit: "no",
    joinEndTime: 1452096000066,
    joinStartTime: 1452009600066,
    joinTemplate: "[{"type":"text","name":"星座"}]",
    link: "www.baidu.com",
    isDefaultPost: "true",
    name: "项目名称",
    needReport: "true",
    organizer: "项目主办人",
    privacy: "private",
    reportType: "p,",
    startTime: 1451923200065,
    tags: "标签1,标签2",
    venue: "场地"
}
   ```

* 提交数据说明：

   ```
      groupId:团体id，isAddSpace：no(不允许成员自己加入分享空间)，
      isPost:所有人发帖（0）管理员发帖（1），joinEndTime：报名开始时间，needReport：需要填写报名表格，
      joinTemplate：报名表格新增字段，link：项目链接，isDefaultPost：是否收起讨论区，
      privacy：隐私设置（private，friend，public），isVisit:(是否校外公开)，
      reportType：报名方式(p/个人,g/团体)，
   ```
* 错误代码：
  
   ```
    {status_code: 400, error_msg: "name is too long" }，
    {status_code: 400, error_msg: "code is exist" }
   ```

##11.验证code是否存在

* URL:/v3/services/api/project/{0}/exist
* Method:GET
* 参数：
   
   ```
    0：项目编号code
    ```
* 返回：

   ```
   {
    exists: false
   }{
    exists: true,
    id: "57832E90B36211E5AEE57932A3FBC68D",
    code: "firstcode"
  }
   ```
      
* 提交数据说明：
   ```
    exists：是否存在该项目编号
   ```

##12.项目详情

* URL:/v3/services/api/project/{0}
* Method:GET
* 参数：
   
   ```
    0：项目id或项目code (String)
   ```
* 返回：
      
   ```
   {
    "createTime": 1438151592000,
    "projectImage": null,
    "joinStartTime": null,
    "groupName": null,
    "reportType": "p
,",
    "isDefaultPost": null,
    "location": null,
    "link": null,
    "adminMembers": [
        [
            "77354A00BBD711E2BEDE5CB5DFAE6554",
            "Elearning",
            "elearning",
            "6161F7F08A9811E4824D95A0A0C521F9",
            "following"
        ],    
    ],
    "endTime": 4102243200000,
    "creator": "77354A00BBD711E2BEDE5CB5DFAE6554",
    "relatedEventList": null,
    "startTime": 1438099200000,
    "id": "AF86ED4035BB11E59E9E8CBAFEAA75DA",
    "projectStatus": "open",
    "shareSpace": "563660C035C211E59E9E8CBAFEAA75DA,null",
    "description": "MYSTU操作指引，...！",
    "name": "MYSTU操作指引",
    "isdel": "1",
    "role": null,
    "joinState": 1,
    "isAddSpace": false,
    "updatedTime": 1438151592000,
    "coverImage": null,
    "members": {
        "invite": [
            
        ],
    },
    "joinTemplate": null,
    "tags": "",
    "files": {
        "photo": [ ],
    },
    "videoUrl": null,
    "organizer": "MYSTU团队",
    "faq": null,
    "eVenue": null,
    "privacy": "public",
    "projectImageSrc": "362438B035BE11E59E9E8CBAFEAA75DA/bj640_.jpg",
    "code": "MYSTUoperation",
    "venue": null,
    "eDescription": null,
    "projectViews": 321,
    "eName": null,
    "groupId": null,
    "project": null,
    "eOrganizer": null,
    "videoUrlJson": null,
    "relatedEvent": null,
    "isVisit": null,
    "needReport": false,
    "owner": "77354A00BBD711E2BEDE5CB5DFAE6554",
    "presidentMember": [
        
    ],
    "joinEndTime": null,
    "projectBanner": ""
}
   ```
       
* 返回数据说明：数据结构同活动详情

##13.修改项目

* URL:/v3/services/api/event/{0}
* Method:PUT
* 参数：
  
    ```
    0：项目id(String)
     ```
* 提交数据结构：
 
    ```
     {
    "createTime": 1431569941000,
    "projectImage":"/v3/services/api/common/file/show/A8899250D7CA11E2B863BE292049461A/img.jpg",
    "joinStartTime": null,
    "groupName": null,
    "reportType": "",
    "isDefaultPost": "false",
    "location": null,
    "link": null,
    "endTime": 1447873200217,
    "creator": "948C4870DE8611E29B9900505699201D",
    "startTime": 1430931600217,
    "id": "95ECE0F0F9DF11E4A9E7305BE7D75F71",
    "projectStatus": "closed",
    "shareSpace": null,
    "description": null,
    "name": "myproject 2",
    "isdel": "1",
    "role": null,
    "joinState": 2,
    "isAddSpace": "no",
    "updatedTime": 1431569941000,
    "coverImage": null,
    "joinTemplate": null,
    "tags": "",
    "files": {
        "photo": [],
    },
    "videoUrl": null,
    "organizer": "123",
    "faq": null,
    "eVenue": null,
    "privacy": "private",
    "projectImageSrc":"A8899250D7CA11E2B863BE292049461A/img.jpg,
    D77F78F0D7C911E2B863BE292049461A/img.jpg",
    "code": "EFDEE5D7",
    "venue": "132",
    "eDescription": null,
    "projectViews": 34,
    "eName": null,
    "groupId": null,
    "project": null,
    "eOrganizer": null,
    "relatedEvent": "3D8EEB08",
    "isVisit": "no",
    "needReport": false,
    "owner": "948C4870DE8611E29B9900505699201D",
    "presidentMember": [
        
    ],
    "joinEndTime": null,
    "projectBanner": "",
    "__privacy": "private",
    "isJoin": true,
    "memberIds": [
        "948C4870DE8611E29B9900505699201D"
    ],
    "adminMemberIds": [
        "948C4870DE8611E29B9900505699201D"
    ],
    "photo": [
        
    ]
}     
   ```
     
* 提交数据说明：
   
   ```
    projectImageSrc:封面图片，shareSpace：分享空间，
    isAddSpace:是否允许成员自己加入分享空间,isDefaultPost:是否显示讨论，
    没有isAddSpaceImg、isAddSpacePost，files、members不必提交
  ```

##14.关注某一个项目

* URL:/v3/services/api/project/{0}/join
* Method:PUT
* 参数：
  
   ```     
    0：项目id(String)
   ```
* 提交数据结构：

   ```
   {
    otherSignData: {
        星座: "水瓶座"
    },
    signType: "p",
    sortLongNumber: "短号"
 }
   ```

      
* 提交数据说明：
   
   ```  
    如需填写表格，则提交填写数据，signType：报名类型（p\个人，g\团体）  
   ```  

* 错误代码：
    
    ```    
    {status_code: 404, error_msg: project is null" }
    ```  

## 15.取消关注某个项目

* URL:/v3/services/api/project/{0}/member
* Method:DELETE
* 参数：
    
     ```
    0：项目id(String)
      ```
* 返回：无  
* 错误代码：
    
     ```
    {status_code: 404, error_msg: "project is null" }
      ```

##16.分享空间

* URL:/v3/services/api/project/{0}/shareSpace?pageIndex=1
* Method:GET
* 参数：
   
     ```
    0:项目编号
      ```
* 返回：

     ```
     {
    "postList": [
        {
            content: "帖子类容",
            id: "D24137E0B42411E5AA366EA86F326711",
            imgs: [
                "CF49A2C0B42411E5AA366EA86F326711"
            ],
            commentCount: 0，followingsCount: 0，likesCount: 0,
            thumbsCount: 0,
            user: {
                id: "948C4870DE8611E29B9900505699201D",
                fullName: "林滨海",
                userName: "s_stu1@uat.stu.edu.cn",
                …
            },
            …
        },
        ...
    ],
    "isAddSpaceImg": false,
    "totalNum": 2,
    "files": {
        "photo": [
            
        ],
        "video": [
            
        ],
        "document": [
            
        ]
    },
    "totalPage": 1
    }
     ```
     
* 返回数据说明：
   
    ```
    postList:分享空间帖子，imgs帖子图片，files:photo,相册照片
    ```

##17.加入分享空间

* URL:/v3/services/api/project/{0}/shareSpace/{1}
* Method:PUT
* 参数：
   
   ```
    0:项目id，1:帖子id（需要加入分享空间的帖子）
    ```     
* 返回：无 


##18.移除分享空间

* URL:/v3/services/api/project/{0}/shareSpace/{1}
* Method:DELETE
* 参数：
  
    ```
    0:项目id，1:帖子id（需要加入分享空间的帖子）
       ```
* 返回：无

##19.项目详情(公开页面，不登录可以访问)

* URL:/v3/services/openapi/v1/project/{0}
* Method:GET
* 参数：
   
   ```
    0：项目id或项目code (String)
    ```
* 返回：

   ```
   {
    adminMembers: [
        [
            "948C4870DE8611E29B9900505699201D",
            "林滨海",
            "s_stu1@uat.stu.edu.cn",
            …
        ]
    ],
    code: "diyige1",
    projectImageSrc: "C3D793B0B41B11E5AA366EA86F326711/567753fbN3e6993db.jpg",
    files: {
        photo: [
            "/services/openapi/v1/file/show/CC5CD220B41B11E5AA366EA86F326711/120_90/127996109.jpg",
            …
        ],
        document: [
            
        ],
        video: [
            
        ]
    },
    members: {
        invite: [
            
        ],
        attend: [
            
        ],
        watch: [
            
        ],
        request: [
            
        ],
        leave: [
            
        ]
    },
    shareSpace: {
        4DF62890B41C11E5AA366EA86F326711: 0
    },
   
     }
   ```
             
* 返回数据说明：
   
   ```
    同项目详情返回数据，projectImageSrc:封面图片，files：photo、相册，members：成员，shareSpace：分享空间
   ```

##20.某一项目讨论(公开页面，不登录可以访问)

* URL:/v3/services/api/post/byProjectId/{0}?pageSize=5
* Method:GET
* 参数：
  
    ```
    0：项目id(String)
     ```
* 返回:
   
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

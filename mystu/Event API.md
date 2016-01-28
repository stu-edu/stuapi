MYSTU Event API 
================================
##说明
* 如未特别说明，返回数据的content-type均为application/json
* post提交返回code为201
* put提交返回code为200
* 如未特别说明，无错误代码


##1.最近活动

* URL:/v3/services/api/event/latest?pageSize=8&pageNo=1
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
               faq,
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
* 返回数据说明：

    ```
     fields与items的每一条数据的数组对应：
     eventStatus:活动状态，
     description：活动描述，
     startTime：活动开始时间，
     endTime：结束时间
     link：活动链接，
     venue：场地，
     tags：标签，
     code：活动编码，
     privacy：隐私设置，
     eventImageSrc：活动封面图，
     joinStartTime：报名开始时间，
     joinEndTime：报名结束时间，
     faq：常见问题，
     joinState：参加状态（0 没开始，1可以参加状态 ，2结束 ，3报名人数已满），
     eventViews：访问人数，
     members：成员，
     files：照片,
     adminMemberIds:管理员
    ```


##2.我的活动

* URL:/v3/services/api/event/myevents?pageSize=8&pageNo=1
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
      items:[["341DF710ADD011E5906186574088FD86",
             "uatAPI浏览记录测试",
              1451354544000,…],
              [...]],
      pageNo: 1,
      pageSize: 8,
      startIndex: 0,
      totalNum: 27,
      totalPage: 4
      }  
     ```


##3.我创建的活动


* URL:/v3/services/api/event/createdevents?pageSize=8&pageNo=1
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
      items:[["341DF710ADD011E5906186574088FD86",
            "uatAPI浏览记录测试",
             1451354544000,…],
              [...]],
      pageNo: 1,
      pageSize: 8,
      startIndex: 0,
      totalNum: 11,
      totalPage: 2
      } 
     ``` 

##4.流行的活动

* URL:/v3/services/api/event/trending?pageSize=8&pageNo=1
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
      items:[["341DF710ADD011E5906186574088FD86",
            "uatAPI浏览记录测试",
             1451354544000,…],
              [...]],
      pageNo: 1,
      pageSize: 8,
      startIndex: 0,
      totalNum: 1,
      totalPage: 1
      } 
    ```  

##5.团体活动

* URL:/v3/services/api/event/byGroupId?pageSize=8&pageNo=1&groupId={0}
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
        groupName: "金融协会",
        ename: "jinrongxiehui",
        …
    },
      fields: id,
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
    items: [
        [
            "7C6BC7B07D1D11E5A3E433627F4D8823",
            "征文大赛活动",
            1446000129000,
            …
        ],
        [
            ...
        ]
    ],
    pageNo: 1,
    pageSize: 8,
    startIndex: 0,
    totalNum: 60,
    totalPage: 8
}
    ```  
* 返回数据说明：
   ```
    additionalData:返回活动相关数据，admins：管理员，groupId：团体id，groupName：团体名称，ename：团体英文名称
   ```

##6.搜索活动

* URL:/v3/services/api/event/byName?pageSize=8&pageNo=1&name={0}&startTime={1}&endTime={2}
* Method:GET
* 参数：

    ```                       
    pageSize 每次查询返回数
    pageNo 当前页 
    0：团体id(String)
    1:活动开始时间(Long)
    2:活动结束时间(Long) 
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

* 返回数据说明：

     ```
    groupName:组织名称，parentId：上级id，最上级为空，
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
      items: [
        {
            createTime: "",
            groupName: "汕头大学青年志愿者协会",
            id: "10",
            parentId: "1",
            role: "",
            "owner": "",
            "status": null,
            "uri": "eventGroup/1",
            "version": 1
        },
            ...
    ],
    pageNo: 1,
    pageSize: 100,
    startIndex: 0,
    totalNum: 7,
    totalPage: 1
       }
    ```

* 返回数据说明：
    ```
    parentId:上层团体id
    ```

##9.搜索团体活动

* URL:/v3/services/api/event/byGroupId?pageSize=8&pageNo=1&groupId={0}
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
        groupName: "金融协会",
        ename: "jinrongxiehui",
        …
    },
       fields: id,
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
    items: [
        [
            "7C6BC7B07D1D11E5A3E433627F4D8823",
            "征文大赛活动",
            1446000129000,
            …
        ],
        [
            ...
        ]
    ],
    pageNo: 1,
    pageSize: 8,
    startIndex: 0,
    totalNum: 60,
    totalPage: 8
}
    ```
      
      
* 返回数据说明: 同第5点，团体活动
     

##10.创建活动

* URL:/v3/services/api/event
* Method:POST
* 参数：无
* 提交数据结构：

   ```
   {
    code: "A50B23C",
    description: "活动描述",
    eDescription: ,
    "英文活动描述",
    eName: "英文活动名称",
    eOrganizer: "英文活动主办人",
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
    maxPeople: "3",
    name: "活动名称",
    needReport: "true",
    organizer: "活动主办人",
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
      isPost:所有人发帖（0）管理员发帖（1），
      joinEndTime：报名开始时间，needReport：需要填写报名表格，joinTemplate：报名表格新增字段，
      link：活动链接，maxPeople，最大报名人数，privacy：隐私设置（private，friend，public），
      isVisit:(是否校外公开)，reportType：报名方式(p/个人,g/团体)，
   ```
* 错误代码：
    ```     
    {status_code: 400, error_msg: "name is too long" }，
    {status_code: 400, error_msg: "code is exist" }
     ```

##11.验证code是否存在

* URL:/v3/services/api/event/{0}/exist
* Method:GET
* 参数：
  
    ``` 
    0：活动编号code
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
* 返回数据说明：
    ```
    exists：是否存在该活动编号
    ```
      
##12.活动详情

* URL:/v3/services/api/event/{0}
* Method:GET
* 参数：
  
    ```
    0：活动id或活动code (String)
    ```
* 返回：
  
   ```
   {
    "joinStartTime": 1429632000000,
    "reportType": "p,",
    "location": null,
    "adminMembers": [
        [
            "DF0A05C4F8BF11E29D4600505699201D",
            "林滨海",
            "linbinhai",
            "9BAECBA0ADC311E594F417F9848717A1",
            "attend"
        ]
    ],
    "endTime": 1431768600000,
    "startTime": 1431734400000,
    "shareSpace": {
        "88CDB980F7E611E48FDFA691E1521057": 0,
        "9AFC9220F7E611E48FDFA691E1521057": 0,
        "9283D6D0F7E611E48FDFA691E1521057": 0
    },
    "description": " 汕头大学第一....",
    "role": null,
    "isPost": 0,
    "coverImage": null,
    "videoUrl": null,
    "organizer": "",
    "faq": null,
    "privacy": "public",
    "code": "B93ED205",
    "eDescription": null,
    "eName": null,
    "project": null,
    "eOrganizer": null,
    "owner": "BEB0ACD0BC6311E294259A23F2480654",
    "needReport": true,
    "maxPeople": null,
    "isVisit": null,
    "presidentMember": [
       
    ],
    "joinEndTime": 1431186900000,
    "isAddSpaceImg": null,
    "createTime": 1429629553000,
    "groupName": "模拟联合国协会",
    "link": "",
    "eventImageSrc": "A5.jpg",
    "creator": "BEB0ACD0BC6311E294259A23F2480654",
    "id": "C4B31C90E83911E491DE9729D40ABB5D",
    "isAddSpacePost": null,
    "name": "第一届汕头大学模拟联合国大会",
    "isdel": "1",
    "joinState": 2,
    "isAddSpace": false,
    "eventBanner": null,
    "members": {
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
    "updatedTime": 1431769515000,
    "tags": "",
    "joinTemplate": "[]",
    "files": {
        "photo": [
         "/services/openapi/v1/file/show/0C87BC60E89911E491DE9729D40ABB5D/120_90/代表招募海报.jpg"
        ],
        "video": [
            
        ],
        "document": [
            
        ]
    },
    "eVenue": null,
    "venue": "待定，短信通知",
    "groupId": "72",
    "eventViews": 157,
    "eventImage": null,
    "eventStatus": "closed"
}  

   ```

* 返回数据说明：
   ``` 
    eventImageSrc:封面图片，files：photo、相册，
    members：成员，shareSpace：分享空间
   ```

##13.修改活动

* URL:/v3/services/api/event/{0}
* Method:PUT
* 参数：
     
     ```
    0：活动id(String)
       ```
* 提交数据结构：
  
     ```
     {
    id: "57832E90B36211E5AEE57932A3FBC68D",
    code: "diyige1",
    eventImageSrc: "C3D793B0B41B11E5AA366EA86F326711/567753fbN3e6993db.jpg",
    shareSpace: {
        4DF62890B41C11E5AA366EA86F326711: 0
    },
    isAddSpace: "no",
    isAddSpaceImg: "no",
    isAddSpacePost: "no",
    ....
   }
   
     ``` 
      
* 提交数据说明：

   ```
      eventImageSrc:封面图片，shareSpace：分享空间，isAddSpace:是否允许成员自己加入分享空间,
      isAddSpaceImg：是否显示成员同一帖子所有图片，isAddSpacePost：是否显示成员所有帖子图片，
      files、members不必提交
   ```    


##14.参加某一个活动

* URL:/v3/services/api/event/{0}/join
* Method:PUT
* 参数：
    
    ```
    0：活动id(String)
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
    {status_code: 404, error_msg: "event is null" }
    ```

##15.取消参加某个活动

* URL:/v3/services/api/event/{0}/member
* Method:DELETE
* 参数：
    
    ``` 
    0：活动id(String)
      ``` 
* 返回：无   
* 错误代码：
    ```      
    {status_code: 404, error_msg: "event is null" }
      ```

##16.分享空间

* URL:/v3/services/api/event/{0}/shareSpace?pageIndex=1
* Method:GET
* 参数：
    
    ```
    0:活动编号
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

* URL:/v3/services/api/event/{0}/shareSpace/{1}
* Method:PUT
* 参数：
    
      ```
    0:活动id，1:帖子id（需要加入分享空间的帖子）
      ```
* 返回：无


##18.移除分享空间

* URL:/v3/services/api/event/{0}/shareSpace/{1}
* Method:DELETE
* 参数：
   
     ```     
    0:活动id，1:帖子id（需要加入分享空间的帖子）
       ```
* 返回：无  

##19.活动详情(公开页面，不登录可以访问)

* URL:/v3/services/openapi/v1/evnet/{0}
* Method:GET
* 参数：
    
     ```
    0：活动id或活动code (String)
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
    eventImageSrc: "C3D793B0B41B11E5AA366EA86F326711/567753fbN3e6993db.jpg",
    files: {
        photo: [
            "/services/openapi/v1/file/show/ CC5CD220B41B11E5AA366EA86F326711/120_90/127996109.jpg",
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
    ....
   }
     ```
     
* 返回数据说明：
     ```
    eventImageSrc:封面图片，files：photo、相册，members：成员，shareSpace：分享空间
      ```

##20.某一活动讨论(公开页面，不登录可以访问)

* URL:/v3/services/openapi/v1/post/byEventId/{0}?pageSize=5
* Method:GET
* 参数：
     
     ```
    0：活动id(String)
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
        items:[],
        pageNo: 1,
        pageSize: 5,
        startIndex: 0,
        totalNum: 0,
        totalPage: 1
        }  
     ```




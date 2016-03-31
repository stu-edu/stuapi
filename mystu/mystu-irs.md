MYSTU IRS API

================================
##说明
* 如未特别说明，返回数据的content-type均为application/json
* post提交返回code为201
* put提交返回code为200
* 如未特别说明，无错误代码


##1.开始上课

* URL:/v3/services/api/timeSpan
* Method:POST
* 参数：无
* 提交数据结构：

    ```
      {
         courseGroupId: 课程班级id，
         courseId: 课程id，
         timeSpanType: "Course"
      }              
    ```
* 提交数据说明：

    ```
      courseGroupId: 课程班级id，
      courseId: 课程id，
      timeSpanType: 类型为Course
    ```



##2.开始签到

* URL:/v3/services/api/timeSpan
* Method:POST
* 参数：无 
* 提交数据结构：

    ```
      {
         courseGroupId: 课程班级id，
         courseId: 课程id，
         parentId:  开始上课id
         timeSpanType: "SignIn"   
       }              
    ```
* 提交数据说明：

    ```
      courseGroupId: 课程班级id，
      courseId: 课程id，
      timeSpanType: 类型为签到SignIn， 
      parentId:开始上课id 
    ```

##3. 学生签到

* URL:/v3/services/api/question/answer
* Method:POST
* 参数：无
* 提交数据结构：

    ```
      {
         index: 0
       }              
    ```
* 提交数据说明：

    ```
      index：0为签到    
    ```

* 错误代码：

   ```
      status_code: 400
      1、error_msg: "i18n_irs_not_yet_started"，课程还未开始
      2、error_msg: "i18n_irs_no_signed_up" ，签到还未开始
      3、error_msg: "i18n_irs_leave"，已请假，不能签到!
      4、error_msg: "i18n_irs_already_signed_up"，已经成功签到
    ```
    
##4. 结束签到

* URL:/v3/services/api/timeSpan/{id}
* Method:PUT
* 参数：
    ```
    id:开始签到返回的id
    ```
* 提交数据结构：

    ```
      {
         beginTime：1459303856319,
         timeSpanType: "SignIn",
         id: "A3420C00F61C11E58A3ADCB1CD29572C"
       }              
    ```
* 提交数据说明：

    ```
    benginTime:开始时间，timeSpanType：类型为签到         
    ```

##5. 创建问题类别

* URL:/v3/services/api/questionCategory
* Method:POST
* 参数：无 
* 提交数据结构：

    ```
      {
         courseGroupId: "2597B9D2BEF411E3928B00505699201D",
         courseId: "A06343E2BEF011E3928B00505699201D",
         title: "历史"
       }              
    ```
* 提交数据说明：

    ```
    title：类别名称    
    ```

##6. 查询类别

* URL:/v3/services/api/questionCategory/{courseId}/{courseGroupId}
* Method:GET
* 参数：
    ```
    courseId:课程id，courseGroupId：班级分组id
     ```
* 返回：

    ```
      {
    "additionalData": null,
    "countHeadsStr": "",
    "entityType": "",
    "fields": "",
    "items": [
        {
            "courseGroupId": "2597B9D2BEF411E3928B00505699201D",
            "courseId": "A06343E2BEF011E3928B00505699201D",
            "createTime": 1459305982000,
            "creator": "948C4870DE8611E29B9900505699201D",
            "fields": [
                "id",
                "title",
                "courseId",
                "courseGroupId",
                "questionCount",
                "version",
                "owner",
                "creator",
                "createTime",
                "status"
            ],
            "id": "9684AFE0F62111E58A3ADCB1CD29572C",
            "owner": "948C4870DE8611E29B9900505699201D",
            "questionCount": 0,
            "status": "ACTIVE",
            "title": "历史",
            "uri": "questionCategory/9684AFE0F62111E58A3ADCB1CD29572C",
            "version": 0
        },
        .....
       
    ],
    "numFields": "",
    "orderByStr": "",
    "pageNo": 1,
    "pageSize": 10,
    "startIndex": 0,
    "totalNum": 8,
    "totalPage": 1
       }              
    ```
* 返回数据说明：

    ```
      pageNo：当前页，
      pageSize：每页个数，
      totalNum：总数，
      totalPage：总页数，
      items:返回的类别数组，
      title:类别名称，
      questionCount：该类别包含问题数量     
    ```

##7. 修改类别

* URL:/v3/services/api/questionCategory/id
* Method:PUT
* 参数：
    ```
     id:类别id
     ```
* 提交数据结构：

    ```
      {
           title: "历史"
       }              
    ```
* 提交数据说明：

    ```
      title：类别名称 
    ```

##8. 删除类别

* URL:/v3/services/api/questionCategory/id
* Method:DELETE
* 参数：
    ```
    id:类别id
    ```
* 提交数据结构：无

##9. 新增问题

* URL:/v3/services/api/question
* Method: POST
* 参数：无 
* 提交数据结构：

    ```
    "categoryId": "9684AFE0F62111E58A3ADCB1CD29572C",
    "allAnswer": [
        {
            "content": "答案1",
            "$$hashKey": "05R",
            "index": 1，
            "images": [
              {
                "name": "u%3D81328812%2C974646496%26fm%3D21%26gp%3D0.jpg",
                 "id": "D14523D0F63F11E58A3ADCB1CD29572C",
                "$$hashKey": "063"
              }
              ],
        },
        {
            "content": "答案2",
            "$$hashKey": "05S",
            "index": 2
        },
        {
            "content": "答案3",
            "$$hashKey": "05T",
            "index": 3
        }
    ],
    "examTimes": 2,
    "title": "测试问题2",
    "description": "1",
    "images": [
        {
            "name": "u%3D81328812%2C974646496%26fm%3D21%26gp%3D0.jpg",
            "id": "D14523D0F63F11E58A3ADCB1CD29572C",
            "$$hashKey": "063"
        }
    ],
    "standardIndex": "3",
    "courseId": "A06343E2BEF011E3928B00505699201D",
    "courseGroupId": "2597B9D2BEF411E3928B00505699201D"
               
    ```
* 提交数据说明：

    ```
    categoryId：类别id，没有类别为null，
    allAnswer：选项数组，包含每项的类容（content）第几个选项（index）含有图片（images），
    examTimes：默认测试时间（分），
    title：问题题目，
    description：描述，
    images：题目包含的图片数组，
    standardIndex：正确答案选项，
    ```

##10. 修改问题

* URL:/v3/services/api/question/{id}
* Method: PUT
* 参数：
    ```
    id：该问题的id
       ```
* 提交数据结构：

    ```
    "categoryId": "9684AFE0F62111E58A3ADCB1CD29572C",
    "allAnswer": [
        {
            "content": "改答案1",
            "$$hashKey": "05R",
            "index": 1，
            "images": [
              {
                "name": "u%3D81328812%2C974646496%26fm%3D21%26gp%3D0.jpg",
                 "id": "D14523D0F63F11E58A3ADCB1CD29572C",
                "$$hashKey": "063"
              }
              ],
        },
        {
            "content": "改答案2",
            "$$hashKey": "05S",
            "index": 2
        },
        {
            "content": "改答案3",
            "$$hashKey": "05T",
            "index": 3
        }
    ],
    id: "D71FB4A0F63F11E58A3ADCB1CD29572C",
    "examTimes": 2,
    "title": "测试问题2",
    "description": "1",
    "images": [
        {
            "name": "u%3D81328812%2C974646496%26fm%3D21%26gp%3D0.jpg",
            "id": "D14523D0F63F11E58A3ADCB1CD29572C",
            "$$hashKey": "063"
        }
    ],
    "standardIndex": "3",
    "courseId": "A06343E2BEF011E3928B00505699201D",
    "courseGroupId": "2597B9D2BEF411E3928B00505699201D"
               
    ```
* 提交数据说明：

    ```
    id：该问题的id，（其他同新增问题说明）
    ```

##11. 删除问题

* URL:/v3/services/api/question/{id}
* Method: DELETE
* 参数：
    ```
    id:该问题的id
    ```
* 提交数据结构：无


##12. 查询问题

* URL:/v3/services/api/question/{courseId}/{courseGroupId}/{categoryId}
* Method: GET
* 参数：
    ```
    courseId:课程的id，
    courseGroupId:班级分组id，
    categoryId类别id（所有问题为-1）
    
    ```
* 返回：

    ```
    "additionalData": null,
    "countHeadsStr": "",
    "entityType": "Question",
    "fields": "id,
              title,
              description,
              examCount,
              categoryId",
    "items": [
        [
            "D71FB4A0F63F11E58A3ADCB1CD29572C",
            "测试问题2",
            "1",
            0,
            "9684AFE0F62111E58A3ADCB1CD29572C"
        ],
        ....
    ],
    "numFields": "",
    "orderByStr": "createTime desc",
    "pageNo": 1,
    "pageSize": 50,
    "startIndex": 0,
    "totalNum": 10,
    "totalPage": 1            
    ```
* 返回数据说明：

    ```
      fields字段与items数组里面每一项相对应，
      title：问题题目，
      description：描述，
      examCount：提问次数，
      categoryId：类别id
    ```

##13. 开始提问

* URL:/v3/services/api/question/{id}
* Method: GET
* 参数：
    ``` id：问题id，
       ```
* 返回：

    ```
    "standardIndex": 3,
    "createTime": 1459318975000,
    "examCount": 0,
    "allAnswer": [
        {
            "content": "答案1",
            "createTime": 1459318975000,
            "creator": "948C4870DE8611E29B9900505699201D",
            "fields": [
                "id",
                "content",
                "questionId",
                "images",
                "index",
                "version",
                "owner",
                "creator",
                "createTime",
                "status"
            ],
            "id": "D7218960F63F11E58A3ADCB1CD29572C",
            "images": [],
            "index": 1,
            "owner": "948C4870DE8611E29B9900505699201D",
            "questionId": "D71FB4A0F63F11E58A3ADCB1CD29572C",
            "status": "ACTIVE",
            "uri": "answer/D7218960F63F11E58A3ADCB1CD29572C",
            "version": 0
        },
        ......
            ],
    "status": "ACTIVE",
    "categoryId": "9684AFE0F62111E58A3ADCB1CD29572C",
    "version": 0,
    "creator": {
        "id": "948C4870DE8611E29B9900505699201D",
        "fullName": "林滨海",
        "userName": "s_stu1@uat.stu.edu.cn",
        "logoUrl": "28BD3960869B11E4B49A4BEAC3FC57F9",
        "displayName": "林滨海."
    },
    "id": "D71FB4A0F63F11E58A3ADCB1CD29572C",
    "title": "测试问题2",
    "description": "1",
    "owner": "948C4870DE8611E29B9900505699201D",
    "examTimes": 2,
    "images": [
        {
            "byteContent": [],
            "content": null,
            "createTime": 1459318965000,
            "creator": "948C4870DE8611E29B9900505699201D",
            "data1": "D71FB4A0F63F11E58A3ADCB1CD29572C",
            "description": "",
            "entityId": "D71FB4A0F63F11E58A3ADCB1CD29572C",
            "entityName": "Question",
            "fields": [
                "id",
                "version",
                "owner",
                "creator",
                "createTime",
                "status"
            ],
            "height": 220,
            "id": "D14523D0F63F11E58A3ADCB1CD29572C",
            "keyWords": "",
            "name": "u=81328812,974646496&fm=21&gp=0.jpg",
            "owner": "948C4870DE8611E29B9900505699201D",
            "status": "ACTIVE",
            "type": "jpg",
            "uri": "common/file/D14523D0F63F11E58A3ADCB1CD29572C",
            "version": 1,
            "width": 352
        }
    ]          
    ```
* 返回数据说明：

    ```
      standardIndex：选项正确答案，
      examCount：测验次数，
      allAnswer：所有的答案选项数组（类容说明同新增问题），
      categoryId：类别id，
      title：问题题目，
      description：问题描述，
    ```


##14. 开始测验

* URL:/v3/services/api/timeSpan
* Method: POST
* 参数:无  
* 提交数据结构：

    ```
    courseGroupId: "2597B9D2BEF411E3928B00505699201D"
    courseId: "A06343E2BEF011E3928B00505699201D"
    examTimes: 2
    parentId: "FC52E180F64311E58A3ADCB1CD29572C"
    questionId: "D71FB4A0F63F11E58A3ADCB1CD29572C"
    timeSpanType: "Exam"
    ```
* 提交数据说明：

    ```
      courseGroupId：班级分组id，
      courseId，课程id，
      examTimes：测验时间，
      parentId：开始上课返回的id，
      questionId：问题id，
      timeSpanType：类型问测验 Exam
   
    ```

##15. 学生提交答案

* URL:/v3/services/api/question/answer
* Method: POST
* 参数:无  
* 提交数据结构：

    ```
    index: "2"
    ```
* 提交数据说明：

    ```
    index:提交1-9的答案
    ```

* 错误代码：

  ```
    status_code: 400
    1、error_msg: "i18n_irs_already_submitted_answer",你已经提交过答案
    2、error_msg: "i18n_irs_not_yet_started",还没有开始上课
    3、error_msg: "i18n_irs_no_quiz_is_available",没有问题进行提问
    4、error_msg: "i18n_irs_quiz_as_you_did_not_sign_up",您还未签到，不能答题
    5、error_msg: "i18n_irs_quiz_as_you_are_on_leave",您状态为请假，不能答题
    6、error_msg: "i18n_irs_the_answer_you_chose_is_invalid",择的答案不存在，请重新选择

    ```
    
##16. 签到请假、迟到

* URL:/v3/services/api/signIn
* Method: POST
* 参数：无  
* 提交数据结构：

    ```
     timeSpanId: "FC638350F64311E58A3ADCB1CD29572C"
     type: "Late"
     userId: "ABC36630BC6311E294259A23F2480654"
    ```
* 提交数据说明：

    ```
     timeSpanId：本次签到开始返回的id，
     type：签到类型（Late迟到，Leave请假），
     userId：学生id
    ```

##17. 学生签到、答题状态

* URL:/v3/services/api/timeSpan/{signid}/{examid}/statusList
* Method: GET
* 参数：  
    ``` 
    signid：开始签到返回的id，examid：开始测验返回的id
       ``` 
* 返回：

    ```
     {
        "FFADD9DC68FD11E38A8E00505699201D": {
            "signIn": "SignIn",
            "exam": true
        },
        "262C5BE0BBCC11E2BEDE5CB5DFAE6554": {
            "signIn": "Absent"
        },
        ......
    }
    ```
* 返回数据说明：

    ```
      “FFADD9DC68FD11E38A8E00505699201D“：每个学生的id,
      signIn:是否签到（SignIn签到，Absent缺席，Late迟到，Leave请假）
      exam：是否答题
    ```

##18. 答题统计1

* URL:/v3/services/api/timeSpan/{examid}/{signid}/examPieChart
* Method: GET
* 参数：
    ```
    examid：开始测验返回的id， 
    signid：开始签到返回的id，
      ```
* 返回：

    ```
     {
        error: 0
        notAnswer: 1
        right: 1
    }
    ```
* 返回数据说明：

    ```
      error:错误数量，
      notAnswer：未答题数量，
      right：正确数量
    ```

##19. 答题统计2

* URL:/v3/services/api/timeSpan/{examid}/answerSelectedInfo
* Method: GET
* 参数： 
   ```
    examid：开始测验返回的id，
    ```   
* 返回：

    ```
    {
    "standardIndex": 3,
    "selectedInfo": {
        "1": [],
        "2": [],
        "3": [
            {
                "id": "FFADD9DC68FD11E38A8E00505699201D",
                "fullName": "廖会林",
                "userName": "huilinliao",
                "logoUrl": "AE7664C07AC811E49CB389F7EA68664C",
                "displayName": "廖会林"
            }
        ]
       }
    }
    ```
* 返回数据说明：

    ```
      standardIndex：正确答案，
      selectedInfo：每个选项选择情况数组（包含用户基本信息）
    ```

##20. 结束上课

* URL:/v3/services/api/timeSpan/{courseId}/{courseGroupId}/unfinished
* Method: POST
* 参数：
    ```
    courseId:课程id，
    courseGroupId，班级分组id
     ```
* 提交数据结构：无

##21.立即提问

* URL:/v3/services/api/timeSpan
* Method: GET
* 参数：
    ```courseId:课程id，courseGroupId，班级分组id
     ```   
* 提交数据结构：

    ```
      courseGroupId: "2597B9D2BEF411E3928B00505699201D"
      courseId: "A06343E2BEF011E3928B00505699201D"
      description: "这个问题？"
      timeSpanType: "Temp"
     ```
* 提交数据说明：

    ```
      description：问题描述，
      timeSpanType：类型为Temp
    ```

##22.立即提问结果查询

* URL:v3/services/api/timeSpan/{tempId}/tempUserList
* Method: GET
* 参数：
    ```
    tempId:立即提问返回的结果
     ```
* 返回：

    ```
    [
        {
        "createTime":
        "creator": "FFADD9DC68FD11E38A8E00505699201D",
        "fields": [
            "id",
            "timeSpanId",
            "userId",
            "isRight",
            "version",
            "owner",
            "creator",
            "createTime",
            "status"
        ],
        "id": "AD7A6920F65211E5B09378BA24BCA242",
        "isRight": false,
        "owner": "FFADD9DC68FD11E38A8E00505699201D",
        "selectedIndex": 3,
        "status": "ACTIVE",
        "timeSpanId": "422BD1A0F65111E5B7034E8340D41DB3",
        "uri": "exam/AD7A6920F65211E5B09378BA24BCA242",
        "userId": "FFADD9DC68FD11E38A8E00505699201D",
        "version": 0
       }，
       .....
    ]
    
     ```
* 返回数据说明：

    ```
      selectedIndex:选择的答案，
      timeSpanId：立即提问返回的id，
      userId：答题人id
   
    ```

##23.立即提问数据统计1

* URL:/v3/services/api/timeSpan/{tempId}/tempExamPieChart
* Method: GET
* 参数： 
    ```
    tempId:立即提问的id  
      ```
* 返回：

    ```
    {
    "1": 0,
    "2": 0,
    "3": 0,
    "4": 0,
    "5": 0,
    "6": 0,
    "7": 0,
    "8": 0,
    "9": 1
    }
    
     ```
* 返回数据说明：

    ```
      1-9，每个选项答题的人数
    ```

##24.立即提问数据统计2

* URL:/v3/services/api/timeSpan/{tempId}/tempAnswerSelectedInfo
* Method: GET
* 参数：
    ```
    tempId:立即提问的id
     ```
* 返回：

    ```
    {
    "selectedInfo": {
        "1": [],
        "2": [],
        "3": [],
        "4": [],
        "5": [],
        "6": [],
        "7": [],
        "8": [],
        "9": [
            {
                displayName: "廖会林"
                fullName: "廖会林"
                id: "FFADD9DC68FD11E38A8E00505699201D"
                logoUrl: "AE7664C07AC811E49CB389F7EA68664C"
                 userName: "huilinliao"
            }
        ]
    }
   }
    
     ```
* 返回数据说明：

    ```
      1-9，每个选项答题的人员数组
    ```

##25.结束立即提问

* URL:/v3/services/api/timeSpan/{tempId}/endTempTimeSpan
* Method: POST
* 参数：
   ```
    tempId:立即提问的id
   ```
* 提交数据结构：

    ```
    {
      id: "422BD1A0F65111E5B7034E8340D41DB3"，
      timeSpanType: "Temp"
    
   }
    
     ```
* 提交数据说明：

    ```
      timeSpanType：类型为Temp
    ```

##26.修改立即提问问题

* URL:/v3/services/api/timeSpan/{id}
* Method: POST
* 参数：
    ```
     id:立即提问的id
      ```
* 提交数据结构：

    ```
   {
    "id": "422BD1A0F65111E5B7034E8340D41DB3",
    "description": "这个是什么"
    }    
     ```
* 提交数据说明：

    ```
      description：问题题目
    ```



























  


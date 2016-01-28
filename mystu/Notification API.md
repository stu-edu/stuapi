MYSTU Notification API
================

##1、获取未读通知
* URL： /services/api/notification/unread
* Method: GET
* 参数： 无
* 返回：
 
 ```
    {
        "total":4,
        "notifications":[
            {
            "id":"568dd923e4b0df9293108d42",
            "sourceId":"75244110A53811E594F417F9848717A1",
            "sourceName":null,
            "sourceUrl":"/v3/discussion/index.jsp#/post/75244110A53811E594F417F9848717A1",
            "authorUserName":"15xychen3",
            "authorName":"陈翔宇",
            "authorIcon":null,
            "authorDescription":null,
            "authorUrl":null,
            "content":"陈翔宇赞了林滨海的帖子",
            "contentDescription":"陈翔宇赞了林滨海的帖子",
            "contentText":"",
            "contentUrl":"/v3/discussion/index.jsp#/post/75244110A53811E594F417F9848717A1",
            "createTime":1452136739642,
            "category":8,//通知类型
            "recipientId":"47120150BC6411E294259A23F2480654",
            "data1":"post_liked",
            "data2":"陈翔宇",
            "data3":"林滨海",
            "data4":"C28972472F2F11E5A9630050568C74A4",
            "data5":"111"},
            ...
            ]
    }
 ```

##2、获取最近通知
* URL： /services/api/notification/more
* Method: GET
* 参数：

 ```
 pageNo
 pageSize
 categories 可以多个类型，多个时以逗号隔开
 ```
* 返回：

 ```
 [
        {
        "id":"568dd923e4b0df9293108d42",
        "sourceId":"75244110A53811E594F417F9848717A1",
        "sourceName":null,
        "sourceUrl":"/v3/discussion/index.jsp#/post/75244110A53811E594F417F9848717A1",
        "authorUserName":"15xychen3",
        "authorName":"陈翔宇",
        "authorIcon":null,
        "authorDescription":null,
        "authorUrl":null,
        "content":"陈翔宇赞了林滨海的帖子",
        "contentDescription":"陈翔宇赞了林滨海的帖子",
        "contentText":"",
        "contentUrl":"/v3/discussion/index.jsp#/post/75244110A53811E594F417F9848717A1",
        "createTime":1452136739642,
        "category":8,//通知类型
        "recipientId":"47120150BC6411E294259A23F2480654",
        "data1":"post_liked",
        "data2":"陈翔宇",
        "data3":"林滨海",
        "data4":"C28972472F2F11E5A9630050568C74A4",
        "data5":"111"},
        ...
        ]
 ```
 
##3、设置所有通知为已读
* URL： /services/api/notification/updateAllToRead
* 参数：无
* Method: POST
* 返回：无


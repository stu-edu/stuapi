MYSTU Schedule API 
================================
## 1. 根据指定的起止时间及类别获取事件
* URL: /services/api/userschedule/query
* METHOD: GET
* 参数：

    ```
    category          类型campus course private exam
    startTime         给定开始的时间戳
    endTime           给定结束的时间戳
    pageNo            指定返回分页数据的第几页，默认为1
    pageSize          指定返回分页数据条数，默认50，最大不超过500.
    orderStr          排序方式，值可为 category,title,startTime,endTime
    ```
* 返回：
    
    ```
    {
      countHeadsStr: "", 
      fields:    "id,
                  createTime,      //创建时间
                  senderLdap,      //创建人
                  userLdap,        //用户帐号 
                  category,        //分类 campus course private exam
                  title,           //事件名称
                  description,     //事件描述
                  startTime,       //开始时间（时间戳）
                  endTime,         //结束时间（时间戳）
                  allDay,          //是否全天事件 1 是 0 否    
                  url,             //事件链接
                  location,        //地址
                  allowEditing,    //是否运行自行编辑  1 是 0 否 
                  status",         //状态  1 已完成  0未完成 
      items: [
            [
                  1322, 
                  1352195169000, 
                  null, 
                  "trainer", 
                  "private", 
                  "meeting", 
                  "meeting", 
                  1352196000000, 
                  1352197800000, 
                  0, 
                  "http://booking.stu.edu.cn", 
                  "meeting room", 
                  0, 
                  1
            ], 
            ..,
      orderByStr: " startTime desc", 
      pageNo: 1, 
      pageSize: 3, 
      startIndex: 0, 
      totalNum: 9, 
      totalPage: 1
    }
    ```
    
## 2. 根据指定的月份获取事件
* URL: /services/api/userschedule/eventsbymonth
* METHOD: GET
* 参数：

    ```
    month:            类型,格式如201304
    pageNo            指定返回分页数据的第几页，默认为1
    pageSize          指定返回分页数据条数，默认50，最大不超过500.
    orderStr          排序方式，值可为 category,title,startTime,endTime
    ```
* 返回：
    
    ```
    {
      countHeadsStr: "", 
      fields:    "id,
                  createTime,      //创建时间
                  senderLdap,      //创建人
                  userLdap,        //用户帐号 
                  category,        //分类 campus course private exam
                  title,           //事件名称
                  description,     //事件描述
                  startTime,       //开始时间（时间戳）
                  endTime,         //结束时间（时间戳）
                  allDay,          //是否全天事件 1 是 0 否    
                  url,             //事件链接
                  location,        //地址
                  allowEditing,    //是否运行自行编辑  1 是 0 否 
                  status",         //状态  1 已完成  0未完成 
      items: [
            [
                  1322, 
                  1352195169000, 
                  null, 
                  "trainer", 
                  "private", 
                  "meeting", 
                  "meeting", 
                  1352196000000, 
                  1352197800000, 
                  0, 
                  "http://booking.stu.edu.cn", 
                  "meeting room", 
                  0, 
                  1
            ], 
            ..,
      orderByStr: " startTime desc", 
      pageNo: 1, 
      pageSize: 3, 
      startIndex: 0, 
      totalNum: 9, 
      totalPage: 1
    }
    ```
 
## 3. 获取最新的事件
* URL: /services/api/userschedule/latestevents
* METHOD: GET
* 参数：

    ```
    pageNo            指定返回分页数据的第几页，默认为1
    pageSize          指定返回分页数据条数，默认50，最大不超过500.
    orderStr          排序方式，值可为 category,title,startTime,endTime
    ```
* 返回：
    
    ```
    {
      countHeadsStr: "", 
      fields:    "id,
                  createTime,      //创建时间
                  senderLdap,      //创建人
                  userLdap,        //用户帐号 
                  category,        //分类 campus course private exam
                  title,           //事件名称
                  description,     //事件描述
                  startTime,       //开始时间（时间戳）
                  endTime,         //结束时间（时间戳）
                  allDay,          //是否全天事件 1 是 0 否    
                  url,             //事件链接
                  location,        //地址
                  allowEditing,    //是否运行自行编辑  1 是 0 否 
                  status",         //状态  1 已完成  0未完成 
      items: [
            [
                  1322, 
                  1352195169000, 
                  null, 
                  "trainer", 
                  "private", 
                  "meeting", 
                  "meeting", 
                  1352196000000, 
                  1352197800000, 
                  0, 
                  "http://booking.stu.edu.cn", 
                  "meeting room", 
                  0, 
                  1
            ], 
            ..,
      orderByStr: " startTime desc", 
      pageNo: 1, 
      pageSize: 3, 
      startIndex: 0, 
      totalNum: 9, 
      totalPage: 1
    }
    ```
## 4. 创建新的日历事件
* URL: /services/api/userschedule
* METHOD: POST
* 参数：
    
    ```
    {
        "createTime": 1452848642966,
        "status": "ACTIVE",
        "location": "中山纪念堂",
        "allDay": 0,
        "endTime": 1452434400000,
        "url": "https://xyh.stu.edu.cn",
        "id": "EC4A51A0BB6611E59B294F8FF0EE2272",
        "startTime": 1452425400000,
        "senderLdap": null,
        "category": "personal",
        "title": "汕大好声音",
        "senderUserId": null,
        "description": "汕头大学校友演唱会",
        "userId": "568AE850BBCD11E2BEDE5CB5DFAE6554",
        "userLdap": "junweichen",
        "allowEditing": null
    }
    ```
* 返回：
    {"success":true}
* 说明：   
    
    ```
    {
        "createTime": 创建时间戳,
        "status": "状态",
        "location": "地址",
        "allDay": 是否全体事件,
        "endTime": 结束时间戳,
        "url": "链接url",
        "id": "Id",
        "startTime": 开始时间戳,
        "senderLdap": "发送者帐号", //从活动引入日程时候用到
        "category": "类别",
        "title": "标题",
        "senderUserId": "发送者Id",
        "description": "描述",
        "userId": "用户Id",
        "userLdap": "用户帐号",
        "allowEditing": 是否允许编辑
    }
    ```

DEMO
====


### 取学生成绩信息	
* 方法 GetStudentCJB
* URL `http://StuWebService.stu.edu.cn/wxjf.asmx`
* 参数

```
   f_xskey	学号 int
```
* 返回

```
    xnxq_name 学期 
    kc_name 课程名 
    xf_no 学分  
    cj_name 成绩  
```
* Memo 此API为传统WEB Service 调用
 
## 1. Create User
* Method: POST
* Url: /user
* Parameters: web form
```
    username
    age integer型
```
* return:
```
    {
      "id":"",
      "username":""
    }
```
* Memo: 成功返回状态201，用户名被使用返回409

##2. Get User
* Method: get
* Url: /user?id={id}
* Parameters:  
```
      id 用户id
```
* return:
```
    {
      "id":"",
      "username":""
    }
```

##3. change user name
* Method: PUT
* Url: /user
* Parameters: content, application/json
```
    {
        "id":""
        "username":""
    }
```
* return:
```
    {
      "id":"",
      "username":""
    }
```
* AA
 * bb

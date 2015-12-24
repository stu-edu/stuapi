### DEMO
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

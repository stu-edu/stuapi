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

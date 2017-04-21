Exam Schedule Api Document
==========================

## 获取考试安排信息
* URL: /credit/api/examschedule/{semester}
* Method: GET
* 参数: 
  ```  "semester":"20161"  ```       
* 返回:

 ```    
 [
 { 
 "examClass": "14396",
 "course": "[ELC1]英语(ELC1)",
 "examDate": "2017-01-03", 
 "examTime": "08:00-10:00",
 "location": "E301",            
 "week": "17",            
 "weekDay": "2",
 "session": "1",            
 "examTimeDesc": "第17周星期二第1场(2017.01.03 08:00-10:00)", 
 "examInvigilator": "吴佩莎"        
 },    
 ...
 ]
```

#Exam Schedule Api Document#

><h4 id="top">目录</h4>

[1. 获取考试安排信息](#1. Exam Schedule Info)

><h4 id="1. Exam Schedule Info">1.获取考试安排信息 </h4>

* URL: /api/creditinfo/examschedule/{semester}
* Method: GET
* 参数: 

  ```
  "semester":"20161"
  ```   
    
* 返回: 

    考试安排信息
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
        {
            "examClass": "14477",
            "course": "[HED6310A]科学技术史",
            "examDate": "2017-01-04",
            "examTime": "16:00-18:00",
            "location": "E305",
            "week": "17",
            "weekDay": "3",
            "session": "4",
            "examTimeDesc": "第17周星期三第4场(2017.01.04 16:00-18:00)",
            "examInvigilator": "陈宏喜"
        },
        {
            "examClass": "14528",
            "course": "[SOC6140A]中国近现代史纲要[SOC0630]",
            "examDate": "2017-01-06",
            "examTime": "10:30-12:30",
            "location": "E408",
            "week": "17",
            "weekDay": "5",
            "session": "2",
            "examTimeDesc": "第17周星期五第2场(2017.01.06 10:30-12:30)",
            "examInvigilator": "许艳民"
        },
        {
            "examClass": "14535",
            "course": "[MAT1901A]微积分C-I",
            "examDate": "2017-01-06",
            "examTime": "16:00-18:00",
            "location": "E308",
            "week": "17",
            "weekDay": "5",
            "session": "4",
            "examTimeDesc": "第17周星期五第4场(2017.01.06 16:00-18:00)",
            "examInvigilator": "谷敏强"
        },
        {
            "examClass": "14787",
            "course": "[CHI1101A]现代汉语A[CHI1010]",
            "examDate": "2017-01-04",
            "examTime": "19:00-21:00",
            "location": "E阶梯教室102",
            "week": "17",
            "weekDay": "3",
            "session": "5",
            "examTimeDesc": "第17周星期三第5场(2017.01.04 19:00-21:00)",
            "examInvigilator": "邓小琴"
        },
        {
            "examClass": "14789",
            "course": "[CHI1103A]外国文学A[CHI1070]",
            "examDate": "2017-01-10",
            "examTime": "16:00-18:00",
            "location": "讲堂二",
            "week": "18",
            "weekDay": "2",
            "session": "4",
            "examTimeDesc": "第18周星期二第4场(2017.01.10 16:00-18:00)",
            "examInvigilator": "彭小燕"
        },
        {
            "examClass": "14798",
            "course": "[CHI1102A]中国现代文学",
            "examDate": "2017-01-09",
            "examTime": "19:00-21:00",
            "location": "E阶梯教室101",
            "week": "18",
            "weekDay": "1",
            "session": "5",
            "examTimeDesc": "第18周星期一第5场(2017.01.09 19:00-21:00)",
            "examInvigilator": "彭志恒"
        }
    ]
    ```
   
* 说明: 

  ```
  semeter：传入学期url参数
  examClass：考试班号
  examDate：考试日期
  examTime：考试时间
  location：考试地点
  week：周次
  weekdy：星期几（周日为7 ）
  session：场次
  examTimeDesc：具体时间描述
  examInvigilator：监考老师
  
  ```  
     
 [top](#top)
STU API
=======

## ͨ��˵��
* �������APIʱ��accessToken�ѹ��ڣ�����http statusΪ401���û������µ�¼��

## 1.��ȡ�û���Ϣ
* ������GET
* URL��https://[domain]/services/api/profile/self
* ��������
* ����ֵ��
```
{
	"id": "�û�id",
	"username": "�û���",
	"email": "�����ʼ�",
	"fullName": "����",
	"englishName": "Ӣ����",
	"logoUrl": "��ǰͷ��",
	"coverImage": "��ǰ����",
	��role��:���û���ɫ��, // studentѧ����faculty��ʦ
	"studentId": "ѧ��" //ѧ�����д��ֶ�
	��teacherId��:����ʦ��š� //��ʦ���д��ֶ�
}
```

## 2.��ȡ�γ���Ϣ
* ������GET
* URL��https://[domain]/services/api/courses/self
* ��������
* ����ֵ��
```
        [
            {
              "id":" 06D131FB431A11E4B8450050568C74A4",
              "courseName":" MYSTU Help",
              "classId":"3527", 
              "role":" teacher",
              "url":"https://my.stu.edu.cn/courses/campus/course/view.php?id=3529",
              "attendanceYear":" 2014",
              "attendanceSemester":" 1"
            },
            {
              "id":"46E883CC461911E3A98400505699201D",
              "courseName":" MYSTU Team",
              "classId":"2369", 
              "role":" teacher",
              "url":"https://my.stu.edu.cn/courses/campus/course/view.php?id=2369",
              "attendanceYear":" 2013",
              "attendanceSemester":" 2"
            }
        ] 
```

## 3.��ȡ�γ̳�Ա
* ������GET
* URL��https://[domain]/services/api/courses/[classId]/members
* ������classId ���ӿ�2��classId�����ΰ�id
* ����ֵ��
```  
 [{
        "studentId": "2014101007",
        "username": "junweichen",
        "fullName": "�¿�ΰ",
        "englishName": "Andy Chen",
        "college":"��ѧԺ",
        "major":"�������ѧ�뼼��",
        "attendanceYear":"2014",
        "role":"student"
    }]
```

## 4.��ȡ�γ̻
* ������GET
* URL��https://[domain]/services/api/courses/[classId]/activities/[filter]
* ������classId/filter->["resource","assignment","all"]
* ����ֵ�� 
```
[
        {
            "id": "46E883CC461911E3A98400505699201D",
            "createdAt": 1343022549,
            "courseId": "629934F4420411E3A98400505699201D",
            "courseName": "MYSTU Team",
            "sectionId": 1235,
            "sectionName": "��һ��",
            "activityId": 431265,
            "activityTitle": "��һ����ҵ",
            "activityCategory": "assignment",
            "activityCategoryLogo": "�ͼ��",
            "activityDescription": "������������420�ֽڡ�",
            "activityUrl": "https://my.stu.edu.cn/moodle/campus/assignment/view.php?id=431265",
            "attachmentUrl": [],
            "additionalUrl": [],
            "additionalStartDate": 1343022549,
            "additionalEndDate": 1343022549,
            "additionalDueDate": 1343022549
        },
        {
            "id": "46E883CC461911E3A98400505699201C",
            "createdAt": 1343022509,
            "courseId": "629934F4420411E3A98400505699201C",
            "courseName": "MYSTU Team",
            "sectionId": 1234,
            "sectionName": "��һ��",
            "activityId": 431264,
            "activityTitle": "�μ�1.pdf",
            "activityCategory": "resource",
            "activityCategoryLogo": "�ͼ��",
            "activityDescription": "������������420�ֽڡ�",
            "activityUrl": "https://my.stu.edu.cn/moodle/campus/resource/view.php?id=431264",
            "attachmentUrl": [
                "http://my.stu.edu.cn/course_campus/uuid.pdf"
            ],
            "additionalUrl": [
                "http://www.wikimedia.com"
            ],
            "additionalStartDate": 1343022549,
            "additionalEndDate": 1343022549,
            "additionalDueDate": null
        }
    ]
```

## 5.��ȡѧ���ɼ�
* ������GET
* URL��https://[domain]/services/api/xuefenzhi/chengjibiao/[studentId]
* ������    studentId ѧ��
* ����ֵ��  


## 6.��ȡ�γ̱�
* ������  ��ȡ�γ̱�
* URL��    https://[domain]/services/api/xuefenzhi/kechengbiao/[studentIdOrTeacherId]/[term]
* ������    
 * studentIdOrTeacherId ѧ��ѧ�Ż��ʦ���
 * term ѧ��ѧ�� 
* ����ֵ��  


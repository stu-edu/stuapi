============
mystu_v3 resources API
============

## 1. 搜索资源(图书、文档、期刊、学位论文)

* URL: /v3/services/api/resources/search
* Method: GET
* Param: 
  
     ```
     {
        searchKey: 关键字,
        searchType: 资源类型 1=图书 3=文档 5=期刊 6=学位论文
     
     }
     ```
* return:

     ```
     searchType=1
     [
        {
            
            bookname: 名称,
            coverurl: 封面地址,
            introduce: 图书相关介绍,
            keyword: 图书搜索关键字(html代码),
            price: 价格,
            publishDate: 出版日期,
            publisher: 出版社,
            url: 图书详细地址相关参数(http://book.duxiu.com/bookDetail.jsp),
            hasCollect: 是否已经收藏,
            author: 作者
        },
        ...
     ]
     
     searchType=3
     [
         {
             url: 文档详细地址,
             title: 文档标题,
             summary: 文档相关介绍,
             hasCollect: 是否已经收藏,
             uperson: 作者
         }
     ]

     searchType=5
     [
         {
             url: 期刊详细地址相关参数(http://jour.duxiu.com/JourDetail.jsp),
             title: 期刊标题,
             introduce: 期刊介绍,
             hasCollect: 是否已经收藏,
             author: 作者
         }
     ]
     
     searchType=6
     [
         {
             url: 学问论文详细地址相关参数(http://jour.duxiu.com/thesisDetail.jsp),
             title: 论文标题,
             introduce: 介绍,
             hasCollect: 是否已经收藏,
             author: 作者
         }
     ]
     ```

## 2. 在推荐图书列表中搜索图书

* URL: /v3/services/api/resources/searchBySuggest
* Method: GET
* params: 

    ```
    {
        searchKey: 搜索关键字
    }
    ```
* return：
    
    ```
    [
        {
            resourcesName: 名称,
            author: 作者,
            contentUrl: 详细地址,
            imgUrl: 封面地址,
            introduce: 相关介绍
        },
        ...
    ]
    ```
    
## 3. 获取当前用户收藏的资源信息

* URL: /v3/services/api/resources/getMyResources
* Method: GET
* params: 

    ```
    {
        pageNo: 当前页,
        pageSize: 每页记录数
    }
    ```
* return：
    
    ```
    [
        {
            resourcesId: ID,
            owner: 收藏用户,
            collectTime: 收藏时间,
            resourcesName: 名称,
            introduce: 描述,
            contentUrl: 详细地址,
            imgUrl: 资源封面,
            author: 作者,
            resourcesType: 类型 (1=图书 3=文档 5=期刊 6=学位论文)
        }
    ]
    ```
    
## 4. 收藏资源

* URL: /v3/services/api/resources/addResources
* Method: POST
* params: 

    ```
    {
        resourcesId: ID,
		resourcesName: 名称,
		introduce: 描述,
		contentUrl: 详细地址,
		imgUrl: 封面,
		author: 作者,
		resourcesType: 类型 (1=图书 3=文档 5=期刊 6=学位论文)
    }
    ```
* return: 
    
    ```
    {
        id: 收藏记录ID,
        resourcesId: ID,
		resourcesName: 名称,
		introduce: 描述,
		contentUrl: 详细地址,
		imgUrl: 封面,
		author: 作者,
		resourcesType: 类型 (1=图书 3=文档 5=期刊 6=学位论文)
    }
    ```
    
## 5. 移除收藏

* URL: /v3/services/api/resources/removeResources
* Method: DELETE
* params: 

    ```
    {
        id: 收藏记录ID
    }
    ```
* return: 
    
    ```
    无
    ```
    
## 6.在推荐列表中移除收藏收藏

* URL: /v3/services/api/resources/removeResourcesBySuggestBookList
* Method: DELETE
* params: 

    ```
    {
        resourcesId: 资源ID
    }
    ```
* return: 
    
    ```
    无
    ```
    
## 7. 推荐图书

* URL: /v3/services/api/resources/addSuggestBook
* Method: POST
* params: 

    ```
    {
        author: 作者,
        contentUrl: 图书详细地址,
        courseGroupId: 开课班ID,
        imgUrl: 封面地址,
        introduce: 描述,
        resourcesId: 资源ID,
        resourcesName: 资源名称
    }
    ```
* return: 
    
    ```
    {
        author: 作者,
        collectTime: 推荐时间,
        contentUrl: 详细地址,
        id: 推荐图书ID,
        mgUrl: 封面地址,
        introduce: 描述,
        owner: 推荐操作用户,
        resourcesId: 资源ID,
        resourcesName：资源名称
    }
    ```
    
## 8. 移除已推荐的图书

* URL: /v3/services/api/resources/removeSuggestBook
* Method: DELET
* params: 

    ```
    {
        id: 推荐图书ID
    }
    ```
* return: 
    
    ```
    无
    ```
    
## 9. 在推荐图书管理界面中我的图书列表移除已推荐的图书

* URL: /v3/services/api/resources/removeSuggestBookByMyBook
* Method: DELETE
* params: 

    ```
    {
        resourcesId: 资源ID,
        courseGroupId: 开课班ID
    }
    ```
* return: 
    
    ```
    无
    ```
    
## 10. 获取已推荐的图书

* URL: /v3/services/api/resources/getSuggestBook
* Method: GET
* params: 

    ```
    {
        courseGroupId: 开课班ID
    }
    ```
* return: 
    
    ```
    {
        items: [
            {
                author: 作者,
                collectTime: 推荐时间,
                contentUrl: 详细内容地址,
                courseGroupId: 开课班ID,
                id: 推荐图书ID,
                imgUrl: 封面地址,
                introduce: 描述,
                owner: 推荐操作用户,
                resourcesId: 资源ID,
                resourcesName: 资源名称
            },
        ]
    }
    ```
    
## 11.

* URL: 
* Method: 
* params: 


    

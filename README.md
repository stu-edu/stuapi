STU oauth 集成三部曲
====================

Oauth2.0原理请参见 http://blog.csdn.net/deepbluecn/article/details/28090471
。


## 第一步，获得授权
   
* 判断app中是否有用户的access token，没有的话需让浏览器跳转到以下地址（oauthserver应替换为实际服务器地址）
  `https://ouathserver/oauth2/authorize?response_type=code&client_id={client_id}&redirect_uri={redirect_uri}&state={state}`
* 参数值具体说明如下：
 * client_id  app名字，由oauth server登记了app初始名称后生成
 * redirect_uri  授权完成后跳转回来的地址，在此url请求里应处理ouath server接下来的动作（即第二步）
 * state  app当前状态，由app自行确定，可以为用户实际访问地址或别的什么，随便，oauth server只是传去传回来。可以没有此参数


## 第二步，以授权码换取access token

* 实现上一步 redirect_uri 回转url的代码，从url参数 code得到授权码，并以授权码向oauth server换取 access token。
* 具体做法:
 * 向 http://oauthserver/oauth2/token 以POST提交以下表单数据和一些header数据
 * grant_type=authorization_code 
 * code=刚刚得到授权码
 * redirect_uri 即redirectBackUri值

 * 应加入Header
   * Accept=application/json
   * 以及 app 身份数据
   	* Authorization=Basic 以base64编码后的身份数据
    * //身份数据组成：以冒号拼接 { clientAppName }和{clientAppSecret } ，拼接后转成bytes，并作base64编码，clientAppSecret也是app登记时由oauthserver生成

 * 请求如果成功，返回一个json字符串，从中拿access_token即可


## 第三步 调用Resource Provider 提供的API。

* 每次请求都必须在header里附上access token，
* Authorization=bearer {accessToken}
* 并设置请求的header 
 * Accept=application/json
 * Content-Type=application/json
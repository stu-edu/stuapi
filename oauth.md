STU oauth ����������
====================

Oauth2.0ԭ����μ� http://blog.csdn.net/deepbluecn/article/details/28090471
��


## ��һ���������Ȩ
   
* �ж�app���Ƿ����û���access token��û�еĻ������������ת�����µ�ַ��oauthserverӦ�滻Ϊʵ�ʷ�������ַ��
  `https://ouathserver/oauth2/authorize?response_type=code&client_id={client_id}&redirect_uri={redirect_uri}&state={state}`
* ����ֵ����˵�����£�
 * client_id  app���֣���oauth server�Ǽ���app��ʼ���ƺ�����
 * redirect_uri  ��Ȩ��ɺ���ת�����ĵ�ַ���ڴ�url������Ӧ����ouath server�������Ķ��������ڶ�����
 * state  app��ǰ״̬����app����ȷ��������Ϊ�û�ʵ�ʷ��ʵ�ַ����ʲô����㣬oauth serverֻ�Ǵ�ȥ������������û�д˲���


## �ڶ���������Ȩ�뻻ȡaccess token

* ʵ����һ�� redirect_uri ��תurl�Ĵ��룬��url���� code�õ���Ȩ�룬������Ȩ����oauth server��ȡ access token��
* ��������:
 * �� http://oauthserver/oauth2/token ��POST�ύ���±����ݺ�һЩheader����
 * grant_type=authorization_code 
 * code=�ոյõ���Ȩ��
 * redirect_uri ��redirectBackUriֵ

 * Ӧ����Header
   * Accept=application/json
   * �Լ� app �������
   	* Authorization=Basic ��base64�������������
    * //���������ɣ���ð��ƴ�� { clientAppName }��{clientAppSecret } ��ƴ�Ӻ�ת��bytes������base64���룬clientAppSecretҲ��app�Ǽ�ʱ��oauthserver����

 * ��������ɹ�������һ��json�ַ�����������access_token����


## ������ ����Resource Provider �ṩ��API��

* ÿ�����󶼱�����header�︽��access token��
* Authorization=bearer {accessToken}
* �����������header 
 * Accept=application/json
 * Content-Type=application/json
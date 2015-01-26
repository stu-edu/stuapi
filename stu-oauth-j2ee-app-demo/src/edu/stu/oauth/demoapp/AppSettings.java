/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *   http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
package edu.stu.oauth.demoapp;

/**
 * Form object for the test page
 * 
 */
public class AppSettings {

  private String accessTokenEndPoint ;
  private String appKey;
  private String appSecret;
  private String authorizationURL;
  private String authorizationURLComplete;
  private String requestURL;
  private boolean implicitGrant;
  private String accessToken;

  public AppSettings() {
    super();
  }

  public AppSettings(String accessTokenEndPoint, 
		  String oauthKey, 
		  String oauthSecret, 
		  String authorizationURL,
		  String step, 
		  String requestURL) {
    super();
    this.accessTokenEndPoint = accessTokenEndPoint;
    this.appKey = oauthKey;
    this.appSecret = oauthSecret;
    this.authorizationURL = authorizationURL;
    this.requestURL = requestURL;
  }


  /**
   * @return the accessTokenEndPoint
   */
  public String getAccessTokenEndPoint() {
    return accessTokenEndPoint;
  }

  /**
   * @param accessTokenEndPoint
   *          the accessTokenEndPoint to set
   */
  public void setAccessTokenEndPoint(String accessTokenEndPoint) {
    this.accessTokenEndPoint = accessTokenEndPoint;
  }



 
  public String getAppKey() {
	return appKey;
}

public void setAppKey(String appKey) {
	this.appKey = appKey;
}

public String getAppSecret() {
	return appSecret;
}

public void setAppSecret(String appSecret) {
	this.appSecret = appSecret;
}

/**
   * @return the authorizationURL
   */
  public String getAuthorizationURL() {
    return authorizationURL;
  }

  /**
   * @param authorizationURL
   *          the authorizationURL to set
   */
  public void setAuthorizationURL(String authorizationURL) {
    this.authorizationURL = authorizationURL;
  }

  /**
   * @return the requestURL
   */
  public String getRequestURL() {
    return requestURL;
  }

  /**
   * @param requestURL
   *          the requestURL to set
   */
  public void setRequestURL(String requestURL) {
    this.requestURL = requestURL;
  }

  /**
   * @return the implicitGrant
   */
  public boolean isImplicitGrant() {
    return implicitGrant;
  }

  /**
   * @param implicitGrant the implicitGrant to set
   */
  public void setImplicitGrant(boolean implicitGrant) {
    this.implicitGrant = implicitGrant;
  }

  /**
   * @return the authorizationURLComplete
   */
  public String getAuthorizationURLComplete() {
    return authorizationURLComplete;
  }

  /**
   * @param authorizationURLComplete the authorizationURLComplete to set
   */
  public void setAuthorizationURLComplete(String authorizationURLComplete) {
    this.authorizationURLComplete = authorizationURLComplete;
  }

  /**
   * @return the accessToken
   */
  public String getAccessToken() {
    return accessToken;
  }

  /**
   * @param accessToken the accessToken to set
   */
  public void setAccessToken(String accessToken) {
    this.accessToken = accessToken;
  }

}

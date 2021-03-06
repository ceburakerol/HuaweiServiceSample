using UnityEngine;
using System.Collections.Generic;
using HuaweiService;

namespace HuaweiService.Auth
{
    public class WeixinAuthProvider_Data : IHmsBaseClass{
        public string name => "com.huawei.agconnect.auth.WeixinAuthProvider";
    }
    public class WeixinAuthProvider :HmsClass<WeixinAuthProvider_Data>
    {
        public WeixinAuthProvider (): base() { }
        public static AGConnectAuthCredential credentialWithToken(string arg0, string arg1) {
            return CallStatic<AGConnectAuthCredential>("credentialWithToken", arg0, arg1);
        }
        public static AGConnectAuthCredential credentialWithToken(string arg0, string arg1, bool arg2) {
            return CallStatic<AGConnectAuthCredential>("credentialWithToken", arg0, arg1, arg2);
        }
    }
}
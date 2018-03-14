using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Permissions;
using System.Runtime.InteropServices;

namespace HCI_Project
{
    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    [ComVisible(true)]
    public class JavaScriptControlHelperLogin
    {
        private LoginWindow _login;
        public JavaScriptControlHelperLogin(LoginWindow w)
        {
            _login = w;
        }
    }

    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    [ComVisible(true)]
    public class JavaScriptControlHelperSignin
    {
        private SignInWindow _signin;
        public JavaScriptControlHelperSignin(SignInWindow w)
        {
            _signin = w;
        }
    }

    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    [ComVisible(true)]
    public class JavaScriptControlHelperMap
    {
        private MapWindow _map;
        public JavaScriptControlHelperMap(MapWindow w)
        {
            _map = w;
        }
    }

    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    [ComVisible(true)]
    public class JavaScriptControlHelperLandmark
    {
        private LandmarkWindow _landmark;
        public JavaScriptControlHelperLandmark(LandmarkWindow w)
        {
            _landmark = w;
        }
    }

    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    [ComVisible(true)]
    public class JavaScriptControlHelperType
    {
        private LandmarkTypeWindow _type;
        public JavaScriptControlHelperType(LandmarkTypeWindow w)
        {
            _type = w;
        }
    }

    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    [ComVisible(true)]
    public class JavaScriptControlHelperTag
    {
        private TagWindow _tag;
        public JavaScriptControlHelperTag(TagWindow w)
        {
            _tag = w;
        }
    }
}

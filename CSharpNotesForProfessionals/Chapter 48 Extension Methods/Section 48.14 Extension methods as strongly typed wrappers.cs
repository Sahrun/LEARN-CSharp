using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Caching;

namespace Chapter_48_Extension_Methods_Section_48_14
{

    //public class Cache
    //{

    //}

    public class UserInfo
    {
    }

    public static class CacheExtensions
    {
        public static void SetuserInfo(this MemoryCache cache, UserInfo data) =>
            cache["UserInfo"] = data;

        public static UserInfo GetUserInfo(this MemoryCache cache) =>
            cache["UserInfo"] as UserInfo;
    }
}

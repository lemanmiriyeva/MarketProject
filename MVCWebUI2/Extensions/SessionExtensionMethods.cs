using Microsoft.AspNetCore.Http;
using System;
using Newtonsoft.Json;

namespace Market.MVCWebUI2.Extensions
{
    public static class SessionExtensionMethods
    {
        public static void SetObject(this ISession session, string key, Object value)
        {
            var stringObject = JsonConvert.SerializeObject(value);
            session.SetString(key, stringObject);
        }

        public static T GetObject<T>(this ISession session, string key) where T : class
        {
            var stringObject = session.GetString(key);
            if (string.IsNullOrEmpty(stringObject))
            {
                return null;
            }
            var value = JsonConvert.DeserializeObject<T>(stringObject);
            return value;
        }
    }
}

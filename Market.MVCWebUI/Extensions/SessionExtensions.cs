using System;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace Market.MVCWebUI.Extensions
{
    public static class SessionExtensions
    {
        public static void SetObject(this ISession session, string key, Object value)
        {
            var stringObject = JsonConvert.SerializeObject(value);
            session.SetString(key,stringObject);
        }

        public static T GetObject<T>(this ISession session, string key) where T:class
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

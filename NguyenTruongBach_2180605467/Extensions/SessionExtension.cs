﻿using System.Text.Json;

namespace NguyenTruongBach_2180605467.Extensions
{
    public static class SessionExtension
    {
        public static void SetObjectAsJson(this ISession session, string key,
object value)
        {
            session.SetString(key, JsonSerializer.Serialize(value));
        }
        public static T GetObjectFromJson<T>(this ISession session, string
       key)
        {
            var value = session.GetString(key);
            return value == null ? default :
           JsonSerializer.Deserialize<T>(value);
        }
    }
}

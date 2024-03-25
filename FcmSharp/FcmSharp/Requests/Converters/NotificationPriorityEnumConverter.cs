// Copyright (c) Philipp Wagner. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using Newtonsoft.Json;

namespace FcmSharp.Requests.Converters
{
    public class NotificationPriorityEnumConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            NotificationPriorityEnum operation = (NotificationPriorityEnum)value;

            switch (operation)
            {
                case NotificationPriorityEnum.PRIORITY_UNSPECIFIED:
                    writer.WriteValue("PRIORITY_UNSPECIFIED");
                    break;
                case NotificationPriorityEnum.PRIORITY_MIN:
                    writer.WriteValue("PRIORITY_MIN");
                    break;
                case NotificationPriorityEnum.PRIORITY_LOW:
                    writer.WriteValue("PRIORITY_LOW");
                    break;
                case NotificationPriorityEnum.PRIORITY_DEFAULT:
                    writer.WriteValue("PRIORITY_DEFAULT");
                    break;
                case NotificationPriorityEnum.PRIORITY_HIGH:
                    writer.WriteValue("PRIORITY_HIGH");
                    break;
                case NotificationPriorityEnum.PRIORITY_MAX:
                    writer.WriteValue("PRIORITY_MAX");
                    break;
            }
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var enumString = (string)reader.Value;

            if (string.IsNullOrWhiteSpace(enumString))
            {
                return null;
            }

            return Enum.Parse(typeof(NotificationPriorityEnum), enumString, true);
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(NotificationPriorityEnum);
        }
    }
}
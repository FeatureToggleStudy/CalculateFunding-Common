﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace CalculateFunding.Common.Extensions
{
    public static class EnumExtensions
    {
        public static TTargetEnum AsMatchingEnum<TTargetEnum>(this Enum value)
            where TTargetEnum : struct
        {
            return value.ToString().AsEnum<TTargetEnum>();
        }

        public static object PropertyMapping<T>(this Enum value, T instance)
        {
            Type genericType = instance.GetType();
            PropertyInfo propertyInfo = genericType.GetProperty(value.ToString());

            return propertyInfo.GetValue(instance);
        }

        public static TTargetEnum AsEnum<TTargetEnum>(this string enumLiteral)
            where TTargetEnum : struct
        {
            if (Enum.TryParse(enumLiteral, true, out TTargetEnum targetEnum))
            {
                if (!Enum.IsDefined(typeof(TTargetEnum), targetEnum))
                {
                    throw new ArgumentException($"{enumLiteral} is not an underlying value of the {typeof(TTargetEnum).Name} enumeration.");
                }
            }
            else
            {
                throw new ArgumentException($"{enumLiteral} is not a member of the {typeof(TTargetEnum).Name} enumeration.");
            }

            return targetEnum;
        }
    }
}

﻿using System.Globalization;

namespace UnityFlow.General.PlatformCompatibility
{
    internal static class CultureInfoHelper
    {
        public static CultureInfo GetCultureInfo(string cultureName)
        {
            return CultureInfo.GetCultureInfo(cultureName);
        }
    }
}
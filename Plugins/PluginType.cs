﻿using System;

namespace UnitySpec.General.Plugins
{
    [Flags]
    public enum PluginType
    {
        Generator = 1,
        Runtime = 2,
        GeneratorAndRuntime = Generator | Runtime
    }
}
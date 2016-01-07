﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Wox.Infrastructure.Storage;

namespace Wox.Plugin.Program
{
    [Serializable]
    public class ProgramCacheStorage : BinaryStorage<ProgramCacheStorage>
    {
        public List<Program> Programs = new List<Program>();

        protected override string FileName { get; } = "ProgramIndexCache";
    }
}
﻿using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace RealmNet
{
    internal class SchemaHandle : RealmHandle
    {
        [Preserve("Constructor used by marshaling, cannot be removed by linker")]
        public SchemaHandle(SchemaInitializerHandle schemaInitializerHandle)
        {
            RuntimeHelpers.PrepareConstrainedRegions();
            try { /**/ }
            finally
            {
                SetHandle(NativeSchema.create(schemaInitializerHandle));
            }
        }

        protected override void Unbind()
        {
            NativeSchema.destroy(handle);
        }
    }
}

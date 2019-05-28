﻿using System.Diagnostics;

namespace ClangSharp
{
    internal sealed class TypeAliasTemplateDecl : RedeclarableTemplateDecl
    {
        public TypeAliasTemplateDecl(CXCursor handle, Cursor parent) : base(handle, parent)
        {
            Debug.Assert(handle.Kind == CXCursorKind.CXCursor_TypeAliasTemplateDecl);
        }
    }
}

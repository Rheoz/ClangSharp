﻿using System.Diagnostics;

namespace ClangSharp
{
    internal sealed class CompoundStmt : Stmt
    {
        public CompoundStmt(CXCursor handle, Cursor parent) : base(handle, parent)
        {
            Debug.Assert(handle.Kind == CXCursorKind.CXCursor_CompoundStmt);
        }
    }
}

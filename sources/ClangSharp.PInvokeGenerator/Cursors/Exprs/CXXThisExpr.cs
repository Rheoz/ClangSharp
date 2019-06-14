using System.Diagnostics;
using ClangSharp.Interop;

namespace ClangSharp
{
    internal sealed class CXXThisExpr : Expr
    {
        public CXXThisExpr(CXCursor handle, Cursor parent) : base(handle, parent)
        {
            Debug.Assert(handle.Kind == CXCursorKind.CXCursor_CXXThisExpr);
        }
    }
}
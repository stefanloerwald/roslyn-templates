using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace MyTemplate
{
    internal static class StringExtension
    {
        public static string NormalizeWhitespace(this string code)
        {
            return CSharpSyntaxTree.ParseText(code).GetRoot().NormalizeWhitespace().ToFullString();
        }
    }
}
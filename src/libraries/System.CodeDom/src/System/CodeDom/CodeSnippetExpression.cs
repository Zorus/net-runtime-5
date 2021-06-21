// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace System.CodeDom
{
    public class CodeSnippetExpression : CodeExpression
    {
        private string _value;

        public CodeSnippetExpression() { }

        public CodeSnippetExpression(string value)
        {
            Value = value;
        }

        public string Value
        {
            get => _value ?? string.Empty;
            set => _value = value;
        }
    }
}

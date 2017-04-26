﻿using ShaderTools.CodeAnalysis.Text;

namespace ShaderTools.Editor.VisualStudio.Hlsl.Tagging.Highlighting
{
    internal struct HighlightSpan
    {
        public TextSpan Span;
        public bool IsDefinition;

        public HighlightSpan(TextSpan span, bool isDefinition)
        {
            Span = span;
            IsDefinition = isDefinition;
        }
    }
}
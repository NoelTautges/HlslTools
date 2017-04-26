using System.ComponentModel.Composition;
using ShaderTools.CodeAnalysis.Hlsl.Compilation;
using ShaderTools.CodeAnalysis.Hlsl.Syntax;
using ShaderTools.CodeAnalysis.Text;

namespace ShaderTools.Editor.VisualStudio.Hlsl.IntelliSense.QuickInfo.QuickInfoModelProviders
{
    [Export(typeof(IQuickInfoModelProvider))]
    internal sealed class NumericConstructorInvocationQuickInfoModelProvider : QuickInfoModelProvider<NumericConstructorInvocationExpressionSyntax>
    {
        protected override QuickInfoModel CreateModel(SemanticModel semanticModel, SourceLocation position, NumericConstructorInvocationExpressionSyntax node)
        {
            if (!node.Type.SourceRange.ContainsOrTouches(position))
                return null;

            if (!node.Type.GetTextSpanSafe().IsInRootFile)
                return null;

            var symbol = semanticModel.GetSymbol(node);
            if (symbol == null)
                return null;

            return QuickInfoModel.ForSymbol(semanticModel, node.Type.GetTextSpanRoot(), symbol);
        }
    }
}
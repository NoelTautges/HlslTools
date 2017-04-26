using System.ComponentModel.Composition;
using ShaderTools.CodeAnalysis.Hlsl.Syntax;

namespace ShaderTools.Editor.VisualStudio.Hlsl.Navigation.GoToDefinitionProviders
{
    [Export(typeof(IGoToDefinitionProvider))]
    internal sealed class MethodInvocationGoToDefinitionProvider : SymbolReferenceGoToDefinitionProvider<MethodInvocationExpressionSyntax>
    {
        protected override SyntaxToken GetNameToken(MethodInvocationExpressionSyntax node)
        {
            return node.Name;
        }
    }
}
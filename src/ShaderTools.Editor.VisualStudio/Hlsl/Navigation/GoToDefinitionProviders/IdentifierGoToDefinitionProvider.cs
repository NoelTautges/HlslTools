using System.ComponentModel.Composition;
using ShaderTools.CodeAnalysis.Hlsl.Syntax;

namespace ShaderTools.Editor.VisualStudio.Hlsl.Navigation.GoToDefinitionProviders
{
    [Export(typeof(IGoToDefinitionProvider))]
    internal sealed class IdentifierGoToDefinitionProvider : SymbolReferenceGoToDefinitionProvider<IdentifierNameSyntax>
    {
        protected override SyntaxToken GetNameToken(IdentifierNameSyntax node)
        {
            return node.Name;
        }
    }
}
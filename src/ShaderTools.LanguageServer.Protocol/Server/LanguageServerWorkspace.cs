﻿using ShaderTools.CodeAnalysis.Text;
using ShaderTools.EditorServices.Workspace;
using ShaderTools.EditorServices.Workspace.Host.Mef;

namespace ShaderTools.LanguageServer.Protocol.Server
{
    public sealed class LanguageServerWorkspace : Workspace
    {
        private readonly string _languageName;

        public LanguageServerWorkspace(string languageName)
            : base(MefHostServices.DefaultHost)
        {
            _languageName = languageName;
        }

        public Document OpenDocument(DocumentId documentId, SourceText sourceText)
        {
            var document = CreateDocument(documentId, _languageName, sourceText);
            OnDocumentOpened(document);
            return document;
        }

        public Document UpdateDocument(Document document, TextChange change)
        {
            var newText = document.SourceText.WithChanges(change);
            return OnDocumentTextChanged(document, newText);
        }

        public void CloseDocument(DocumentId documentId)
        {
            OnDocumentClosed(documentId);
        }
    }
}
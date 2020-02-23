﻿using System.Windows.Controls;
using System.Windows.Documents;

namespace CodeVoidWPF.Extensions
{
    public static class Extentions
    {
        public static string Text(this RichTextBox richTextBox)
        {
            TextRange content = new TextRange(richTextBox.Document.ContentStart, richTextBox.Document.ContentEnd);
            return content.Text;
        }
    }
}

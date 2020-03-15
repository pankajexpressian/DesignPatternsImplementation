using System;
using System.Text;

namespace DesignPatternsImplementation.Memento
{
    public class Editor
    {
        public string Content { get; set; }
        public EditorState CreateState()
        {
            return new EditorState(Content);
        }

        public void Restore(EditorState state)
        {
            Content = state!=null?state.GetContent():"";
        }
    }
}

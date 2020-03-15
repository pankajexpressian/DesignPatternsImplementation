namespace DesignPatternsImplementation.Memento
{
    public class EditorState
    {
        private string _content;
        public EditorState(string content)
        {
            _content = content;
        }

        public string GetContent()
        {
            return _content;
        }
    }
}

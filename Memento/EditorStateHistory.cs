using System.Collections.Generic;

namespace DesignPatternsImplementation.Memento
{
    public class EditorStateHistory
    {
        private List<EditorState> _editorStateList;
        public void Push(EditorState state)
        {
            if (_editorStateList == null)
            {
                _editorStateList = new List<EditorState>();
            }
            _editorStateList.Add(state);
        }

        public EditorState Pop()
        {
            EditorState lastItem = null;
            var lastIndex = _editorStateList.Count-1;
            if (lastIndex >= 0)
            {
                lastItem = _editorStateList[lastIndex];
                _editorStateList.Remove(lastItem);
                if (_editorStateList.Count>0)
                {
                    lastItem = _editorStateList[_editorStateList.Count - 1];
                }
                else
                {
                    lastItem = null;
                }
            }
            return lastItem;

        }
    }
}

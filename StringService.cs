namespace StringProcessingApp.Services
{
    public class StringService
    {
        private string _current = string.Empty;
        private string _backup = string.Empty;

        public void LoadText(string input)
        {
            _current = input;
            _backup = input;
        }

        public string Display()
        {
            return _current;
        }

        public void MakeUpper()
        {
            _current = _current.ToUpper();
        }

        public void MakeLower()
        {
            _current = _current.ToLower();
        }

        public int GetLength()
        {
            return _current.Length;
        }

        public bool HasWord(string value)
        {
            return _current.Contains(value);
        }

        public void ChangeWord(string oldValue, string newValue)
        {
            _current = _current.Replace(oldValue, newValue);
        }

        public void GetPart(int start, int count)
        {
            _current = _current.Substring(start, count);
        }

        public void CleanSpaces()
        {
            _current = _current.Trim();
        }

        public void Restore()
        {
            _current = _backup;
        }
    }
}

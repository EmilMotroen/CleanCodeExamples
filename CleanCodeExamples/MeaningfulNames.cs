namespace CleanCodeExamples
{
    class MeaningfulNames
    {
        private string _strDesc;  // Description of ... with type encoding 

        public void SetDescription(string description)
        {
            _strDesc = description;
        }

        public string GetDescription()
        {
            return _strDesc;
        }
    }
}

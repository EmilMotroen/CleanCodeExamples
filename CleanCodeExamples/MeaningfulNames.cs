using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeExamples
{
    class MeaningfulNames
    {
        private string _desc;  // Description of ...

        public void SetDescription(string description)
        {
            _desc = description;
        }

        public string GetDescription()
        {
            return _desc;
        }
    }
}

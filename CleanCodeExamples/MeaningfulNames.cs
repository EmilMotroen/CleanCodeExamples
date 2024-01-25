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

        void SetDescription(string description)
        {
            _desc = description;
        }

        string GetDescription()
        {
            return _desc;
        }
    }
}

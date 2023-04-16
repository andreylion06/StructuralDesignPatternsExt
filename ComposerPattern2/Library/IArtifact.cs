using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposerPattern2.Library
{
    public interface IArtifact
    {
        public string GetName();
        public int GetWeight();
        public int GetPowerBuf();
        public int GetCount();
    }
}

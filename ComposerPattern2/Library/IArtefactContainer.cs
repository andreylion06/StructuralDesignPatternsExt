using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposerPattern2.Library
{
    public interface IArtifactContainer : IArtifact
    {
        public void AddArtifact(IArtifact artifact);
        public void RemoveArtifact(IArtifact artifact);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposerPattern2.Library
{
    public class ArtifactContainer : IArtifactContainer
    {
        public string Name { get; private set; }
        private List<IArtifact> _children = new List<IArtifact>();

        public ArtifactContainer(string name)
        {
            Name = name;
        }

        public void AddArtifact(IArtifact artifact)
        {
            this._children.Add(artifact);
        }

        public void RemoveArtifact(IArtifact artifact)
        {
            this._children.Remove(artifact);
        }

        public string GetName()
        {
            return this.Name;
        }

        public int GetWeight()
        {
            return _children.Sum((next) => next.GetWeight());
        }

        public int GetPowerBuf()
        {
            return _children.Sum((next) => next.GetPowerBuf());
        }

        public int GetCount()
        {
            return _children.Sum((next) => next.GetCount());
        }
    }
}

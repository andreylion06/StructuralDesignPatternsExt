using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposerPattern2.Library
{
    public class CompositeArtifact : Artifact, IArtifactContainer
    {
        private List<IArtifact> _children = new List<IArtifact>();
        public CompositeArtifact(string name, int weight, int powerBuf) : base(name, weight, powerBuf)
        {
        }

        public void AddArtifact(IArtifact artifact)
        {
            this._children.Add(artifact);
        }

        public void RemoveArtifact(IArtifact artifact)
        {
            this._children.Remove(artifact);
        }

        public override int GetWeight()
        {
            return this._children.Aggregate(this._weight, (sum, next) => sum += next.GetWeight());
        }

        public override int GetPowerBuf()
        {
            return this._children.Aggregate(this._powerBuf, (sum, next) => sum += next.GetPowerBuf());
        }

        public override int GetCount()
        {
            return this._children.Aggregate(0, (sum, next) => sum += next.GetCount());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposerPattern2.Library
{
    public class MarvelHero
    {
        private List<IArtifact> _artifacts = new List<IArtifact>();
        public string Name { get; private set; }

        private int _power;

        private bool logging = false;

        public MarvelHero(string name, int power)
        {
            this.Name = name;
            this._power = power;
        }

        public void AddArtifact(IArtifact artifact)
        {
            this._artifacts.Add(artifact);
            if (logging)
                Console.WriteLine($"{artifact.GetName()} artifact with the power {artifact.GetPowerBuf()} has been added");
        }

        public void RemoveArtifact(IArtifact artifact)
        {
            this._artifacts.Remove(artifact);
            if (logging)
                Console.WriteLine($"{artifact.GetName()} artifact with the power {artifact.GetPowerBuf()} has been removed");

        }

        public void SetLogging(bool logging)
        { 
            this.logging = logging; 
        }

        public void Strike()
        {
            int totalPower = this._artifacts.Aggregate(this._power, (sum, next) => sum += next.GetPowerBuf());
            Console.WriteLine($"{this.Name} hits with power {totalPower}");
        }

        public void CalculateArtefictsWeight()
        {
            int totalArtifactsWeight = this._artifacts.Aggregate(0, (sum, next) => sum += next.GetWeight());
            Console.WriteLine($"Total artifacts weight: {totalArtifactsWeight}");
        }

        public void CountArtifacts()
        {
            int totalArtifactCount = this._artifacts.Count;
            Console.WriteLine($"{this.Name} has {totalArtifactCount} artifacts");
        }
    }
}

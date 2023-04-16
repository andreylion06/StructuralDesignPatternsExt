﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposerPattern2.Library
{
    public class Artifact : IArtifact
    {
        public string Name { get; protected set; }
        protected int _weight;
        protected int _powerBuf;

        public Artifact(string name, int weight, int powerBuf)
        {
            this.Name = name;
            this._weight = weight;
            this._powerBuf = powerBuf;
        }

        public virtual string GetName()
        {
            return this.Name;
        } 

        public virtual int GetWeight()
        {
            return this._weight;
        }

        public virtual int GetPowerBuf()
        {
            return this._powerBuf;
        }

        public virtual int GetCount()
        {
            return 1;
        }
    }
}
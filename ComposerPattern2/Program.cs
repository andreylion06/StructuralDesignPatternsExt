using ComposerPattern2.Library;

MarvelHero ironMan = new MarvelHero("Iron Man", 1000);
ironMan.SetLogging(true);

Artifact jet = new Artifact("Jet", 100, 50);
ironMan.AddArtifact(jet);

ArtifactContainer glove = new ArtifactContainer("Glove");
glove.AddArtifact(new Artifact("stone 1", 10, 100));
glove.AddArtifact(new Artifact("stone 2", 15, 150));
glove.AddArtifact(new Artifact("stone 3", 5, 250));
glove.AddArtifact(new Artifact("stone 4", 30, 100));
glove.AddArtifact(new Artifact("stone 5", 20, 200));

ironMan.AddArtifact(glove);

Console.WriteLine(glove.GetPowerBuf());
ironMan.Strike();
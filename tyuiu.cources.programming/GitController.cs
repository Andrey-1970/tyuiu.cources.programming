﻿using LibGit2Sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace tyuiu.cources.programming
{
    public class GitController
    {
        public void Load(string repoUrl, string rootDir)
        {
            var filename = Path.GetFileNameWithoutExtension(repoUrl);
            var localDir = $@"{rootDir}\{filename}";
            if (Directory.Exists(localDir))
            {
                throw new FileLoadException($"Directory {localDir} already exists!");
            }
            Repository.Clone(repoUrl, localDir);
            //var repo = new Repository(destDir);
            //foreach (var f in repo.Network.Remotes)
            //{
            //    repo.Network.Remotes.Remove(f.Name);
            //}
        }
    }
}

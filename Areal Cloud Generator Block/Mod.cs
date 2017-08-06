using System;
using spaar.ModLoader;
using UnityEngine;

namespace Areal_Cloud_Generator_Block
{

    public class YourMod : Mod
    {
        public override string Name { get; } = "<placeholder>";
        public override string DisplayName { get; } = "<placeholder>";
        public override string Author { get; } = "<placeholder>";
        public override Version Version { get; } = new Version(1, 0, 0);

        public override void OnLoad()
        {
            // Your initialization code here
        }

        public override void OnUnload()
        {
            // Your code here
            // e.g. save configuration, destroy your objects if CanBeUnloaded is true etc
        }
    }
}

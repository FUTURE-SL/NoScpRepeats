using Exiled.API.Features;
using HarmonyLib;
using System;
namespace NoScpRepeats
{
    public class NoScpRepeats : Plugin<Config>
    {
        private Harmony _harmony;
        public override string Author { get; } = "FUTURE";
        public override string Name { get; } = "NoScpRepeats";
        public override Version Version { get; } = new Version(1, 0, 0);
        public override Version RequiredExiledVersion { get; } = new Version(8, 8, 1);
        public override void OnEnabled()
        {
            _harmony = new Harmony("FUTURE.noscprepeats");
            _harmony.PatchAll();
            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            _harmony.UnpatchAll();
            _harmony = null;
            base.OnDisabled();
        }
    }
}
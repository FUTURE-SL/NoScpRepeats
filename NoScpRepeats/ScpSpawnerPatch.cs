using HarmonyLib;
using PlayerRoles;
using PlayerRoles.RoleAssign;
using System.Collections.Generic;
namespace NoScpRepeats
{
    [HarmonyPatch(typeof(ScpSpawner), nameof(ScpSpawner.AssignScp))]
    internal class ScpSpawnerPatch
    {
        public static bool Prefix(RoleTypeId scp, List<RoleTypeId> otherScps) => !otherScps.Contains(scp);
    }
}
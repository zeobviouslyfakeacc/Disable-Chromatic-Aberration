using MelonLoader;
using UnityEngine;

namespace DisableChromaticAberration
{
    internal class Implementation : MelonMod
    {
        public override void OnApplicationStart()
        {
            Debug.Log($"[{InfoAttribute.Name}] Version {InfoAttribute.Version} loaded!");
        }
    }
}

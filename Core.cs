using MelonLoader;

[assembly: MelonInfo(typeof(Sandbox.Core), "Sandbox", "1.0.0", "taldo", null)]
[assembly: MelonGame("Videocult", "Airframe")]

namespace Sandbox
{
    public class Core : MelonMod
    {
        public UnityEngine.Vector3 camera_aim_point;

        
        public override void OnInitializeMelon()
        {
            LoggerInstance.Msg("Initialized.");
        }
    }
}
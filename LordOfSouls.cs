using Modding;

namespace LordOfSouls
{
    public class LordOfSouls : Mod, ITogglableMod
    {
        public override string GetVersion() => "1.0.0";
        public override void Initialize()
        {
            Log("Initializing");
        }
        public void Unload()
        {
            Log("Mod unloading");
        }
    }
}

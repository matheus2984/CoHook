using System.IO;

namespace CoHook
{
    public static class Effects
    {
        public static void Remove(string path)
        {
            var effect = path + @"\c3\effect";
            var backup = path + @"\coh\backup";

            var actionSound = path + @"\ini\ActionSound.ini";
            var weaponEffect = path + @"\ini\WeaponEffect.ini";
            var _3DEffect = path + @"\ini\3DEffect.ini";
            var _3DEffectObj = path + @"\ini\3DEffectObj.ini";

            Directory.CreateDirectory(backup);

              Directory.Move(effect, backup+@"\effect");
            File.Move(actionSound, backup + @"\ActionSound.ini");
            File.Move(weaponEffect, backup + @"\WeaponEffect.ini");
            File.Move(_3DEffect, backup + @"\3DEffect.ini");
            File.Move(_3DEffectObj, backup + @"\3DEffectObj.ini");
        }

        public static void Restore(string path)
        {
            var effect = path + @"\c3\effect";
            var backup = path + @"\coh\backup";

            var actionSound = path + @"\ini\ActionSound.ini";
            var weaponEffect = path + @"\ini\WeaponEffect.ini";
            var _3DEffect = path + @"\ini\3DEffect.ini";
            var _3DEffectObj = path + @"\ini\3DEffectObj.ini";

            Directory.Move(backup + @"\effect", effect);
            File.Move(backup + @"\ActionSound.ini", actionSound);
            File.Move(backup + @"\WeaponEffect.ini", weaponEffect);
            File.Move(backup + @"\3DEffect.ini", _3DEffect);
            File.Move(backup + @"\3DEffectObj.ini", _3DEffectObj);

            Directory.Delete(backup);
        }
    }
}
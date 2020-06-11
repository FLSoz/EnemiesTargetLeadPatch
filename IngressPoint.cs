using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;

using Harmony;

namespace EnemiesTargetLeadPatch
{
    public static class IngressPoint
    {
        public static void Main()
        {
            HarmonyInstance.Create("flsoz.ttmm.enemytargetlead.mod").PatchAll(Assembly.GetExecutingAssembly());

            try
            {
                WeaponAimMod.src.WrappedDataHolder.cheatDisabled = true;
                Console.WriteLine("SUCCESS - enable enemy target lead");
            }
            catch
            {
                Console.WriteLine("Failed to enable enemy target lead");
            }
        }
    }
}

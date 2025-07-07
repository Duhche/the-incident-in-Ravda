using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace the_incident_in_Ravda
{
    public static class achivement_c
    {
        private static Dictionary<string, bool> achievements = new Dictionary<string, bool>()
    {
        { "Buried in the basement", false },{ "The good stranger", false },{ "Forever lost", false },{"Rock bottom", false},
            {"Overdose", false },{"Tricked",false},{"The bus to home",false},{"Left hand of the Ravda boss",false}

    };

        public static void Unlock(string name)
        {
            if (achievements.ContainsKey(name) && !achievements[name])
            {
                achievements[name] = true;
                MessageBox.Show($"Achievement Unlocked: {name}!", "Achievement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public static bool IsUnlocked(string name)
        {
            return achievements.TryGetValue(name, out bool unlocked) && unlocked;
        }

        public static Dictionary<string, bool> GetAll()
        {
            return new Dictionary<string, bool>(achievements);
        }
    }
}

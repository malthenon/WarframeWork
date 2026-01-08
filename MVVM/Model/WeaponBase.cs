using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarframeWork.MVVM.Model
{
    public class WeaponBase : ItemBase
    {
        public string url { get; set; }
        public double mr { get; set; }
        public double riven_disposition { get; set; }
        public string[] polarities { get; set; }
        public string thumbnail { get; set; }
        public string[] tags { get; set; }
        public bool vaulted { get; set; }
        public int marketCost { get; set; }
        public int bpCost { get; set; }
        public object[] attacks { get; set; }
        public int masteryReq { get; set; }
        public int buildPrice { get; set; }
        public int buildTime { get; set; }
        public int skipBuildTimePrice { get; set; }
        public int buildQuantity { get; set; }
        public bool consumeOnBuild { get; set; }
        public string wikiaThumbnail { get; set; }
        public string wikiaUrl { get; set; }
        public float criticalChance { get; set; }
        public float criticalMultiplier { get; set; }
        public int disposition { get; set; }
        public float fireRate { get; set; }
        public float omegaAttenuation { get; set; }
        public float procChance { get; set; }
        public string releaseDate { get; set; }
        public int slot { get; set; }
        public int totalDamage { get; set; }
        public string vaultDate { get; set; }
    }
}

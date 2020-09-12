using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Config : AsNum.JsonConfig.JsonConfigItem
    {

        public string BaiDuFYAppId { get; set; }
        public string BaiDuFYKey { get; set; }
        public string SourceFile { get; set; }
        public string TargetFile { get; set; }

        public override string CfgFile => "Config.json";


    }
}

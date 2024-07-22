using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sso_task_md5_patcher {
    public class TaskGfxInfo {
        public uint id;
        public string path = "";

        public string toString() {
            return $"GlfxInfo ID:{id} PATH:{path}";
        }
    }
}

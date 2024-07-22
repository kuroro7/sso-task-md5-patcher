using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sso_task_md5_patcher {
    public class TaskMD5 {
        public const int BUFF_LEN = 16;
        public byte[] data;

        public TaskMD5(byte[] m) {
            data = new byte[BUFF_LEN];
            this.data = m;
        }

        public void fromString(string md5HexString) {
            if (string.IsNullOrWhiteSpace(md5HexString) || md5HexString.Length != BUFF_LEN * 2)
                throw new ArgumentException("Invalid MD5 hex string");

            data = new byte[BUFF_LEN];

            for (var i = 0; i < BUFF_LEN; i++) {
                var byteValueHexString = md5HexString.Substring(i * 2, 2);
                data[i] = Convert.ToByte(byteValueHexString, 16);
            }
        }

        public string toString() {
            if (data == null)
                throw new Exception("No md5 data to convert");

            StringBuilder sb = new StringBuilder();
            foreach (var b in data)
                sb.AppendFormat("{0:x2}", b);

            return sb.ToString();
        }
    }
}

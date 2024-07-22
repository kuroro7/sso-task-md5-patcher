using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sso_task_md5_patcher {
    public class TaskDataFile {
        public uint magic;
        public uint version;
        public uint itemCount;
        public uint packCount;

        public List<TaskMD5> md5List;
        public List<TaskMD5> childMd5List;
        public List<TaskGfxInfo> taskGfxInfoList;
        public List<TaskSoundInfo> taskSoundInfoList;
        public List<BitOrderInfo> bitOrderInfoList;

        public string path;
        private FileStream fileStream;
        private BinaryReader reader;

        public uint taskCount;
        public const uint BIN_CHECK_VALUE = 4;

        fMain form;

        public TaskDataFile(fMain form) {
            this.form = form;
        }

        public void read(string path) {
            this.path = path;

            fileStream = new FileStream(path, FileMode.Open);
            reader = new BinaryReader(fileStream);

            form.setStatus("Loading tasks.data header ...");
            magic = reader.ReadUInt32();
            version = reader.ReadUInt32();

            itemCount = reader.ReadUInt32();
            packCount = reader.ReadUInt32();

            if (version != 220 && version != 221)
                return;

            validateVersion();
            form.setStatus("Loading tasks.data MD5 ...");
            readMD5();
            binCheck();
            readGfxInfoList();
            binCheck();
            readTaskSoundInfoList();
            readTaskBitOrder();

            fileStream.Close();

            readChildMd5();
        }

        public void write() {
            FileStream fileStream = new FileStream(path, FileMode.Create);
            BinaryWriter writer = new BinaryWriter(fileStream);

            writer.Write(magic);
            writer.Write(version);
            writer.Write(itemCount);
            writer.Write(packCount);

            writeMD5(writer);
            writer.Write(BIN_CHECK_VALUE);
            writeGfxInfoList(writer);
            writer.Write(BIN_CHECK_VALUE);
            writeTaskSoundInfoList(writer);
            writeTaskBitOrder(writer);

            writer.Close();
            fileStream.Close();
        }

        private void readTaskBitOrder() {
            bitOrderInfoList = new List<BitOrderInfo>();

            var size = reader.ReadUInt32();

            for (var i = 0; i < size; i++) {
                var bitOrderInfo = new BitOrderInfo();
                bitOrderInfo.bitOrder = reader.ReadInt32();
                bitOrderInfo.taskId = reader.ReadUInt32();
                bitOrderInfoList.Add(bitOrderInfo);
            }
        }

        private void writeTaskBitOrder(BinaryWriter writer) {
            writer.Write((uint) bitOrderInfoList.Count);
            
            foreach (var bitOrderInfo in bitOrderInfoList) {
                writer.Write(bitOrderInfo.bitOrder);
                writer.Write(bitOrderInfo.taskId);
            }
        }

        private void readTaskSoundInfoList() {
            taskSoundInfoList = new List<TaskSoundInfo>();
            var taskSoundInfoSize = reader.ReadUInt32();

            for (var taskSoundInfoIndex = 0; taskSoundInfoIndex < taskSoundInfoSize; taskSoundInfoIndex++) {
                var taskSoundInfo = new TaskSoundInfo();

                taskSoundInfo.id = reader.ReadUInt32();
                var strSize = reader.ReadInt32();
                var strBytes = reader.ReadBytes(strSize * 2);
                taskSoundInfo.path = Encoding.Unicode.GetString(strBytes);

                taskSoundInfoList.Add(taskSoundInfo);
            }
        }

        private void writeTaskSoundInfoList(BinaryWriter writer) {
            writer.Write((uint)taskSoundInfoList.Count);

            foreach (var taskSoundInfo in taskSoundInfoList) {
                writer.Write(taskSoundInfo.id);

                var strBytes = Encoding.Unicode.GetBytes(taskSoundInfo.path);
                writer.Write(strBytes.Length / 2);
                writer.Write(strBytes);
            }
        }

        private void readGfxInfoList() {
            taskGfxInfoList = new List<TaskGfxInfo>();
            var taskGfxInfoSize = reader.ReadUInt32();

            for (var taskGfxInfoIndex = 0; taskGfxInfoIndex < taskGfxInfoSize; taskGfxInfoIndex++) {
                var taskGfxInfo = new TaskGfxInfo();
                taskGfxInfo.id = reader.ReadUInt32();

                var strSize = reader.ReadInt32();
                var strBytes = reader.ReadBytes(strSize * 2);
                taskGfxInfo.path = Encoding.Unicode.GetString(strBytes);

                taskGfxInfoList.Add(taskGfxInfo);
            }
        }

        private void writeGfxInfoList(BinaryWriter writer) {
            writer.Write((uint)taskGfxInfoList.Count);

            foreach (var taskGfxInfo in taskGfxInfoList) {
                writer.Write(taskGfxInfo.id);

                var strBytes = Encoding.Unicode.GetBytes(taskGfxInfo.path);
                writer.Write(strBytes.Length / 2);
                writer.Write(strBytes);
            }
        }

        private void readMD5() {
            md5List = new List<TaskMD5>();

            for (var packIndex = 0; packIndex < packCount; packIndex++) {
                var bytes = reader.ReadBytes(16);
                var taskMd5 = new TaskMD5(bytes);
                md5List.Add(taskMd5);
            }
        }

        private void readChildMd5() {
            childMd5List = new List<TaskMD5>();

            for (var md5Index = 0; md5Index < packCount; md5Index++) {
                form.setStatus($"Calculating tasks.data{md5Index+1} md5 ...");
                var path = this.path + (md5Index + 1);
                byte[] fileMD5 = System.Security.Cryptography.MD5.Create().ComputeHash(System.IO.File.ReadAllBytes(path));
                TaskMD5 childMd5 = new TaskMD5(fileMD5);
                childMd5List.Add(childMd5);
            }
        }

        private void writeMD5(BinaryWriter writer) {
            for (var packIndex = 0; packIndex < packCount; packIndex++) {
                var md5 = childMd5List[packIndex];
                writer.Write(md5.data);
            }
        }

        private void validateVersion() {
            if (version < 219)
                throw (new Exception($"Version of task.data file must be >= 219. Got {version}"));
        }

        private void binCheck() {
            var sbinCheck = reader.ReadUInt32();

            if (sbinCheck != 4)
                throw (new Exception($"BAD BIN CHECK: Expected {4} but got {sbinCheck}"));
        }
    }
}

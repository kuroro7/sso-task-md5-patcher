using System.Windows.Forms;

namespace sso_task_md5_patcher {
    public partial class fMain : Form {
        public TaskDataFile taskDataFile;
        public fMain() {
            InitializeComponent();
        }

        private void btPatch_Click(object sender, EventArgs e) {
            taskDataFile.write();
            MessageBox.Show("File was successfully patched!", "Save Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            load(taskDataFile.path);
        }

        public void setStatus(string status) {
            lbStatus.Text = status;
        }

        public void load(string path) {
            grid.Rows.Clear();
            btPatch.Enabled = false;

            taskDataFile = new TaskDataFile(this);
            taskDataFile.read(path);

            edtVersion.Text = taskDataFile.version.ToString();
            edtMagic.Text = taskDataFile.magic.ToString();
            edtPackCount.Text = taskDataFile.packCount.ToString();
            edtItemCount.Text = taskDataFile.itemCount.ToString();

            if (taskDataFile.version != 220 && taskDataFile.version != 221) {
                MessageBox.Show($"This patcher only supports tasks.data versions 220 and 221. Your file is version {taskDataFile.version}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (var index = 0; index < taskDataFile.packCount; index++) {
                var md5 = taskDataFile.md5List[index];
                var childMd5 = taskDataFile.childMd5List[index];

                string[] row = {
                            $"tasks.data{index+1}",
                            md5.toString(),
                            childMd5.toString()
                        };

                var rowIndex = grid.Rows.Add(row);

                if (md5.toString() != childMd5.toString()) {
                    grid.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Yellow;
                }
            }

            btPatch.Enabled = true;
            setStatus($"{taskDataFile.path} loaded!");
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e) {
            using (OpenFileDialog openFileDialog = new OpenFileDialog()) {
                openFileDialog.Filter = "Data files (tasks.data)|tasks.data";
                openFileDialog.Title = "Open SSO tasks.data file";

                if (openFileDialog.ShowDialog() == DialogResult.OK) {
                    load(openFileDialog.FileName);
                }
            }
        }
    }
}

using Microsoft.WindowsAPICodePack.Dialogs;

namespace DirectoryChecker {

    public partial class DCWindow : Form {

        private Dictionary<string, long> selectedFolders = new();
        private IOrderedEnumerable<KeyValuePair<string, long>> sortedDictionary;

        public DCWindow() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            Label_Results.Text = "Your Directories and associated file size will appear listed here.";
        }

        private void OpenFileDialogBox() {
            using var dialog = new CommonOpenFileDialog {
                IsFolderPicker = true,
                Multiselect = true
            };
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok) {
                foreach (var file in dialog.FileNames) {
                    selectedFolders.Add(file, 0);
                }
            }
        }

        #region DICTIONARY
        private void CalculateDirectorySize() {
            if (selectedFolders.Count == 0)
                return;
            foreach (KeyValuePair<string, long> folder in selectedFolders) {
                long size = GetDirectorySize(folder.Key);
                selectedFolders[folder.Key] = size;
            }
        }
        private static long GetDirectorySize(string targetPath) {
            DirectoryInfo dirInfo = new DirectoryInfo(targetPath);
            var dirSize = Task.Run(() => dirInfo.EnumerateFiles("*", SearchOption.AllDirectories).Sum(file => file.Length)).Result;
            return dirSize;
        }
        private void SortDictionary() {
            sortedDictionary = from entry in selectedFolders orderby entry.Value descending select entry;
        }
        private void DisplayResults() {
            foreach (var item in sortedDictionary) {
                Label_Results.Text += "\n" + ConvertBytesToMegabytes(item.Value).ToString("F2") + " MB :: " + item.Key;
            }
        }
        #endregion

        #region CONVERTING BYTES
        private double ConvertBytesToMegabytes(long bytes) { return (bytes / 1024f) / 1024f; }
        #endregion

        #region BUTTONS
        private void Btn_SelectFolders_Click(object sender, EventArgs e) {
            selectedFolders.Clear();
            OpenFileDialogBox();
        }

        private void Btn_CalculateSize_Click(object sender, EventArgs e) {
            Label_Results.Text = "";
            CalculateDirectorySize();
            SortDictionary();
            DisplayResults();
        }
        #endregion

    }

}
using Newtonsoft.Json;
using System.Security.Principal;

namespace CMD_GUI;

public partial class FrmMain : Form
{
    #region Variable

    private static string _currentJson;

    private static string _sourceIniDir, _targetIniDir, _loadIniDir;

    private static List<string> _recentList = new();
    private const int RecentMax = 4;

    private static string SourceIniDir
    {
        get => _sourceIniDir;
        set
        {
            _sourceIniDir = value;
            Settings.Default.SourceIni = value;
            Settings.Default.Save();
        }
    }

    private static string TargetIniDir
    {
        get => _targetIniDir;
        set
        {
            _targetIniDir = value;
            Settings.Default.TargetIni = value;
            Settings.Default.Save();
        }
    }

    private static string LoadIniDir
    {
        get => _loadIniDir;
        set
        {
            _loadIniDir = value;
            Settings.Default.LoadIni = value;
            Settings.Default.Save();
        }
    }

    #endregion Variable

    public FrmMain()
    {
        InitializeComponent();
    }

    #region Load/Save

    private void FrmMain_Load(object sender, EventArgs e)
    {
        SourceIniDir = Settings.Default.SourceIni;
        TargetIniDir = Settings.Default.TargetIni;
        LoadIniDir = Settings.Default.LoadIni;

        if (Settings.Default.RecentList != null)
            _recentList = Settings.Default.RecentList;
        LoadRecent();

        runAsAdminToolStripMenuItem.Enabled = !IsAdministrator();
    }

    private static bool IsAdministrator()
    {
        var identity = WindowsIdentity.GetCurrent();
        var principal = new WindowsPrincipal(identity);
        return principal.IsInRole(WindowsBuiltInRole.Administrator);
    }

    private void LoadFile(string fileName)
    {
        try
        {
            var tempLoad = LoadJson<FileInfo>(fileName);
            cbOption.Items.Clear();

            txtSource.Text = tempLoad.SourceFile;
            cbOption.Items.AddRange(tempLoad.Options.ToArray());
            txtTarget.Text = tempLoad.TargetFile;
            txtWorkDir.Text = tempLoad.WorkingDirectory;
            _currentJson = fileName;
            UpdateOptions();
            AddRecentFile(fileName);
        }
        catch
        {
            //
        }
    }

    private static T LoadJson<T>(string fileName)
    {
        if (string.IsNullOrWhiteSpace(fileName)) return default;

        var objectOut = default(T);

        try
        {
            objectOut = JsonConvert.DeserializeObject<T>(File.ReadAllText(fileName));
        }
        catch
        {
            //
        }

        return objectOut;
    }

    private void SaveXml(bool save)
    {
        if (string.IsNullOrWhiteSpace(txtSource.Text))
        {
            MessageBox.Show("Source File is empty", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (save && !string.IsNullOrWhiteSpace(_currentJson))
        {
            SaveFile(_currentJson);
        }
        else
        {
            var saveFile = new SaveFileDialog
            {
                Filter = "JSON|*.json|All files|*.*",
                Title = Text,
                DefaultExt = ".json",
            };
            if (!string.IsNullOrWhiteSpace(LoadIniDir))
            {
                saveFile.InitialDirectory = LoadIniDir;
            }
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                SaveFile(saveFile.FileName);
            }
        }
    }

    private void SaveFile(string fileName)
    {
        var options = (from object? t in cbOption.Items select t.ToString()).ToList();
        var tempSave = new FileInfo
        {
            SourceFile = txtSource.Text,
            Options = options,
            WorkingDirectory = txtWorkDir.Text,
            TargetFile = txtTarget.Text
        };
        SaveJson(tempSave, fileName);
    }

    private static void SaveJson<T>(T serializableObject, string fileName)
    {
        if (serializableObject == null) return;

        try
        {
            File.WriteAllText(fileName, JsonConvert.SerializeObject(serializableObject, Newtonsoft.Json.Formatting.Indented));
        }
        catch
        {
            //
        }
    }

    #endregion Load/Save

    #region Menu

    #region File

    private void loadToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var openFile = new OpenFileDialog
        {
            Filter = "JSON|*.json|All files|*.*",
            Title = Text,
            DefaultExt = ".json"
        };
        if (!string.IsNullOrWhiteSpace(LoadIniDir))
        {
            openFile.InitialDirectory = LoadIniDir;
        }

        if (openFile.ShowDialog() == DialogResult.OK)
        {
            var filePath = openFile.FileName;
            LoadIniDir = filePath.Remove(filePath.Length - openFile.SafeFileName!.Length);
            LoadFile(openFile.FileName);
        }
    }

    private void saveToolStripMenuItem_Click(object sender, EventArgs e)
    {
        SaveXml(true);
    }

    private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        SaveXml(false);
    }

    private void AddRecentFile(string path)
    {
        recentFileToolStripMenuItem.DropDownItems.Clear();

        if (_recentList.Contains(path))
        {
            _recentList.Remove(path);
        }
        _recentList.Insert(0, path);
        while (_recentList.Count > RecentMax)
        {
            _recentList.RemoveAt(_recentList.Count - 1);
        }

        foreach (var fileRecent in _recentList.Select(item => new ToolStripMenuItem(item, null, RecentFile)))
        {
            recentFileToolStripMenuItem.DropDownItems.Add(fileRecent);
        }

        Settings.Default.RecentList = _recentList;
        Settings.Default.Save();
    }

    private void LoadRecent()
    {
        if (_recentList is { Count: 0 }) return;

        foreach (var fileRecent in _recentList.Select(item => new ToolStripMenuItem(item, null, RecentFile)))
        {
            recentFileToolStripMenuItem.DropDownItems.Add(fileRecent); //add the menu to "recent" menu
        }
    }

    private void RecentFile(object sender, EventArgs e)
    {
        var path = sender.ToString();
        if (File.Exists(path))
        {
            LoadFile(path);
        }
        else
        {
            if (path != null)
                _recentList.Remove(path);
        }
    }

    #endregion File

    private void runAsAdminToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Close();
        var path = System.Reflection.Assembly.GetExecutingAssembly().Location;
        if (path.EndsWith(".dll"))
            path = path.Replace(".dll", ".exe");
        var proc = new Process();
        proc.StartInfo.FileName = path;
        proc.StartInfo.UseShellExecute = true;
        proc.StartInfo.Verb = "runas";
        proc.Start();
    }

    #endregion Menu

    #region Drag/Drop Events

    private void DragEnterAll(object sender, DragEventArgs e)
    {
        if (e.Data == null) return;
        e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.Copy : DragDropEffects.None;
    }

    private void FrmMain_DragDrop(object sender, DragEventArgs e)
    {
        IsDragDrop(e);
    }

    private void txtSource_DragDrop(object sender, DragEventArgs e)
    {
        IsDragDrop(e, txtSource);
    }

    private void txtTarget_DragDrop(object sender, DragEventArgs e)
    {
        IsDragDrop(e, txtTarget);
    }

    private void IsDragDrop(DragEventArgs e, Control? txtBox = null)
    {
        if (e.Data == null) return;
        try
        {
            if (!e.Data.GetDataPresent(DataFormats.FileDrop)) return;

            var files = (string[])e.Data.GetData(DataFormats.FileDrop);
            var fileName = files[0];
            if (fileName.EndsWith(".exe") || fileName.EndsWith(".dll"))
            {
                if (txtBox != null)
                    txtBox.Text = fileName;
            }

            if (fileName.EndsWith(".xml"))
            {
                LoadFile(fileName);
            }
        }
        catch
        {
            //
        }
    }

    #endregion Drag/Drop Events

    #region Button Events

    private void btnBrowseSource_Click(object sender, EventArgs e)
    {
        var openFile = new OpenFileDialog
        {
            Filter = "All files(*.*)|*.*",
            Title = Text
        };
        if (!string.IsNullOrWhiteSpace(SourceIniDir))
        {
            openFile.InitialDirectory = SourceIniDir;
        }

        if (openFile.ShowDialog() == DialogResult.OK)
        {
            try
            {
                var filePath = openFile.FileName;
                SourceIniDir = filePath.Remove(filePath.Length - openFile.SafeFileName!.Length);
                txtSource.Text = openFile.FileName;
            }
            catch
            {
                //
            }
        }
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        cbOption.Items.Add(txtAddOption.Text);
        txtAddOption.Clear();
        cbOption.SelectedIndex = cbOption.Items.Count - 1;
        UpdateOptions();
    }

    private void btnRemove_Click(object sender, EventArgs e)
    {
        cbOption.Items.RemoveAt(cbOption.SelectedIndex);
        UpdateOptions();
    }

    private void UpdateOptions()
    {
        lbOptions.Text = "Count: " + cbOption.Items.Count;
        UpdateArgs();
    }

    private void btnBrowseTarget_Click(object sender, EventArgs e)
    {
        var openFile = new OpenFileDialog
        {
            Filter = "All files(*.*)|*.*",
            Title = Text
        };
        if (!string.IsNullOrWhiteSpace(TargetIniDir))
        {
            openFile.InitialDirectory = TargetIniDir;
        }

        if (openFile.ShowDialog() == DialogResult.OK)
        {
            try
            {
                var filePath = openFile.FileName;
                TargetIniDir = filePath.Remove(filePath.Length - openFile.SafeFileName!.Length);
                txtTarget.Text = openFile.FileName;
            }
            catch
            {
                //
            }
        }
    }

    private void btnRun_Click(object sender, EventArgs e)
    {
        var process = new Process();
        var startInfo = new ProcessStartInfo
        {
            FileName = "cmd.exe",
            Arguments = txtArgurments.Text,
            RedirectStandardInput = true,
        };
        if (!string.IsNullOrWhiteSpace(txtWorkDir.Text))
        {
            startInfo.WorkingDirectory = txtWorkDir.Text;
        }
        process.StartInfo = startInfo;
        process.Start();
    }

    #endregion Button Events

    #region Update Args

    private void txtSource_TextChanged(object sender, EventArgs e)
    {
        UpdateArgs();
    }

    private void txtTarget_TextChanged(object sender, EventArgs e)
    {
        UpdateArgs();
    }

    private void chkPause_CheckedChanged(object sender, EventArgs e)
    {
        UpdateArgs();
    }

    private void UpdateArgs()
    {
        var pause = chkPause.Checked ? "/K " : "/C ";

        var target = GetTargetPath();

        var source = GetSource(target);

        var options = GetOptions();

        txtArgurments.Text = pause + source + options + target;
    }

    private string GetSource(string target)
    {
        var source = txtSource.Text;
        if (source.StartsWith("\"") && source.EndsWith("\"")) return source;

        source = "\"" + txtSource.Text + "\"";

        if (string.IsNullOrWhiteSpace(target)) return source;

        return "\"\"" + txtSource.Text + "\"";
    }

    private string GetOptions()
    {
        return cbOption.Items.Cast<object?>().Aggregate("", (current, t) => current + (" " + t));
    }

    private string GetTargetPath()
    {
        var target = txtTarget.Text;
        if (string.IsNullOrWhiteSpace(target)) return target;

        target = " " + txtTarget.Text;

        if (target.StartsWith(" \"") && target.EndsWith("\"")) return target;

        return " \"" + txtTarget.Text + "\"\"";
    }

    #endregion Update Args
}
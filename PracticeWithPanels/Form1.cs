using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace PracticeWithPanels
{
    //public partial class Form1 : System.Collections.Generic.IEqualityComparer<System.IO.FileInfo>
    //{
    //    public bool Equals(System.IO.FileInfo f1, System.IO.FileInfo f2)
    //    {
    //        return (f1.Name == f2.Name);
    //    }

    //    public int GetHashCode(System.IO.FileInfo fi)
    //    {
    //        string s = fi.Name;
    //        return s.GetHashCode();
    //    }
    //}

    public partial class Form1 : Form
    {
        Dictionary<string, string> FolderToCompare = new Dictionary<string, string>();
        Dictionary<string, string> OriginalFolder = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            Cursor = Cursors.WaitCursor;

            #region #AttemptNumberOne
            //string folderToSearch_1 = null;
            //string folderToSearch_2 = null;
            //string[] fileExtensions =
            //{
            //    "NEF",
            //    ".JPG",
            //    ".JPEG",
            //    ".PNG"
            //};

            //if (lblSelectedFolder.Text != null && lblSelectedFolder_2.Text != null)
            //{
            //    folderToSearch_1 = lblSelectedFolder.Text;
            //    folderToSearch_2 = lblSelectedFolder_2.Text;

            //    Stopwatch watch = new Stopwatch();
            //    watch.Start();

            //    Cursor = Cursors.WaitCursor;
            //    treeView1.Visible = false;
            //    treeView1.Nodes.Clear();
            //    Refresh();

            //    try
            //    {
            //        // Groups = groups of duplicate files
            //        // info = individual file
            //        var getFileInfo1 =
            //            from string filename in Directory.GetFiles(folderToSearch_1, "*.*", SearchOption.AllDirectories)
            //                .Where(name => name.EndsWith(".NEF") || name.EndsWith(".JPG") || name.EndsWith(".JPEG"))
            //            select new
            //            {
            //                Name = filename,
            //                Hash = GetFileHash(filename)
            //            };

            //        var getFileInfo2 =
            //            from string filename_2 in Directory.GetFiles(folderToSearch_2, "*.*", SearchOption.AllDirectories)
            //                .Where(s => fileExtensions.Contains(Path.GetExtension(s).ToUpper()))
            //            select new
            //            {
            //                Name = filename_2,
            //                Hash = GetFileHash(filename_2)
            //            };


            //        // Select all files with the same hash
            //        // Group them by the hash code
            //        var duplicateFileGroups =
            //            from info in getFileInfo1
            //            group info by info.Hash
            //            into g
            //            where g.Count() > 1
            //            select g;

            //        int num_groups = 0;
            //        int num_files = 0;


            //        // This outputs the following: 
            //        // g8g7dJpDTRfkDDqYojWaA==
            //        //      D:\Media\Test\2010-08-12\100_1581 - Copy.JPG
            //        //      D:\Media\Test\2010-08-12\100_1581.JPG
            //        foreach (var g in duplicateFileGroups)
            //        {
            //            num_groups++;
            //            TreeNode hash_node = treeView1.Nodes.Add(g.Key.ToString());
            //            foreach (var info in g)
            //            {
            //                num_files++;
            //                TreeNode file_node = new TreeNode(info.Name);
            //                file_node.Tag = new FileInfo(info.Name);
            //                hash_node.Nodes.Add(file_node);
            //            }
            //        }

            //        lblNumDuplicates.Text = (num_files - num_groups).ToString() + " duplicate files";
            //        treeView1.ExpandAll();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }
            //    finally
            //    {
            //        if (treeView1.Nodes.Count > 0)
            //        {
            //            treeView1.Nodes[0].EnsureVisible();
            //        }

            //        treeView1.Visible = true;
            //        Cursor = Cursors.Default;
            //    }

            //    watch.Stop();
            //    lblExecutionTime.Text = watch.Elapsed.TotalSeconds.ToString("0.00") + " seconds";
            //}
            //else
            //{
            //    MessageBox.Show("Please select a folder to search");
            //}

            #endregion
            // Clear the dictionaries on new attempt
            FolderToCompare.Clear();
            OriginalFolder.Clear();

            if (lblSelectedFolder.Text.Length > 2 && lblSelectedFolder_2.Text.Length > 2)
            {
                string sourceFolder = lblSelectedFolder.Text;
                string destFolder = lblSelectedFolder_2.Text;

                // List of extensions to search for
                var AllowableExtensions = new List<string>();

                if (ckbCameraRaw.Checked == true)
                {
                    string[] fileTypes = {
                        ".NEF", ".CR2", ".ARW", ".RW2", ".WGI", ".RAW", ".KDC", ".FPX",
                        ".DCR", ".EIP", ".FFF", ".ARW", ".PCD", ".CZI", ".PEF", ".KQP",
                        ".LFR", ".DNG", ".RWL", ".IIQ", ".RAF", ".R3D", ".ORF", ".IA",
                        ".CRW", ".MOS", ".3FR", ".ARI", ".CIB", ".MDC", ".MRW", ".APU",
                        ".x3F", ".MEF", ".SR2", ".RA2", ".NOP", ".DC2", ".ST7", ".NDD",
                        ".EXF", ".LFP", ".OLR", ".SRW", ".SRF", ".ERF", ".GREY", ".GRAY",
                        ".GRY ", ".ST8 ", ".MF@ ", ".ST4 ", ".KC2 ", ".DCS ", ".CRAW", ".CE1 ",
                        ".RWZ ", ".3PR ", ".YCBCRA", ".BAY", ".ST6", ".CMT", ".STX", ".NWB",
                        ".M02", ".SD0", ".M03"};
                    AllowableExtensions.AddRange(fileTypes);
                };

                if (ckbImageFiles.Checked == true)
                {
                    string[] fileTypes =
                    {
                        ".JPEG", ".JPG", ".JFIF", ".EXIF", ".TIFF", ".GIF", ".BMP", ".PNG", ".SVG",
                        ".PPM", ".PGM", ".PBM", ".PNM", ".WEBP", ".HEIF", ".BAT", ".BPG", ".CGM"
                    };
                    AllowableExtensions.AddRange(fileTypes);
                }

                if (sourceFolder != destFolder)
                {

                    //        var getFileInfo1 =
                    //            from string filename in Directory.GetFiles(folderToSearch_1, "*.*", SearchOption.AllDirectories)
                    //                .Where(name => name.EndsWith(".NEF") || name.EndsWith(".JPG") || name.EndsWith(".JPEG"))
                    //            select new
                    //            {
                    //                Name = filename,
                    //                Hash = GetFileHash(filename)
                    //            };

                    int numDuplicates = 0;
                    Stopwatch watch = new Stopwatch();
                    watch.Start();

                    var fileName1 =
                        from string filename
                        in Directory.GetFiles(sourceFolder, "*.*", SearchOption.AllDirectories)
                        .Where(s => s.EndsWith(Path.GetExtension(s), StringComparison.OrdinalIgnoreCase))
                        select new
                        {
                            Name = filename
                        };
                    var fileName2 =
                        from string filename2
                            in Directory.GetFiles(destFolder, "*.*", SearchOption.AllDirectories)
                            .Where(s => s.EndsWith(Path.GetExtension(s), StringComparison.OrdinalIgnoreCase))
                        select new
                        {
                            Name = filename2
                        };

                    // Create a FolderToCompare list of all files in destination folder
                    lblNextStage.Text = "1 of 3";
                    foreach (var file in fileName2)
                    {
                        UpdateStatusStrip(file.Name);
                        string fileToAdd = AddToHashTable(file.Name);
                        FolderToCompare.Add(file.Name, fileToAdd);
                    }
                    lblNextStage.Text = "2 of 3";
                    // Create a FolderToCompare list of all files in the source folder
                    foreach (var file1 in fileName1)
                    {
                        UpdateStatusStrip(file1.Name);
                        string fileToAdd2 = AddToHashTable(file1.Name);
                        OriginalFolder.Add(file1.Name, fileToAdd2);
                    }

                    lblNextStage.Text = "3 of 3";

                    toolStripCurrentlyAnalyzing.Text = "Comparing files - This may take some time.";

                    // Foreach "C:\Users\X\Documents\Document" => "xCLK10+8201AbxU4913ztYYa=="
                    foreach (KeyValuePair<string, string> possibleDuplicate in FolderToCompare)
                    {
                        // Get the name of the original file in the original folder
                        // (folder 2: D:\Media\Pictures\file001.jpeg)
                        string originalName = OriginalFolder.Keys.FirstOrDefault(k => k.Equals(possibleDuplicate.Key));


                        // Get the name of the duplicate file in the compared against folder
                        // (folder 1: E:\Media\Pictures\file001.jpeg)
                        string duplicateName = possibleDuplicate.Key.ToString();

                        if (OriginalFolder.ContainsValue(possibleDuplicate.Value.ToString()))
                        {

                            treeView1.Nodes.Add("These files may be duplicates:");
                            if (FileCompare(originalName, duplicateName))
                            {
                                TreeNode node = new TreeNode("Possible duplicate: " + duplicateName);
                                TreeNode originalFileNode = new TreeNode("Original file location: " + originalName);
                                treeView1.Nodes.Add(node);
                                treeView1.Refresh();
                            }
                        }
                    }
                    toolStripCurrentlyAnalyzing.Text = "Done Analyzing.";


                    // Replaced foreach with LINQ statement
                    //foreach (var s in fileName1)
                    //{
                    //    foreach (var t in fileName2)
                    //    {
                    //        lblCurrentlyAnalyzing.Text = s.Name.ToString();
                    //        if (FileCompare(s.Name, t.Name))
                    //        {
                    //            numDuplicates++;
                    //            // num_files++;
                    //            // TreeNode file_node = new TreeNode(info.Name);
                    //            // file_node.Tag = new FileInfo(info.Name);
                    //            // hash_node.Nodes.Add(file_node);
                    //            TreeNode file_node = new TreeNode(s.Name);
                    //            file_node.Tag = new FileInfo(t.Name);
                    //            treeView1.Nodes.Add("Original file:  " + s.Name);
                    //            treeView1.Nodes.Add("Duplicate file: " + t.Name);
                    //            treeView1.Nodes.Add("+---------------------------------------------+");
                    //        };
                    //    }
                    //}

                    // Stop the watch
                    watch.Stop();

                    // After analyzing, reset the cursor to the default and enable the buttons. 
                    Cursor = Cursors.Default;
                    btnStart.Enabled = true;

                    // Update the status strip to empty, and update labels to show a finished status. 
                    toolStripCurrentlyAnalyzing.Text = null;
                    lblNumberFilesAnalyzed.Text = FolderToCompare.Count.ToString();
                    lblExecutionTime.Text = watch.Elapsed.ToString();
                    lblNumDuplicates.Text = numDuplicates.ToString();
                }
                else
                {
                    MessageBox.Show("Please select two different folders to analyze");
                }
            }
            else
            {
                MessageBox.Show("Please select a source and destination folder");
                btnStart.Enabled = true;
                Cursor = Cursors.Default;
            }

        }

        private string AddToHashTable(string fileName)
        {
            try
            {
                FileStream source = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                byte[] shortenedSource = new byte[1024];
                using (BinaryReader reader = new BinaryReader(new FileStream(fileName, FileMode.Open, FileAccess.Read)))
                {
                    reader.BaseStream.Seek(0, SeekOrigin.Begin);
                    reader.Read(shortenedSource, 0, 1024);
                }
                using (var md5 = MD5.Create())
                {
                    var hash = md5.ComputeHash(shortenedSource);
                    string hashString = Convert.ToBase64String(hash);
                    // Returns an MD5 checksum of a file, like: g8g7dJpDTRfkDDqYojWaA==
                    return hashString;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return "An error occured";
            }
        }

        private bool FileCompare(string file1, string file2)
        {
            int file1Bytes;
            int file2Bytes;

            if (file1 == file2)
            {
                return true;
            }

            FileStream fs1 = new FileStream(file1, FileMode.Open, FileAccess.Read);
            FileStream fs2 = new FileStream(file2, FileMode.Open, FileAccess.Read);

            if (fs1.Length != fs2.Length)
            {
                fs1.Close();
                fs2.Close();
                return false;
            }

            do
            {
                file1Bytes = fs1.ReadByte();
                file2Bytes = fs2.ReadByte();
            } while ((file1Bytes == file2Bytes) && (file1Bytes != -1));

            fs1.Close();
            fs2.Close();

            return ((file1Bytes - file2Bytes) == 0);
        }

        //Refresh the statusStrip and show the current file being analyzed

        private void UpdateStatusStrip(string fileName)
        {
            toolStripCurrentlyAnalyzing.Text = fileName;
            statusStrip1.Refresh();
        }


        private void btnChooseFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            lblSelectedFolder.Text = folderBrowserDialog1.SelectedPath;
        }

        private void ckbFilesAll_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbFilesAll.Checked == true)
            {
                ckbCameraRaw.Enabled = false;
                ckbCameraRaw.Checked = true;
                ckbDocuments.Enabled = false;
                ckbDocuments.Checked = true;
                ckbImageFiles.Enabled = false;
                ckbImageFiles.Checked = true;
                ckbPdf.Checked = true;
                ckbPdf.Enabled = false;
                ckbVideo.Checked = true;
                ckbVideo.Enabled = false;

            }
            else
            {
                ckbCameraRaw.Enabled = true;
                ckbCameraRaw.Checked = false;
                ckbDocuments.Enabled = true;
                ckbDocuments.Checked = false;
                ckbImageFiles.Enabled = true;
                ckbImageFiles.Checked = false;
                ckbPdf.Checked = false;
                ckbPdf.Enabled = true;
                ckbVideo.Checked = false;
                ckbVideo.Enabled = true;
            }
        }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void btnChooseFolder_2_Click(object sender, EventArgs e)
    {
        folderBrowserDialog2.ShowDialog();
        lblSelectedFolder_2.Text = folderBrowserDialog2.SelectedPath;

    }

    private void btnChooseFolder_2_Click_1(object sender, EventArgs e)
    {

        folderBrowserDialog2.ShowDialog();
        lblSelectedFolder_2.Text = folderBrowserDialog2.SelectedPath;
    }

    private void toolStripStatusLabel1_Click(object sender, EventArgs e)
    {

    }
}
}

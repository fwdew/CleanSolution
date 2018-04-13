using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CleanSolution
{
   public partial class CleanForm : Form
   {
      private readonly string[] FOLDERS_TO_DELETE = {
         ".vs",
         "bin",
         "obj",
         "debug",
         "release"
      };

      public CleanForm()
      {
         InitializeComponent();
      }

      private string GetFolderPathToClean()
      {
         using (var fbd = new FolderBrowserDialog()) {
            var result = fbd.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath)) {
               return fbd.SelectedPath;
            }
         }

         return string.Empty;
      }

      private void CleanFolderRecursively(string folderName)
      {
         var subFolders = Directory.GetDirectories(folderName);
         for (var i = 0; i < subFolders.Length; i++) {
            var subFolder = subFolders[i];
            var subFolderName = Path.GetFileName(subFolder).ToLower();

            if (FOLDERS_TO_DELETE.Contains(subFolderName)) {
               Directory.Delete(subFolder, true);
            } else {
               CleanFolderRecursively(subFolder);
            }
         }
      }

      private void buttonClean_Click(object sender, EventArgs e)
      {
         var mainFolder = GetFolderPathToClean().Trim();

         if (!string.IsNullOrEmpty(mainFolder)
            && Directory.Exists(mainFolder)) {
            CleanFolderRecursively(mainFolder);
            Close();
         }
      }
   }
}

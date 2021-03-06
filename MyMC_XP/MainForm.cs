﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Linq;
using Nini.Config;
//using System.Threading.Tasks;
using System.Windows.Forms;
using MyMCLibrary;
using log4net;

namespace MyMC_XP
{
    public partial class MainForm : Form, IEditPaths
    {
        //private static readonly ILog log = LogHelper.GetLogger();
		private static readonly ILog log = LogHelper.Get_Logger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

        public MainForm()
        {
            InitializeComponent();
            Logger.Setup();
        }

        void MainFormLoad(object sender, EventArgs e)
        {
            hourLabel.Text = DateTime.Now.ToString("HH:mm:ss");

            DisableMenuComboBoxOptions();

            LoadConfig();

        }


        #region Interface methods

        public void SetPaths(string saveExportPath, string cardsFolderPath, string saveFolderPath, string newCardsFolderPath)
        {
            userExportFolder = saveExportPath;
            lastOpenMcDir = cardsFolderPath;
            lastOpenSaveDir = saveFolderPath;
            newCardsFolder = newCardsFolderPath;

            SaveConfig();
        }

        public void SetOptionPath(string anOption, string aValue)
        {
            SaveOption(anOption, aValue);
            LoadConfig();
        }

        #endregion


        #region MenuBarItem		

        void CloseMC1ToolStripMenuItemClick(object sender, EventArgs e)
        {
            #region Debug				
            log.Debug("───────────────────────────────────────────────────────────────────────────────\n" +
                        "Close Mc1 button click.");
            #endregion

            memoryCardOne = null;

            DisableMcOneButtons();
            label1.Text = "Memory Card Name: ";

            if (memoryCardTwo != null)
            {
                toolStripStatusLabel1.Text = memoryCardTwo.GetPath();
                toolStripStatusLabel2.Text = memoryCardTwo.GetFreeSpace();
            }
            else
            {
                toolStripStatusLabel1.Text = NO_CARD;
                toolStripStatusLabel2.Text = EMPTY_CARD;
            }

            #region Debug
            log.Debug("Close Mc1 button click - Exit." +
                        "\n───────────────────────────────────────────────────────────────────────────────");
            #endregion
        }

        void CloseMC2ToolStripMenuItemClick(object sender, EventArgs e)
        {
            #region Debug
            log.Debug("───────────────────────────────────────────────────────────────────────────────\n" +
                        "Close Mc2 button click.");
            #endregion

            memoryCardTwo = null;

            DisableMcTwoButtons();
            label2.Text = "Memory Card Name: ";

            if (memoryCardOne != null)
            {
                toolStripStatusLabel1.Text = memoryCardOne.GetPath();
                toolStripStatusLabel2.Text = memoryCardOne.GetFreeSpace();
            }
            else
            {
                toolStripStatusLabel1.Text = NO_CARD;
                toolStripStatusLabel2.Text = EMPTY_CARD;
            }

            #region Debug
            log.Debug("Close Mc2 button click - Exit." +
                        "\n───────────────────────────────────────────────────────────────────────────────");
            #endregion
        }

        void CreateMcToolStripMenuItemClick(object sender, EventArgs e)
        {
            #region Debug
            log.Debug("───────────────────────────────────────────────────────────────────────────────\n" +
                        "Create Mc button click.");
            #endregion

            GenMc vmcForm = new GenMc();
            vmcForm.SetUtil = util_VMC;
            //			vmcForm.SetConverter	= util_Converter;
            //			vmcForm.SetTempCleaner  = util_TempCleaner;
            vmcForm.SetTempFolder = tempFolder;
            vmcForm.SetDirectory = newCardsFolder;

            vmcForm.ShowDialog(this);

            #region Debug
            log.Debug("Create Mc button click - Exit." +
                        "\n───────────────────────────────────────────────────────────────────────────────");
            #endregion
        }

        void ExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            Close();
        }


        void AsPSUToolStripMenuItemMouseUp(object sender, MouseEventArgs e)
        {
            #region Debug
            log.Debug("───────────────────────────────────────────────────────────────────────────────\n" +
                        "As PSU Checked.");
            #endregion

            mode = MODE_PSU;

            #region Debug
            log.Debug("\nMODE = " + mode + "\n");
            log.Debug("As PSU Checked - Exit." +
                        "\n───────────────────────────────────────────────────────────────────────────────");
            #endregion
        }

        void AsmaxToolStripMenuItemMouseUp(object sender, MouseEventArgs e)
        {
            #region Debug
            log.Debug("───────────────────────────────────────────────────────────────────────────────\n" +
                        "As MAX Checked.");
            #endregion

            mode = MODE_MAX;

            #region Debug
            log.Debug("\nMODE = " + mode + "\n");
            log.Debug("As MAX Checked - Exit." +
                        "\n───────────────────────────────────────────────────────────────────────────────");
            #endregion
        }


        void AllPSUToolStripMenuItemClick(object sender, EventArgs e)
        {
            var files = GetFilesByExtensions(lastOpenSaveDir, ".psu");

            DoProgress(files);

        }

        void AllMAXToolStripMenuItemClick(object sender, EventArgs e)
        {
            var files = GetFilesByExtensions(lastOpenSaveDir, ".max");

            DoProgress(files);
        }

        void AllCBSToolStripMenuItemClick(object sender, EventArgs e)
        {
            var files = GetFilesByExtensions(lastOpenSaveDir, ".cbs");

            DoProgress(files);
        }

        void AllNPOToolStripMenuItemClick(object sender, EventArgs e)
        {
            var files = GetFilesByExtensions(lastOpenSaveDir, ".npo");

            DoProgress(files);
        }

        void AllFILESToolStripMenuItemClick(object sender, EventArgs e)
        {
            var files = GetFilesByExtensions(lastOpenSaveDir, ".psu", ".max", ".cbs", ".npo");

            DoProgress(files);
        }


        void VmcConverterToolStripMenuItemClick(object sender, EventArgs e)
        {
            var vmcConverter = new VmcConverter();
            vmcConverter.ShowDialog();
        }


        void PreferencesToolStripMenuItemClick(object sender, EventArgs e)
        {
            Preference preferences = new Preference();

            preferences.ExportPath = userExportFolder;
            preferences.FolderCards = lastOpenMcDir;
            preferences.SavesFolder = lastOpenSaveDir;
            preferences.NewCardsFolder = newCardsFolder;

            preferences.ShowDialog(this);
        }


        void MyMcDualToolStripMenuItemClick(object sender, EventArgs e)
        {
            MessageBox.Show("MyMc Dual " + VERSION + ":\n" +
                            "\tThis tool makes use of\n" +
                            "\t\t·MYMC PS2 tool command line\n" +
                            "\t\t·Genvmc tool command line.\n" +
                            "\t\t·Convpcsx tool command line.\n" +
                            "The thanks goes to the respective authors.\n\n" +
                               "Author: Joack.", "About MyMc Dual");
        }

        #endregion


        #region MenuIconsBar

        void OpenMcOneButtonClick(object sender, EventArgs e)
        {

            #region	Debug
            log.Debug("_______________________________________________________________________________");
            log.Debug("Open Mc1 button click.\n");
            #endregion

            memoryCardOne = OpenMc(memoryCardOne);

            if (memoryCardOne != null)
            {
                #region	Debug
                log.Debug("\nMc1 is not null.\n");
                DebugMc(memoryCardOne);
                #endregion

                label1.Text = "Memory Card Name: " + Path.GetFileName(memoryCardOne.GetPath());
                EnableMcOneButtons();
                ShowMcContent(memoryCardOne, dataGridView1);

            }
            #region	Debug		
            else
            {
                log.Debug("\nMc1 is null.\n");
            }

            log.Debug("\nOpen Mc1 button click - Exit.\n");
            log.Debug("_______________________________________________________________________________");
            #endregion
        }

        void OpenMcTwoButtonClick(object sender, EventArgs e)
        {

            #region Debug
            log.Debug("_______________________________________________________________________________");
            log.Debug("Open Mc2 button click." + Environment.NewLine);
            #endregion

            memoryCardTwo = OpenMc(memoryCardTwo);

            if (memoryCardTwo != null)
            {
                #region Debug
                log.Debug("\nMc2 is not null.\n");
                DebugMc(memoryCardTwo);
                #endregion

                label2.Text = "Memory Card Name: " + Path.GetFileName(memoryCardTwo.GetPath());
                EnableMcTwoButtons();
                ShowMcContent(memoryCardTwo, dataGridView2);
            }
            #region	Debug		
            else
            {
                log.Debug("\nMc2 is null.\n");
            }

            log.Debug("Open Mc2 button click - Exit.\n");

            log.Debug("_______________________________________________________________________________");
            #endregion
        }


        void ImportToMcOneButtonClick(object sender, EventArgs e)
        {
            #region Debug
            log.Debug("───────────────────────────────────────────────────────────────────────────────\n" +
                      "Import to Mc1 button click.\n");
            #endregion

            OpenFileDialog importOpenDialog = GetImportFileDialog();

            if (importOpenDialog.ShowDialog() == DialogResult.OK)
            {
                #region debug
                log.Debug("Ok button.");
                #endregion

                string mcPath = memoryCardOne.GetPath();
                lastOpenSaveDir = Path.GetDirectoryName(importOpenDialog.FileNames[0]);

                #region Debug
                log.Debug("Importing:\n");
                #endregion

                foreach (string importFile in importOpenDialog.FileNames)
                {
                    #region Debug
                    log.Debug("File: " + importFile);
                    #endregion

                    Utils.Card.ImportSave(mcPath, importFile);
                }

                SetOptionPath("SaveFolder", lastOpenSaveDir);
            }
            #region debug
            else
            {
                log.Debug("Cancel Button.");
            }
            #endregion

            memoryCardOne = RefreshMemoryCard(memoryCardOne, dataGridView1);

            #region Debug
            log.Debug("\nImport to Mc1 button click - Exit.\n" +
                        "───────────────────────────────────────────────────────────────────────────────");
            #endregion

        }

        void ImportToMcTwoButtonClick(object sender, EventArgs e)
        {
            #region Debug
            log.Debug("───────────────────────────────────────────────────────────────────────────────\n" +
                      "Import to Mc2 button click.\n");
            #endregion

            OpenFileDialog importOpenDialog = GetImportFileDialog();

            if (importOpenDialog.ShowDialog() == DialogResult.OK)
            {
                string mcPath = memoryCardTwo.GetPath();

                #region Debug
                log.Debug("Importing:\n");
                #endregion

                foreach (string importFile in importOpenDialog.FileNames)
                {
                    #region Debug
                    log.Debug("File: " + importFile);
                    #endregion

                    Utils.Card.ImportSave(mcPath, importFile);
                }
            }
            memoryCardTwo = RefreshMemoryCard(memoryCardTwo, dataGridView2);

            #region Debug
            log.Debug("\nImport to Mc2 button click - Exit.\n" +
                        "───────────────────────────────────────────────────────────────────────────────");
            #endregion
        }


        void ExportSaveButtonClick(object sender, EventArgs e)
        {
            #region Debug
            log.Debug("───────────────────────────────────────────────────────────────────────────────\n" +
                              "Export Save Button Click\n");
            #endregion

            DataGridView dgv = GetDataGridView(focusedMemoryCard);
            MemoryCard card = GetActualCard(dgv.Name);

            if (card != null)
            {
                DataGridViewSelectedRowCollection savesCollection = dgv.SelectedRows;
                string filePath = String.Empty;

                #region Debug
                log.Debug("Exporting files\n");
                log.Debug(String.Format("{0,-20} {1,5} {2,-25} {3}", "Name", "Size", "Date", "Description\n"));
                #endregion

                foreach (DataGridViewRow row in savesCollection)
                {
                    Utils.Card.ExportSave(card.GetPath(), row.Cells[0].Value.ToString(), userExportFolder, mode);

                    #region Debug
                    log.Debug(String.Format("{0,-20} {1,5} {2,-25} {3}", row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(),
                              row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString()));
                    #endregion

                }
                #region Debug
                log.Debug("Export Finished.\n");
                #endregion

                MessageBox.Show("Finish export files.");
            }
            #region Debug
            else
            {
                log.Debug("No memory card opened.");

            }
            #endregion

            #region Debug
            log.Debug("Export Save Button Click - Exit\n" +
                      "───────────────────────────────────────────────────────────────────────────────");
            #endregion
        }


        void McOneToMcTwoButtonClick(object sender, EventArgs e)
        {
            #region Debug
            log.Debug("───────────────────────────────────────────────────────────────────────────────\n" +
                              "Mc1 to Mc2 file transfer Button Click\n");
            #endregion

            TransferSavesMcOneToMcTwo(dataGridView1.SelectedRows);

            #region debug
            log.Debug("\nMc1 to Mc2 file transfer Button Click - Exit.\n" +
                        "───────────────────────────────────────────────────────────────────────────────");
            #endregion
        }

        void McTwoToMcOneButtonClick(object sender, EventArgs e)
        {
            #region Debug
            log.Debug("───────────────────────────────────────────────────────────────────────────────\n" +
                      "Mc2 to Mc1 file transfer Button Click\n");
            #endregion

            TransferSavesMcTwoToMcOne(dataGridView2.SelectedRows);

            #region debug
            log.Debug("\nMc2 to Mc1 file transfer Button Click - Exit.\n" +
                                "───────────────────────────────────────────────────────────────────────────────");
            #endregion
        }


        void DeleteSaveButtonClick(object sender, EventArgs e)
        {
            #region Debug
            log.Debug("───────────────────────────────────────────────────────────────────────────────\n" +
                      "Delete Save Button Click\n\n" +
                        "Deleting file(s):\n");
            #endregion

            if (focusedMemoryCard.Name == "dataGridView1")
            {
                memoryCardOne = DoDelete(ref memoryCardOne);

                #region	Debug
                DebugMc(memoryCardOne);
                #endregion
            }
            else
            {
                memoryCardTwo = DoDelete(ref memoryCardTwo);

                #region Debug
                DebugMc(memoryCardTwo);
                #endregion
            }


        }

        #endregion


        #region StatusBarItems		

        void ToolStripStatusLabel1Click(object sender, EventArgs e)
        {
            string pathDir = toolStripStatusLabel1.Text;

            if (pathDir != null && pathDir != String.Empty && pathDir != NO_CARD)
            {
                System.Diagnostics.Process.Start("explorer.exe", String.Format("/select, \"{0}\"", pathDir));
            }
        }

        void Timer1Tick(object sender, EventArgs e)
        {
            hourLabel.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        #endregion


        #region My Methods

        private MemoryCard OpenMc(MemoryCard card)
        {
            mcOpenDialog.Reset();
            mcOpenDialog.Filter = "PS2 File Format|*.ps2|PS2 File Bin Format|*.bin";
            mcOpenDialog.FilterIndex = 2;
            mcOpenDialog.InitialDirectory = lastOpenMcDir;

            mcOpenDialog.FileName = "";
            mcOpenDialog.Multiselect = false;

            if (mcOpenDialog.ShowDialog() == DialogResult.OK)
            {
                #region Debug
                log.Debug("Ok button\n");
                #endregion

                string mc = mcOpenDialog.FileName;
                lastOpenMcDir = Path.GetDirectoryName(mcOpenDialog.FileName);

                SetOptionPath("McFolder", lastOpenMcDir);

                return new MemoryCard(mc, Utils.Card.LoadFiles(mc), Utils.Card.GetMcFreeSpace(mc));
            }
            #region Debug
            log.Debug("Cancel button");
            #endregion
            return card;
        }

        private void ShowMcContent(MemoryCard card, DataGridView mcView)
        {
            mcView.Rows.Clear();

            List<SaveFile> listFiles = card.LoadSaves();

            for (int i = 2; i <= listFiles.Count - 1; i++)
            {
                SaveFile save = listFiles[i];
                mcView.Rows.Add(save.FileName, save.FileSize, save.FileDate, save.FileDescription);
            }

            toolStripStatusLabel1.Text = card.GetPath();
            toolStripStatusLabel2.Text = card.GetFreeSpace();

        }

        private void EnableMcOneButtons()
        {
            importToMcOneButton.Enabled = true;
            mcOneToMcTwoButton.Enabled = true;
            dataGridView1.Enabled = true;
            closeMC1ToolStripMenuItem.Enabled = true;
            deleteSaveButton.Enabled = true;
            ExportSaveButton.Enabled = true;
        }

        private void EnableMcTwoButtons()
        {
            importToMcTwoButton.Enabled = true;
            mcTwoToMcOneButton.Enabled = true;
            dataGridView2.Enabled = true;
            closeMC2ToolStripMenuItem.Enabled = true;
            deleteSaveButton.Enabled = true;
            ExportSaveButton.Enabled = true;
        }

        private void DisableMcOneButtons()
        {
            importToMcOneButton.Enabled = false;
            mcOneToMcTwoButton.Enabled = false;
            dataGridView1.Rows.Clear();
            dataGridView1.Enabled = false;
            closeMC1ToolStripMenuItem.Enabled = false;

            if (memoryCardTwo == null)
            {
                ExportSaveButton.Enabled = false;
                deleteSaveButton.Enabled = false;
            }
        }

        private void DisableMcTwoButtons()
        {
            importToMcTwoButton.Enabled = false;
            mcTwoToMcOneButton.Enabled = false;
            dataGridView2.Rows.Clear();
            dataGridView2.Enabled = false;
            closeMC2ToolStripMenuItem.Enabled = false;

            if (memoryCardOne == null)
            {
                ExportSaveButton.Enabled = false;
                deleteSaveButton.Enabled = false;
            }
        }

        private void OnFocusMemoryCard(object sender, EventArgs e)
        {
            focusedMemoryCard = sender as DataGridView;


            switch (focusedMemoryCard.Name)
            {
                case "dataGridView1":

                    if (memoryCardOne != null)
                    {
                        toolStripStatusLabel1.Text = memoryCardOne.GetPath();
                        toolStripStatusLabel2.Text = memoryCardOne.GetFreeSpace();
                    }
                    else
                    {
                        toolStripStatusLabel1.Text = NO_CARD;
                        toolStripStatusLabel2.Text = EMPTY_CARD;
                    }

                    break;

                case "dataGridView2":

                    if (memoryCardTwo != null)
                    {
                        toolStripStatusLabel1.Text = memoryCardTwo.GetPath();
                        toolStripStatusLabel2.Text = memoryCardTwo.GetFreeSpace();
                    }
                    else
                    {
                        toolStripStatusLabel1.Text = NO_CARD;
                        toolStripStatusLabel2.Text = EMPTY_CARD;
                    }

                    break;

                default:
                    toolStripStatusLabel1.Text = NO_CARD;
                    toolStripStatusLabel2.Text = EMPTY_CARD;
                    break;
            }
        }

        private string DoFileName(string sourceFile, string destinyDir)
        {
            string fileName = Path.GetFileNameWithoutExtension(sourceFile);
            string fileExt = Path.GetExtension(sourceFile);
            string fileFullName = String.Format("{0}{1}", fileName, fileExt);

            int index = 1;

            while (File.Exists(destinyDir + "\\" + fileFullName))
            {
                fileFullName = String.Format("{0}({1}){2}", fileName, index, fileExt);
                index++;
            }
            return destinyDir + fileFullName;
        }

        private void TransferSaves(MemoryCard cardFrom, MemoryCard cardTo, IEnumerable savesCollection)
        {
            if (cardTo != null)
            {
                #region Debug
                log.Debug("Transferring files.\n");
                log.Debug(String.Format("From: {0}", cardFrom.GetPath()));
                log.Debug(String.Format("To: {0}\n", cardTo.GetPath()));
                #endregion

                string filePath = String.Empty;
                string saveName = String.Empty;
                string mcPathFrom = cardFrom.GetPath();
                string mcPathTo = cardTo.GetPath();

                foreach (DataGridViewRow saveRow in savesCollection)
                {
                    saveName = saveRow.Cells[0].Value.ToString();

                    #region Debug
                    log.Debug(String.Format("Exporting file {0} from {1}", saveName, mcPathFrom));
                    #endregion

                    Utils.Card.ExportSave(mcPathFrom, saveName, tempFolder, MODE_PSU);

                    filePath = String.Format("{0}\\{1}{2}", tempFolder, saveName, ".psu");

                    #region Debug
                    log.Info(String.Format("Importing file {0} to {1}", saveName, mcPathTo));
                    #endregion

                    Utils.Card.ImportSave(mcPathTo, filePath);

                    #region Debug
                    log.Warn(String.Format("Deleting  file {0}\n", filePath));
                    #endregion

                    Utils.Cleaner.DeleteTemp(filePath);
                }
            }
        }

        private void TransferSavesMcOneToMcTwo(IEnumerable saveCollection)
        {
            if (memoryCardTwo != null)
            {
                TransferSaves(memoryCardOne, memoryCardTwo, saveCollection);
                UpdateCard(dataGridView2, memoryCardTwo);

                #region Debug
                DebugMc(memoryCardTwo);
                #endregion

            }
            else
            {
                MessageBox.Show("You must open a memory card on the side 2.");
            }
        }

        private void TransferSavesMcTwoToMcOne(IEnumerable saveCollection)
        {
            if (memoryCardOne != null)
            {
                TransferSaves(memoryCardTwo, memoryCardOne, saveCollection);
                UpdateCard(dataGridView1, memoryCardOne);

                #region	Debug
                DebugMc(memoryCardOne);
                #endregion
            }
            else
            {
                MessageBox.Show("You must open a memory card on the side 1.");
            }
        }

        private MemoryCard DoDelete(ref MemoryCard card)
        {
            if (card != null && card.LoadSaves().Count > 2)
            {
                DialogResult result = MessageBox.Show("This action can't be undone!\nAre you sure?", "Delete save(s)", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

                if (result == DialogResult.OK)
                {
                    #region Debug
                    log.Debug("Ok button");
                    #endregion

                    string mcPath = card.GetPath();
                    DataGridViewSelectedRowCollection savesCollection = focusedMemoryCard.SelectedRows;

                    DoBatchDelete(mcPath, savesCollection);

                    #region debug
                    log.Debug("\nDelete Save Button Click - Exit.\n" +
                                        "───────────────────────────────────────────────────────────────────────────────");
                    #endregion

                    return RefreshMemoryCard(card, focusedMemoryCard);
                }
                #region Debug
                log.Debug("Cancel button");
                #endregion

            }
            else
            {
                MessageBox.Show("Unable to delete.");
            }

            #region debug
            log.Debug("\nDelete Save Button Click - Exit.\n" +
                                "───────────────────────────────────────────────────────────────────────────────");
            #endregion
            return card;
        }

        private void DoBatchDelete(string mcPath, IEnumerable savesCollection)
        {
            foreach (DataGridViewRow row in savesCollection)
            {
                #region Debug
                log.Warn(row.Cells[0].Value.ToString());
                #endregion

                Utils.Card.DeleteSave(mcPath, row.Cells[0].Value.ToString());
            }

        }

        private MemoryCard RefreshMemoryCard(MemoryCard memCard, DataGridView view)
        {
            string mcPath = memCard.GetPath();

            MemoryCard card = new MemoryCard(mcPath, Utils.Card.LoadFiles(mcPath), Utils.Card.GetMcFreeSpace(mcPath));

            ShowMcContent(card, view);

            DebugMc(card);

            return card;
        }

        private OpenFileDialog GetImportFileDialog()
        {
            OpenFileDialog openDialog = new OpenFileDialog();

            openDialog.Filter = "EMS file|*.psu|Max Drive file|*.max|Codebreaker file|*.cbs|SharkPort file|*.npo|All files|*.*";
            openDialog.FilterIndex = 1;
            openDialog.Multiselect = true;
            openDialog.InitialDirectory = lastOpenSaveDir;

            return openDialog;
        }

        private void UncheckOtherToolStripMenuItems(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;

            foreach (ToolStripMenuItem menuItem in exportToolStripMenuItem1.DropDownItems)
            {
                menuItem.Checked = false;
            }

            item.Checked = true;
        }

        private void OnDragAndDrop(object sender, DragEventArgs e)
        {
            #region Debug
            Console.WriteLine("───────────────────────────────────────────────────────────────────────────────\n" +
                              "Drag and Drop event\n");
            #endregion

            DataGridView focusedCard = sender as DataGridView;
            string[] droppedFolders = (string[])e.Data.GetData(DataFormats.FileDrop);

            switch (focusedCard.Name)
            {
                case "dataGridView1":
                    if (memoryCardOne != null)
                    {
                        DoDragAndDrop(memoryCardOne, droppedFolders);
                        memoryCardOne = RefreshMemoryCard(memoryCardOne, dataGridView1);
                    }
                    else
                    {
                        MessageBox.Show("You need to open a memory card.");
                    }

                    break;

                case "dataGridView2":
                    if (memoryCardTwo != null)
                    {
                        DoDragAndDrop(memoryCardTwo, droppedFolders);
                        memoryCardTwo = RefreshMemoryCard(memoryCardTwo, dataGridView2);
                    }
                    else
                    {
                        MessageBox.Show("You need to open a memory card.");
                    }
                    break;
            }
            #region debug
            Console.WriteLine("\nDrag and Drop event - exit.\n" +
                                "───────────────────────────────────────────────────────────────────────────────");
            #endregion
        }

        private void DoDragAndDrop(MemoryCard card, string[] droppedFolders)
        {
            string mcPath = card.GetPath();

            foreach (string folder in droppedFolders)
            {
                Utils.Card.AddRawFile(mcPath, folder);
            }
        }

        private void SetContextMenuItems(string dgvName)
        {
            if (dgvName == "dataGridView1")
            {
                ContextMenuItemCopySavesTo.Text = "Copy saves to MC2";
                ContextMenuItemMoveSavesTo.Text = "Move saves to MC2";
                ContextMenuItemCopyAllTo.Text = "Copy All to MC2";
            }
            else
            {
                ContextMenuItemCopySavesTo.Text = "Copy saves to MC1";
                ContextMenuItemMoveSavesTo.Text = "Move saves to MC1";
                ContextMenuItemCopyAllTo.Text = "Copy All to MC1";
            }
        }

        private Action<object, EventArgs> GetCopyMethod(string selector)
        {
            if (selector == "dataGridView1")
            {
                return McOneToMcTwoButtonClick;
            }
            else
            {
                return McTwoToMcOneButtonClick;
            }
        }

        private Action<IEnumerable> GetCopyAllMethod(string selector)
        {
            if (selector == "dataGridView1")
            {
                return TransferSavesMcOneToMcTwo;
            }
            else
            {
                return TransferSavesMcTwoToMcOne;
            }
        }

        private MemoryCard GetActualCard(string focusedCard)
        {
            var cardMap = new Dictionary<string, MemoryCard>()
            {
                { "dataGridView1", memoryCardOne },
                { "dataGridView2", memoryCardTwo }
            };

            MemoryCard tempCard;

            return cardMap.TryGetValue(focusedCard, out tempCard) ? tempCard : null;
        }

        private MemoryCard GetUnfocusedCard(string unfocusedCard)
        {
            var cardMap = new Dictionary<string, MemoryCard>()
            {
                { "dataGridView1", memoryCardTwo },
                { "dataGridView2", memoryCardOne }
            };

            MemoryCard tempCard;

            return cardMap.TryGetValue(unfocusedCard, out tempCard) ? tempCard : null;
        }

        private void UpdateCard(DataGridView slot, MemoryCard card)
        {
            switch (slot.Name)
            {
                case "dataGridView1":
                    memoryCardOne = RefreshMemoryCard(card, slot);
                    break;
                case "dataGridView2":
                    memoryCardTwo = RefreshMemoryCard(card, slot);
                    break;
            }
        }

        private void LoadConfig()
        {
            IniConfigSource config = new IniConfigSource(configFile);

            userExportFolder = config.Configs["Paths"].GetString("ExportFolder");
            lastOpenMcDir = config.Configs["Paths"].GetString("McFolder");
            lastOpenSaveDir = config.Configs["Paths"].GetString("SaveFolder");
            newCardsFolder = config.Configs["Paths"].GetString("NewCardsFolder");

        }

        private void SaveConfig()
        {
            IniConfigSource config = new IniConfigSource(configFile);

            config.Configs["Paths"].Set("ExportFolder", userExportFolder);
            config.Configs["Paths"].Set("McFolder", lastOpenMcDir);
            config.Configs["Paths"].Set("SaveFolder", lastOpenSaveDir);
            config.Configs["Paths"].Set("NewCardsFolder", newCardsFolder);

            config.Save();
        }

        private DataGridView GetDataGridView(DataGridView dgv)
        {
            var map = new Dictionary<string, DataGridView>()
            {
                { "dataGridView1", dataGridView1 },
                { "dataGridView2", dataGridView2 }
            };

            DataGridView temp;

            return map.TryGetValue(dgv.Name, out temp) ? temp : null;
        }

        private void SaveOption(string anOption, string aValue)
        {
            IConfigSource config = new IniConfigSource(configFile);

            config.Configs["Paths"].Set(anOption, aValue);
            config.Save();
        }

        #endregion


        #region MC Debug

        private void DebugMc(MemoryCard memory)
        {
            // ─ │┌ ┐└ ┘├ ┤┬ ┴ ┼
            log.Debug("┌─────────────────────┐");
            log.Debug("│     MEMORY CARD     │");
            log.Debug("└─────────────────────┘\n");

            log.Debug(String.Format("Memory card Path: {0}", memory.GetPath()));
            log.Debug(String.Format("Memory card Free space: {0}", memory.GetFreeSpace()));
            log.Debug(String.Format("Memory card save count: {0}\n", memory.LoadSaves().Count - 2));

            log.Debug("Memory card Save List:\n");

            List<SaveFile> saveList = memory.LoadSaves();

            for (int i = 2; i < saveList.Count; i++)
            {
                log.Debug("┌─────────────────────────────────────────────────────────────────────────────┐");
                log.Debug(String.Format("│  FILE Nº {0,-67}│", String.Format("{0:D3}", i - 1)));
                log.Debug("├─────────────────────────────────────────────────────────────────────────────┤");
                log.Debug(String.Format("│ Save Name: {0,-65}|", saveList[i].FileName));
                log.Debug(String.Format("│ Save Size: {0,-65}|", saveList[i].FileSize));
                log.Debug(String.Format("│ Save Date: {0,-65}|", saveList[i].FileDate));
                log.Debug(String.Format("│ Save Description: {0,-58}|", saveList[i].FileDescription));
                log.Debug("└─────────────────────────────────────────────────────────────────────────────┘\n");
                //Console.WriteLine();
            }
        }

        #endregion

        void DataGridViewDragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }

        void DataGridViewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DeleteSaveButtonClick(sender, null);
            }
        }


        void DataGridViewMouseUp(object sender, MouseEventArgs e)
        {
            DataGridView dgv = GetDataGridView(sender as DataGridView);
            MemoryCard card = GetActualCard(dgv.Name);

            if (e.Button == MouseButtons.Right && card != null)
            {
                focusedMemoryCard = dgv;
                SetContextMenuItems(dgv.Name);

                contextMenuStrip1.Show(sender as DataGridView, e.Location);
            }
        }

        #region	ContextMenuItems

        void ContextMenuItemSelectAllClick(object sender, EventArgs e)
        {
            focusedMemoryCard.SelectAll();
        }

        void ContextMenuItemCopySavesToClick(object sender, EventArgs e)
        {
            Action<object, EventArgs> doCopy = GetCopyMethod(focusedMemoryCard.Name);
            doCopy(null, null);
        }

        void ContextMenuItemMoveSavesToClick(object sender, EventArgs e)
        {
            ContextMenuItemCopySavesToClick(null, null);

            MemoryCard cardFrom = GetActualCard(focusedMemoryCard.Name);
            MemoryCard cardTo = GetUnfocusedCard(focusedMemoryCard.Name);

            if (cardTo != null)
            {
                DoBatchDelete(cardFrom.GetPath(), focusedMemoryCard.SelectedRows);
                UpdateCard(focusedMemoryCard, cardFrom);
            }
        }

        void ContextMenuItemCopyAllToClick(object sender, EventArgs e)
        {
            Action<IEnumerable> doCopyAll = GetCopyAllMethod(focusedMemoryCard.Name);
            doCopyAll(focusedMemoryCard.Rows);
        }

        void ContextMenuItemDeleteSelectedsClick(object sender, EventArgs e)
        {
            DeleteSaveButtonClick(focusedMemoryCard, null);
        }

        void DeleteAllToolStripMenuItemClick(object sender, EventArgs e)
        {
            MemoryCard card = GetActualCard(focusedMemoryCard.Name);

            if (focusedMemoryCard.Rows.Count > 0)
            {
                DoBatchDelete(card.GetPath(), focusedMemoryCard.Rows);
                UpdateCard(focusedMemoryCard, card);
            }
            else
            {
                MessageBox.Show("Tch tch tch... You can't do that! \nThe memory card its empty.");
            }
        }

        #endregion


        private IEnumerable<FileInfo> GetFilesByExtensions(string pathDir, params string[] extensions)
        {
            var dir = new DirectoryInfo(pathDir);
            if (extensions == null)
                throw new ArgumentNullException("extensions");
 
            IEnumerable<FileInfo> files = dir.GetFiles();
            return files.Where(f => extensions.Contains(f.Extension));
        }

        private void DoProgress(IEnumerable<FileInfo> files)
        {
            var dgv = GetDataGridView(focusedMemoryCard);
            var card = GetActualCard(dgv.Name);

            DoProgressBar(files, card);

            UpdateCard(dgv, card);
        }

        private void DoProgressBar(IEnumerable<FileInfo> files, MemoryCard card)
        {
            var formProgress = new ProcessBar();
            formProgress.SetList = files;
            formProgress.McPath = card.GetPath();

            formProgress.ShowDialog();
        }

        void MenuComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            if (menuComboBox.SelectedItem.ToString() == "VMC 1")
            {
                if (memoryCardOne != null)
                {
                    EnableMenuComboBoxOptions();
                    focusedMemoryCard = dataGridView1;
                }
                else
                {
                    DisableMenuComboBoxOptions();
                }

            }
            else
            {
                if (memoryCardTwo != null)
                {
                    EnableMenuComboBoxOptions();
                    focusedMemoryCard = dataGridView2;
                }
                else
                {
                    DisableMenuComboBoxOptions();
                }
            }
        }

        private void DisableMenuComboBoxOptions()
        {
            allPSUToolStripMenuItem.Enabled = false;
            allMAXToolStripMenuItem.Enabled = false;
            allCBSToolStripMenuItem.Enabled = false;
            allNPOToolStripMenuItem.Enabled = false;
            allFILESToolStripMenuItem.Enabled = false;
        }

        private void EnableMenuComboBoxOptions()
        {
            allPSUToolStripMenuItem.Enabled = true;
            allMAXToolStripMenuItem.Enabled = true;
            allCBSToolStripMenuItem.Enabled = true;
            allNPOToolStripMenuItem.Enabled = true;
            allFILESToolStripMenuItem.Enabled = true;
        }
    }
}

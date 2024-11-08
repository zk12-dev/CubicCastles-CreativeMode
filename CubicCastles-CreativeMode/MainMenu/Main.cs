using Memory;
using MetroSet_UI.Forms;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Timers;
using Sunny.UI;
using BrightIdeasSoftware.Design;

namespace ETS
{

    public partial class MainForm : MetroSetForm
    {
        public Mem m = new Mem();
        private System.Timers.Timer processCheckTimer;

        

        public MainForm()
        {
            InitializeComponent();

            // This loads the BlockData.txt so the search bar can access it
            LoadTextFile();

            // Block list settings (i prefered to write these settings as code and not set them up in the settings of the ListView)
            listViewResults.SmallImageList = imageListIcons;
            imageListIcons.ImageSize = new Size(32, 32);
            listViewResults.View = View.Details;
            listViewResults.Columns.Add("Results", -2, HorizontalAlignment.Left);
            listViewResults.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewResults.Scrollable = true;

            // Sets by default the column size to 465 so the horizontal scrollbar doesn't appear
            foreach (ColumnHeader column in listViewResults.Columns)
            {
                column.Width = 455;
            }

            // More color overrides, the SunnyUI TabControl seems to be bugged and overrides the colors, anything placed in it can't get applied the correct color from the properties
            status_label.ForeColor = Color.White;
            process_label.ForeColor = Color.White;
            Hispano.ForeColor = Color.DimGray;
            searchButton.ForeColor = Color.White;


            }

        // This stores all the blocks from the text file in a list
        public List<string> fileContents = new List<string>();

        private void LoadTextFile()
        {
            try
            {
                string folderPath = Application.StartupPath;
                string filePath = Path.Combine(folderPath, "BlockData.txt");
                if (File.Exists(filePath))
                {
                    fileContents = File.ReadAllLines(filePath).ToList();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on the load: " + ex.Message);
            }
        }


        private void searchButton_MouseClick(object sender, MouseEventArgs e)
        {
            // Get the search term from the textbox
            string searchTerm = BlockSearchBar.Text.Trim();

            // Clear the previous results
            listViewResults.Items.Clear();
            imageListIcons.Images.Clear();

            // Perform the search if the file is loaded and the search term is not empty
            if (fileContents != null && !string.IsNullOrEmpty(searchTerm))
            {
                // Find lines that contain the search term (case insensitive)
                var results = fileContents.Where(line => line.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0);
                int index = 0;

                // Add the matching results to the ListView
                foreach (var result in results)
                {

                    if (!string.IsNullOrWhiteSpace(result))
                    {
                        string formattedResult = FormatLine(result); // Format the line in the right way
                        string id = GetID(result); // Extract the ID from the line

                        // Try to load the corresponding image from the blocks folder (example: "101.png")
                        string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                        string imageFolderPath = Path.Combine(baseDirectory, "Blocks");
                        string imagePath = Path.Combine(imageFolderPath, id + ".png");

                        if (File.Exists(imagePath))
                        {
                            // Load the image and add it to the ImageList
                            imageListIcons.Images.Add(Image.FromFile(imagePath));

                            // Create a new ListViewItem with text and image
                            ListViewItem item = new ListViewItem(formattedResult, index);
                            listViewResults.Items.Add(item);

                            index++; // Increment the image index
                        }
                        else
                        {
                            // If no image is found, add text without image
                            ListViewItem item = new ListViewItem(formattedResult);
                            listViewResults.Items.Add(item);
                        }

                    }

                }

                // Si no hay resultados, notificar al usuario
                if (listViewResults.Items.Count == 0)
                {
                    ListViewItem item = new ListViewItem("No results found  :-)");
                    listViewResults.Items.Add(item);
                }

                // Sets the colum size to a size that doesn't let's the horizontal scrollbar appear
                foreach (ColumnHeader column in listViewResults.Columns)
                {
                    column.Width = 440;
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Block Name  :-)");
            }

        }

        private string FormatLine(string line)
        {
            // Split the line by the period
            var parts = line.Split(new[] { '.' }, 2);

            if (parts.Length == 2)
            {
                // Extract the ID and Block Name, and trim any extra spaces
                string id = parts[0].Trim();
                string blockName = parts[1].Trim();

                // Return the formatted string "Block: [Block Name]   |   ID: [ID]"
                return $" {blockName}   |   ID: {id}";
            }

            // If the line doesnt match the expected format, return the original line
            return line;

        }

        private string GetID(string line)
        {
            var parts = line.Split(new[] { '.' }, 2);

            if (parts.Length == 2)
            {
                return parts[0].Trim(); // Return the ID part
            }

            return "100"; // If no ID found, return "DIRT ID"
        }

        private void listViewResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewResults.SelectedItems.Count > 0)
            {
                if (listViewResults.SelectedItems.Count > 0)
                {
                    ListViewItem selectedItem = listViewResults.SelectedItems[0];
                    string selectedText = selectedItem.Text;

                    // Extract the block ID from the selected item in the ViewList
                    string blockID = ExtractIDFromText(selectedText);

                    // Call the method to edit the code based on the selected block ID from the ViewList
                    EditCodeBasedOnID(blockID);
                }
            }
        }

        private string ExtractIDFromText(string itemText)
        {
            string[] parts = itemText.Split('|');  // Split by " | "

            if (parts.Length > 1)
            {
                string idPart = parts[1].Trim();
                string id = idPart.Replace("ID:", "").Trim();
                return id;
            }
            return string.Empty;  // Return empty if no ID found
        }

        private byte[] ConvertIDToBytes(int blockID)
        {
            // Convert the integer to a 2-byte little-endian format
            byte[] blockBytes = BitConverter.GetBytes((short)blockID);
            return blockBytes;
        }

        private void EditCodeBasedOnID(string blockID)
        {
            if (!string.IsNullOrEmpty(blockID))
            {
                // Convert the blockID to an integer
                if (int.TryParse(blockID, out int blockIDValue))
                {
                    // Convert the blockID to a byte array
                    byte[] blockIDBytes = ConvertIDToBytes(blockIDValue);

                    // Convert the byte array to a hexadecimal string (example: "64 00" for ID 100)
                    string blockIDHex = BitConverter.ToString(blockIDBytes).Replace("-", " ");

                    // Insert the edited bytes in to the main script
                    string fullID = "66 C7 46 02 " + blockIDHex + " 0F BF 7E 02 0F BE D1 E9 1A 29 E9 FF 90";

                    // Write the needed bytes in the Code Cave
                    m.WriteMemory("Cubic.exe+2ED4F7", "bytes", fullID);
                }
                else
                {
                    MessageBox.Show("Invalid block ID  :-)");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            StartProcessCheckTimer();

            if (!EasyToStopWorker.IsBusy)
                EasyToStopWorker.RunWorkerAsync();
        }

        private void StartProcessCheckTimer()
        {
            processCheckTimer = new System.Timers.Timer(1000);
            processCheckTimer.Elapsed += ProcessCheckTimer_Elapsed;
            processCheckTimer.AutoReset = true;
            processCheckTimer.Enabled = true;
        }


        private bool hasReadMemory = false;
        private bool wasConnected = false;
        public string OfflineArray;
        public string ChangeBlocksArray;

        private void ProcessCheckTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            processCheckTimer.Enabled = false;

            int pID = m.GetProcIdFromName("Cubic");
            bool openProc = pID > 0 && m.OpenProcess(pID);

            if (openProc)
            {
                this.Invoke(new Action(() =>
                {
                    UpdateLabel(procIDDisplay, pID.ToString(), Color.Green);
                    UpdateLabel(getStatusDisplay, "CONNECTED", Color.Green);
                }));

                if (!wasConnected)
                {
                    wasConnected = true;
                    hasReadMemory = false;
                }

                // Only read memory once, this can be used in the future to read more addresses if they don't have static bytes
                if (!hasReadMemory)
                {
                    int byteCountBobY = 8;
                    int byteCountBobZX = 4;
                    byte[] BobY = m.ReadBytes("", byteCountBobY);
                    byte[] BobZX = m.ReadBytes("", byteCountBobZX);

                    if (byteCountBobY != 0 | byteCountBobZX != 0)
                    {
                        OfflineArray = BitConverter.ToString(BobY).Replace("-", " ");
                        ChangeBlocksArray = BitConverter.ToString(BobZX).Replace("-", " ");
                        hasReadMemory = true;
                    }
                }
            }
            else
            {
                this.Invoke(new Action(() =>
                {
                    UpdateLabel(procIDDisplay, "DISCONNECTED", Color.Red);
                    UpdateLabel(getStatusDisplay, "DISCONNECTED", Color.Red);
                }));

                if (wasConnected)
                {
                    wasConnected = false;
                    hasReadMemory = false;  // Allow reading again in the future if the process gets disconnected.
                }
            }
            processCheckTimer.Enabled = true;
        }

        private void UpdateLabel(Label label, string text, Color color)
        {

            if (label.InvokeRequired)
            {
                label.Invoke((MethodInvoker)delegate
                {
                    label.Text = text;
                    label.ForeColor = color;
                });
            }
            else
            {
                label.Text = text;
                label.ForeColor = color;
            }
        }

        private bool OfflineModeState = false;

        private System.Timers.Timer _updateTimer;

        private void EasyToStopWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            _updateTimer = new System.Timers.Timer(100);
            _updateTimer.Elapsed += UpdateMemoryOnTimerTick;
            _updateTimer.AutoReset = true;
            _updateTimer.Start();
        }

        private void UpdateMemoryOnTimerTick(object sender, ElapsedEventArgs e)
        {
            CheckAndUpdateMemory();
        }

        private void CheckAndUpdateMemory()
        {
            if (enableOfflineMode.Switched != OfflineModeState)
            {
                OfflineModeState = enableOfflineMode.Switched;
                if (OfflineModeState)
                {
                    m.WriteMemory("Cubic.exe+17FE1C", "bytes", "E9 D6 D6 16 00");
                    m.WriteMemory("Cubic.exe+245A57", "bytes", "90 90");
                }
                else
                {
                    m.WriteMemory("Cubic.exe+17FE1C", "bytes", "0F BF 7E 02 0F");
                    m.WriteMemory("Cubic.exe+245A57", "bytes", "8B 16");
                }
            }

        }


    }
}



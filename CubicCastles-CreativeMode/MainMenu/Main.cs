using Memory;
using MetroSet_UI.Forms;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading.Tasks;
using System.IO;
using System.Linq;
using System.Configuration;
using System.Collections.Generic;

namespace ETS
{


    public partial class MainForm : MetroSetForm
    {
        public Mem m = new Mem();



        public MainForm()
        {
            InitializeComponent();

            // This loads the BlockData.txt so the search bar can access it
            LoadTextFile();

            // Block list settings (i prefered to write these settings as code and not set them up in the settings of the ListView)
            listViewResults.Visible = false;
            listViewResults.SmallImageList = imageListIcons;
            imageListIcons.ImageSize = new Size(32, 32);
            listViewResults.View = View.Details;
            listViewResults.Columns.Add("Results", -2, HorizontalAlignment.Left);
            listViewResults.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewResults.Scrollable = true;
            

        }

        // This stores all the blocks from the text file in a list
        public List<string> fileContents = new List<string>();

        private void LoadTextFile()
        {
            try
            {
                // This reads all the lines from the text file and stores it in fileContents list
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

        private void searchButton_MouseClick(object sender, EventArgs e)
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

                // Show or hide the ListView based on if there are results or not
                listViewResults.Visible = listViewResults.Items.Count > 0;

                // If no results, notify the user
                if (listViewResults.Items.Count == 0)
                {
                    ListViewItem item = new ListViewItem("No results found  :-)");
                    listViewResults.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Block Name  :-)");
                listViewResults.Visible = false; // Hide result list if search term is empty
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
                    string fullID = "66 C7 46 02 " + blockIDHex + " 0F BF 7E 02 0F BE D1 E9 35 24 F0 FF 90";

                    // Write the needed bytes in the Code Cave
                    m.WriteMemory("Cubic.exe+27C1ED", "bytes", fullID);
                }
                else
                {
                    MessageBox.Show("Invalid block ID  :-)");
                }
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();

            if (!backgroundWorker2.IsBusy)
                backgroundWorker2.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            // This is used to attach the mod menu to the game, if the attachment is succesfully the labels will change from "Disconnected" to the pID and so on.
            while (true)
            {

                int pID = m.GetProcIdFromName("Cubic");
                bool openProc = false;
                if (pID > 0)
                {
                    openProc = m.OpenProcess(pID);
                    procIDLabel.Invoke((MethodInvoker)delegate
                    {
                        procIDLabel.Text = pID.ToString();
                        procIDLabel.ForeColor = Color.Green;
                    });
                }

                else if (!(pID > 0))
                {
                    procIDLabel.Invoke((MethodInvoker)delegate
                    {
                        procIDLabel.Text = "DISCONNECTED";
                        procIDLabel.ForeColor = Color.Red;
                    });
                }

                if (openProc == false)
                {
                    getHackStatus.Invoke((MethodInvoker)delegate
                    {
                        getHackStatus.Text = "DISCONNECTED";
                        getHackStatus.ForeColor = Color.Red;
                    });
                }

                else if (openProc)
                {
                    getHackStatus.Invoke((MethodInvoker)delegate
                    {
                        getHackStatus.Text = "CONNECTED";
                        getHackStatus.ForeColor = Color.Green;
                    });
                };

                // This is used to slow a bit the process of searching the name of "Cubic" through all the other processes so it consumes less CPU %
                System.Threading.Thread.Sleep(200);
            }


        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            // This is used to enable the Offline-Mode, also this creates the Code Cave so the Search Bar only needs to write the code in the Code Cave created here.
            while (true)
            {
                
                if (enableOfflineMode.Switched)
                {
                    // Offline-Mode Enabler
                    m.WriteMemory("Cubic.exe+244247", "bytes", "90 90");
                    // Jump to the Code Cave
                    m.WriteMemory("Cubic.exe+17E62D", "bytes", "E9 BB DB 0F 00");
                }
                else if (!enableOfflineMode.Switched)
                {
                    // Offline-Mode Disabler
                    m.WriteMemory("Cubic.exe+244247", "bytes", "8B 16");
                    // Return from the Code Cave
                    m.WriteMemory("Cubic.exe+17E62D", "bytes", "0F BF 7E 02 0F");
                }

            }
        }

    }
}



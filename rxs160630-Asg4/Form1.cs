/*=============================================================================
 |   Assignment:  CS6326 Assignment 4
 |       Author:  Raunak Sabhani 
 |     Language:  C#
 |    File Name:  Form1.cs
 |
 +-----------------------------------------------------------------------------
 |
 |  Description:  A multithreaded file searching application.
 |
 |        Input:  The program takes as input a file and a search string. Reads the file in a different thread and searches for the required string. Results are printed to a list on screen. 
 |
 |       Output:  The program displays the line no and the line in a list
 |
 |       File Purpose: Main file containing the form class
 *===========================================================================*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rxs160630_Asg4
{
    public partial class Form1 : Form
    {
        private int lineNo;
        private String foundLine;

        //Form constructor
        public Form1()
        {
            InitializeComponent();
            showMessage("Choose file to search");
            ctlSearchButton.Enabled = false;
        }

        //Display message on the status bar
        private void showMessage(String msg)
        {
            ctlStatusLabel.Text = msg;
            ctlStatusBar.Refresh();
        }

        //Event handler on click of browse button
        private void ctlBrowseButton_Click(object sender, EventArgs e)
        {
            openFileDialogCtl.Filter = "Report File|*.txt";
            openFileDialogCtl.Title = "Select a Report File to Analyze";
            if (openFileDialogCtl.ShowDialog() == DialogResult.OK)
            {
                ctlFileTextBox.Text = openFileDialogCtl.FileName;
                showMessage("Enter a text to search in file");
            }
        }

        //Event handler on click of search button
        private void ctlSearchButton_Click(object sender, EventArgs e)
        {
            if(String.Equals(ctlSearchButton.Text, "Search"))
            {
                ctlSearchButton.Text = "Cancel";
                ctlListView.Items.Clear();
                showMessage("Reading file");
                ctlBrowseButton.Enabled = false;
                
                ctlBackgroundWorker.RunWorkerAsync();
            } else
            {
                showMessage("Cancelling file read");
                ctlSearchButton.Text = "Search";
                ctlBackgroundWorker.CancelAsync();
            }
        }

        //Background worker is reading the file and reporting progress
        private void ctlBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            String line = String.Empty;
            StreamReader file = new StreamReader(ctlFileTextBox.Text);
            long fileSize = new FileInfo(ctlFileTextBox.Text).Length;
            Debug.Print("File size is: " + fileSize.ToString());
            long bytesRead = 0;
            int count = 0;
            while ((line = file.ReadLine()) != null)
            {
                bytesRead = bytesRead + line.Length;
                if (ctlBackgroundWorker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                if (line.IndexOf(ctlSearchTextBox.Text, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    lineNo = count;
                    foundLine = String.Copy(line);
                    Debug.Print(bytesRead.ToString());
                    ctlBackgroundWorker.ReportProgress(Convert.ToInt32((bytesRead * 100) / fileSize));
                    Thread.Sleep(100);
                }
                count = count + 1;
            }
        }

        //Progress is reported and list view is populated with each mathcing line
        private void ctlBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ListViewItem lvi = new ListViewItem(lineNo.ToString());
            lvi.SubItems.Add(foundLine);
            ctlListView.Items.Add(lvi);
            showMessage(e.ProgressPercentage.ToString() + "% read");
        }

        //File read is complete. All the inputs are set back to default
        private void ctlBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                showMessage("File read cancelled");
            }
            else if(e.Error != null)
            {
                showMessage(e.Error.Message);
            } else
            {
                showMessage("File read complete");
            }

            ctlBrowseButton.Enabled = true;
            ctlSearchButton.Text = "Search";
        }

        //Validate entry in search text field
        private void ctlSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(ctlFileTextBox.Text)
                && !String.IsNullOrWhiteSpace(ctlSearchTextBox.Text)
                && System.IO.File.Exists(ctlFileTextBox.Text))
            {
                ctlSearchButton.Enabled = true;
            }
            else
            {
                ctlSearchButton.Enabled = false;
            }
        }
    }
}

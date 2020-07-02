using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace purgeoldfiles
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            button2.Enabled = false;
            directorytext.Text = @"D:\test";
            resulttext.ReadOnly = true;
            waitinglist.ReadOnly = true;
            purgeresult.ReadOnly = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        long totalsize = 0;
        string diffdays = "";
        string fullpath = "";
        int deletesum = 0;
        string[] DeleteFilePath=new string[100];
         
        private void button1_Click(object sender, EventArgs e)
        {
            string path = directorytext.Text;
            long length = 0;
            resulttext.Text = "";
            waitinglist.Text = "";
            try
            {
                DirectoryInfo d = new DirectoryInfo(path);

                //DateTime creation = File.GetCreationTime(@"C:\test.txt");
                FileInfo[] Files = d.GetFiles("*.*"); //Getting Text files
                
                foreach (FileInfo file in Files)
                {
                      fullpath = path + '\\' + file.ToString();
                    length = new System.IO.FileInfo(fullpath).Length;
                    length = length / 1024;
                    DateTime creation = File.GetLastWriteTime(fullpath);
                    System.TimeSpan diffResult = DateTime.Today.Subtract(creation);
                    diffdays = diffResult.Days.ToString();
                   
                    if (diffResult.Days > Int32.Parse(expireday.Text))
                    {

                       DeleteFilePath[deletesum] = fullpath;
                        waitinglist.Text =  waitinglist.Text + fullpath+"\n";
                       
                      label8.Text = "sum:" + (++deletesum) +" files";

                        
                    }

                    resulttext.Text = resulttext.Text + file.ToString() + length.ToString()+ "k modified time is" + creation.ToString() +"subtracted day is "+ diffdays + "\n";
                    totalsize = length + totalsize;
                }
                totalsize = totalsize / 1024;

                label3.Text = "totalsize is" + totalsize.ToString()+'M';
                if (waitinglist.Text.Length>1)
                button2.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               // throw;
                
                //System.Windows.Forms.Application.ExitThread( );  
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (totalsize < Int32.Parse(maxsize.Text)) { MessageBox.Show("actual totalsize is less than"+maxsize.Text+" M,  so do nothing!"); }
            else {
                int i;
            
                for (i = 0; i < deletesum; i++)
                {  
                    
                     File.Delete(DeleteFilePath[i]); 
                purgeresult.Text=purgeresult.Text+ DeleteFilePath[i] + "\n";
                }
               
               // label4.Text = label4.Text + i.ToString();

               label9.Text = "deleted "+i.ToString()+" files";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}

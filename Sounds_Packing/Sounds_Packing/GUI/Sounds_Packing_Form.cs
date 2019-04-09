using Sounds_Packing.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sounds_Packing.GUI
{
    public partial class Sounds_Packing_Form : Form
    {
        bool Text_Only;
        Sounds_Allocations Sounds_Allocation_Algorithms;
        Stopwatch Timer;

        public Sounds_Packing_Form()
        {
            Text_Only = false;
            Sounds_Allocation_Algorithms = new Sounds_Allocations();
            Timer = new Stopwatch();
            InitializeComponent();
        }


        //Check if there is an Empty Input Field Then Dispaly a Messege
        private bool Check_All_Inputs()
        {
            if (Input_Path_TextBox.Text == "")
            {
                MessageBox.Show("Please, Choose Intput Folder!", "Empty Field!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            else if (Output_Path_TextBox.Text == "")
            {
                MessageBox.Show("Please, Choose Output Folder!", "Empty Field!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            else if (int.Parse(Folder_Duration.Text) == 0)
            {
                MessageBox.Show("Please, Enter Folder Duration!", "Empty Field!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (File_Type.Text == "")
            {
                MessageBox.Show("Please, Enter Files Extension!", "Empty Field!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                return true;
            }
        }


        //Worst Fit Algorithm Using Linear Search Button
        private void Worst_Fit_LS_Click(object sender, EventArgs e)
        {
            Set_Text_Only();
            if(!Check_All_Inputs())
            {
                return;
            }

            Timer = Sounds_Allocation_Algorithms.Worst_Fit_Algorithm_LS(Input_Path_TextBox.Text, Output_Path_TextBox.Text, int.Parse(Folder_Duration.Text), File_Type.Text, Text_Only);
            string Temp_Timer = "";
            Sounds_Allocation_Algorithms.Get_Algorithm_Time_Duration(Timer, ref Temp_Timer);
            Worst_Fit_LS_Time.Text = Temp_Timer;

        }


        //Worst Fit Algorithm Using Priority Queue Button
        private void Worst_Fit_PQ_Click(object sender, EventArgs e)
        {
            Set_Text_Only();
            if(!Check_All_Inputs())
            {
                return;
            }

            Timer = Sounds_Allocation_Algorithms.Worst_Fit_Algorithm_PQ(Input_Path_TextBox.Text, Output_Path_TextBox.Text, int.Parse(Folder_Duration.Text), File_Type.Text, Text_Only);
            string Temp_Timer = "";
            Sounds_Allocation_Algorithms.Get_Algorithm_Time_Duration(Timer, ref Temp_Timer);
            Worst_Fit_PQ_Time.Text = Temp_Timer;
        }


        //Worst Fit Decreasing Algorithm Using Linear Search Button
        private void Worst_Fit_Decreasing_LS_Click(object sender, EventArgs e)
        {
            Set_Text_Only();
            if (!Check_All_Inputs())
            {
                return;
            }

            Timer = Sounds_Allocation_Algorithms.Worst_Fit_Decreasing_Algorithm_LS(Input_Path_TextBox.Text, Output_Path_TextBox.Text, int.Parse(Folder_Duration.Text), File_Type.Text, Text_Only);
            string Temp_Timer = "";
            Sounds_Allocation_Algorithms.Get_Algorithm_Time_Duration(Timer, ref Temp_Timer);
            Worst_Fit_Decreasing_LS_Time.Text = Temp_Timer;
        }


        //Worst Fit Decreasing Algorithm Using Priority Queue Button
        private void Worst_Fit_Decreasing_PQ_Click(object sender, EventArgs e)
        {
            Set_Text_Only();
            if (!Check_All_Inputs())
            {
                return;
            }

            Timer = Sounds_Allocation_Algorithms.Worst_Fit_Decreasing_Algorithm_PQ(Input_Path_TextBox.Text, Output_Path_TextBox.Text, int.Parse(Folder_Duration.Text), File_Type.Text, Text_Only);
            string Temp_Timer = "";
            Sounds_Allocation_Algorithms.Get_Algorithm_Time_Duration(Timer, ref Temp_Timer);
            Worst_Fit_Decreasing_PQ_Time.Text = Temp_Timer;
        }


        //Best Fit Algorithm Using Linear Search Button
        private void Best_Fit_LS_Click(object sender, EventArgs e)
        {
            Set_Text_Only();
            if (!Check_All_Inputs())
            {
                return;
            }

            Timer = Sounds_Allocation_Algorithms.Best_Fit_Algorithm_LS(Input_Path_TextBox.Text, Output_Path_TextBox.Text, int.Parse(Folder_Duration.Text), File_Type.Text, Text_Only);
            string Temp_Timer = "";
            Sounds_Allocation_Algorithms.Get_Algorithm_Time_Duration(Timer, ref Temp_Timer);
            Best_Fit_LS_Time.Text = Temp_Timer;
        }


        //Best Fit Decreasing Algorithm Using Linear Search Button
        private void Best_Fit_Decreasing_LS_Click(object sender, EventArgs e)
        {
            Set_Text_Only();
            if (!Check_All_Inputs())
            {
                return;
            }

            Timer = Sounds_Allocation_Algorithms.Best_Fit_Decreasing_Algorithm_LS(Input_Path_TextBox.Text, Output_Path_TextBox.Text, int.Parse(Folder_Duration.Text), File_Type.Text, Text_Only);
            string Temp_Timer = "";
            Sounds_Allocation_Algorithms.Get_Algorithm_Time_Duration(Timer, ref Temp_Timer);
            Best_Fit_Decreasing_LS_Time.Text = Temp_Timer;
        }


        //First Fit Decreasing Algorithm Using Linear Search Button
        private void First_Fit_Decreasing_LS_Click(object sender, EventArgs e)
        {
            Set_Text_Only();
            if (!Check_All_Inputs())
            {
                return;
            }

            Timer = Sounds_Allocation_Algorithms.First_Fit_Decreasing_Algorithm_LS(Input_Path_TextBox.Text, Output_Path_TextBox.Text, int.Parse(Folder_Duration.Text), File_Type.Text, Text_Only);
            string Temp_Timer = "";
            Sounds_Allocation_Algorithms.Get_Algorithm_Time_Duration(Timer, ref Temp_Timer);
            First_Fit_Decreasing_LS_Time.Text = Temp_Timer;
        }


        //Folder Filling Algorithm Button
        private void Folder_Filling_Click(object sender, EventArgs e)
        {
            Set_Text_Only();
            if (!Check_All_Inputs())
            {
                return;
            }

            Timer = Sounds_Allocation_Algorithms.Folder_Filling_Algorithm(Input_Path_TextBox.Text, Output_Path_TextBox.Text, int.Parse(Folder_Duration.Text), File_Type.Text, Text_Only);
            string Temp_Timer = "";
            Sounds_Allocation_Algorithms.Get_Algorithm_Time_Duration(Timer, ref Temp_Timer);
            Folder_Filling_Time.Text = Temp_Timer;
        }

        //Run All Algorithms Button
        private void ALL_Algorithms_Click(object sender, EventArgs e)
        {
            if (!Check_All_Inputs())
            {
                return;
            }

            Worst_Fit_LS_Click(sender, e);
            Worst_Fit_PQ_Click(sender, e);
            Worst_Fit_Decreasing_LS_Click(sender, e);
            Worst_Fit_Decreasing_PQ_Click(sender, e);
            Best_Fit_LS_Click(sender, e);
            Best_Fit_Decreasing_LS_Click(sender, e);
            First_Fit_Decreasing_LS_Click(sender, e);
            Folder_Filling_Click(sender, e);            
        }

        #region GUI Functions
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Set_Text_Only()
        {
            if (Text_File_Only.Checked == true)
            {
                Text_Only = true;
                return;
            }

            Text_Only = false;
        }

      
        private void Input_Path_Click(object sender, EventArgs e)
        {
            Input_Folder.ShowDialog();
            Input_Path_TextBox.Text = Input_Folder.SelectedPath.ToString();
        }

        private void Output_Path_Click(object sender, EventArgs e)
        {
            Output_Folder.ShowDialog();
            Output_Path_TextBox.Text = Output_Folder.SelectedPath.ToString();
        }

        private void Folder_Duration_Click(object sender, EventArgs e)
        {
            Folder_Duration.Text = "";
        }

        private void File_Type_Click(object sender, EventArgs e)
        {
            File_Type.Text = "";
        }


        #endregion

        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox4.Image = Properties.Resources._2;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources._1;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox5_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox5.Image = Properties.Resources._4;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Image = Properties.Resources._3;

        }
    }
}

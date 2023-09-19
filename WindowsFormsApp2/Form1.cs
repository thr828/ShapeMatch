using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HalconDotNet;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        HObject image = new HObject(); 
        HObject grayImage=new HObject();
        HTuple hwindowHandle;
        HTuple row=new HTuple();
        HTuple column = new HTuple();
        HTuple radius = new HTuple();
        HTuple angle = new HTuple();
        HTuple scale = new HTuple();
        HTuple score = new HTuple();
        HObject circle = new HObject();
        HTuple modelID = new HTuple();
        HObject reduceDomain = new HObject();
        private void readBtn_Click(object sender, EventArgs e)
        {
            hwindowHandle = hSmartWindowControl1.HalconWindow;
            HOperatorSet.ReadImage(out grayImage, "./images/小鹿.jpg");
          //  HOperatorSet.Rgb1ToGray(image, out grayImage);
            HOperatorSet.DispImage(grayImage, hwindowHandle);
        }

        private void btnCreateCircle_Click(object sender, EventArgs e)
        {

            Task.Run(() =>
            {
                HOperatorSet.SetColor(hwindowHandle, "red");
                row.Dispose(); column.Dispose(); radius.Dispose();
                HOperatorSet.DrawCircle(hwindowHandle, out row, out column, out radius);
                HOperatorSet.GenCircle(out circle, row, column, radius);
                HOperatorSet.ReduceDomain(grayImage, circle, out reduceDomain);
                HOperatorSet.CreateScaledShapeModel( reduceDomain, "auto", -0.39, 0.79, "auto", 0.9, 1.1, "auto", "auto", "use_polarity", "auto", "auto", out modelID);
                HOperatorSet.WriteShapeModel(modelID, Environment.CurrentDirectory+ "/匹配模板.shm");
            });

        }

        private void brnLoadModel_Click(object sender, EventArgs e)
        {
            HOperatorSet.ReadShapeModel(Environment.CurrentDirectory + "/匹配模板.shm", out modelID);
            HOperatorSet.FindScaledShapeModel(grayImage, modelID, -0.39, 0.78, 0.9, 1.1, 0.5, 5, 0.5, "least_squares", 0, 0.9, out row, out column, out angle, out scale, out score);
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
          //  HOperatorSet.DispCircle(hwindowHandle,row,column, radius);
            HOperatorSet.DispText(hwindowHandle, "结果坐标:" + row + "," + column, "window", row, column,"black", "box", "true");
        }
    }
}

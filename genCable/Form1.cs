using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Geometry;
using System;
using System.Collections.Generic;
using System.Windows.Forms;



using Application = Autodesk.AutoCAD.ApplicationServices.Application;

namespace genCable
{
    public partial class Form1 : Form
    {
        public int fish_count = 0;
        public List<Point3d> points_start = new List<Point3d>();
        public List<Point3d> points_end = new List<Point3d>();
        public Form1()
        {
            InitializeComponent();
            

        }

        private void set_default_text()
        {
            tbFlacPx.Text = "-2.45";
            tbFlacPz.Text = "28.36";
            tb_segments.Text = "10";
            tb_group.Text = "cable1";
            tb_dis.Text = "800";
            combo_unit.SelectedIndex = 0;


        }
        private void Form1_Load(object sender, EventArgs e)
        {
            set_default_text();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void btn_select_line_Click(object sender, EventArgs e)
        {
            points_start.Clear();
            points_end.Clear();

            // 获取AutoCAD文档和编辑器对象
            Document doc = Application.DocumentManager.MdiActiveDocument;
            Database db = doc.Database;
            Editor ed = doc.Editor;


            // 提示用户选择直线
            PromptSelectionOptions opts = new PromptSelectionOptions();
            opts.MessageForAdding = "\nSelect lines: ";
            opts.MessageForRemoval = "\nRemove lines: ";
            opts.AllowDuplicates = false;
            opts.SingleOnly = false;
            
            // 过滤器：只允许选择直线
            TypedValue[] filterList = new TypedValue[] {
                new TypedValue((int)DxfCode.Start, "LINE")
            };
            SelectionFilter filter = new SelectionFilter(filterList);
            //窗口聚焦
            this.WindowState = FormWindowState.Minimized;
            Autodesk.AutoCAD.Internal.Utils.SetFocusToDwgView();
            
            // 执行选择
            PromptSelectionResult selRes = ed.GetSelection(opts, filter);
            if (selRes.Status == PromptStatus.OK)
            {
                using (Transaction tr = db.TransactionManager.StartTransaction())
                {
                    SelectionSet selSet = selRes.Value;
                    foreach (SelectedObject selObj in selSet)
                    {
                        // 打开选择的直线对象
                        Entity ent = tr.GetObject(selObj.ObjectId, OpenMode.ForRead) as Entity;
                        if (ent != null && ent is Line)
                        {
                            Line line = (Line)ent;
                            // 获取直线的起点和终点
                            Point3d startPt = line.StartPoint;
                            points_start.Add(startPt);
                            Point3d endPt = line.EndPoint;
                            points_end.Add(endPt);
                            // 在控制台中输出直线的起点和终点坐标
                            //ed.WriteMessage("\nSelected line start point: {0}, end point: {1}", startPt, endPt);
                        }
                    }
                    tr.Commit();
                }
                this.WindowState = FormWindowState.Normal;
                int selected = selRes.Value.Count;
                label_line_num.Text = selected.ToString()+" selected";
            }
            else
            {
                ed.WriteMessage("\nNo valid objects selected.");
                this.WindowState = FormWindowState.Normal;
                return;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 获取AutoCAD文档和编辑器对象
            Document doc = Application.DocumentManager.MdiActiveDocument;
            Database db = doc.Database;
            Editor ed = doc.Editor;

            //窗口聚焦
            this.WindowState = FormWindowState.Minimized;
            Autodesk.AutoCAD.Internal.Utils.SetFocusToDwgView();
            

            PromptPointOptions promptOptions = new PromptPointOptions("\n指定参考点");
            PromptPointResult promptResult = ed.GetPoint(promptOptions);

            if (promptResult.Status == PromptStatus.OK)
            {
                Point3d selectedPoint = promptResult.Value;
                // 在控制台中输出用户选择的点的坐标
                ed.WriteMessage("\nSelected point coordinates: {0}", selectedPoint);
                this.WindowState = FormWindowState.Normal;
                tbCadPx.Text = selectedPoint.X.ToString();
                tbCadPy.Text = selectedPoint.Y.ToString();

            }
            else
            {
                ed.WriteMessage("\nNo valid point selected.");
                this.WindowState = FormWindowState.Normal;
                return;
            }
        }
        
        private void btn_gen_Click(object sender, EventArgs e)
        {
            tb_flow.Text = "";

            double Px_flac = 0;
            double Pz_flac = 0;
            // Flac3D 参考点
            try
            {
                Px_flac = double.Parse(tbFlacPx.Text);
                Pz_flac = double.Parse(tbFlacPz.Text);
            }
            catch 
            {
                MessageBox.Show("Flac3D 参考点设置错误", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //CAD参考点
            double Px_cad = 0;
            double Py_cad = 0;
            try
            {
                 Px_cad = double.Parse(tbCadPx.Text);
                 Py_cad = double.Parse(tbCadPy.Text);
            }catch
            {
                MessageBox.Show("CAD 参考点设置错误", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //段数segments

            int segments = 10;
            try
            {
                segments = int.Parse(tb_segments.Text);
                if (segments <= 0)
                {
                    throw new Exception("段数只能为正整数");
                }
            }catch
            {
                MessageBox.Show("段数设置错误", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            double dis = 800;
            try
            {
                dis = double.Parse(tb_dis.Text);
            } catch
            {
                MessageBox.Show("排距错误", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // 获取AutoCAD文档和编辑器对象
            Document doc = Application.DocumentManager.MdiActiveDocument;
            Database db = doc.Database;
            Editor ed = doc.Editor;



            tb_flow.Text += $"fish define gencable{fish_count}\n";
            tb_flow.Text += "\tlocal y = 0.1;\n";
            tb_flow.Text += "\tloop while y<4.2;tunnel depth\n";
            tb_flow.Text += "\t\tcommand\n";
            for (int i = 0;i<points_start.Count;i++)
            {
                var startP = points_start[i];
                var endP = points_end[i];
                if (combo_unit.SelectedIndex == 1)//1:1
                {
                    tb_flow.Text += $"\t\t\tstruct cable create by-line ({startP.X - Px_cad + Px_flac},[y],{startP.Y - Py_cad + Pz_flac}) ({endP.X - Px_cad + Px_flac},[y],{endP.Y - Py_cad + Pz_flac}) segments={segments} group \"{tb_group.Text}\"\n";
                }
                else if (combo_unit.SelectedIndex == 0)//1:1000
                {
                    tb_flow.Text += $"\t\t\tstruct cable create by-line ({startP.X/1000 - Px_cad/1000 + Px_flac},[y],{startP.Y/1000 - Py_cad/1000 + Pz_flac}) ({endP.X/1000 - Px_cad/1000 + Px_flac},[y],{endP.Y/1000 - Py_cad/1000 + Pz_flac}) segments={segments} group \"{tb_group.Text}\"\n";
                }
                
            }
            tb_flow.Text += "\t\tendcommand\n";
            tb_flow.Text += $"\t\ty+={dis/1000};distance\n";
            tb_flow.Text += "\tendloop\n";
            tb_flow.Text += "end\n";
            tb_flow.Text += $"@gencable{fish_count++}\n";
        }

        private void btn_copy_Click(object sender, EventArgs e)
        {
            if (tb_flow.Text != "")
            {
                Clipboard.SetDataObject(tb_flow.Text);
                
            }
        }
    }
}

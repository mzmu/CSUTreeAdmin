using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.DataSourcesFile;
using ESRI.ArcGIS.DataSourcesGDB;
using ESRI.ArcGIS.DataSourcesRaster;
using Npgsql;
namespace CSUTreeAdmin
{
    public partial class CSUTreeAdminMainform : Form
    {
        protected string currentOperatoin = "DO_NOTHING";  // define a state whose default state is "DO_NOTHIN".
        protected NpgsqlConnection conn = null;  // define a connection.


        public CSUTreeAdminMainform()
        {
            InitializeComponent();
            addCSUSatellite();  // add into the raster image as map.
        }


        // a function for connecting database.
        protected NpgsqlConnection getConnection()
        {
            var connString = "Host=127.0.0.1;Username=postgres;Password=123456;Database=trees";
            NpgsqlConnection conn = new NpgsqlConnection(connString);
            conn.Open();
            return conn;
        } 


        // change the current state to "ADD_TREE".
        private void btnAddTree_Click(object sender, EventArgs e)
        {
            currentOperatoin = "ADD_TREE";
            tbMapView.CurrentTool = null;  // make the others tools be not useful.
        }


        protected void addCSUSatellite()
        {
            IRasterLayer rl = new RasterLayer();
            rl.CreateFromFilePath(@"D:\Assignment\Senior1\GISdev\data\csu.jpg");
            mapControl.AddLayer(rl, mapControl.LayerCount);
        }


        protected void addTree(double x, double y)
        {
            NpgsqlConnection conn = getConnection();  // create a connection.
            FormTreeInformation dlg = new FormTreeInformation();
            dlg.setXY(x, y);
            if (DialogResult.OK != dlg.ShowDialog())
            {
                return;
            }
            
            // Insert some data
            string sql = String.Format("insert into trees(geo,treetype,age,diameter) values('SRID=3857;POINT({0} {1})'::geometry,@t,@d,@a)", x, y);
            NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("t", dlg.getTreeType());
            cmd.Parameters.AddWithValue("d", dlg.getTreeDiameter());
            cmd.Parameters.AddWithValue("a", dlg.getTreeAge());
            cmd.ExecuteNonQuery();

            conn.Close();
            mapControl.ActiveView.Refresh();
        }


        // get the detail information of the tree around the specified point
        protected Tree getTreeIDByLocation(double x, double y, double tolerance)
        {
            NpgsqlConnection conn = getConnection();
            // select the specific position of tree, return all information about the tree.
            string sql = String.Format(
                                  "select "
                                + " id,treetype,age,diameter,st_x(geo) as x,st_y(geo) as y "
                                + " from "
                                + " trees "
                                + " where "
                                + " st_distance(geo, "
                                + " 'SRID=3857;POINT({0} {1})'::geometry) < {2};",
                                x, y, tolerance);
            NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
            NpgsqlDataReader reader = cmd.ExecuteReader();

            Tree tree = null;
            if (!reader.HasRows)
            {
                return tree;
            }

            reader.Read();
            tree = new Tree();
            int i = 0;  // a good method to get the specified information by index.
            tree.Id = reader.GetInt32(i++);
            tree.Treetype = reader.GetInt32(i++);
            tree.Age = reader.GetDouble(i++);
            tree.Diameter = reader.GetDouble(i++);
            tree.X = reader.GetDouble(i++);
            tree.Y = reader.GetDouble(i++);

            return tree;
        }


        public void removeTree(double x, double y)
        {
            NpgsqlConnection conn = getConnection();
            double tolerance = 5 * 2.54 / 72 / 100 * mapControl.MapScale;
            Tree tree = getTreeIDByLocation(x,y,tolerance);
            if(tree == null)
            {
                return;
            }
            // show a dialog for confirm deleting operation.
            string message = "辛辛苦苦采集的数据你要删掉吗？";  // the appearance of the popup dialog.
            string caption = "确认一下";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            // if select the "YES" button, execute deleting.
            if (result != DialogResult.Yes)
            {
                return;
            }
            NpgsqlCommand cmd = new NpgsqlCommand(
                String.Format("delete from trees where id = {0}", tree.Id),
                conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            mapControl.ActiveView.Refresh();
        }


        private void mapControl_OnMouseDown(object sender, ESRI.ArcGIS.Controls.IMapControlEvents2_OnMouseDownEvent e)
        {
            if (currentOperatoin == "ADD_TREE")
            {
                addTree(e.mapX, e.mapY);
            }
            else if (currentOperatoin == "REMOVE_TREE")
            {
                removeTree(e.mapX, e.mapY);
            }
            else if (currentOperatoin == "EDIT_TREE")
            {
                editTree(e.mapX, e.mapY);
            }
        }


        protected void editTree(double x, double y)
        {
            double tolerance = 5 * 2.54 / 72 / 100 * mapControl.MapScale;
            Tree tree = getTreeIDByLocation(x, y, tolerance);
            if (tree == null)
            {
                return;
            }

            // click a tree and then pop out a dialog to display the detail information about the tree.
            FormTreeInformation dlg = new FormTreeInformation();
            dlg.Id = tree.Id;
            dlg.setXY(tree.X, tree.Y);
            dlg.setTreeAge(tree.Age);
            dlg.setTreeDiameter(tree.Diameter);
            dlg.setTreeType(tree.Treetype);
            dlg.ShowDialog();
        }


        private void tbMapView_OnItemClick(object sender, ESRI.ArcGIS.Controls.IToolbarControlEvents_OnItemClickEvent e)
        {
            currentOperatoin = "DO_NOTHING";
        }


        private void btnRemoveTree_Click(object sender, EventArgs e)
        {
            currentOperatoin = "REMOVE_TREE";
        }


        private void btnEditTreeInfo_Click(object sender, EventArgs e)
        {
            currentOperatoin = "EDIT_TREE";
            tbMapView.CurrentTool = null;
        }

    }
}
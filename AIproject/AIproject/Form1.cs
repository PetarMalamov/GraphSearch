﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AIproject.Logic;

namespace AIproject
{
    public partial class Form1 : Form
    {
        Graph graph = new Graph();
        BFS bfs;
        WeigthCoordinatesSearch wcs;
        string[] methods = { "Shortest path","Weigth Search" };
        public Form1()
        {
            InitializeComponent();
            SearchPanel.Visible = false;
            AddLinkPanel.Visible = false;
            SearchMethod.Items.AddRange(methods);
        }

        private void AddComboBoxItem(ComboBox cb,List<string> items)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void AddNodePanel_Click(object sender, EventArgs e)
        {
            AddLinkPanel.Visible = false;
            SearchPanel.Visible = false;
            MainPanel.Visible = true;
        }

        private void AddNode_Click(object sender, EventArgs e)
        {
            graph.addNode(new Node(NodeNameTf.Text,Double.Parse(NodeWeightTf.Text),Double.Parse(xTB.Text), Double.Parse(yTB.Text)));
            MessageBox.Show("Node added");
        }

        private void AddLinkButton_Click(object sender, EventArgs e)
        {
            graph.addLink((string)FromNodeCB.SelectedItem,(string)ToNodeCB.SelectedItem,true);
            MessageBox.Show("Link added");
        }

        private void AddLink_Click(object sender, EventArgs e)
        {
            AddLinkPanel.Visible = true;
            SearchPanel.Visible = false;
            MainPanel.Visible = false;
            FromNodeCB.Items.Clear();
            ToNodeCB.Items.Clear();
            FromNodeCB.Items.AddRange(graph.getNodes().ToArray());
            ToNodeCB.Items.AddRange(graph.getNodes().ToArray());
        }

        private void Search_Click(object sender, EventArgs e)
        {
            AddLinkPanel.Visible = false;
            SearchPanel.Visible = true;
            MainPanel.Visible = false;
            SearchFromCB.Items.Clear();
            SearchToCB.Items.Clear();
            SearchFromCB.Items.AddRange(graph.getNodes().ToArray());
            SearchToCB.Items.AddRange(graph.getNodes().ToArray());
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string from = (string)SearchFromCB.SelectedItem;
            string to = (string)SearchToCB.SelectedItem;
            List<string> path = new List<string>();
            bfs = new BFS(graph);
            wcs = new WeigthCoordinatesSearch(graph);
            switch ((string)SearchMethod.SelectedItem)
            {
                case "Shortest path":
                    path = bfs.search(from, to);
                    break;
                case "Weigth Search":
                    path = wcs.search(from, to);
                    break;
                default:
                    break;
            }

            graph.ClearTested();
            if (path!=null)
            {
                path.Reverse();
                MessageBox.Show(String.Join("->", path)+" and the elements are "+path.Count);
            }else
            {
                MessageBox.Show("no path");
            }
        }

        private void lab(object sender, PaintEventArgs e)
        {

        }
    }
}

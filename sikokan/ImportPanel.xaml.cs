﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace sikokan
{
    /// <summary>
    /// Interaction logic for ImportPanel.xaml
    /// </summary>
    public partial class ImportPanel : DockPanel
    {
        public ImportPanel()
        {
            InitializeComponent();
            FileSelectMenus fileSelectkun=new FileSelectMenus();
            fileSelectkun.Text = "tintin";
            fileSelectkun.TitlePic = "";
            fileSelectkun.clicked += (sender, eventargs)=>{
                MessageBox.Show("ちんちん");
            };
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
        }
    }
}

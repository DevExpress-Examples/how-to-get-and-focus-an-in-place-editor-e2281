using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using DevExpress.Xpf.Bars;

namespace FocusEditor_Ex {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
        }

        private void btn_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e) {
            (beiEditor.Links[0] as BarEditItemLink).Editor.Focus();
        }
    }
}

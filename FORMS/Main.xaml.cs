using System;
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
using System.Windows.Shapes;

namespace dtg_admin.FORMS
{
    /// <summary>
    /// Interaktionslogik für Main.xaml
    /// </summary>
    public partial class Main : Window
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Frm_main_Loaded(object sender, RoutedEventArgs e)
        {

            // Einfach nur das die Namen in der unteren Combobox stehen
            Cmbx_user.Items.Add("");
            Cmbx_user.Items.Add("Yingiz");
            Cmbx_user.Items.Add("Threnario");
            Cmbx_user.Items.Add("Tschui");
            Cmbx_user.Items.Add("Thanatos");

            //Das was in der Search Namensbox ist
            Cmbx_name.Items.Add("");
            Cmbx_name.Items.Add("Hey");



        }

        private void Cmbx_name_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Search aktivieren
            Btn_search.IsEnabled = true;
        }

     

        private void Cmbx_name_FocusableChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            //Nach suche alles andere Aktivieren
            Livi_strikes.IsEnabled = true;
            Cmbx_user.IsEnabled = true;
            Txtb_comment.IsEnabled = true;
            Btn_add.IsEnabled = true;
            Btn_delete.IsEnabled = true;
        }

        private void Btn_search_Click(object sender, RoutedEventArgs e)
        {
            Livi_strikes.IsEnabled = true;
            Cmbx_user.IsEnabled = true;
            Txtb_comment.IsEnabled = true;
            Btn_add.IsEnabled = true;
            Btn_delete.IsEnabled = true;

            if (Livi_strikes.Items.Count == 0)
            {
                Livi_strikes.Items.Add("Nicht angemeldet");
                Livi_strikes.Items.Add("Zu Spät");
                Livi_strikes.Items.Add("Regeln missachtet!(Bemerkung)");
                Livi_strikes.Items.Add("Member flame");
                Livi_strikes.Items.Add("Zu schlechte Performance");

            }
        }
    }
}

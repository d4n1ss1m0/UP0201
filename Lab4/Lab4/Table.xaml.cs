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

namespace Lab4
{
    /// <summary>
    /// Логика взаимодействия для Table.xaml
    /// </summary>
    public partial class Table : Window
    {
        public Table()
        {
            InitializeComponent();
            using (ApplicationContext db = new ApplicationContext())
            {
                List<TableElem> elems = new List<TableElem>();
                var acc = db.Accounts;
                foreach(Account ac in acc)
                {
                    elems.Add(new TableElem(ac));               
                }
                AccountT.ItemsSource = elems;
            }
        }
    }
}

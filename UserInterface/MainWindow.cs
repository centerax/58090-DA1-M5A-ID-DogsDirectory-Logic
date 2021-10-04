using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;

namespace UserInterface
{
    public partial class MainWindow : Form
    {
        public DogsDirectorySqlServer DogsAndOwners { get; private set; }

        public MainWindow()
        {
            InitializeComponent();
            DogsAndOwners = new DogsDirectorySqlServer();
            LoadAddDogOwnerUserControl();
        }

        private void LoadAddDogOwnerUserControl()
        {
            pnlMain.Controls.Clear();
            UserControl addOwner = new AddDogOwner(DogsAndOwners);
            pnlMain.Controls.Add(addOwner);
        }

        private void btnAddDog_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            UserControl addDog = new AddDog(DogsAndOwners);
            pnlMain.Controls.Add(addDog);
        }

        private void btnAddDogOwner_Click(object sender, EventArgs e)
        {
            LoadAddDogOwnerUserControl();
        }

        private void btnListDirectory_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            ListDogsAndOwners listData = new ListDogsAndOwners(DogsAndOwners);
            pnlMain.Controls.Add(listData);
        }
    }
}

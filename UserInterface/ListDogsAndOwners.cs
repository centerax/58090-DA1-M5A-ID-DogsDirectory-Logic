using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;

namespace UserInterface
{
    public partial class ListDogsAndOwners : UserControl
    {
        private DogsDirectory directory;

        public ListDogsAndOwners(DogsDirectory aDirectory)
        {
            InitializeComponent();
            directory = aDirectory;

            InitializeOwnersListBox();
            LoadDogsForOwner();
        }

        private void LoadDogsForOwner()
        {
            DogOwner selectedOwner = (DogOwner)lstboxOwners.SelectedItem;

            if (selectedOwner != null)
            {
                lstboxDogs.DataSource = selectedOwner.Dogs();
            }
        }

        private void InitializeOwnersListBox()
        {
            lstboxOwners.DataSource = directory.Owners();
        }

        private void lstboxOwners_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadDogsForOwner();
        }
    }
}

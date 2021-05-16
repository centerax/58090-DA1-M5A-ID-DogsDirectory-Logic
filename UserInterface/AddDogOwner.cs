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
    public partial class AddDogOwner : UserControl
    {
        private DogsDirectorySqlServer directory;
        public AddDogOwner(DogsDirectorySqlServer aDirectory)
        {
            InitializeComponent();
            directory = aDirectory;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (AnyFieldBlank())
            {
                MessageBox.Show("No puede haber campos vacíos.", "Ha ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                AddNewOwner();
                EmptyFields();
                MessageBox.Show("Dueño agregado con éxito.", "Operación realizada correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void EmptyFields()
        {
            txtAddress.Text = "";
            txtMobile.Text = "";
            txtName.Text = "";
        }

        private void AddNewOwner()
        {
            string name = txtName.Text.Trim();
            string mobile = txtMobile.Text.Trim();
            string address = txtAddress.Text.Trim();

            DogOwner newOwner = new DogOwner { 
                Name = name,
                Mobile = mobile,
                Address = address
            };

            directory.AddOwner(newOwner);
        }

        private bool AnyFieldBlank()
        {
            bool isNameBlank = string.IsNullOrEmpty(txtName.Text.Trim());
            bool isMobilelank = string.IsNullOrEmpty(txtMobile.Text.Trim());
            bool isAddressBlank = string.IsNullOrEmpty(txtAddress.Text.Trim());

            return isNameBlank || isMobilelank || isAddressBlank;
        }
    }
}

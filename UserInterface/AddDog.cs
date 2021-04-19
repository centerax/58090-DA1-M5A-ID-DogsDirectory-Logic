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
using Domain.Exceptions;

namespace UserInterface
{
    public partial class AddDog : UserControl
    {
        private DogsDirectory directory;

        public AddDog(DogsDirectory aDirectory)
        {
            InitializeComponent();
            directory = aDirectory;

            LoadSizes();
            LoadOwners();
        }

        private void LoadOwners()
        {
            cmbOwner.DataSource = directory.Owners();
        }

        private void LoadSizes()
        {
            cmbSize.DataSource = Enum.GetValues(typeof(Dog.BreedSize));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!AnyTextFieldBlank())
            {
                if (AnyDogSizeAndOwnerSelected())
                {
                    try
                    {
                        AddNewDog();
                        EmptyFields();
                        MessageBox.Show("Perro agregado con éxito.", "Operación realizada correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (NameTooLongException ex)
                    {
                        MessageBox.Show(ex.Message, "Ha ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione Dueño y Tamaño.", "Ha ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No puede haber campos vacíos.", "Ha ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EmptyFields()
        {
            txtName.Text = "";
            txtBreed.Text = "";
            cmbOwner.SelectedIndex = 0;
            cmbSize.SelectedIndex = 0;
        }

        private void AddNewDog()
        {
            string name = txtName.Text.Trim();
            string breed = txtBreed.Text.Trim();
            Dog.BreedSize size = (Dog.BreedSize)cmbSize.SelectedItem;
            DogOwner owner = (DogOwner)cmbOwner.SelectedItem;

            Dog newDog = new Dog
            {
                Name = name,
                Size = size,
                Breed = breed,
            };

            directory.AddDog(owner, newDog);
        }

        private bool AnyDogSizeAndOwnerSelected()
        {
            bool dogSizeSelected = cmbSize.SelectedIndex != -1;
            bool ownerSelected = cmbOwner.SelectedIndex != -1;

            return dogSizeSelected && ownerSelected;
        }

        private bool AnyTextFieldBlank()
        {
            bool isNameBlank = string.IsNullOrEmpty(txtName.Text.Trim());
            bool isBreedlank = string.IsNullOrEmpty(txtBreed.Text.Trim());

            return isNameBlank || isBreedlank;
        }
    }
}

using System.ComponentModel.DataAnnotations;

namespace Telephone_directory_Winforms
{
    public partial class MainForm : Form
    {
        private List<Contact> contacts = new List<Contact>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) ||
                string.IsNullOrEmpty(txtNumber.Text) ||
                string.IsNullOrEmpty(txtAddres.Text))
            {
                MessageBox.Show("Сначала заполните поля для ввода.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var Contact = new Contact
            {
                Name = txtName.Text,
                Number = txtNumber.Text,
                Address = txtAddres.Text,
            };

            contacts.Add(Contact);
            UpdateContactList();
            ClearFields();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (contactListBox.SelectedItem is Contact contact)
            {
                contacts.Remove(contact);
                UpdateContactList();
            }

            else
            {
                MessageBox.Show("Выберите контакт для удаления.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void ClearFields()
        {
            txtName.Clear();
            txtNumber.Clear();
            txtAddres.Clear();
        }

        private void UpdateContactList()
        {
            string searchItem = txtSearch.Text;
            contactListBox.Items.Clear();
            var filteredContacts = contacts.Where(c => c.Name.ToLower().Contains(searchItem)).ToList();

            foreach (var contact in filteredContacts)
            {
                contactListBox.Items.Add(contact);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            UpdateContactList();
        }
    }
}

using IFSPStore.App.Base;
using IFSPStore.App.ViewModels;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Service.Validators;
using Microsoft.VisualBasic.ApplicationServices;
using User = IFSPStore.Domain.Entities.User;

namespace IFSPStore.App.Register
{
    public partial class UserForm : BaseForm
    {
        #region Variables
        private readonly IBaseService<User> _usersService;
        private List<UserModel> _users;
        private bool isPasswordVisible = false;

        #endregion

        #region Methods
        public UserForm(IBaseService<User> usersService)
        {
            _usersService = usersService;

            InitializeComponent();
        }

        private void FormToObject(User user)
        {
            user.Name = tbName.Text;
            user.Email = tbEmail.Text;
            user.Password = tbPassword.Text;
            user.Login = tbLogin.Text;
            user.RegisterDate = DateTime.UtcNow;
            user.IsActive = true;
        }

        protected override void Save()
        {
            try
            {
                if (isEditMode)
                {
                    int.TryParse(tbId.Text, out int id);

                    var user = _usersService.GetById<User>(id);

                    FormToObject(user);

                    user = _usersService.Update<User, User, UserValidator>(user);
                }
                else
                {
                    var user = new User();

                    FormToObject(user);

                    user = _usersService.Add<User, User, UserValidator>(user);
                }

                ClearFields();

                MessageBox.Show("User saved successfully", "IFSP Store",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "IFSP Store",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Delete(int id)
        {
            try
            {
                _usersService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "IFSP Store",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void PopulateGrid()
        {
            try
            {
                _users = _usersService.Get<UserModel>().ToList();
                dataGridViewList.DataSource = _users;
                //dataGridViewList.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "IFSP Store",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void GridToForm(DataGridViewRow? record)
        {
            try
            {
                tbId.Text = record?.Cells["Id"].Value.ToString();
                tbName.Text = record?.Cells["Name"].Value.ToString();
                tbEmail.Text = record?.Cells["Email"].Value.ToString();
                tbLogin.Text = record?.Cells["Login"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "IFSP Store",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbPasswordVisible_CheckedChanged(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;

            tbPassword.PasswordChar = isPasswordVisible ?
                new char[1].First() :
                '●';
        }

        #endregion
    }
}

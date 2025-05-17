using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Mini_Case_Study
{
    public partial class Form1 : Form
    {
        // SQLite database connection
        SQLiteConnection con;

        /// <summary>
        /// Converts numeric role values to their text equivalents (0=Guest, 1=Admin, 2=SuperAdmin)
        /// </summary>
        /// <param name="roleValue">The numeric role value to convert</param>
        /// <returns>Text representation of the role</returns>
        private string GetRoleText(object roleValue)
        {
            // Check for null values
            if (roleValue == null || roleValue == DBNull.Value)
                return "Unknown";

            int role;
            if (int.TryParse(roleValue.ToString(), out role))
            {
                // Return text equivalent based on numeric role
                switch (role)
                {
                    case 0:
                        return "Guest";
                    case 1:
                        return "Admin";
                    case 2:
                        return "SuperAdmin";
                    default:
                        return "Unknown";
                }
            }
            return roleValue.ToString();
        }

        /// <summary>
        /// Loads users from database and displays them in the DataGridView
        /// </summary>
        private void LoadUsers()
        {
            // SQL query to fetch all users
            string query = "SELECT ID, Username, Email, IsEnabled FROM User_Info";

            using (SQLiteCommand cmd = new SQLiteCommand(query, con))
            {
                try
                {
                    con.Open();

                    // Load data into DataTable
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Add a new column to display text representation of roles
                    if (dt.Columns.Contains("UserRoles"))
                    {
                        DataColumn roleTextColumn = new DataColumn("RoleText", typeof(string));
                        dt.Columns.Add(roleTextColumn);
                        foreach (DataRow row in dt.Rows)
                        {
                            row["RoleText"] = GetRoleText(row["UserRoles"]);
                        }
                    }

                    // Bind data to DataGridView
                    DGV_UserInfo.DataSource = dt;

                    // Hide original numeric role column, show text equivalent
                    if (DGV_UserInfo.Columns.Contains("UserRoles"))
                    {
                        DGV_UserInfo.Columns["UserRoles"].Visible = false;
                    }
                    if (DGV_UserInfo.Columns.Contains("RoleText"))
                    {
                        DGV_UserInfo.Columns["RoleText"].HeaderText = "Role";
                        DGV_UserInfo.Columns["RoleText"].DisplayIndex = 3;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading users: " + ex.Message);
                }
                finally
                {
                    // Always close the connection
                    con.Close();
                }
            }
        }

        /// <summary>
        /// Form constructor - application entry point
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            // Create SQLite database connection
            string dbPath = Path.Combine(Application.StartupPath, "Mini_Case-DB_SQLite.db");
            con = new SQLiteConnection($"Data Source={dbPath};Version=3;");
        }

        /// <summary>
        /// Form Load Event - triggered when the form is loaded
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            // Customize DataGridView header styles
            DGV_UserInfo.EnableHeadersVisualStyles = false;
            DGV_UserInfo.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DGV_UserInfo.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue;
            DGV_UserInfo.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // Subscribe to cell formatting event
            DGV_UserInfo.CellFormatting += DGV_UserInfo_CellFormatting;

            // Load users from database
            LoadUsers();
        }

        /// <summary>
        /// Cell formatting event for DataGridView
        /// </summary>
        private void DGV_UserInfo_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Convert numeric role values to text for UserRoles column
            if (DGV_UserInfo.Columns[e.ColumnIndex].Name == "UserRoles" && e.Value != null)
            {
                e.Value = GetRoleText(e.Value);
                e.FormattingApplied = true;
            }
        }

        /// <summary>
        /// New User button click event
        /// </summary>
        private void b_NewUser_Click(object sender, EventArgs e)
        {
            // Make user info form visible
            GB_UserInfo.Visible = true;
            b_SaveUser.Visible = true;
            pictureBox1.SendToBack();

            // Clear form fields
            ClearInputFields();
        }

        /// <summary>
        /// Active/Inactive user filter checkbox change event
        /// </summary>
        private void cb_disableds_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string query;

                // Determine query based on checkbox state
                if (cb_disableds.Checked)
                {
                    // Get only active users
                    query = "SELECT ID, Username, Email, IsEnabled FROM User_Info WHERE LOWER(IsEnabled) = 'true'";
                }
                else
                {
                    // Get all users
                    query = "SELECT ID, Username, Email, IsEnabled FROM User_Info";
                }

                using (SQLiteConnection tempCon = new SQLiteConnection(con.ConnectionString))
                {
                    tempCon.Open();
                    using (SQLiteDataAdapter da = new SQLiteDataAdapter(query, tempCon))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        // Add role text column
                        if (dt.Columns.Contains("UserRoles"))
                        {
                            DataColumn roleTextColumn = new DataColumn("RoleText", typeof(string));
                            dt.Columns.Add(roleTextColumn);
                            foreach (DataRow row in dt.Rows)
                            {
                                row["RoleText"] = GetRoleText(row["UserRoles"]);
                            }
                        }

                        // Bind data to DataGridView
                        DGV_UserInfo.DataSource = dt;

                        // Set column visibility and header text
                        if (DGV_UserInfo.Columns.Contains("UserRoles"))
                        {
                            DGV_UserInfo.Columns["UserRoles"].Visible = false;
                        }
                        if (DGV_UserInfo.Columns.Contains("RoleText"))
                        {
                            DGV_UserInfo.Columns["RoleText"].HeaderText = "Role";
                            DGV_UserInfo.Columns["RoleText"].DisplayIndex = 3;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering users: " + ex.Message);
            }
        }

        /// <summary>
        /// Save User button click event
        /// </summary>
        private void b_SaveUser_Click(object sender, EventArgs e)
        {
            // Get and trim form data
            string username = tb_Username.Text.Trim();
            string displayName = tb_displayname.Text.Trim();
            string phone = tb_phone.Text.Trim();
            string email = tb_email.Text.Trim();
            int roleIndex = cb_roles.SelectedIndex;
            string isEnabled = Cb_IsEnabled.Checked ? "True" : "False";

            // Form validation - check for empty fields
            if (string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(displayName) ||
                string.IsNullOrEmpty(phone) ||
                string.IsNullOrEmpty(email) ||
                roleIndex == -1)
            {
                MessageBox.Show("Please complete all fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Username and phone validation - check format using Regex
            if (!System.Text.RegularExpressions.Regex.IsMatch(username, @"^[a-zA-ZğüşöçıİĞÜŞÖÇ]+$"))
            {
                MessageBox.Show("Username must contain only letters.", "Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(phone, @"^\d+$"))
            {
                MessageBox.Show("Phone number must contain only digits.", "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if username already exists in the database
            bool usernameExists = false;
            string checkQuery = "SELECT COUNT(*) FROM User_Info WHERE LOWER(Username) = LOWER(@Username)";

            using (SQLiteConnection checkCon = new SQLiteConnection(con.ConnectionString))
            {
                using (SQLiteCommand checkCmd = new SQLiteCommand(checkQuery, checkCon))
                {
                    checkCmd.Parameters.AddWithValue("@Username", username);

                    try
                    {
                        checkCon.Open();
                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                        usernameExists = (count > 0);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error checking username: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    finally
                    {
                        checkCon.Close();
                    }
                }
            }

            // If username already exists, show error message and return
            if (usernameExists)
            {
                MessageBox.Show("This username is already taken. Please choose a different username.",
                                "Username Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // SQL query to insert new user
            string query = "INSERT INTO User_Info (Username, DisplayName, Phone, Email, UserRoles, IsEnabled) " +
                           "VALUES (@Username, @DisplayName, @Phone, @Email, @UserRoles, @IsEnabled)";

            using (SQLiteCommand cmd = new SQLiteCommand(query, con))
            {
                // Add parameter values - safe against SQL Injection
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@DisplayName", displayName);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@UserRoles", roleIndex);
                cmd.Parameters.AddWithValue("@IsEnabled", isEnabled);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear form fields
                    ClearInputFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Always close the connection
                    con.Close();
                }
            }

            // Refresh user list
            LoadUsers();
        }

        /// <summary>
        /// Helper method to clear form input fields
        /// </summary>
        private void ClearInputFields()
        {
            tb_Username.Clear();
            tb_displayname.Clear();
            tb_phone.Clear();
            tb_email.Clear();
            cb_roles.SelectedIndex = -1; // Reset role selection
            Cb_IsEnabled.Checked = true; // Set enabled by default
        }
    }
}
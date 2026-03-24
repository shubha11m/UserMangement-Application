Public Class DashboardForm
    Inherits Form

    Private lblWelcome As New Label()
    Private lblUserInfo As New Label()
    Private lblEmail As New Label()
    Private lblPhone As New Label()
    Private lblAddress As New Label()
    Private lblJoinDate As New Label()
    Private txtEmail As New TextBox()
    Private txtPhone As New TextBox()
    Private txtAddress As New TextBox()
    Private txtJoinDate As New TextBox()
    Private btnEdit As New Button()
    Private btnSave As New Button()
    Private btnLogout As New Button()
    Private username As String

    Public Sub New(uname As String)
        username = uname
        InitializeComponent()
        LoadUserData()
    End Sub

    Private Sub InitializeComponent()
        Me.Text = "User Dashboard"
        Me.Size = New Size(600, 450)
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.BackColor = Color.WhiteSmoke

        ' Welcome Label
        lblWelcome.Text = "Welcome to Dashboard"
        lblWelcome.Location = New Point(20, 20)
        lblWelcome.Size = New Size(300, 30)
        lblWelcome.Font = New Font("Arial", 14, FontStyle.Bold)
        lblWelcome.ForeColor = Color.DarkBlue

        ' User Info Label
        lblUserInfo.Text = "Username: " & username
        lblUserInfo.Location = New Point(20, 60)
        lblUserInfo.Size = New Size(400, 25)
        lblUserInfo.Font = New Font("Arial", 11)

        ' Email Label
        lblEmail.Text = "Email:"
        lblEmail.Location = New Point(20, 100)
        lblEmail.Size = New Size(100, 25)
        lblEmail.Font = New Font("Arial", 10)

        ' Email TextBox
        txtEmail.Location = New Point(130, 100)
        txtEmail.Size = New Size(400, 25)
        txtEmail.ReadOnly = True
        txtEmail.Font = New Font("Arial", 10)

        ' Phone Label
        lblPhone.Text = "Phone:"
        lblPhone.Location = New Point(20, 140)
        lblPhone.Size = New Size(100, 25)
        lblPhone.Font = New Font("Arial", 10)

        ' Phone TextBox
        txtPhone.Location = New Point(130, 140)
        txtPhone.Size = New Size(400, 25)
        txtPhone.ReadOnly = True
        txtPhone.Font = New Font("Arial", 10)

        ' Address Label
        lblAddress.Text = "Address:"
        lblAddress.Location = New Point(20, 180)
        lblAddress.Size = New Size(100, 25)
        lblAddress.Font = New Font("Arial", 10)

        ' Address TextBox
        txtAddress.Location = New Point(130, 180)
        txtAddress.Size = New Size(400, 60)
        txtAddress.ReadOnly = True
        txtAddress.Multiline = True
        txtAddress.Font = New Font("Arial", 10)

        ' Join Date Label
        lblJoinDate.Text = "Join Date:"
        lblJoinDate.Location = New Point(20, 250)
        lblJoinDate.Size = New Size(100, 25)
        lblJoinDate.Font = New Font("Arial", 10)

        ' Join Date TextBox
        txtJoinDate.Location = New Point(130, 250)
        txtJoinDate.Size = New Size(400, 25)
        txtJoinDate.ReadOnly = True
        txtJoinDate.Font = New Font("Arial", 10)

        ' Edit Button
        btnEdit.Text = "Edit"
        btnEdit.Location = New Point(130, 290)
        btnEdit.Size = New Size(100, 35)
        btnEdit.Font = New Font("Arial", 10)
        btnEdit.BackColor = Color.LightGreen
        AddHandler btnEdit.Click, AddressOf btnEdit_Click

        ' Save Button
        btnSave.Text = "Save"
        btnSave.Location = New Point(240, 290)
        btnSave.Size = New Size(100, 35)
        btnSave.Font = New Font("Arial", 10)
        btnSave.BackColor = Color.LightYellow
        btnSave.Visible = False
        AddHandler btnSave.Click, AddressOf btnSave_Click

        ' Logout Button
        btnLogout.Text = "Logout"
        btnLogout.Location = New Point(350, 290)
        btnLogout.Size = New Size(100, 35)
        btnLogout.Font = New Font("Arial", 10)
        btnLogout.BackColor = Color.LightCoral
        AddHandler btnLogout.Click, AddressOf btnLogout_Click

        ' Add controls to form
        Me.Controls.Add(lblWelcome)
        Me.Controls.Add(lblUserInfo)
        Me.Controls.Add(lblEmail)
        Me.Controls.Add(txtEmail)
        Me.Controls.Add(lblPhone)
        Me.Controls.Add(txtPhone)
        Me.Controls.Add(lblAddress)
        Me.Controls.Add(txtAddress)
        Me.Controls.Add(lblJoinDate)
        Me.Controls.Add(txtJoinDate)
        Me.Controls.Add(btnEdit)
        Me.Controls.Add(btnSave)
        Me.Controls.Add(btnLogout)
    End Sub

    Private Sub LoadUserData()
        ' In a real application, fetch data from database
        ' For demo purposes, we'll use sample data
        txtEmail.Text = username & "@example.com"
        txtPhone.Text = "+1-800-123-4567"
        txtAddress.Text = "123 Main Street" & vbCrLf & "Springfield, IL 62701"
        txtJoinDate.Text = DateTime.Now.AddMonths(-6).ToString("MM/dd/yyyy")
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs)
        ' Enable editing
        txtEmail.ReadOnly = False
        txtPhone.ReadOnly = False
        txtAddress.ReadOnly = False
        txtJoinDate.ReadOnly = False

        ' Change button visibility
        btnEdit.Visible = False
        btnSave.Visible = True

        ' Highlight editable fields
        txtEmail.BackColor = Color.Yellow
        txtPhone.BackColor = Color.Yellow
        txtAddress.BackColor = Color.Yellow
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs)
        ' In a real application, save data to database
        MessageBox.Show("User information updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Disable editing
        txtEmail.ReadOnly = True
        txtPhone.ReadOnly = True
        txtAddress.ReadOnly = True
        txtJoinDate.ReadOnly = True

        ' Reset background colors
        txtEmail.BackColor = Color.White
        txtPhone.BackColor = Color.White
        txtAddress.BackColor = Color.White

        ' Change button visibility
        btnEdit.Visible = True
        btnSave.Visible = False
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
End Class


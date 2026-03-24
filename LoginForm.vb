Public Class LoginForm
    Inherits Form

    Private lblUsername As New Label()
    Private lblPassword As New Label()
    Private txtUsername As New TextBox()
    Private txtPassword As New TextBox()
    Private btnLogin As New Button()
    Private btnExit As New Button()
    Private lblError As New Label()

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub InitializeComponent()
        Me.Text = "User Login"
        Me.Size = New Size(400, 300)
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = True
        Me.BackColor = Color.WhiteSmoke

        ' Username Label
        lblUsername.Text = "Username:"
        lblUsername.Location = New Point(50, 50)
        lblUsername.Size = New Size(100, 25)
        lblUsername.Font = New Font("Arial", 10)

        ' Username TextBox
        txtUsername.Location = New Point(160, 50)
        txtUsername.Size = New Size(200, 25)
        txtUsername.Font = New Font("Arial", 10)

        ' Password Label
        lblPassword.Text = "Password:"
        lblPassword.Location = New Point(50, 100)
        lblPassword.Size = New Size(100, 25)
        lblPassword.Font = New Font("Arial", 10)

        ' Password TextBox
        txtPassword.Location = New Point(160, 100)
        txtPassword.Size = New Size(200, 25)
        txtPassword.PasswordChar = "*"c
        txtPassword.Font = New Font("Arial", 10)

        ' Error Label
        lblError.Text = ""
        lblError.Location = New Point(50, 140)
        lblError.Size = New Size(310, 30)
        lblError.ForeColor = Color.Red
        lblError.Font = New Font("Arial", 9)

        ' Login Button
        btnLogin.Text = "Login"
        btnLogin.Location = New Point(160, 180)
        btnLogin.Size = New Size(100, 35)
        btnLogin.Font = New Font("Arial", 10)
        btnLogin.BackColor = Color.LightBlue
        AddHandler btnLogin.Click, AddressOf btnLogin_Click

        ' Exit Button
        btnExit.Text = "Exit"
        btnExit.Location = New Point(270, 180)
        btnExit.Size = New Size(100, 35)
        btnExit.Font = New Font("Arial", 10)
        btnExit.BackColor = Color.LightCoral
        AddHandler btnExit.Click, AddressOf btnExit_Click

        ' Add controls to form
        Me.Controls.Add(lblUsername)
        Me.Controls.Add(txtUsername)
        Me.Controls.Add(lblPassword)
        Me.Controls.Add(txtPassword)
        Me.Controls.Add(lblError)
        Me.Controls.Add(btnLogin)
        Me.Controls.Add(btnExit)
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs)
        If ValidateLogin() Then
            ' Show Dashboard
            Dim dashboard As New DashboardForm(txtUsername.Text)
            Me.Hide()
            dashboard.ShowDialog()
            Me.Show()
            ' Clear fields after returning
            txtUsername.Clear()
            txtPassword.Clear()
            lblError.Text = ""
        End If
    End Sub

    Private Function ValidateLogin() As Boolean
        If String.IsNullOrWhiteSpace(txtUsername.Text) Then
            lblError.Text = "Please enter a username"
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtPassword.Text) Then
            lblError.Text = "Please enter a password"
            Return False
        End If

        ' Simple validation: username and password must be at least 3 characters
        If txtUsername.Text.Length < 3 Then
            lblError.Text = "Username must be at least 3 characters"
            Return False
        End If

        If txtPassword.Text.Length < 3 Then
            lblError.Text = "Password must be at least 3 characters"
            Return False
        End If

        ' For demo purposes, accept any valid input
        ' In a real application, validate against a database
        lblError.Text = ""
        Return True
    End Function

    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub
End Class


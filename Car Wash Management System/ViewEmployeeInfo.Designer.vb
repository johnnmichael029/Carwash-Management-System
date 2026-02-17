<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewEmployeeInfo
    Inherits BaseForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        LabelTotalSalary = New Label()
        LabelSalary = New Label()
        Label15 = New Label()
        Label14 = New Label()
        TextBoxBarangay = New TextBox()
        UpdateBtn = New Button()
        FormCloseBtn = New Button()
        DataGridViewDetailerHistory = New DataGridView()
        Label7 = New Label()
        Label5 = New Label()
        TextBoxCity = New TextBox()
        Label13 = New Label()
        Label4 = New Label()
        TextBoxLastName = New TextBox()
        Label3 = New Label()
        LabelEmployeeID = New Label()
        Label8 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        TextBoxEmail = New TextBox()
        TextBoxAge = New TextBox()
        Label2 = New Label()
        TextBoxNumber = New TextBox()
        TextBoxName = New TextBox()
        Panel8 = New Panel()
        Label6 = New Label()
        DateTimePeriodData = New DateTimePicker()
        TextBox1 = New TextBox()
        btnCyclePeriod = New Button()
        ComboBoxGender = New ComboBox()
        ComboBoxPosition = New ComboBox()
        Label1 = New Label()
        CType(DataGridViewDetailerHistory, ComponentModel.ISupportInitialize).BeginInit()
        Panel8.SuspendLayout()
        SuspendLayout()
        ' 
        ' LabelTotalSalary
        ' 
        LabelTotalSalary.AutoSize = True
        LabelTotalSalary.Font = New Font("Century Gothic", 11.25F, FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        LabelTotalSalary.ForeColor = Color.Red
        LabelTotalSalary.Location = New Point(57, 723)
        LabelTotalSalary.Name = "LabelTotalSalary"
        LabelTotalSalary.Size = New Size(17, 20)
        LabelTotalSalary.TabIndex = 122
        LabelTotalSalary.Text = "0"
        ' 
        ' LabelSalary
        ' 
        LabelSalary.AutoSize = True
        LabelSalary.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelSalary.ForeColor = Color.FromArgb(CByte(77), CByte(77), CByte(83))
        LabelSalary.Location = New Point(57, 742)
        LabelSalary.Name = "LabelSalary"
        LabelSalary.Size = New Size(130, 16)
        LabelSalary.TabIndex = 121
        LabelSalary.Text = "Salary for the Day (₱)"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Century Gothic", 9F)
        Label15.ForeColor = Color.FromArgb(CByte(77), CByte(77), CByte(83))
        Label15.Location = New Point(317, 169)
        Label15.Name = "Label15"
        Label15.Size = New Size(53, 17)
        Label15.TabIndex = 116
        Label15.Text = "Gender"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Century Gothic", 9F)
        Label14.ForeColor = Color.FromArgb(CByte(77), CByte(77), CByte(83))
        Label14.Location = New Point(54, 161)
        Label14.Name = "Label14"
        Label14.Size = New Size(64, 17)
        Label14.TabIndex = 114
        Label14.Text = "Barangay"
        ' 
        ' TextBoxBarangay
        ' 
        TextBoxBarangay.Font = New Font("Century Gothic", 11.25F)
        TextBoxBarangay.Location = New Point(50, 141)
        TextBoxBarangay.Multiline = True
        TextBoxBarangay.Name = "TextBoxBarangay"
        TextBoxBarangay.Size = New Size(261, 40)
        TextBoxBarangay.TabIndex = 113
        ' 
        ' UpdateBtn
        ' 
        UpdateBtn.Anchor = AnchorStyles.Top
        UpdateBtn.BackColor = Color.Green
        UpdateBtn.FlatAppearance.BorderSize = 0
        UpdateBtn.FlatStyle = FlatStyle.Flat
        UpdateBtn.Font = New Font("Century Gothic", 11.25F)
        UpdateBtn.ForeColor = Color.White
        UpdateBtn.Location = New Point(726, 726)
        UpdateBtn.Name = "UpdateBtn"
        UpdateBtn.Size = New Size(123, 40)
        UpdateBtn.TabIndex = 112
        UpdateBtn.Text = "Save"
        UpdateBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        UpdateBtn.UseVisualStyleBackColor = False
        ' 
        ' FormCloseBtn
        ' 
        FormCloseBtn.FlatAppearance.BorderSize = 0
        FormCloseBtn.FlatStyle = FlatStyle.Flat
        FormCloseBtn.Image = My.Resources.Resources.reject1
        FormCloseBtn.Location = New Point(865, 9)
        FormCloseBtn.Name = "FormCloseBtn"
        FormCloseBtn.Size = New Size(34, 23)
        FormCloseBtn.TabIndex = 111
        FormCloseBtn.UseVisualStyleBackColor = True
        ' 
        ' DataGridViewDetailerHistory
        ' 
        DataGridViewDetailerHistory.AllowUserToAddRows = False
        DataGridViewDetailerHistory.AllowUserToResizeColumns = False
        DataGridViewDetailerHistory.AllowUserToResizeRows = False
        DataGridViewDetailerHistory.Anchor = AnchorStyles.None
        DataGridViewDetailerHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewDetailerHistory.BackgroundColor = Color.White
        DataGridViewDetailerHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewDetailerHistory.Location = New Point(54, 223)
        DataGridViewDetailerHistory.Name = "DataGridViewDetailerHistory"
        DataGridViewDetailerHistory.ReadOnly = True
        DataGridViewDetailerHistory.Size = New Size(795, 491)
        DataGridViewDetailerHistory.TabIndex = 110
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.FromArgb(CByte(77), CByte(77), CByte(83))
        Label7.Location = New Point(45, 198)
        Label7.Name = "Label7"
        Label7.Size = New Size(141, 19)
        Label7.TabIndex = 109
        Label7.Text = "DETAILER HISTORY"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 9F)
        Label5.ForeColor = Color.FromArgb(CByte(77), CByte(77), CByte(83))
        Label5.Location = New Point(588, 115)
        Label5.Name = "Label5"
        Label5.Size = New Size(31, 17)
        Label5.TabIndex = 107
        Label5.Text = "City"
        ' 
        ' TextBoxCity
        ' 
        TextBoxCity.Font = New Font("Century Gothic", 11.25F)
        TextBoxCity.Location = New Point(584, 95)
        TextBoxCity.Multiline = True
        TextBoxCity.Name = "TextBoxCity"
        TextBoxCity.Size = New Size(261, 40)
        TextBoxCity.TabIndex = 106
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Century Gothic", 9F)
        Label13.ForeColor = Color.FromArgb(CByte(77), CByte(77), CByte(83))
        Label13.Location = New Point(320, 115)
        Label13.Name = "Label13"
        Label13.Size = New Size(39, 17)
        Label13.TabIndex = 94
        Label13.Text = "Email"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 9F)
        Label4.ForeColor = Color.FromArgb(CByte(77), CByte(77), CByte(83))
        Label4.Location = New Point(321, 69)
        Label4.Name = "Label4"
        Label4.Size = New Size(71, 17)
        Label4.TabIndex = 104
        Label4.Text = "Last Name"
        ' 
        ' TextBoxLastName
        ' 
        TextBoxLastName.Font = New Font("Century Gothic", 11.25F)
        TextBoxLastName.Location = New Point(317, 49)
        TextBoxLastName.Multiline = True
        TextBoxLastName.Name = "TextBoxLastName"
        TextBoxLastName.Size = New Size(261, 40)
        TextBoxLastName.TabIndex = 105
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(77), CByte(77), CByte(83))
        Label3.Location = New Point(41, 26)
        Label3.Name = "Label3"
        Label3.Size = New Size(198, 19)
        Label3.TabIndex = 103
        Label3.Text = "EMPLOYEE INFORMATION"
        ' 
        ' LabelEmployeeID
        ' 
        LabelEmployeeID.AutoSize = True
        LabelEmployeeID.Font = New Font("Segoe UI", 9F, FontStyle.Underline)
        LabelEmployeeID.ForeColor = Color.Red
        LabelEmployeeID.Location = New Point(492, 9)
        LabelEmployeeID.Name = "LabelEmployeeID"
        LabelEmployeeID.Size = New Size(0, 15)
        LabelEmployeeID.TabIndex = 97
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Century Gothic", 9F)
        Label8.ForeColor = Color.FromArgb(CByte(77), CByte(77), CByte(83))
        Label8.Location = New Point(54, 68)
        Label8.Name = "Label8"
        Label8.Size = New Size(70, 17)
        Label8.TabIndex = 86
        Label8.Text = "First Name"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Century Gothic", 9F)
        Label11.ForeColor = Color.FromArgb(CByte(77), CByte(77), CByte(83))
        Label11.Location = New Point(587, 69)
        Label11.Name = "Label11"
        Label11.Size = New Size(95, 17)
        Label11.TabIndex = 92
        Label11.Text = "Phone Number"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Century Gothic", 9F)
        Label12.ForeColor = Color.FromArgb(CByte(77), CByte(77), CByte(83))
        Label12.Location = New Point(53, 115)
        Label12.Name = "Label12"
        Label12.Size = New Size(33, 17)
        Label12.TabIndex = 93
        Label12.Text = "Age"
        ' 
        ' TextBoxEmail
        ' 
        TextBoxEmail.Font = New Font("Century Gothic", 11.25F)
        TextBoxEmail.Location = New Point(317, 95)
        TextBoxEmail.Multiline = True
        TextBoxEmail.Name = "TextBoxEmail"
        TextBoxEmail.Size = New Size(261, 40)
        TextBoxEmail.TabIndex = 90
        ' 
        ' TextBoxAge
        ' 
        TextBoxAge.Font = New Font("Century Gothic", 11.25F)
        TextBoxAge.Location = New Point(50, 95)
        TextBoxAge.Multiline = True
        TextBoxAge.Name = "TextBoxAge"
        TextBoxAge.Size = New Size(261, 40)
        TextBoxAge.TabIndex = 89
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 9F)
        Label2.Location = New Point(410, 7)
        Label2.Name = "Label2"
        Label2.Size = New Size(81, 17)
        Label2.TabIndex = 96
        Label2.Text = "Employee ID"
        ' 
        ' TextBoxNumber
        ' 
        TextBoxNumber.Font = New Font("Century Gothic", 11.25F)
        TextBoxNumber.Location = New Point(584, 49)
        TextBoxNumber.Multiline = True
        TextBoxNumber.Name = "TextBoxNumber"
        TextBoxNumber.Size = New Size(261, 40)
        TextBoxNumber.TabIndex = 88
        ' 
        ' TextBoxName
        ' 
        TextBoxName.Font = New Font("Century Gothic", 11.25F)
        TextBoxName.Location = New Point(50, 48)
        TextBoxName.Multiline = True
        TextBoxName.Name = "TextBoxName"
        TextBoxName.Size = New Size(261, 40)
        TextBoxName.TabIndex = 87
        ' 
        ' Panel8
        ' 
        Panel8.BorderStyle = BorderStyle.FixedSingle
        Panel8.Controls.Add(Label6)
        Panel8.Controls.Add(DateTimePeriodData)
        Panel8.Controls.Add(LabelTotalSalary)
        Panel8.Controls.Add(LabelSalary)
        Panel8.Controls.Add(TextBox1)
        Panel8.Controls.Add(btnCyclePeriod)
        Panel8.Controls.Add(ComboBoxGender)
        Panel8.Controls.Add(ComboBoxPosition)
        Panel8.Controls.Add(Label1)
        Panel8.Controls.Add(Label15)
        Panel8.Controls.Add(Label14)
        Panel8.Controls.Add(TextBoxBarangay)
        Panel8.Controls.Add(UpdateBtn)
        Panel8.Controls.Add(FormCloseBtn)
        Panel8.Controls.Add(DataGridViewDetailerHistory)
        Panel8.Controls.Add(Label7)
        Panel8.Controls.Add(Label5)
        Panel8.Controls.Add(TextBoxCity)
        Panel8.Controls.Add(Label13)
        Panel8.Controls.Add(Label4)
        Panel8.Controls.Add(TextBoxLastName)
        Panel8.Controls.Add(Label3)
        Panel8.Controls.Add(LabelEmployeeID)
        Panel8.Controls.Add(Label8)
        Panel8.Controls.Add(Label11)
        Panel8.Controls.Add(Label12)
        Panel8.Controls.Add(TextBoxEmail)
        Panel8.Controls.Add(TextBoxAge)
        Panel8.Controls.Add(Label2)
        Panel8.Controls.Add(TextBoxNumber)
        Panel8.Controls.Add(TextBoxName)
        Panel8.Location = New Point(0, 0)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(911, 788)
        Panel8.TabIndex = 74
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 9F)
        Label6.ForeColor = Color.FromArgb(CByte(77), CByte(77), CByte(83))
        Label6.Location = New Point(277, 199)
        Label6.Name = "Label6"
        Label6.Size = New Size(150, 17)
        Label6.TabIndex = 131
        Label6.Text = "Select End Date (12MN)"
        ' 
        ' DateTimePeriodData
        ' 
        DateTimePeriodData.CalendarFont = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DateTimePeriodData.CustomFormat = "MM/dd/yyyy"
        DateTimePeriodData.Format = DateTimePickerFormat.Custom
        DateTimePeriodData.Location = New Point(192, 196)
        DateTimePeriodData.Name = "DateTimePeriodData"
        DateTimePeriodData.Size = New Size(83, 23)
        DateTimePeriodData.TabIndex = 130
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.White
        TextBox1.Enabled = False
        TextBox1.Font = New Font("Century Gothic", 11.25F)
        TextBox1.Location = New Point(54, 720)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(261, 40)
        TextBox1.TabIndex = 129
        ' 
        ' btnCyclePeriod
        ' 
        btnCyclePeriod.BackColor = Color.FromArgb(CByte(92), CByte(81), CByte(224))
        btnCyclePeriod.FlatAppearance.BorderSize = 0
        btnCyclePeriod.FlatStyle = FlatStyle.Flat
        btnCyclePeriod.Font = New Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCyclePeriod.ForeColor = Color.White
        btnCyclePeriod.Location = New Point(709, 184)
        btnCyclePeriod.Name = "btnCyclePeriod"
        btnCyclePeriod.Size = New Size(140, 33)
        btnCyclePeriod.TabIndex = 75
        btnCyclePeriod.Text = "Daily"
        btnCyclePeriod.UseVisualStyleBackColor = False
        ' 
        ' ComboBoxGender
        ' 
        ComboBoxGender.AutoCompleteCustomSource.AddRange(New String() {"Male", "Female", "LGBT"})
        ComboBoxGender.AutoCompleteSource = AutoCompleteSource.CustomSource
        ComboBoxGender.BackColor = Color.White
        ComboBoxGender.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxGender.Font = New Font("Century Gothic", 9F)
        ComboBoxGender.FormattingEnabled = True
        ComboBoxGender.Items.AddRange(New Object() {"Male", "Female", "LGBT"})
        ComboBoxGender.Location = New Point(317, 141)
        ComboBoxGender.Name = "ComboBoxGender"
        ComboBoxGender.Size = New Size(261, 25)
        ComboBoxGender.TabIndex = 128
        ' 
        ' ComboBoxPosition
        ' 
        ComboBoxPosition.AutoCompleteCustomSource.AddRange(New String() {"Detailer", "Cashier", "Manager"})
        ComboBoxPosition.AutoCompleteSource = AutoCompleteSource.CustomSource
        ComboBoxPosition.BackColor = Color.White
        ComboBoxPosition.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxPosition.Font = New Font("Century Gothic", 9F)
        ComboBoxPosition.FormattingEnabled = True
        ComboBoxPosition.Items.AddRange(New Object() {"Detailer", "Cashier", "Manager"})
        ComboBoxPosition.Location = New Point(584, 141)
        ComboBoxPosition.Name = "ComboBoxPosition"
        ComboBoxPosition.Size = New Size(261, 25)
        ComboBoxPosition.TabIndex = 127
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 9F)
        Label1.ForeColor = Color.FromArgb(CByte(77), CByte(77), CByte(83))
        Label1.Location = New Point(584, 169)
        Label1.Name = "Label1"
        Label1.Size = New Size(54, 17)
        Label1.TabIndex = 126
        Label1.Text = "Position"
        ' 
        ' ViewEmployeeInfo
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(911, 788)
        Controls.Add(Panel8)
        FormBorderStyle = FormBorderStyle.None
        Name = "ViewEmployeeInfo"
        Text = "ViewEmployeeInfo"
        CType(DataGridViewDetailerHistory, ComponentModel.ISupportInitialize).EndInit()
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents LabelTotalSalary As Label
    Friend WithEvents LabelSalary As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBoxBarangay As TextBox
    Friend WithEvents UpdateBtn As Button
    Friend WithEvents FormCloseBtn As Button
    Friend WithEvents DataGridViewDetailerHistory As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxCity As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxLastName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents LabelEmployeeID As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents TextBoxAge As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxNumber As TextBox
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxGender As ComboBox
    Friend WithEvents ComboBoxPosition As ComboBox
    Friend WithEvents btnCyclePeriod As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DateTimePeriodData As DateTimePicker
    Friend WithEvents Label6 As Label
End Class

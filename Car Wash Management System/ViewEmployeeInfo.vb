Public Class ViewEmployeeInfo
    Inherits BaseForm
    Private ReadOnly _parentCustomerForm As Object

    Public Sub New(parentForm As Object)
        MyBase.New()
        ' This call is required by the designer.
        InitializeComponent()

        _parentCustomerForm = parentForm

    End Sub


    Private Sub ViewEmployeeInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

    End Sub

    Private Sub TextBoxNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxNumber.KeyPress
        ' Allow digits (0-9) and Control keys (like Backspace)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' This blocks the character
        End If
    End Sub
    Private Sub TextBoxAge_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxAge.KeyPress
        ' Allow digits (0-9) and Control keys (like Backspace)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' This blocks the character
        End If
    End Sub

    Private Sub FormCloseBtn_Click(sender As Object, e As EventArgs) Handles FormCloseBtn.Click
        Me.Hide()
        DataGridViewDetailerHistory.DataSource = Nothing
        LabelTotalSalary.Text = "0.00"

        ' Reset the shared service dates
        ViewEmployeeInfoService.ResetToDefault(btnCyclePeriod)

    End Sub



    Private Sub ButtonToggleChart_Click(sender As Object, e As EventArgs) Handles btnCyclePeriod.Click
        ' Get the next period string
        Dim nextPeriod As String = ViewEmployeeInfoService.TogglePeriodView(btnCyclePeriod, Me)

    End Sub

    'Private Sub ButtonTogglePeriodFunction()
    '    Dim startDate As DateTime
    '    Dim endDate As DateTime = DateTime.Today.AddDays(1) ' Always end at the start of tomorrow
    '    Dim employeeID As String = LabelEmployeeID.Text

    '    ' Cycle the mode
    '    currentFilterMode = (currentFilterMode + 1) Mod 4

    '    Select Case currentFilterMode
    '        Case 0 ' Daily
    '            btnCyclePeriod.Text = "Daily"
    '            startDate = DateTime.Today
    '        Case 1 ' Weekly
    '            btnCyclePeriod.Text = "Weekly"
    '            ' Gets the first day of the current week (Sunday)
    '            startDate = DateTime.Today.AddDays(-(DatePart(DateInterval.Weekday, DateTime.Today) - 1))
    '        Case 2 ' Monthly
    '            btnCyclePeriod.Text = "Monthly"
    '            startDate = New DateTime(DateTime.Today.Year, DateTime.Today.Month, 1)
    '    End Select

    '    ' Call the database helper to get the total
    '    Dim totalSalary As Decimal = viewEmployeeeInfoDatabaseHelper.GetDynamicSalaryByPeriod(employeeID, startDate, endDate)

    '    ' Update your Revenue label
    '    LabelRevenue.Text = totalSalary.ToString("N2")
    'End Sub

    'Private Sub RefreshEmployeeHistory()
    '    Dim employeeID As String = LabelEmployeeID.Text
    '    ' Ensure we have an ID before querying
    '    If String.IsNullOrEmpty(employeeID) OrElse employeeID = "LabelEmployeeID" Then Return

    '    Dim startDate As DateTime
    '    Dim endDate As DateTime = DateTime.Today.AddDays(1) ' Always capture up to the end of today

    '    ' 1. Determine date range based on current button state
    '    Select Case currentFilterMode
    '        Case 0 ' Daily
    '            startDate = DateTime.Today
    '        Case 1 ' Weekly
    '            startDate = DateTime.Today.AddDays(-(DatePart(DateInterval.Weekday, DateTime.Today) - 1))
    '        Case 2 ' 2 Weeks
    '            startDate = DateTime.Today.AddDays(-14)
    '        Case 3 ' Monthly
    '            startDate = New DateTime(DateTime.Today.Year, DateTime.Today.Month, 1)
    '    End Select

    '    ' 2. Fetch the fresh data from the database
    '    Dim filteredTable As DataTable = viewEmployeeeInfoDatabaseHelper.GetEmployeeDetailMadeFiltered(employeeID, startDate, endDate)
    '    DataGridViewDetailerHistory.DataSource = filteredTable

    '    ' 3. Calculate the Revenue total from the new data
    '    Dim totalRevenue As Decimal = 0
    '    For Each row As DataRow In filteredTable.Rows
    '        totalRevenue += Convert.ToDecimal(row("EmployeeSalary"))
    '    Next

    '    ' 4. Update the UI labels
    '    LabelRevenue.Text = totalRevenue.ToString("N2")
    'End Sub
End Class
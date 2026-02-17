Public Class ViewEmployeeInfoService
    Inherits BaseForm
    Public Shared startDate As DateTime = DateTime.Today
    Public Shared endDate As DateTime = DateTime.Today.AddDays(1)
    
    ' Call this to ensure the form always starts fresh

    Public Sub New()
        MyBase.New()
    End Sub
    Public Sub ResetToDefault(btn As Button)
        btn.Text = "Daily"
        startDate = DateTime.Today
        endDate = DateTime.Today.AddDays(1)

    End Sub

    Public Function TogglePeriodView(buttonToggleChart As Button, viewForm As ViewEmployeeInfo) As String
        Dim nextPeriod As String
        Select Case buttonToggleChart.Text
            Case "Daily"
                'If its Daily, go to Weekly
                viewForm.LabelSalary.Text = "Salary for the Week (₱)"
                startDate = DateTime.Today.AddDays(-7)
                nextPeriod = "Weekly"

            Case "Weekly"
                'If its Weekly, go to Monthly
                viewForm.LabelSalary.Text = "Salary for the Month (₱)"
                startDate = DateTime.Today.AddDays(-30)
                nextPeriod = "Monthly"

            Case "Monthly"
                'If its Monthly, go to All-Period
                viewForm.LabelSalary.Text = "Salary for the Year (₱)"
                startDate = DateTime.Today.AddYears(-1) ' Effectively all records
                nextPeriod = "Yearly"
            Case Else
                'If its All-Period, go to Daily
                viewForm.LabelSalary.Text = "Salary for the Day (₱)"
                startDate = DateTime.Today
                nextPeriod = "Daily"

        End Select

        buttonToggleChart.Text = nextPeriod
        CalculateAndRefresh(viewForm)
        Return nextPeriod
    End Function

    Public Sub CalculateAndRefresh(viewForm As ViewEmployeeInfo)
        ' Find the open form instance
        If viewForm Is Nothing Then Return

        Dim empID As String = viewForm.LabelEmployeeID.Text
        ' Prevent query if ID is not yet loaded
        If String.IsNullOrEmpty(empID) OrElse empID = "LabelEmployeeID" Then Return

        ' 1. Fetch filtered data
        Dim dt As DataTable = viewEmployeeeInfoDatabaseHelper.GetEmployeeDetailMadeFiltered(empID, startDate, endDate)
        viewForm.DataGridViewDetailerHistory.DataSource = dt

        viewForm.DataGridViewDetailerHistory.Columns("EmployeeSalary").DefaultCellStyle.Format = "N2"
        viewForm.DataGridViewDetailerHistory.Columns("TotalPrice").DefaultCellStyle.Format = "N2"

        ' 2. Sum the Salary column by name for safety
        Dim totalSalary As Decimal = 0
        For Each row As DataRow In dt.Rows
            If Not IsDBNull(row("EmployeeSalary")) Then
                totalSalary += Convert.ToDecimal(row("EmployeeSalary"))
            End If
        Next

        ' 3. Update UI
        viewForm.LabelTotalSalary.Text = totalSalary.ToString("N2")
    End Sub

End Class
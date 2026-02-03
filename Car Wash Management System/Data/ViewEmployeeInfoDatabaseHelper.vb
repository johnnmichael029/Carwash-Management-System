Imports Microsoft.Data.SqlClient

Public Class ViewEmployeeInfoDatabaseHelper
    Shared constr As String

    Public Sub New(connectionString As String)
        constr = connectionString
    End Sub

    Public Function GetEmployeeDetailMade(employeeID As String) As DataTable
        Dim dt As New DataTable()
        Using con As New SqlConnection(constr)
            Try
                ' The query calculates the 30% cut and formats it for your DataGridView
                Dim selectQuery As String =
                "SELECT " &
                "s.SalesID, " &
                "s.Detailer, " &
                "sv_base.ServiceName AS Service, " &
                "sv_addon.ServiceName AS AddonService, " &
                "s.SaleDate, " &
                "s.TotalPrice, " &
                "'30%' AS PercentCut, " &
                "(s.TotalPrice * 0.30) AS EmployeeSalary " &
                "FROM SalesHistoryTable s " &
                "INNER JOIN EmployeeTable e ON s.Detailer = (e.Name + ' ' + e.LastName) " &
                "INNER JOIN ServicesTable sv_base ON s.ServiceID = sv_base.ServiceID " &
                "LEFT JOIN ServicesTable sv_addon ON s.AddonServiceID = sv_addon.ServiceID " &
                "WHERE e.EmployeeID = @EmployeeID " &
                "ORDER BY s.SalesID DESC"

                Dim cmd As New SqlCommand(selectQuery, con)
                ' Uses the employeeIDValue passed from your GetSelectedRowData sub
                cmd.Parameters.AddWithValue("@EmployeeID", employeeID)

                Dim adapter As New SqlDataAdapter(cmd)
                adapter.Fill(dt)

            Catch ex As Exception
                ' Pass the error up or handle it here
                Throw New Exception("Database Error: " & ex.Message)
            End Try
        End Using
        Return dt
    End Function

    Public Function GetEmployeeDetailMadeFiltered(employeeID As String, startDate As DateTime, endDate As DateTime) As DataTable
        Dim dt As New DataTable()
        Using con As New SqlConnection(constr)
            Try
                ' This query matches the Detailer name string to the Employee ID
                Dim selectQuery As String =
                "SELECT " &
                "s.SalesID, " &
                "s.Detailer, " &
                "sv_base.ServiceName AS Service, " &
                "sv_addon.ServiceName AS AddonService, " &
                "s.SaleDate, " &
                "s.TotalPrice, " &
                "'30%' AS PercentCut, " &
                "(s.TotalPrice * 0.30) AS EmployeeSalary " &
                "FROM SalesHistoryTable s " &
                "INNER JOIN EmployeeTable e ON s.Detailer = (e.Name + ' ' + e.LastName) " &
                "INNER JOIN ServicesTable sv_base ON s.ServiceID = sv_base.ServiceID " &
                "LEFT JOIN ServicesTable sv_addon ON s.AddonServiceID = sv_addon.ServiceID " &
                "WHERE e.EmployeeID = @EmpID " &
                "AND s.SaleDate >= @Start " &
                "AND s.SaleDate < @End"

                Dim cmd As New SqlCommand(selectQuery, con)
                ' Parameters prevent SQL Injection and handle date formatting
                cmd.Parameters.AddWithValue("@EmpID", employeeID)
                cmd.Parameters.AddWithValue("@Start", startDate)
                cmd.Parameters.AddWithValue("@End", endDate)

                Dim adapter As New SqlDataAdapter(cmd)
                adapter.Fill(dt)

            Catch ex As Exception
                ' Propagates the error back to your UI for debugging
                Throw New Exception("Database Error: " & ex.Message)
            End Try
        End Using
        Return dt
    End Function

    Public Shared Function GetDynamicSalaryByPeriod(employeeID As String, timePeriod As String) As Decimal
        Dim total As Decimal = 0
        Dim today As DateTime = DateTime.Today
        Dim startDate As DateTime
        Dim endDate As DateTime = today.AddDays(1) ' Up to the end of today

        ' --- 1. Dynamic Date Range Calculation (Logic from your example) ---
        Select Case timePeriod.ToUpper()
            Case "DAY"
                startDate = today
            Case "WEEK"
                ' Find the start of the current week (Sunday)
                startDate = today.AddDays(DayOfWeek.Sunday - today.DayOfWeek)
            Case "MONTH"
                ' Start of the current month
                startDate = New DateTime(today.Year, today.Month, 1)
            Case Else
                Throw New ArgumentException("Invalid time period: " & timePeriod)
        End Select

        ' --- 2. Database Execution ---
        Using con As New SqlConnection(constr)
            Try
                ' This query joins the tables to match the name string to the ID
                Dim query As String =
                "SELECT ISNULL(SUM(s.TotalPrice * 0.30), 0) " &
                "FROM SalesHistoryTable s " &
                "INNER JOIN EmployeeTable e ON s.Detailer = (e.Name + ' ' + e.LastName) " &
                "WHERE e.EmployeeID = @EmpID AND s.SaleDate >= @Start AND s.SaleDate < @End"

                Dim cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@EmpID", employeeID)
                cmd.Parameters.AddWithValue("@Start", startDate)
                cmd.Parameters.AddWithValue("@End", endDate)

                con.Open()
                ' ExecuteScalar is used because we only need one single number (the sum)
                total = Convert.ToDecimal(cmd.ExecuteScalar())

            Catch ex As Exception
                MessageBox.Show("Database Error: " & ex.Message)
            End Try
        End Using

        Return total
    End Function


End Class

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim filePath As String = "C:\savings.txt"
        Dim fileLines As String() = System.IO.File.ReadAllLines(filePath)

        For i As Integer = 0 To fileLines.Length - 1 Step 2
            selectedMonth.Items.Add(fileLines(i))
        Next

        btnStatistics.Visible = False
        monthSavings.Visible = False
        averageSavings.Visible = False
        significantSavings.Visible = False
    End Sub

    Private Sub selectedMonthChanged(sender As Object, e As EventArgs) Handles selectedMonth.SelectedIndexChanged
        Dim selectedIndex As Integer = CInt(selectedMonth.SelectedIndex)

        Dim filePath As String = "C:\savings.txt"
        Dim fileLines As String() = System.IO.File.ReadAllLines(filePath)
        Dim selectedSavings As String = fileLines(selectedIndex * 2 + 1)

        monthSavings.Text = "The electric savings for " & selectedMonth.SelectedItem.ToString() & ": $" & selectedSavings

        btnStatistics.Visible = True
        monthSavings.Visible = True
        averageSavings.Visible = False
        significantSavings.Visible = False
    End Sub

    Private Sub btnStatistics_Click(sender As Object, e As EventArgs) Handles btnStatistics.Click
        Dim filePath As String = "C:\savings.txt"
        Dim fileLines As String() = System.IO.File.ReadAllLines(filePath)

        Dim totalSavings As Double = 0
        Dim maxSavings As Double = 0
        Dim maxSavingsMonth As String = ""

        For i As Integer = 1 To fileLines.Length - 1 Step 2
            Dim savings As Double = Double.Parse(fileLines(i))
            totalSavings += savings

            If savings > maxSavings Then
                maxSavings = savings
                maxSavingsMonth = fileLines(i - 1)
            End If
        Next

        Dim averageSavings As Double = totalSavings / 12

        monthSavings.Text = "The electric savings for: $" & averageSavings.ToString("0.00")
        Me.averageSavings.Text = "The average monthly savings: " & " ($" & maxSavings & ")" 

        Me.averageSavings.Visible = True
        significantSavings.Visible = True
        monthSavings.Visible = True
    End Sub
End Class

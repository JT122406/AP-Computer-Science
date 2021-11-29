Public Class Form1
    Dim totalCredits As Double
    Dim GPAS As Double
    Dim UnweightGPAS As Double
    Private Sub InfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InfoToolStripMenuItem.Click
        MessageBox.Show("GPA Calculator uses a normal 4.0 scale from the College board website. It multiplies the weight of the class, amount of credits, and grade point of the grade you got in each class adds them up for all the classes then divides by the total amount of credits to get total GPA https://pages.collegeboard.org/how-to-convert-gpa-4.0-scale")
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub
    Private Sub ButtonNext_Click(sender As Object, e As EventArgs) Handles ButtonNext.Click
        Dim weight As Double = 0
        Dim grade As Integer
        If (Me.TextBoxGrade.Text = Nothing) Or Not (Me.RadioButton1.Checked Or Me.RadioButton2.Checked Or Me.RadioButton3.Checked Or Me.RadioButton4.Checked) Or Not (Me.RadioButton5.Checked Or Me.RadioButton6.Checked Or Me.RadioButton7.Checked) Then
            grade = -1
        Else
            grade = Val(Me.TextBoxGrade.Text)
        End If
        If grade <= 100 And grade >= 0 Then
            Dim gradepoint As Double = 0
            Dim Credits As Double
            If RadioButton1.Checked Then
                weight = 1
            ElseIf RadioButton2.Checked Then
                weight = 1.1
            ElseIf RadioButton3.Checked Then
                weight = 1.2
            ElseIf RadioButton4.Checked Then
                weight = 1.25
            End If

            If RadioButton5.Checked Then
                Credits = 10
            ElseIf RadioButton6.Checked Then
                Credits = 5
            ElseIf RadioButton7.Checked Then
                Credits = 2.5
            End If

            totalCredits = totalCredits + Credits
            If grade >= 97 Then
                gradepoint = 4.3
            ElseIf grade >= 94 Then
                gradepoint = 4.0
            ElseIf grade >= 90 Then
                gradepoint = 3.7
            ElseIf grade >= 87 Then
                gradepoint = 3.3
            ElseIf grade >= 84 Then
                gradepoint = 3.0
            ElseIf grade >= 80 Then
                gradepoint = 2.7
            ElseIf grade >= 77 Then
                gradepoint = 2.3
            ElseIf grade >= 74 Then
                gradepoint = 2.0
            ElseIf grade >= 70 Then
                gradepoint = 1.7
            ElseIf grade >= 67 Then
                gradepoint = 1.3
            ElseIf grade >= 64 Then
                gradepoint = 1.0
            ElseIf grade >= 60 Then
                gradepoint = 0.7
            Else
                gradepoint = 0
            End If

            Dim unweightedGPA As Double = (gradepoint * Credits)
            UnweightGPAS = UnweightGPAS + unweightedGPA

            Dim GPA As Double = (gradepoint * weight * Credits)
            GPAS = GPAS + GPA
            Me.TextBoxGrade.Clear()
        Else
            MessageBox.Show("Enter a valid Grade, Weight, and Credits")
        End If
    End Sub
    Private Sub ButtonCalculate_Click(sender As Object, e As EventArgs) Handles ButtonCalculate.Click
        Dim finalGPA As Double = (GPAS / totalCredits)
        Dim finalunweightedGPA As Double = (UnweightGPAS / totalCredits)
        MessageBox.Show("Your cumulative weighted GPA is: " + Str(finalGPA) + "Your cumulative unwieghted GPA is: " + Str(finalunweightedGPA))
        'GPAS = 0
        'totalCredits = 0
    End Sub

    Private Sub DeveloperInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeveloperInfoToolStripMenuItem.Click
        MessageBox.Show("Howdy")
    End Sub
End Class

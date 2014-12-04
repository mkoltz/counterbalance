Public Class Form1
    Dim exp As Experiment
    Dim randomizedConditions(,)
    Dim factorList As New ArrayList()
    Dim currentFactor As Factor
    Dim saveDirectory As String
    Dim conditionCounter, numTrials As Integer



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        exp = New Experiment(1, 1)

        For Each f As Factor In factorList

            exp.defineFactor(f)

        Next

        exp.setRepeats(repeatSelector.Value)


        For subject As Byte = 101 To NumSubjects.Value + 100

            My.Computer.FileSystem.CreateDirectory(saveDirectory & "\" & "S" & subject)
            For block As Byte = 1 To numBlocks.Value

                Dim writer As New System.IO.StreamWriter(saveDirectory & "\" & "S" & subject & "\" & "S" & subject & "_Block" & block & ".txt")

                exp.writeRandomizedConditions(writer)
            Next

        Next

    End Sub



    Private Sub DefineFactorButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DefineFactorButton.Click

        If FactorNameTextBox.Text <> Nothing Then
            ListBox1.Items.Add(FactorNameTextBox.Text)
            Dim temporaryFactor As New Factor({}, 1, FactorNameTextBox.Text)
            factorList.Add(temporaryFactor)
            FactorNameTextBox.Text = ""
        End If

    End Sub




    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        factorList.RemoveAt(ListBox1.SelectedIndex)
        ListBox1.Items.Remove(ListBox1.SelectedItem)
        countConditions()
    End Sub


    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

        ListBox2.Items.Clear()
        Try
            currentFactor = factorList.Item(ListBox1.SelectedIndex)

            Dim levels As Byte = currentFactor.getNumLevels

            If levels <> 0 Then
                For i As Byte = 0 To levels - 1
                    ListBox2.Items.Add(currentFactor.getLevel(i))
                Next
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If TextBox2.Text <> Nothing And ListBox1.SelectedIndex <> -1 Then

            ListBox2.Items.Add(TextBox2.Text)
            currentFactor.addLevel(TextBox2.Text)
            TextBox2.Text = ""

            countConditions()

        End If

        

    End Sub


    Private Sub EditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditButton.Click

        If ListBox2.SelectedIndex <> -1 Then
            currentFactor.removeLevel(ListBox2.SelectedIndex)
            ListBox2.Items.Remove(ListBox2.SelectedItem)

            countConditions()
        End If
      

    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        FolderBrowserDialog1.ShowDialog()
        saveDirectory = FolderBrowserDialog1.SelectedPath

        TextBox1.Text = saveDirectory


    End Sub

    Public Sub countConditions()

        If factorList.Count <> 0 Then
            conditionCounter = 1

            For f As Byte = 0 To factorList.Count - 1
                Dim tempFactor As Factor = factorList.Item(f)

                conditionCounter = conditionCounter * tempFactor.getNumLevels

            Next

            numConditions.Text = conditionCounter

            numTrials = conditionCounter * repeatSelector.Value

            numTrialsLabel.Text = numTrials
        End If
        

    End Sub

    Private Sub repeatSelector_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles repeatSelector.ValueChanged
        Try
            countConditions()
        Catch ex As Exception

        End Try


    End Sub


    Private Sub ImportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImportToolStripMenuItem.Click, ExportToolStripMenuItem.Click, CloseToolStripMenuItem.Click

        If sender Is ImportToolStripMenuItem Then
            clearExperiment()
            expFileBrowser.ShowDialog()

            If expFileBrowser.FileName <> Nothing Then
                Using myReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(expFileBrowser.FileName)

                    myReader.TextFieldType = FileIO.FieldType.Delimited
                    myReader.SetDelimiters(vbTab)

                    Dim currentRow As String()
                    Dim index, elementNumber As Integer
                    index = 0
                    elementNumber = 0

                    While Not myReader.EndOfData

                        currentRow = myReader.ReadFields
                        Dim first As Boolean = True

                        For Each element In currentRow
                            If element <> "" Then
                                If first Then
                                    ListBox1.Items.Add(" " & element)
                                    Dim temporaryFactor As New Factor({}, 1, " " & element)
                                    factorList.Add(temporaryFactor)
                                    first = False
                                Else
                                    currentFactor = factorList.Item(index)
                                    currentFactor.addLevel(" " & element)
                                End If
                            End If
                        Next

                        index = index + 1
                    End While

                End Using
                ListBox1.SelectedIndex = 0
            End If



            
        End If

        If sender Is ExportToolStripMenuItem Then

            saveEXPfile.ShowDialog()

            If saveEXPfile.FileName <> Nothing Then
                Using writer As New System.IO.StreamWriter(saveEXPfile.FileName)

                    For Each f As Factor In factorList

                        writer.Write(f.factorName & vbTab)

                        For level As Byte = 0 To f.getNumLevels - 1
                            If level <> f.getNumLevels - 1 Then
                                writer.Write(f.getLevel(level) & vbTab)
                            Else
                                writer.Write(f.getLevel(level))
                            End If

                        Next

                        writer.WriteLine()
                    Next

                End Using
            End If
            
        End If

        If sender Is CloseToolStripMenuItem Then
            End
        End If
    End Sub

    Public Sub clearExperiment()
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()

        factorList.Clear()
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        expFileBrowser.Filter = "txt | *.txt"
        saveEXPfile.Filter = "txt | *.txt"
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        clearExperiment()
    End Sub

    Private Sub upButton_Click(sender As System.Object, e As System.EventArgs) Handles upButton.Click

        Dim i As Integer = ListBox1.SelectedIndex

        If i > 0 Then

            Dim tempListboxItem = ListBox1.Items(i - 1)
            Dim tempFactor = factorList.Item(i - 1)

            ListBox1.Items.Insert(i + 1, tempListboxItem)
            factorList.Insert(i + 1, tempFactor)
            ListBox1.Items.RemoveAt(i - 1)
            factorList.RemoveAt(i - 1)

        End If

    End Sub

    Private Sub downButton_Click(sender As System.Object, e As System.EventArgs) Handles downButton.Click

        Dim i As Integer = ListBox1.SelectedIndex

        If i < ListBox1.Items.Count - 1 Then

            Dim tempListboxItem = ListBox1.Items(i + 1)
            Dim tempFactor = factorList.Item(i + 1)

            ListBox1.Items.Insert(i, tempListboxItem)
            factorList.Insert(i, tempFactor)
            ListBox1.Items.RemoveAt(i + 2)
            factorList.RemoveAt(i + 2)

        End If

    End Sub

End Class

Public Class Experiment

    Dim experimentalFactors() As Factor
    Dim numSubjects As Byte
    Dim repeats As Byte = 2
    Dim randomArray(,)
    Dim conditionNumber As Integer = 0
    Dim conditionsArray(,)
    Dim conditionCounter() As Byte
    Dim numFactors As Byte = 0


    '1 = within, 2 = between, 3 = mixed
    Dim design As Byte

    Public Sub New(ByVal design As Byte, ByVal numSubjects As Byte)

        Me.design = design
        Me.numSubjects = numSubjects

    End Sub

    Public Sub setRepeats(ByVal repeats As Byte)
        Me.repeats = repeats
    End Sub

    Public Sub defineFactor(ByRef factor As Factor)
        numFactors += 1
        If experimentalFactors Is Nothing Then
            ReDim experimentalFactors(0)
            experimentalFactors(UBound(experimentalFactors)) = factor
        Else
            ReDim Preserve experimentalFactors(UBound(experimentalFactors) + 1)
            experimentalFactors(UBound(experimentalFactors)) = factor
        End If

        buildConditionsArray()


    End Sub

    Public Sub defineFactor(ByVal factorName As String, ByVal factorType As Byte, ByVal levels() As Object)
        numFactors += 1

        If experimentalFactors Is Nothing Then
            ReDim experimentalFactors(0)
            experimentalFactors(UBound(experimentalFactors)) = New Factor(levels, factorType, factorName)

        Else
            ReDim Preserve experimentalFactors(UBound(experimentalFactors) + 1)
            experimentalFactors(UBound(experimentalFactors)) = New Factor(levels, factorType, factorName)

        End If

        buildConditionsArray()
    End Sub

   

    Public Sub buildRandomArray()
        Dim numConditions As Integer = getNumConditions()
        ReDim conditionCounter(numConditions - 1)
        ReDim randomArray((numConditions * repeats) - 1, UBound(experimentalFactors))

        For c As Integer = 0 To UBound(randomArray, 1)
            Randomize()

            Dim keepLooking As Boolean = True

            While keepLooking
                Dim random As Integer = Rnd() * numConditions - 1
                If random >= 0 Then
                    If conditionCounter(random) < repeats Then
                        keepLooking = False
                        conditionCounter(random) += 1

                        For i As Byte = 0 To numFactors - 1
                            randomArray(c, i) = conditionsArray(random, i)
                        Next
                    End If
                End If

            End While

        Next

    End Sub

    Sub buildConditionsArray()

        conditionNumber = 0
        ReDim conditionsArray(getNumConditions() - 1, UBound(experimentalFactors))
        Dim layerArray(UBound(experimentalFactors) - 1) As Object

        If layerArray.Length <> 0 Then
            recursiveCombinations(layerArray, 0)
        End If
    End Sub

    Private Sub recursiveCombinations(ByVal layersAbove() As Object, ByVal currentLayer As Byte)
        If currentLayer = UBound(experimentalFactors) Then
            For levelInCurrentLayer As Byte = 0 To experimentalFactors(currentLayer).getNumLevels - 1
                For levelsAbove As Byte = 0 To UBound(layersAbove)
                    conditionsArray(conditionNumber, levelsAbove) = layersAbove(levelsAbove)
                Next
                conditionsArray(conditionNumber, currentLayer) = experimentalFactors(currentLayer).getLevel(levelInCurrentLayer)
                conditionNumber += 1
            Next
        Else
            For i As Byte = 0 To experimentalFactors(currentLayer).getNumLevels - 1
                layersAbove(currentLayer) = experimentalFactors(currentLayer).getLevel(i)
                recursiveCombinations(layersAbove, currentLayer + 1)
            Next
        End If
    End Sub

    Public Function getNumConditions() As Integer
        Dim numConditions As Integer = 1
        For i As Byte = 0 To UBound(experimentalFactors)
            numConditions = numConditions * experimentalFactors(i).getNumLevels
        Next

        Return numConditions
    End Function

    Public Sub writeRandomizedConditions(ByRef writer As System.IO.StreamWriter)

        buildRandomArray()

        writer.Write("#")

        For f As Byte = 0 To numFactors - 1
            If f = 0 Then
                writer.Write(experimentalFactors(f).factorName)
            Else
                writer.Write("," & experimentalFactors(f).factorName)
            End If

        Next

        writer.WriteLine()
        writer.WriteLine("*")

        For i As Integer = 0 To UBound(randomArray, 1)

            For c As Integer = 0 To UBound(randomArray, 2)

                If c = 0 Then
                    writer.Write(randomArray(i, c))
                Else
                    writer.Write("," & randomArray(i, c))
                End If

            Next

            writer.WriteLine()

        Next
        writer.WriteLine("*")
        writer.Close()
    End Sub
End Class

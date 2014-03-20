Public Class Factor

    ' Dim lvls() As Double
    Dim type As Byte
    Dim myName As String

    Dim factorlist As New ArrayList()

    Public Sub New(ByRef levels() As Object, ByVal type As Byte, ByVal name As String)

        For i As Integer = 0 To UBound(levels)
            factorlist.Add(levels(i))
        Next

        myName = name
        Me.type = type

    End Sub

    Public Function getNumLevels()
        Return factorlist.Count
    End Function


    Public Function getLevel(ByVal levelNumber As Byte)

        Return factorlist(levelNumber)

    End Function

    Public Sub removeLevel(ByVal levelNumber As Byte)

        factorlist.RemoveAt(levelNumber)

    End Sub

    Public Sub addLevel(ByRef level As Object)
        factorlist.Add(level)
    End Sub

    Public Property factorName As String
        Get
            Return myName
        End Get
        Set(value As String)
            myName = value
        End Set
    End Property




End Class

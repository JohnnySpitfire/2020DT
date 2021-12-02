''Started 9/6/20
''Author B John

Public Class Book

    Dim title As String
    Dim author As String
    Dim publisher As String
    Dim ibsn As Double
    Dim estimatedValue As Double

    Public Sub New(titleInput As String, authorInput As String, publisherInput As String, ibsnInput As Double, estimatedValueInput As Double)

        Me.title = titleInput
        Me.author = authorInput
        Me.publisher = publisherInput
        Me.ibsn = ibsnInput
        Me.estimatedValue = estimatedValueInput

    End Sub
    'Getter Functions
    Function GetTitle()

        Return Me.title

    End Function

    Function GetAuthor()

        Return Me.author

    End Function

    Function GetPublisher()

        Return Me.publisher

    End Function

    Function GetIBSN()

        Return Me.ibsn

    End Function

    Function GetEstimatedValue()

        Return Me.estimatedValue

    End Function

    ''Setter Functions
    Function SetTitle(titleInput)

        Me.title = titleInput

        Return Nothing

    End Function

    Function SetAuthor(authorInput)

        Me.author = authorInput

        Return Nothing

    End Function

    Function SetPublisher(publisherInput)

        Me.publisher = publisherInput

        Return Nothing

    End Function

    Function SetIBSN(ibsnInput)

        Me.ibsn = ibsnInput

        Return Nothing

    End Function

    Function SetEstimatedValue(estimatedValueInput)

        Me.estimatedValue = estimatedValueInput

        Return Nothing

    End Function

    Function GetBookInfo()

        'returns all book values

        Return Me.title & vbCrLf &
               Me.author & vbCrLf &
               Me.publisher & vbCrLf &
               Me.ibsn & vbCrLf &
               Me.estimatedValue

    End Function

    Function GetBookTitleAuthor()

        'returns basic identity values for book list

        Return Me.title & " | " & Me.author

    End Function

End Class

''<Started> 9/6/20 </Started>
''<Author> B John </Author>
'<summary> provides a seperate GUI for the user to create new books and add them to the list. It provides error catches and feedback boxes that tells the user the error. It will also provide default "unknown" values for the input boxes if the user cannot complete the list</summary>

Public Class AddBookGUI

    Function SetTextForTesting(titleInput As String, authorInput As String, publisherInput As String, IBSNInput As String, estimatedValueInput As String)

        TitleInputTextBox.Text = titleInput
        AuthorInputTextBox.Text = authorInput
        PublisherInputTextBox.Text = publisherInput
        IBSNInputTextBox.Text = IBSNInput
        EstimatedValueInputTextBox.Text = estimatedValueInput

        Return Nothing

    End Function

    Function EmptyFieldCheck(emptyField As String)
        'asks the user if they intend to leave the input fields empty. If they do, prints a default "unknown" variable to the textbox
        'returns false if the textboxes are switched to "unknown" variables

        If MsgBox("Do you wish to leave the " & emptyField & " field blank", vbYesNo, "Error") = DialogResult.Yes Then

            Select Case emptyField
                Case = "title"

                    TitleInputTextBox.Text = "Unknown"

                Case = "author"

                    AuthorInputTextBox.Text = "Unknown"

                Case = "publisher"

                    PublisherInputTextBox.Text = "Unknown"

                Case = "IBSN"

                    IBSNInputTextBox.Text = 1000000000

                Case "estimated value"

                    EstimatedValueInputTextBox.Text = 0

            End Select

        Else

            Exit Function

        End If

        Return False

    End Function

    Public Function CreateBook()

        ''Creates book. Passes textbox input values through guard clauses, and then into a new book.

        'Guard Clauses
        'Empty field
        If TitleInputTextBox.Text = "" Then Throw New Exception("TitleRequiredException")
        If AuthorInputTextBox.Text = "" Then Throw New Exception("AuthorRequiredException")
        If PublisherInputTextBox.Text = "" Then Throw New Exception("PublisherRequiredException")
        If IBSNInputTextBox.Text = "" Then Throw New Exception("IBSNRequiredException")
        If EstimatedValueInputTextBox.Text = "" Then Throw New Exception("EstimatedValueRequiredException")

        'Non numerical input
        If IsNumeric(IBSNInputTextBox.Text) = False Then Throw New Exception("InvalidIBSNDataTypeException")
        If IsNumeric(EstimatedValueInputTextBox.Text) = False Then Throw New Exception("InvalidEstimatedValueDataTypeException")

        'invalid ISBN number length (only 10 or 13 digits long)
        If IBSNInputTextBox.Text.Length <> 10 And IBSNInputTextBox.Text.Length <> 13 Then Throw New Exception("InvalidIBSNNumberOfDigitsException")

        'maximum number of books (up to 20 books)
        If MainPage.GetBooksCount > 19 Then Throw New Exception("MaximumNumberOfBooksReachedException")


        Dim title As String = TitleInputTextBox.Text
        Dim author As String = AuthorInputTextBox.Text
        Dim publisher As String = PublisherInputTextBox.Text
        Dim IBSN As Double = CDbl(IBSNInputTextBox.Text)
        Dim estimatedValue As Double = CDbl(EstimatedValueInputTextBox.Text)

        'creates new book and passes it to Books Arraylist
        Dim NewBook As New Book(title, author, publisher, IBSN, estimatedValue)
        MainPage.AddBook(NewBook)

        'returns newbook value for testing.
        Return NewBook

    End Function

    Private Sub AddBookButton_Click(sender As Object, e As EventArgs) Handles AddBookButton.Click


        ''Attempts to create book when btnAddBook is pressed. Will display any errors, and clear and close AddBookGUI if there are no errors.
        ''passes the field that is missing to the EmptyFieldCheck function and return true if the user inputs a string into the textbox, and false if the programe sets the textbox fields.

        Dim feedback As String = "Book Added"
        Dim title As String
        Dim userDefinedField As Boolean = True


        Try

            title = "Success"

            Me.CreateBook()

        Catch ex As Exception
            title = ex.Message

            Select Case title
                Case = "TitleRequiredException"

                    feedback = "Please enter the title"

                    userDefinedField = EmptyFieldCheck("title")
                    TitleInputTextBox.Focus()

                Case = "AuthorRequiredException"

                    feedback = "Please enter the author"

                    userDefinedField = EmptyFieldCheck("author")
                    AuthorInputTextBox.Focus()

                Case = "PublisherRequiredException"

                    feedback = "Please enter the publisher"

                    userDefinedField = EmptyFieldCheck("publisher")
                    PublisherInputTextBox.Focus()

                Case = "IBSNRequiredException"

                    feedback = "Please enter the IBSN number"

                    userDefinedField = EmptyFieldCheck("IBSN")
                    IBSNInputTextBox.Focus()

                Case = "EstimatedValueRequiredException"

                    feedback = "Please enter the estimated value"

                    userDefinedField = EmptyFieldCheck("estimated value")
                    EstimatedValueInputTextBox.Focus()

                Case = "MaximumNumBooksReached"

                    feedback = "You have reached the maximum number of books"

                Case = "InvalidIBSNDataTypeException"

                    feedback = "Please enter a number for the IBSN number"
                    IBSNInputTextBox.Focus()

                Case = "InvalidEstimatedValueDataTypeException"

                    feedback = "Please enter a number for the estimated value"
                    EstimatedValueInputTextBox.Focus()

                Case = "InvalidIBSNNumberOfDigitsException"

                    feedback = "Please enter a 10 digit number or a 13 digit number"
                    IBSNInputTextBox.Focus()

                Case = "MaximumNumberOfBooksReachedException"
                    'closes addBookDialogue to allow user to delete books.
                    feedback = "Please delete a book before adding another"

                    MainPage.addBookDialogue.Close()

                Case Else
                    title = "An Error Has Occourred"
                    feedback = ex.Message

            End Select

        End Try
        ''if the user has intended to enter text in the textbox they get an error message.
        If userDefinedField = True Then MsgBox(feedback, vbOKOnly, title)


        'clears fields and closes AddBookGUI if successful
        If title = "Success" Then

            TitleInputTextBox.Clear()
            AuthorInputTextBox.Clear()
            PublisherInputTextBox.Clear()
            IBSNInputTextBox.Clear()
            EstimatedValueInputTextBox.Clear()

            MainPage.addBookDialogue.Close()

        End If

        'refeshes BookList
        MainPage.UpdateCheckList()

    End Sub

    Private Sub CancelAddBookButton_Click(sender As Object, e As EventArgs) Handles CancelAddBookButton.Click

        'clears AddBookGUI when dialogue is closed through cancel buttion

        MainPage.addBookDialogue.Close()

        TitleInputTextBox.Clear()
        AuthorInputTextBox.Clear()
        PublisherInputTextBox.Clear()
        IBSNInputTextBox.Clear()
        EstimatedValueInputTextBox.Clear()

    End Sub

End Class
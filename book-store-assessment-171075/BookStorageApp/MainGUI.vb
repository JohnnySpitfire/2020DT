Imports System.Windows.Forms
Imports System.Text
Imports System.IO
''<Started> 9/6/20 </Started>
''<Author> B John </Author>
'<summary> Main Gui for the user, allows the user to view the books in a checked list box, and allows them to interact (add, delete, view, load, save) the items on the list.</summary>

Public Class MainGUI

    Private books As New ArrayList
    Public addBookDialogue As New AddBookGUI()
    Public displayBookDialogue As New DisplayBookInfo

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.


    End Sub

    Function GetBookCheckList()

        Return Me.BookCheckedListBox

    End Function

    Function GetBooks()

        Return Me.books

    End Function

    Function GetBookAtIndex(indexInput) As Book

        Return Me.books.Item(indexInput)

    End Function

    Function GetBooksCount()

        Return Me.books.Count

    End Function

    Function AddBook(BookInput) As Book

        Me.books.Add(BookInput)

        Return Nothing

    End Function

    Function RemoveBook(index) As Integer

        Me.books.RemoveAt(index)

        Return Nothing

    End Function

    Function UpdateCheckList()

        'Updates the book list by clearing the list, and adding every book in the array back into the list


        BookCheckedListBox.Items.Clear()

        For Each BF As Book In Me.books

            If BF Is Nothing Then Exit For

            BookCheckedListBox.Items.Add(BF.GetBookTitleAuthor)

        Next

        'Updates total book counter at the top of the MainGUI
        NumberOfBooksLabel.Text = "Total Number Of Books: " & GetBooksCount()

        Return Nothing

    End Function


    Private Sub NewBookButton_Click(sender As Object, e As EventArgs) Handles NewBookButton.Click

        addBookDialogue.ShowDialog()

    End Sub

    Private Sub DeleteSingleBookButton_Click(sender As Object, e As EventArgs) Handles DeleteSingleBookButton.Click

        ''deletes a book at the index value of the checked book.

        With BookCheckedListBox

            If .CheckedItems.Count = 1 Then

                Dim userInput = MsgBox("Are you sure you want to delete this book?", vbYesNo, "Confirmation")

                If userInput = MsgBoxResult.Yes Then

                    Dim index = .Items.IndexOf(.SelectedItem)

                    RemoveBook(index)

                    UpdateCheckList()

                    MsgBox("Book successfully deleted", vbOKOnly, "Success")

                    Exit Sub

                End If

            Else

                MsgBox("Please select a book to delete", vbOKOnly, "Error")

            End If

        End With

    End Sub

    Private Sub DeleteAllBooksButton_Click(sender As Object, e As EventArgs) Handles DeleteAllBooksButton.Click

        ''clears the books arraylist

        Dim userInput = MsgBox("Are you sure you want to delete all books?", vbYesNo, "Confirmation")

        If userInput = MsgBoxResult.Yes Then

            books.Clear()

            UpdateCheckList()

            MsgBox("All books successfully deleted", vbOKOnly, "Success")

            Exit Sub

        End If

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click

        ''confirmation message to check if user wants to exit the program

        Dim response As MsgBoxResult = MsgBox("Are you sure?", MsgBoxStyle.YesNo, "Exit")

        If response = MsgBoxResult.Yes = True Then End

    End Sub

    Private Sub DisplayBookInfoButton_Click(sender As Object, e As EventArgs) Handles DisplayBookInfoButton.Click

        displayBookDialogue.ShowDialog()

    End Sub

    Private Sub BookListListBox_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles BookCheckedListBox.ItemCheck
        ''ensures that only one checkbox is ticked at a time on the bookchecklistbox

        For index As Integer = 0 To BookCheckedListBox.Items.Count - 1
            If index <> e.Index Then BookCheckedListBox.SetItemChecked(index, False)
        Next
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        ''saves the books arraylist to a text document at a path provided by the user

        Dim allBooks As New StringBuilder
        Dim fileWriter As StreamWriter
        Dim results As DialogResult

        results = SaveFileDialog.ShowDialog()

        If results = DialogResult.OK Then

            ''appemds books arraylist to single string
            For Each BK As Book In Me.books

                If BK Is Nothing Then Exit For

                allBooks.Append(BK.GetBookInfo)
                allBooks.Append(vbCrLf)

            Next

            Dim fileString = allBooks.ToString

            ''writes the string to the text document at path specified by user in savefiledialogue
            fileWriter = New StreamWriter(SaveFileDialog.FileName, False)
            fileWriter.Write(fileString)
            fileWriter.Close()

        End If

    End Sub

    Private Sub LoadButton_Click(sender As Object, e As EventArgs) Handles LoadButton.Click

        ''reads a text file from user specified path in openfiledialogue into a single string
        Dim fileReader As StreamReader
        Dim results As DialogResult

        Dim loadBookListString As String

        results = OpenFileDialog.ShowDialog
        If results = DialogResult.OK Then
            fileReader = New StreamReader(OpenFileDialog.FileName)
            loadBookListString = fileReader.ReadToEnd()
            fileReader.Close()

        Else
            ''exits sub if user closes openfiledialogue
            Exit Sub

        End If

        'divides text file into an array by line (every line in text file is item in array)
        Dim stringBooksArray() = loadBookListString.Split(New String() {Environment.NewLine}, StringSplitOptions.None)

        'converts array to list
        Dim loadBooksList As List(Of String) = stringBooksArray.ToList

        'checks if there are items im the books arraylist and asks user if they wish to overwrite their list if yes then clear list, else exit loading
        If Me.books.Count = 0 Then

        Else
            Dim userResponse = MsgBox("Do you wish to overwrite your list?", vbYesNo, "Overwrite")

            If userResponse = vbYes Then

                Me.books.Clear()

            Else

                Exit Sub

            End If

        End If

        'writes the list to the books arraylist, displays an error to the user if an exception is encountered.
        Try
                For counter = 0 To (loadBooksList.Count / 5) - 1

                    If loadBooksList Is Nothing Then Exit For

                    MainPage.addBookDialogue.SetTextForTesting(loadBooksList.Item(0), loadBooksList.Item(1), loadBooksList.Item(2), loadBooksList.Item(3), loadBooksList.Item(4))
                    MainPage.addBookDialogue.CreateBook()

                    loadBooksList.RemoveRange(0, 5)

                Next

            Catch ex As Exception

            Dim title As String = ex.Message

            MainPage.books.Clear()

            MsgBox("Invalid file, please check file formatting", vbOK, title)

        End Try
        'clears the input textboxes and updates the book checklist.
        UpdateCheckList()

        With MainPage.addBookDialogue

            .TitleInputTextBox.Clear()
            .AuthorInputTextBox.Clear()
            .PublisherInputTextBox.Clear()
            .IBSNInputTextBox.Clear()
            .EstimatedValueInputTextBox.Clear()

        End With

    End Sub

End Class
Imports System.Text
Public Class DisplayBookInfo
    ''<Started> 9/7/20 </Started>
    ''<Author> B John </Author>
    '<summary> provides a small dialogue box for the user to be able to view all of the information of the book, as well as delete the displayed book</summary>
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.


    End Sub

    Private Sub DisplayBookInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'prints selected item in the checkedlistbox fully with labels.

        With MainPage.GetBookCheckList

            If .CheckedItems.Count <> 1 Then

                MsgBox("Please select a book", vbOKOnly, "Error")

                MainPage.displayBookDialogue.Close()

            Else

                Dim checked As Integer = MainPage.BookCheckedListBox.SelectedIndex

                With MainPage.GetBookAtIndex(checked)

                    BookInfoTextBox.Text = "Title: " & .GetTitle & vbCrLf &
                                            "Author: " & .GetAuthor & vbCrLf &
                                            "Publisher: " & .GetPublisher & vbCrLf &
                                            "IBSN: " & .GetIBSN & vbCrLf &
                                            "Estimated Value: " & .GetEstimatedValue & vbCrLf

                End With

            End If

        End With

    End Sub

    Private Sub DeleteBookInfoButton_Click(sender As Object, e As EventArgs) Handles DeleteBookInfoButton.Click

        ''deletes displayed book in the displaybook info gui
        With MainPage.GetBookCheckList

            If .CheckedItems.Count = 1 Then

                Dim userInput = MsgBox("Are you sure you want to delete this book?", vbYesNo, "Confirmation")

                If userInput = MsgBoxResult.Yes Then


                    Dim index = .Items.IndexOf(.SelectedItem)

                    MainPage.RemoveBook(index)

                    MsgBox("Book successfully deleted", vbOKOnly, "Success")

                    MainPage.UpdateCheckList()

                    MainPage.displayBookDialogue.Close()

                End If

            Else

                MsgBox("Please select a book to delete", vbOKOnly, "Error")

            End If

        End With
    End Sub

    Private Sub CloseBookInfoButton_Click(sender As Object, e As EventArgs) Handles CloseBookInfoButton.Click

        MainPage.displayBookDialogue.Close()

    End Sub
End Class
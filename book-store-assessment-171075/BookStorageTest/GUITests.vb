Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
''<Started> 9/6/20 </Started>
''<Author> B John </Author>
''<summary> Tests for all of the functions within the main gui and add book gui </summary>

<TestClass> Public Class GUITests

    <TestMethod()> Public Sub TestCreateBook()

        ''attempts to create a book and tests that the items match the local values that were passed to the create book function.s

        'arrange 

        Dim title As String = "The Fifth Science"
        Dim author As String = "Exurb1a"
        Dim publisher As String = "Puffin"
        Dim IBSN As String = "9785553560732"
        Dim estimatedValue As String = "9.99"
        Dim AB As New BookStorageApp.AddBookGUI
        Dim BF As New BookStorageApp.MainGUI
        Dim TempBook As New ArrayList


        'act

        AB.SetTextForTesting(title, author, publisher, IBSN, estimatedValue)


        BF.AddBook(AB.CreateBook())
        Dim addedBook As BookStorageApp.Book = BF.GetBooks(0)
        TempBook.Add(addedBook)

        'assert

        Assert.AreEqual(title, TempBook.Item(0).GetTitle)
        Assert.AreEqual(author, TempBook.Item(0).GetAuthor)
        Assert.AreEqual(publisher, TempBook.Item(0).GetPublisher)
        Assert.AreEqual(9785553560732.0, TempBook.Item(0).GetIBSN)
        Assert.AreEqual(9.99, TempBook.Item(0).GetEstimatedValue)

    End Sub

    <TestMethod()> Public Sub TestCreateFiveBooks()

        'attempts to create 5 books, if any exeptions are caught, any of the book items are empty, or if the total number of items within the tempbook arraylist does not equal 5 then fail the test.

        'arrange 

        Dim title As String = "The Fifth Science"
        Dim author As String = "Exurb1a"
        Dim publisher As String = "Puffin"
        Dim IBSN As String = "9785553560732"
        Dim estimatedValue As String = "9.99"
        Dim AB As New BookStorageApp.AddBookGUI
        Dim BF As New BookStorageApp.MainGUI
        Dim tempBook As New ArrayList

        'act

        Try
            For counter As Integer = 0 To 4

                AB.SetTextForTesting(counter & "_" & title, author, publisher, IBSN, estimatedValue)
                BF.AddBook(AB.CreateBook)

                tempBook.Add(BF.GetBookAtIndex(counter))

            Next

            'assert


        Catch Ex As Exception
            Assert.Fail()


        End Try

        If tempBook.Count <> 5 Then Assert.Fail()

        For Each BA As BookStorageApp.Book In tempBook

            If BA Is Nothing Then Assert.Fail()

        Next

    End Sub

    <TestMethod> Public Sub TestEmptyTitle()

        Dim title As String = ""
        Dim author As String = "Exurb1a"
        Dim publisher As String = "Puffin"
        Dim IBSN As String = "9785553560732"
        Dim estimatedValue As String = "9.99"
        Dim BF As New BookStorageApp.AddBookGUI

        BF.SetTextForTesting(title, author, publisher, IBSN, estimatedValue)

        'act

        Try

            BF.CreateBook()
            Assert.Fail()

        Catch ex As Exception

            Assert.AreEqual("TitleRequiredException", ex.Message)

        End Try

    End Sub

    <TestMethod> Public Sub TestEmptyAuthor()

        Dim title As String = "The Fifth Science"
        Dim author As String = ""
        Dim publisher As String = "Puffin"
        Dim IBSN As String = "9785553560732"
        Dim estimatedValue As String = "9.99"
        Dim BF As New BookStorageApp.AddBookGUI

        BF.SetTextForTesting(title, author, publisher, IBSN, estimatedValue)

        'act

        Try

            BF.CreateBook()
            Assert.Fail()

        Catch ex As Exception

            Assert.AreEqual("AuthorRequiredException", ex.Message)

        End Try

    End Sub

    <TestMethod> Public Sub TestEmptyPublisher()

        Dim title As String = "The Fifth Science"
        Dim author As String = "Exurb1a"
        Dim publisher As String = ""
        Dim IBSN As String = "9785553560732"
        Dim estimatedValue As String = "9.99"
        Dim BF As New BookStorageApp.AddBookGUI

        BF.SetTextForTesting(title, author, publisher, IBSN, estimatedValue)

        'act

        Try

            BF.CreateBook()
            Assert.Fail()

        Catch ex As Exception

            Assert.AreEqual("PublisherRequiredException", ex.Message)

        End Try

    End Sub

    <TestMethod> Public Sub TestEmptyIBSN()

        Dim title As String = "The Fifth Science"
        Dim author As String = "Exurb1a"
        Dim publisher As String = "Puffin"
        Dim IBSN As String = ""
        Dim estimatedValue As String = "9.99"
        Dim BF As New BookStorageApp.AddBookGUI

        BF.SetTextForTesting(title, author, publisher, IBSN, estimatedValue)

        'act

        Try

            BF.CreateBook()
            Assert.Fail()

        Catch ex As Exception

            Assert.AreEqual("IBSNRequiredException", ex.Message)

        End Try

    End Sub

    <TestMethod> Public Sub TestEmptyEstimatedValue()

        Dim title As String = "The Fifth Science"
        Dim author As String = "Exurb1a"
        Dim publisher As String = "Puffin"
        Dim IBSN As String = "9785553560732"
        Dim estimatedValue As String = ""
        Dim BF As New BookStorageApp.AddBookGUI

        BF.SetTextForTesting(title, author, publisher, IBSN, estimatedValue)

        'act

        Try

            BF.CreateBook()
            Assert.Fail()

        Catch ex As Exception

            Assert.AreEqual("EstimatedValueRequiredException", ex.Message)

        End Try

    End Sub

    <TestMethod> Public Sub TestIncorrectIBSNDataType()

        Dim title As String = "The Fifth Science"
        Dim author As String = "Exurb1a"
        Dim publisher As String = "Puffin"
        Dim IBSN As String = "Test"
        Dim estimatedValue As String = "9.99"
        Dim BF As New BookStorageApp.AddBookGUI

        BF.SetTextForTesting(title, author, publisher, IBSN, estimatedValue)

        'act

        Try

            BF.CreateBook()
            Assert.Fail()

        Catch ex As Exception

            Assert.AreEqual("InvalidIBSNDataTypeException", ex.Message)

        End Try

    End Sub
    <TestMethod> Public Sub TestIncorrectEstimatedValueDataType()

        Dim title As String = "The Fifth Science"
        Dim author As String = "Exurb1a"
        Dim publisher As String = "Puffin"
        Dim IBSN As String = "9785553560732"
        Dim estimatedValue As String = "Test"
        Dim BF As New BookStorageApp.AddBookGUI

        BF.SetTextForTesting(title, author, publisher, IBSN, estimatedValue)

        'act

        Try

            BF.CreateBook()
            Assert.Fail()

        Catch ex As Exception

            Assert.AreEqual("InvalidEstimatedValueDataTypeException", ex.Message)

        End Try

    End Sub

    <TestMethod> Public Sub TestInvalidIBSNNumberOfDigits()

        Dim title As String = "The Fifth Science"
        Dim author As String = "Exurb1a"
        Dim publisher As String = "Puffin"
        Dim IBSN As String = "1"
        Dim estimatedValue As String = "12.2"
        Dim BF As New BookStorageApp.AddBookGUI

        BF.SetTextForTesting(title, author, publisher, IBSN, estimatedValue)

        'act

        Try

            BF.CreateBook()
            Assert.Fail()

        Catch ex As Exception

            Assert.AreEqual("InvalidIBSNNumberOfDigitsException", ex.Message)

        End Try

    End Sub

    <TestMethod> Public Sub TestMaxiumumNumberOfBooksReached()
        'arrange 

        Dim title As String = "The Fifth Science"
        Dim author As String = "Exurb1a"
        Dim publisher As String = "Puffin"
        Dim IBSN As String = "9785553560732"
        Dim estimatedValue As String = "9.99"
        Dim AB As New BookStorageApp.AddBookGUI
        Dim BF As New BookStorageApp.MainGUI
        Dim tempBook As New ArrayList

        Try
            For counter As Integer = 0 To 20

                AB.SetTextForTesting(counter & "_" & title, author, publisher, IBSN, estimatedValue)
                BF.AddBook(AB.CreateBook)

                tempBook.Add(BF.GetBookAtIndex(counter))

            Next

            Assert.Fail()

        Catch Ex As Exception
            Assert.AreEqual(Ex.Message, "MaximumNumberOfBooksReachedException")


        End Try


    End Sub

    <TestMethod()> Public Sub TestDeleteBook()

        'attempts to create 5 books and remove last book from arraylist if the total count of the booklist are not equal then the test fails, as the books are not deleted.

        'arrange 

        Dim title As String = "The Fifth Science"
        Dim author As String = "Exurb1a"
        Dim publisher As String = "Puffin"
        Dim IBSN As String = "9785553560732"
        Dim estimatedValue As String = "9.99"
        Dim AB As New BookStorageApp.AddBookGUI
        Dim BF As New BookStorageApp.MainGUI
        Dim tempBook As New ArrayList

        'act

        Try
            For counter As Integer = 0 To 4

                AB.SetTextForTesting(counter & "_" & title, author, publisher, IBSN, estimatedValue)
                BF.AddBook(AB.CreateBook)

                tempBook.Add(BF.GetBookAtIndex(counter))

            Next

            tempBook.RemoveAt(4)
            BF.RemoveBook(4)


            'assert


        Catch Ex As Exception
            Assert.Fail()


        End Try


        If tempBook.Count <> BF.GetBooksCount Then Assert.Fail()

        For Each BA As BookStorageApp.Book In tempBook

            If BA Is Nothing Then Assert.Fail()

        Next

    End Sub

End Class
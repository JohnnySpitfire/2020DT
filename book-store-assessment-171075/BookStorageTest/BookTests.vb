Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
''<Started> 9/6/20 </Started>
''<Author> B John </Author>
'<summary> tests for all of the functions within the book class</summary>

<TestClass()> Public Class BookTests

    <TestMethod()> Public Sub TestConstructors()

        'arrange
        Dim bookOne = CreateBook()
        Dim bookTwo = CreateBook()
        Dim bookThree = CreateBook()

        'act

        'assert
        Assert.IsNotNull(bookOne)
        Assert.IsNotNull(bookTwo)
        Assert.IsNotNull(bookThree)

    End Sub

    <TestMethod()> Public Sub TestGetTitle()

        'arrange
        Dim bookOne = CreateBook()
        Dim testTitle As String = "Red Mars"
        Dim bookTitle As String = bookOne.GetTitle

        'act

        'assert
        Assert.AreEqual(testTitle, bookTitle)

    End Sub

    <TestMethod()> Public Sub TestGetAuthor()

        'arrange
        Dim bookOne = CreateBook()
        Dim testAuthor As String = "Kim Stanley Robinson"
        Dim bookAurhor As String = bookOne.GetAuthor

        'act

        'assert
        Assert.AreEqual(testAuthor, bookAurhor)

    End Sub

    <TestMethod()> Public Sub TestGetPublisher()

        'arrange
        Dim bookOne = CreateBook()
        Dim testPublisher As String = "Spectra"
        Dim bookPublisher As String = bookOne.GetPublisher

        'act

        'assert
        Assert.AreEqual(testPublisher, bookPublisher)

    End Sub

    <TestMethod()> Public Sub TestGetIBSN()

        'arrange
        Dim bookOne = CreateBook()
        Dim testIBSN As Double = 9780553560732
        Dim bookIBSN As Double = bookOne.GetIBSN

        'act

        'assert
        Assert.AreEqual(testIBSN, bookIBSN)

    End Sub

    <TestMethod()> Public Sub TestGetEstimatedValue()

        'arrange
        Dim bookOne = CreateBook()
        Dim testEstimatedValue As Double = 6.99
        Dim bookEstimatedValue As Double = bookOne.GetEstimatedValue

        'act

        'assert
        Assert.AreEqual(testEstimatedValue, bookEstimatedValue)

    End Sub

    <TestMethod()> Public Sub TestSetTitle()

        'arrange
        Dim bookOne = CreateBook()
        Dim testTitle As String = "The Fifth Science"

        'act

        bookOne.SetTitle(testTitle)

        'assert
        Assert.AreEqual(testTitle, bookOne.GetTitle)

    End Sub

    <TestMethod()> Public Sub TestSetAuthor()

        'arrange
        Dim bookOne = CreateBook()
        Dim testAuthor As String = "Exurb1a"

        'act

        bookOne.SetAuthor(testAuthor)

        'assert
        Assert.AreEqual(testAuthor, bookOne.GetAuthor)

    End Sub

    <TestMethod()> Public Sub TestSetPublisher()

        'arrange
        Dim bookOne = CreateBook()
        Dim testPublisher As String = "Puffin"

        'act

        bookOne.SetPublisher(testPublisher)

        'assert
        Assert.AreEqual(testPublisher, bookOne.GetPublisher)

    End Sub

    <TestMethod()> Public Sub TestSetIBSN()

        'arrange
        Dim bookOne = CreateBook()
        Dim testIBSN As Double = 9785553560732

        'act

        bookOne.SetIBSN(testIBSN)

        'assert
        Assert.AreEqual(testIBSN, bookOne.GetIBSN)

    End Sub

    <TestMethod()> Public Sub TestSetEstimatedValue()

        'arrange
        Dim bookOne = CreateBook()
        Dim testEstimatedValue As Double = 10.0

        'act

        bookOne.SetEstimatedValue(testEstimatedValue)

        'assert
        Assert.AreEqual(testEstimatedValue, bookOne.GetEstimatedValue)

    End Sub

    <TestMethod()> Public Sub TestGetBookInfo()

        'arrange
        Dim bookOne = CreateBook()
        Dim testString As String

        'act

        testString = (bookOne.GetTitle & vbCrLf &
                      bookOne.GetAuthor & vbCrLf &
                      bookOne.GetPublisher & vbCrLf &
                      bookOne.GetIBSN & vbCrLf &
                      bookOne.GetEstimatedValue)

        'assert
        Assert.AreEqual(testString, bookOne.GetBookInfo)

    End Sub

    <TestMethod()> Public Sub TestGetTitleAuthor()

        'arrange
        Dim bookOne = CreateBook()
        Dim testString As String

        'act

        testString = (bookOne.GetTitle & " | " & bookOne.GetAuthor)

        'assert
        Assert.AreEqual(testString, bookOne.GetBookTitleAuthor)

    End Sub



    Function CreateBook()

        Dim title As String = "Red Mars"
        Dim author As String = "Kim Stanley Robinson"
        Dim publisher As String = "Spectra"
        Dim isbn As Double = 9780553560732
        Dim estimatedValue = 6.99

        Return New BookStorageApp.Book(title, author, publisher, isbn, estimatedValue)

    End Function

End Class
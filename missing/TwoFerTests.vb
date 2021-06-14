Imports Xunit
Public Class TwoFerTests
    <Fact>
    Public Sub No_name_given()
        Assert.Equal("One for you, one for me.", TwoFer.Speak())
    End Sub
    <Fact>
    Public Sub A_name_given()
        Assert.Equal("One for Alice, one for me.", TwoFer.Speak("Alice"))
    End Sub
    <Fact>
    Public Sub Another_name_given()
        Assert.Equal("One for Bob, one for me.", TwoFer.Speak("Bob"))
    End Sub
End Class

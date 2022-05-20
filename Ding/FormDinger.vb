Public Class FormDinger

    ' Start
    Private Sub FormDinger_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim Arguments() As String = Environment.GetCommandLineArgs() ' Load program arguments into String Array

        Try ' to play sound from argument

            If My.Computer.FileSystem.FileExists(Arguments(1)) Then ' If argument file exists Then

                My.Computer.Audio.Play(Arguments(1), AudioPlayMode.WaitToComplete) ' Play sound from file

                GoTo 0 ' End program

            End If

        Catch ex As Exception ' A lack of arguments will cause an error

            ' do nothing

        End Try


        My.Computer.Audio.Play(My.Resources.chime, AudioPlayMode.WaitToComplete) ' Play built in chime

0:
        Close()

    End Sub

    Private Sub LabelPlaying_MouseEnter(sender As Object, e As EventArgs) Handles LabelPlaying.MouseEnter

        Close() ' If somehow you the form opens, it will close when interacted with

    End Sub


End Class

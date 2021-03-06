﻿Public Class UpdateQuestion
    Protected question_id As Integer
    Protected db As New db

    Public Sub New(ByVal qid As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        question_id = qid

        tbUpdateQuestion.Text = welcome.getQuestionValue("question")
    End Sub
    Private Sub btnUpdateQuestion_Click(sender As Object, e As EventArgs) Handles btnUpdateQuestion.Click

        db.sql = "Update questions Set question = @question WHERE id = @question_id"
        db.bind("@question_id", question_id)
        db.bind("@question", tbUpdateQuestion.Text)
        db.Execute()
        Me.Dispose()

    End Sub
End Class
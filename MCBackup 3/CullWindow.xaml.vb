﻿Imports Scripting
Imports System.ComponentModel

Public Class CullWindow
    Private Main As MainWindow = DirectCast(Application.Current.MainWindow, MainWindow)

    Private DeleteBackgroundWorker As New BackgroundWorker()
    Private ItemsToDelete As New ArrayList

    Sub New()
        InitializeComponent()

        AddHandler DeleteBackgroundWorker.DoWork, New DoWorkEventHandler(AddressOf DeleteBackgroundWorker_DoWork)
        AddHandler DeleteBackgroundWorker.RunWorkerCompleted, New RunWorkerCompletedEventHandler(AddressOf DeleteBackgroundWorker_RunWorkerCompleted)

        Me.Title = MCBackup.Language.Dictionary("CullWindow.Title")
        Label1.Content = MCBackup.Language.Dictionary("CullWindow.Label1.Content")
        Label2.Content = MCBackup.Language.Dictionary("CullWindow.Label2.Content")
        CullButton.Content = MCBackup.Language.Dictionary("CullWindow.CullButton.Content")
    End Sub

    Private Sub Cull_Loaded(sender As Object, e As RoutedEventArgs) Handles Cull.Loaded
        Dim DaysNumUpDownMargin As Thickness = DaysNumUpDown.Margin
        Dim Label2Margin As Thickness = Label2.Margin
        DaysNumUpDownMargin.Left = Label1.ActualWidth + 10
        Label2Margin.Left = Label1.ActualWidth + 95
        DaysNumUpDown.Margin = DaysNumUpDownMargin
        Label2.Margin = Label2Margin
    End Sub

    Private Sub CullButton_Click(sender As Object, e As RoutedEventArgs) Handles CullButton.Click
        If MetroMessageBox.Show(String.Format(MCBackup.Language.Dictionary("CullWindow.AreYouSureMsg"), DaysNumUpDown.Value), MCBackup.Language.Dictionary("Message.Caption.AreYouSure"), MessageBoxButton.YesNo, MessageBoxImage.Question) = MessageBoxResult.No Then
            Exit Sub
        End If

        ItemsToDelete.Clear()

        For Each Item In Main.ListView.Items
            If Main.GetFolderDateCreated(My.Settings.BackupsFolderLocation & "\" & Item.Name).AddDays(DaysNumUpDown.Value) < Date.Today Then
                ItemsToDelete.Add(Item.Name)
            End If
        Next

        DeleteBackgroundWorker.RunWorkerAsync()
        Main.StatusLabel.Content = MCBackup.Language.Dictionary("Status.Deleting")
        Main.ProgressBar.IsIndeterminate = True
        Me.Close()
    End Sub

    Private Sub DeleteBackgroundWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs)
        For Each Item As String In ItemsToDelete
            Try
                My.Computer.FileSystem.DeleteDirectory(My.Settings.BackupsFolderLocation & "\" & Item, FileIO.DeleteDirectoryOption.DeleteAllContents)
            Catch ex As Exception
                ErrorWindow.Show(MCBackup.Language.Dictionary("Message.DeleteError"), ex)
            End Try
        Next
    End Sub

    Private Sub DeleteBackgroundWorker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs)
        Main.StatusLabel.Content = MCBackup.Language.Dictionary("Status.DeleteComplete")
        Main.ProgressBar.IsIndeterminate = False
        Main.RefreshBackupsList()
    End Sub
End Class

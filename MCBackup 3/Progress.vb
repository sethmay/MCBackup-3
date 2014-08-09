﻿Imports Microsoft.WindowsAPICodePack.Taskbar

Public Class Progress
    Private Shared MainWindow As MainWindow = DirectCast(Application.Current.MainWindow, MainWindow)

    Public Shared Property Value As Integer
        Get
            Return MainWindow.ProgressBar.Value
        End Get
        Set(value As Integer)
            MainWindow.ProgressBar.Value = value
            If Environment.OSVersion.Version.Major > 5 Then
                TaskbarManager.Instance.SetProgressValue(value, MainWindow.ProgressBar.Maximum)
            End If
        End Set
    End Property
End Class
﻿Imports System.ComponentModel

Public Class ExtractCompletedEventArgs
    Inherits AsyncCompletedEventArgs
    Public Sub New([error] As Exception, cancelled As Boolean)
        MyBase.New([error], cancelled, Nothing)
    End Sub
End Class
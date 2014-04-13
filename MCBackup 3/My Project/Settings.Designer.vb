﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Ce code a été généré par un outil.
'     Version du runtime :4.0.30319.34011
'
'     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
'     le code est régénéré.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On



<Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
 Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0"),  _
 Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
Partial Friend NotInheritable Class MySettings
    Inherits Global.System.Configuration.ApplicationSettingsBase
    
    Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
    
#Region "Fonctionnalité Enregistrement automatique My.Settings"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(ByVal sender As Global.System.Object, ByVal e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region
    
    Public Shared ReadOnly Property [Default]() As MySettings
        Get
            
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
            Return defaultInstance
        End Get
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("")>  _
    Public Property MinecraftFolderLocation() As String
        Get
            Return CType(Me("MinecraftFolderLocation"),String)
        End Get
        Set
            Me("MinecraftFolderLocation") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("")>  _
    Public Property BackupsFolderLocation() As String
        Get
            Return CType(Me("BackupsFolderLocation"),String)
        End Get
        Set
            Me("BackupsFolderLocation") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("")>  _
    Public Property SavesFolderLocation() As String
        Get
            Return CType(Me("SavesFolderLocation"),String)
        End Get
        Set
            Me("SavesFolderLocation") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("100")>  _
    Public Property InterfaceOpacity() As Integer
        Get
            Return CType(Me("InterfaceOpacity"),Integer)
        End Get
        Set
            Me("InterfaceOpacity") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("")>  _
    Public Property BackgroundImageLocation() As String
        Get
            Return CType(Me("BackgroundImageLocation"),String)
        End Get
        Set
            Me("BackgroundImageLocation") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Public Property BackgroundImageStretch() As Integer
        Get
            Return CType(Me("BackgroundImageStretch"),Integer)
        End Get
        Set
            Me("BackgroundImageStretch") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
    Public Property CheckForUpdates() As Boolean
        Get
            Return CType(Me("CheckForUpdates"),Boolean)
        End Get
        Set
            Me("CheckForUpdates") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
    Public Property ShowBalloonTips() As Boolean
        Get
            Return CType(Me("ShowBalloonTips"),Boolean)
        End Get
        Set
            Me("ShowBalloonTips") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
    Public Property CloseToTray() As Boolean
        Get
            Return CType(Me("CloseToTray"),Boolean)
        End Get
        Set
            Me("CloseToTray") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
    Public Property SaveCloseState() As Boolean
        Get
            Return CType(Me("SaveCloseState"),Boolean)
        End Get
        Set
            Me("SaveCloseState") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
    Public Property CreateThumbOnWorld() As Boolean
        Get
            Return CType(Me("CreateThumbOnWorld"),Boolean)
        End Get
        Set
            Me("CreateThumbOnWorld") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("")>  _
    Public Property Language() As String
        Get
            Return CType(Me("Language"),String)
        End Get
        Set
            Me("Language") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("#FF000000")>  _
    Public Property StatusLabelColor() As Global.System.Windows.Media.Color
        Get
            Return CType(Me("StatusLabelColor"),Global.System.Windows.Media.Color)
        End Get
        Set
            Me("StatusLabelColor") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("[AUTO]")>  _
    Public Property AutoBkpPrefix() As String
        Get
            Return CType(Me("AutoBkpPrefix"),String)
        End Get
        Set
            Me("AutoBkpPrefix") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("")>  _
    Public Property AutoBkpSuffix() As String
        Get
            Return CType(Me("AutoBkpSuffix"),String)
        End Get
        Set
            Me("AutoBkpSuffix") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("240")>  _
    Public Property SidebarWidth() As Integer
        Get
            Return CType(Me("SidebarWidth"),Integer)
        End Get
        Set
            Me("SidebarWidth") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("Cyan")>  _
    Public Property Theme() As String
        Get
            Return CType(Me("Theme"),String)
        End Get
        Set
            Me("Theme") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("125")>  _
    Public Property ListViewTextColorIntensity() As String
        Get
            Return CType(Me("ListViewTextColorIntensity"),String)
        End Get
        Set
            Me("ListViewTextColorIntensity") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("Type")>  _
    Public Property ListViewGroupBy() As String
        Get
            Return CType(Me("ListViewGroupBy"),String)
        End Get
        Set
            Me("ListViewGroupBy") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("DateCreated")>  _
    Public Property ListViewSortBy() As String
        Get
            Return CType(Me("ListViewSortBy"),String)
        End Get
        Set
            Me("ListViewSortBy") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("Ascending")>  _
    Public Property ListViewSortByDirection() As Global.System.ComponentModel.ListSortDirection
        Get
            Return CType(Me("ListViewSortByDirection"),Global.System.ComponentModel.ListSortDirection)
        End Get
        Set
            Me("ListViewSortByDirection") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("<?xml version=""1.0"" encoding=""utf-16""?>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"<ArrayOfString xmlns:xsi=""http://www.w3."& _ 
        "org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" />")>  _
    Public Property BackupGroups() As Global.System.Collections.Specialized.StringCollection
        Get
            Return CType(Me("BackupGroups"),Global.System.Collections.Specialized.StringCollection)
        End Get
        Set
            Me("BackupGroups") = value
        End Set
    End Property
End Class

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.MCBackup.MySettings
            Get
                Return Global.MCBackup.MySettings.Default
            End Get
        End Property
    End Module
End Namespace

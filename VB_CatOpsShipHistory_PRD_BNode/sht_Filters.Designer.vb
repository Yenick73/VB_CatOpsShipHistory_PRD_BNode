'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On



'''
<Microsoft.VisualStudio.Tools.Applications.Runtime.StartupObjectAttribute(1),  _
 Global.System.Security.Permissions.PermissionSetAttribute(Global.System.Security.Permissions.SecurityAction.Demand, Name:="FullTrust")>  _
Partial Public NotInheritable Class sht_Filters
    Inherits Microsoft.Office.Tools.Excel.WorksheetBase
    
    Friend WithEvents ftr_BA As Microsoft.Office.Tools.Excel.NamedRange
    
    Friend WithEvents ftr_CPK As Microsoft.Office.Tools.Excel.NamedRange
    
    Friend WithEvents ftr_CPK_SortBy As Microsoft.Office.Tools.Excel.NamedRange
    
    Friend WithEvents ftr_CPK_SortDirection As Microsoft.Office.Tools.Excel.NamedRange
    
    Friend WithEvents ftr_FeatureGroup As Microsoft.Office.Tools.Excel.NamedRange
    
    Friend WithEvents ftr_KeyFig As Microsoft.Office.Tools.Excel.NamedRange
    
    Friend WithEvents ftr_KeyFig_Value As Microsoft.Office.Tools.Excel.NamedRange
    
    Friend WithEvents ftr_OffsetTo As Microsoft.Office.Tools.Excel.NamedRange
    
    Friend WithEvents ftr_PL As Microsoft.Office.Tools.Excel.NamedRange
    
    Friend WithEvents ftr_PLGroup As Microsoft.Office.Tools.Excel.NamedRange
    
    '''
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)>  _
    Public Sub New(ByVal factory As Global.Microsoft.Office.Tools.Excel.Factory, ByVal serviceProvider As Global.System.IServiceProvider)
        MyBase.New(factory, serviceProvider, "sht_Filters", "sht_Filters")
    End Sub
    
    '''
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "17.0.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)>  _
    Protected Overrides Sub Initialize()
        MyBase.Initialize
        Globals.sht_Filters = Me
        Global.System.Windows.Forms.Application.EnableVisualStyles
        Me.InitializeCachedData
        Me.InitializeControls
        Me.InitializeComponents
        Me.InitializeData
    End Sub
    
    '''
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "17.0.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)>  _
    Protected Overrides Sub FinishInitialization()
        Me.OnStartup
    End Sub
    
    '''
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "17.0.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)>  _
    Protected Overrides Sub InitializeDataBindings()
        Me.BeginInitialization
        Me.BindToData
        Me.EndInitialization
    End Sub
    
    '''
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "17.0.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)>  _
    Private Sub InitializeCachedData()
        If (Me.DataHost Is Nothing) Then
            Return
        End If
        If Me.DataHost.IsCacheInitialized Then
            Me.DataHost.FillCachedData(Me)
        End If
    End Sub
    
    '''
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "17.0.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)>  _
    Private Sub InitializeData()
    End Sub
    
    '''
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "17.0.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)>  _
    Private Sub BindToData()
    End Sub
    
    '''
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Private Sub StartCaching(ByVal MemberName As String)
        Me.DataHost.StartCaching(Me, MemberName)
    End Sub
    
    '''
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Private Sub StopCaching(ByVal MemberName As String)
        Me.DataHost.StopCaching(Me, MemberName)
    End Sub
    
    '''
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Private Function IsCached(ByVal MemberName As String) As Boolean
        Return Me.DataHost.IsCached(Me, MemberName)
    End Function
    
    '''
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "17.0.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)>  _
    Private Sub BeginInitialization()
        Me.BeginInit
        Me.ftr_BA.BeginInit
        Me.ftr_CPK.BeginInit
        Me.ftr_CPK_SortBy.BeginInit
        Me.ftr_CPK_SortDirection.BeginInit
        Me.ftr_FeatureGroup.BeginInit
        Me.ftr_KeyFig.BeginInit
        Me.ftr_KeyFig_Value.BeginInit
        Me.ftr_OffsetTo.BeginInit
        Me.ftr_PL.BeginInit
        Me.ftr_PLGroup.BeginInit
    End Sub
    
    '''
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "17.0.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)>  _
    Private Sub EndInitialization()
        Me.ftr_PLGroup.EndInit
        Me.ftr_PL.EndInit
        Me.ftr_OffsetTo.EndInit
        Me.ftr_KeyFig_Value.EndInit
        Me.ftr_KeyFig.EndInit
        Me.ftr_FeatureGroup.EndInit
        Me.ftr_CPK_SortDirection.EndInit
        Me.ftr_CPK_SortBy.EndInit
        Me.ftr_CPK.EndInit
        Me.ftr_BA.EndInit
        Me.EndInit
    End Sub
    
    '''
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "17.0.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)>  _
    Private Sub InitializeControls()
        Me.ftr_BA = Globals.Factory.CreateNamedRange(Nothing, Nothing, "ftr_BA", "ftr_BA", Me)
        Me.ftr_CPK = Globals.Factory.CreateNamedRange(Nothing, Nothing, "ftr_CPK", "ftr_CPK", Me)
        Me.ftr_CPK_SortBy = Globals.Factory.CreateNamedRange(Nothing, Nothing, "ftr_CPK_SortBy", "ftr_CPK_SortBy", Me)
        Me.ftr_CPK_SortDirection = Globals.Factory.CreateNamedRange(Nothing, Nothing, "ftr_CPK_SortDirection", "ftr_CPK_SortDirection", Me)
        Me.ftr_FeatureGroup = Globals.Factory.CreateNamedRange(Nothing, Nothing, "ftr_FeatureGroup", "ftr_FeatureGroup", Me)
        Me.ftr_KeyFig = Globals.Factory.CreateNamedRange(Nothing, Nothing, "ftr_KeyFig", "ftr_KeyFig", Me)
        Me.ftr_KeyFig_Value = Globals.Factory.CreateNamedRange(Nothing, Nothing, "ftr_KeyFig_Value", "ftr_KeyFig_Value", Me)
        Me.ftr_OffsetTo = Globals.Factory.CreateNamedRange(Nothing, Nothing, "ftr_OffsetTo", "ftr_OffsetTo", Me)
        Me.ftr_PL = Globals.Factory.CreateNamedRange(Nothing, Nothing, "ftr_PL", "ftr_PL", Me)
        Me.ftr_PLGroup = Globals.Factory.CreateNamedRange(Nothing, Nothing, "ftr_PLGroup", "ftr_PLGroup", Me)
    End Sub
    
    '''
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "17.0.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)>  _
    Private Sub InitializeComponents()
    End Sub
    
    '''
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Private Function NeedsFill(ByVal MemberName As String) As Boolean
        Return Me.DataHost.NeedsFill(Me, MemberName)
    End Function
    
    '''
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "17.0.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)>  _
    Protected Overrides Sub OnShutdown()
        Me.ftr_PLGroup.Dispose
        Me.ftr_PL.Dispose
        Me.ftr_OffsetTo.Dispose
        Me.ftr_KeyFig_Value.Dispose
        Me.ftr_KeyFig.Dispose
        Me.ftr_FeatureGroup.Dispose
        Me.ftr_CPK_SortDirection.Dispose
        Me.ftr_CPK_SortBy.Dispose
        Me.ftr_CPK.Dispose
        Me.ftr_BA.Dispose
        MyBase.OnShutdown
    End Sub
End Class

Partial Friend NotInheritable Class Globals
    
    Private Shared _sht_Filters As sht_Filters
    
    Friend Shared Property sht_Filters() As sht_Filters
        Get
            Return _sht_Filters
        End Get
        Set
            If (_sht_Filters Is Nothing) Then
                _sht_Filters = value
            Else
                Throw New System.NotSupportedException()
            End If
        End Set
    End Property
End Class

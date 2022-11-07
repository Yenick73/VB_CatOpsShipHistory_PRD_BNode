Partial Class rbb_ShipHistory_PRD_BNode
    Inherits Microsoft.Office.Tools.Ribbon.RibbonBase

    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Sub New(ByVal container As System.ComponentModel.IContainer)
        MyClass.New()

        'Required for Windows.Forms Class Composition Designer support
        If (container IsNot Nothing) Then
            container.Add(Me)
        End If

    End Sub

    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Sub New()
        MyBase.New(Globals.Factory.GetRibbonFactory())

        'This call is required by the Component Designer.
        InitializeComponent()

    End Sub

    'Component overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Component Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Component Designer
    'It can be modified using the Component Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.rib_ShipHistory_PRD_Bnode = Me.Factory.CreateRibbonTab
        Me.grp_Data = Me.Factory.CreateRibbonGroup
        Me.btn_DataFilter = Me.Factory.CreateRibbonButton
        Me.btn_RefreshReport = Me.Factory.CreateRibbonButton
        Me.rib_ShipHistory_PRD_Bnode.SuspendLayout()
        Me.grp_Data.SuspendLayout()
        Me.SuspendLayout()
        '
        'rib_ShipHistory_PRD_Bnode
        '
        Me.rib_ShipHistory_PRD_Bnode.Groups.Add(Me.grp_Data)
        Me.rib_ShipHistory_PRD_Bnode.Label = "Ship History (PRD/BNode)"
        Me.rib_ShipHistory_PRD_Bnode.Name = "rib_ShipHistory_PRD_Bnode"
        '
        'grp_Data
        '
        Me.grp_Data.Items.Add(Me.btn_DataFilter)
        Me.grp_Data.Items.Add(Me.btn_RefreshReport)
        Me.grp_Data.Label = "Data"
        Me.grp_Data.Name = "grp_Data"
        '
        'btn_DataFilter
        '
        Me.btn_DataFilter.Label = "Data Filter"
        Me.btn_DataFilter.Name = "btn_DataFilter"
        '
        'btn_RefreshReport
        '
        Me.btn_RefreshReport.Label = "Refresh Report"
        Me.btn_RefreshReport.Name = "btn_RefreshReport"
        '
        'rbb_ShipHistory_PRD_BNode
        '
        Me.Name = "rbb_ShipHistory_PRD_BNode"
        Me.RibbonType = "Microsoft.Excel.Workbook"
        Me.Tabs.Add(Me.rib_ShipHistory_PRD_Bnode)
        Me.rib_ShipHistory_PRD_Bnode.ResumeLayout(False)
        Me.rib_ShipHistory_PRD_Bnode.PerformLayout()
        Me.grp_Data.ResumeLayout(False)
        Me.grp_Data.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rib_ShipHistory_PRD_Bnode As Microsoft.Office.Tools.Ribbon.RibbonTab
    Friend WithEvents grp_Data As Microsoft.Office.Tools.Ribbon.RibbonGroup
    Friend WithEvents btn_DataFilter As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents btn_RefreshReport As Microsoft.Office.Tools.Ribbon.RibbonButton
End Class

Partial Class ThisRibbonCollection

    <System.Diagnostics.DebuggerNonUserCode()> _
    Friend ReadOnly Property Ribbon1() As rbb_ShipHistory_PRD_BNode
        Get
            Return Me.GetRibbon(Of rbb_ShipHistory_PRD_BNode)()
        End Get
    End Property
End Class

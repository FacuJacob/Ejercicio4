<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        grdMatriz = New DataGridView()
        lstVector = New ListBox()
        cmdEjecutar = New Button()
        CType(grdMatriz, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' grdMatriz
        ' 
        grdMatriz.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        grdMatriz.ColumnHeadersVisible = False
        grdMatriz.Location = New Point(12, 12)
        grdMatriz.Name = "grdMatriz"
        grdMatriz.RowHeadersVisible = False
        grdMatriz.RowTemplate.Height = 25
        grdMatriz.Size = New Size(362, 274)
        grdMatriz.TabIndex = 0
        ' 
        ' lstVector
        ' 
        lstVector.FormattingEnabled = True
        lstVector.ItemHeight = 15
        lstVector.Location = New Point(380, 12)
        lstVector.Name = "lstVector"
        lstVector.Size = New Size(87, 274)
        lstVector.TabIndex = 1
        ' 
        ' cmdEjecutar
        ' 
        cmdEjecutar.Location = New Point(12, 292)
        cmdEjecutar.Name = "cmdEjecutar"
        cmdEjecutar.Size = New Size(362, 58)
        cmdEjecutar.TabIndex = 2
        cmdEjecutar.Text = "Ejecutar"
        cmdEjecutar.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(cmdEjecutar)
        Controls.Add(lstVector)
        Controls.Add(grdMatriz)
        Name = "Form1"
        Text = "Form1"
        CType(grdMatriz, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents grdMatriz As DataGridView
    Friend WithEvents lstVector As ListBox
    Friend WithEvents cmdEjecutar As Button
End Class

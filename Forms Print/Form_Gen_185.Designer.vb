<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Gen_185
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tw_contents = New System.Windows.Forms.TreeView()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_rem = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_print = New System.Windows.Forms.Button()
        Me.img_content = New System.Windows.Forms.PictureBox()
        Me.cb_printers = New System.Windows.Forms.ComboBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.btn_print_2 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MeasurementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtp_date = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_establishment = New System.Windows.Forms.TextBox()
        CType(Me.img_content, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tw_contents
        '
        Me.tw_contents.Location = New System.Drawing.Point(16, 209)
        Me.tw_contents.Name = "tw_contents"
        Me.tw_contents.Size = New System.Drawing.Size(377, 432)
        Me.tw_contents.TabIndex = 4
        '
        'btn_add
        '
        Me.btn_add.Location = New System.Drawing.Point(279, 167)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(114, 36)
        Me.btn_add.TabIndex = 5
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'btn_rem
        '
        Me.btn_rem.Location = New System.Drawing.Point(16, 167)
        Me.btn_rem.Name = "btn_rem"
        Me.btn_rem.Size = New System.Drawing.Size(114, 36)
        Me.btn_rem.TabIndex = 6
        Me.btn_rem.Text = "Remove"
        Me.btn_rem.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(364, 28)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Gen 185 : Increment Certificate Form"
        '
        'btn_print
        '
        Me.btn_print.Location = New System.Drawing.Point(790, 605)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(80, 36)
        Me.btn_print.TabIndex = 8
        Me.btn_print.Text = "Print 1"
        Me.btn_print.UseVisualStyleBackColor = True
        '
        'img_content
        '
        Me.img_content.Location = New System.Drawing.Point(399, 35)
        Me.img_content.Name = "img_content"
        Me.img_content.Size = New System.Drawing.Size(471, 564)
        Me.img_content.TabIndex = 9
        Me.img_content.TabStop = False
        '
        'cb_printers
        '
        Me.cb_printers.FormattingEnabled = True
        Me.cb_printers.Location = New System.Drawing.Point(399, 609)
        Me.cb_printers.Name = "cb_printers"
        Me.cb_printers.Size = New System.Drawing.Size(304, 31)
        Me.cb_printers.TabIndex = 10
        '
        'PrintDocument1
        '
        '
        'btn_print_2
        '
        Me.btn_print_2.Location = New System.Drawing.Point(709, 605)
        Me.btn_print_2.Name = "btn_print_2"
        Me.btn_print_2.Size = New System.Drawing.Size(75, 36)
        Me.btn_print_2.TabIndex = 12
        Me.btn_print_2.Text = "Print 2"
        Me.btn_print_2.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(882, 28)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.OpenToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(128, 26)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(128, 26)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(128, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MeasurementToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(70, 24)
        Me.EditToolStripMenuItem.Text = "System"
        '
        'MeasurementToolStripMenuItem
        '
        Me.MeasurementToolStripMenuItem.Name = "MeasurementToolStripMenuItem"
        Me.MeasurementToolStripMenuItem.Size = New System.Drawing.Size(183, 26)
        Me.MeasurementToolStripMenuItem.Text = "Configuration"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(81, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Date"
        '
        'dtp_date
        '
        Me.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_date.Location = New System.Drawing.Point(134, 115)
        Me.dtp_date.Name = "dtp_date"
        Me.dtp_date.Size = New System.Drawing.Size(133, 30)
        Me.dtp_date.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Establishment"
        '
        'txt_establishment
        '
        Me.txt_establishment.Location = New System.Drawing.Point(134, 79)
        Me.txt_establishment.Name = "txt_establishment"
        Me.txt_establishment.Size = New System.Drawing.Size(259, 30)
        Me.txt_establishment.TabIndex = 0
        '
        'Form_Gen_185
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(882, 653)
        Me.Controls.Add(Me.btn_print_2)
        Me.Controls.Add(Me.cb_printers)
        Me.Controls.Add(Me.img_content)
        Me.Controls.Add(Me.btn_print)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_rem)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.tw_contents)
        Me.Controls.Add(Me.dtp_date)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_establishment)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form_Gen_185"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gen-185 : Increment Cetificate Form"
        CType(Me.img_content, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tw_contents As TreeView
    Friend WithEvents btn_add As Button
    Friend WithEvents btn_rem As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_print As Button
    Friend WithEvents img_content As PictureBox
    Friend WithEvents cb_printers As ComboBox
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents btn_print_2 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MeasurementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents dtp_date As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_establishment As TextBox
End Class

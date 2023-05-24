<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Welcome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Welcome))
        Me.pbWelcome = New System.Windows.Forms.PictureBox()
        Me.btnReserve = New System.Windows.Forms.Button()
        Me.btnCustomer = New System.Windows.Forms.Button()
        Me.btnRoom = New System.Windows.Forms.Button()
        CType(Me.pbWelcome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbWelcome
        '
        Me.pbWelcome.Image = CType(resources.GetObject("pbWelcome.Image"), System.Drawing.Image)
        Me.pbWelcome.Location = New System.Drawing.Point(0, 0)
        Me.pbWelcome.Name = "pbWelcome"
        Me.pbWelcome.Size = New System.Drawing.Size(803, 399)
        Me.pbWelcome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbWelcome.TabIndex = 4
        Me.pbWelcome.TabStop = False
        '
        'btnReserve
        '
        Me.btnReserve.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.btnReserve.FlatAppearance.BorderSize = 0
        Me.btnReserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReserve.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReserve.ForeColor = System.Drawing.Color.White
        Me.btnReserve.Location = New System.Drawing.Point(0, 120)
        Me.btnReserve.Name = "btnReserve"
        Me.btnReserve.Size = New System.Drawing.Size(215, 47)
        Me.btnReserve.TabIndex = 0
        Me.btnReserve.Text = "MANAGE RESERVATIONS"
        Me.btnReserve.UseVisualStyleBackColor = False
        '
        'btnCustomer
        '
        Me.btnCustomer.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.btnCustomer.FlatAppearance.BorderSize = 0
        Me.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCustomer.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomer.ForeColor = System.Drawing.Color.White
        Me.btnCustomer.Location = New System.Drawing.Point(0, 201)
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.Size = New System.Drawing.Size(166, 47)
        Me.btnCustomer.TabIndex = 1
        Me.btnCustomer.Text = "MANAGE CUSTOMERS"
        Me.btnCustomer.UseVisualStyleBackColor = False
        '
        'btnRoom
        '
        Me.btnRoom.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.btnRoom.FlatAppearance.BorderSize = 0
        Me.btnRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRoom.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRoom.ForeColor = System.Drawing.Color.White
        Me.btnRoom.Location = New System.Drawing.Point(0, 282)
        Me.btnRoom.Name = "btnRoom"
        Me.btnRoom.Size = New System.Drawing.Size(166, 47)
        Me.btnRoom.TabIndex = 2
        Me.btnRoom.Text = "MANAGE ROOMS"
        Me.btnRoom.UseVisualStyleBackColor = False
        '
        'Welcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(803, 399)
        Me.Controls.Add(Me.btnRoom)
        Me.Controls.Add(Me.btnCustomer)
        Me.Controls.Add(Me.btnReserve)
        Me.Controls.Add(Me.pbWelcome)
        Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Welcome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Welcome"
        CType(Me.pbWelcome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbWelcome As PictureBox
    Friend WithEvents btnReserve As Button
    Friend WithEvents btnCustomer As Button
    Friend WithEvents btnRoom As Button
End Class

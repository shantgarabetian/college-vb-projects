<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class shopping
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
        Me.shopsign = New System.Windows.Forms.Label()
        Me.destination = New System.Windows.Forms.Label()
        Me.pricing = New System.Windows.Forms.Label()
        Me.confirm = New System.Windows.Forms.Button()
        Me.clearing = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.costumselection = New System.Windows.Forms.GroupBox()
        Me.pirate = New System.Windows.Forms.RadioButton()
        Me.batman = New System.Windows.Forms.RadioButton()
        Me.stormtrooper = New System.Windows.Forms.RadioButton()
        Me.renaissancebtn = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.costumselection.SuspendLayout()
        Me.SuspendLayout()
        '
        'shopsign
        '
        Me.shopsign.AutoSize = True
        Me.shopsign.Font = New System.Drawing.Font("Arial Rounded MT Bold", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.shopsign.Location = New System.Drawing.Point(110, 45)
        Me.shopsign.Name = "shopsign"
        Me.shopsign.Size = New System.Drawing.Size(323, 32)
        Me.shopsign.TabIndex = 0
        Me.shopsign.Text = "Costum rental spetials"
        '
        'destination
        '
        Me.destination.AutoSize = True
        Me.destination.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.destination.Location = New System.Drawing.Point(92, 116)
        Me.destination.Name = "destination"
        Me.destination.Size = New System.Drawing.Size(120, 23)
        Me.destination.TabIndex = 1
        Me.destination.Text = "Destination"
        '
        'pricing
        '
        Me.pricing.AutoSize = True
        Me.pricing.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pricing.Location = New System.Drawing.Point(571, 122)
        Me.pricing.Name = "pricing"
        Me.pricing.Size = New System.Drawing.Size(61, 23)
        Me.pricing.TabIndex = 2
        Me.pricing.Text = "Price"
        '
        'confirm
        '
        Me.confirm.Location = New System.Drawing.Point(567, 216)
        Me.confirm.Name = "confirm"
        Me.confirm.Size = New System.Drawing.Size(165, 35)
        Me.confirm.TabIndex = 7
        Me.confirm.Text = "Confim You Order"
        Me.confirm.UseVisualStyleBackColor = True
        '
        'clearing
        '
        Me.clearing.Location = New System.Drawing.Point(567, 312)
        Me.clearing.Name = "clearing"
        Me.clearing.Size = New System.Drawing.Size(165, 35)
        Me.clearing.TabIndex = 8
        Me.clearing.Text = "Clear Your Selection"
        Me.clearing.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(567, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 17)
        Me.Label4.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ch2shop.My.Resources.Resources.renaissance
        Me.PictureBox1.Location = New System.Drawing.Point(302, 122)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(206, 225)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'costumselection
        '
        Me.costumselection.Controls.Add(Me.pirate)
        Me.costumselection.Controls.Add(Me.batman)
        Me.costumselection.Controls.Add(Me.stormtrooper)
        Me.costumselection.Controls.Add(Me.renaissancebtn)
        Me.costumselection.Location = New System.Drawing.Point(61, 142)
        Me.costumselection.Name = "costumselection"
        Me.costumselection.Size = New System.Drawing.Size(200, 205)
        Me.costumselection.TabIndex = 11
        Me.costumselection.TabStop = False
        '
        'pirate
        '
        Me.pirate.AutoSize = True
        Me.pirate.Location = New System.Drawing.Point(19, 158)
        Me.pirate.Name = "pirate"
        Me.pirate.Size = New System.Drawing.Size(66, 21)
        Me.pirate.TabIndex = 3
        Me.pirate.TabStop = True
        Me.pirate.Text = "Pirate"
        Me.pirate.UseVisualStyleBackColor = True
        '
        'batman
        '
        Me.batman.AutoSize = True
        Me.batman.Location = New System.Drawing.Point(19, 116)
        Me.batman.Name = "batman"
        Me.batman.Size = New System.Drawing.Size(77, 21)
        Me.batman.TabIndex = 2
        Me.batman.TabStop = True
        Me.batman.Text = "Batman"
        Me.batman.UseVisualStyleBackColor = True
        '
        'stormtrooper
        '
        Me.stormtrooper.AutoSize = True
        Me.stormtrooper.Location = New System.Drawing.Point(19, 74)
        Me.stormtrooper.Name = "stormtrooper"
        Me.stormtrooper.Size = New System.Drawing.Size(112, 21)
        Me.stormtrooper.TabIndex = 1
        Me.stormtrooper.TabStop = True
        Me.stormtrooper.Text = "Stormtrooper"
        Me.stormtrooper.UseVisualStyleBackColor = True
        '
        'renaissancebtn
        '
        Me.renaissancebtn.AutoSize = True
        Me.renaissancebtn.Location = New System.Drawing.Point(19, 32)
        Me.renaissancebtn.Name = "renaissancebtn"
        Me.renaissancebtn.Size = New System.Drawing.Size(136, 21)
        Me.renaissancebtn.TabIndex = 0
        Me.renaissancebtn.TabStop = True
        Me.renaissancebtn.Text = "Renassance Fair"
        Me.renaissancebtn.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(572, 275)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 17)
        Me.Label5.TabIndex = 12
        '
        'shopping
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.costumselection)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.clearing)
        Me.Controls.Add(Me.confirm)
        Me.Controls.Add(Me.pricing)
        Me.Controls.Add(Me.destination)
        Me.Controls.Add(Me.shopsign)
        Me.Name = "shopping"
        Me.Text = "COSTUME SHOP"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.costumselection.ResumeLayout(False)
        Me.costumselection.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents shopsign As Label
    Friend WithEvents destination As Label
    Friend WithEvents pricing As Label
    Friend WithEvents confirm As Button
    Friend WithEvents clearing As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents costumselection As GroupBox
    Friend WithEvents pirate As RadioButton
    Friend WithEvents batman As RadioButton
    Friend WithEvents stormtrooper As RadioButton
    Friend WithEvents renaissancebtn As RadioButton

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles renaissancebtn.CheckedChanged
        PictureBox1.Image = My.Resources.renaissance
        Label4.Text = " $40 week rental"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles stormtrooper.CheckedChanged
        PictureBox1.Image = My.Resources.stormtrooper
        Label4.Text = " $49 week rental"
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles batman.CheckedChanged
        PictureBox1.Image = My.Resources.batman
        Label4.Text = " $36 week rental"
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles pirate.CheckedChanged
        PictureBox1.Image = My.Resources.pirate
        Label4.Text = " $29 week rental"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles clearing.Click
        renaissancebtn.Checked = False
        stormtrooper.Checked = False
        batman.Checked = False
        pirate.Checked = False
        Label5.Text = " "
        Label4.Text = " Please select a Costume to rent "
    End Sub

    Friend WithEvents Label5 As Label

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles confirm.Click
        Label5.Text = " Thank you "
    End Sub
End Class

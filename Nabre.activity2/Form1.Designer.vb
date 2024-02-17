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
        Label1 = New Label()
        num1 = New TextBox()
        Label2 = New Label()
        num2 = New TextBox()
        btn1 = New Button()
        lblResult = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(27, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(132, 20)
        Label1.TabIndex = 0
        Label1.Text = "Enter First Number"
        ' 
        ' num1
        ' 
        num1.Location = New Point(27, 32)
        num1.Name = "num1"
        num1.Size = New Size(125, 27)
        num1.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 78)
        Label2.Name = "Label2"
        Label2.Size = New Size(154, 20)
        Label2.TabIndex = 2
        Label2.Text = "Enter Second Number"
        ' 
        ' num2
        ' 
        num2.Location = New Point(27, 101)
        num2.Name = "num2"
        num2.Size = New Size(125, 27)
        num2.TabIndex = 3
        ' 
        ' btn1
        ' 
        btn1.Location = New Point(38, 156)
        btn1.Name = "btn1"
        btn1.Size = New Size(94, 29)
        btn1.TabIndex = 4
        btn1.Text = "Subtract"
        btn1.UseVisualStyleBackColor = True
        ' 
        ' lblResult
        ' 
        lblResult.AutoSize = True
        lblResult.Location = New Point(57, 207)
        lblResult.Name = "lblResult"
        lblResult.Size = New Size(49, 20)
        lblResult.TabIndex = 5
        lblResult.Text = "Result"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btn1)
        Controls.Add(num2)
        Controls.Add(Label2)
        Controls.Add(num1)
        Controls.Add(Label1)
        Controls.Add(lblResult)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents num1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents num2 As TextBox
    Friend WithEvents btn1 As Button
    Friend WithEvents lblResult As Label

End Class

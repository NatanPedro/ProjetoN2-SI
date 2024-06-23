<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Pedidos
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pedidos))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btn_Vender = New System.Windows.Forms.Button()
        Me.CucucucucuDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbpedidosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_dataGrid_Func = New MetroFramework.Controls.MetroGrid()
        Me.Data = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeProduto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantidade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorUnitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Excluir = New System.Windows.Forms.DataGridViewImageColumn()
        Me.btn_Print = New System.Windows.Forms.Button()
        CType(Me.CucucucucuDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbpedidosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.txt_dataGrid_Func, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Vender
        '
        Me.btn_Vender.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btn_Vender.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Vender.FlatAppearance.BorderSize = 0
        Me.btn_Vender.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Vender.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Vender.ForeColor = System.Drawing.Color.Snow
        Me.btn_Vender.Image = CType(resources.GetObject("btn_Vender.Image"), System.Drawing.Image)
        Me.btn_Vender.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Vender.Location = New System.Drawing.Point(16, 50)
        Me.btn_Vender.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_Vender.Name = "btn_Vender"
        Me.btn_Vender.Padding = New System.Windows.Forms.Padding(7, 0, 0, 0)
        Me.btn_Vender.Size = New System.Drawing.Size(175, 44)
        Me.btn_Vender.TabIndex = 12
        Me.btn_Vender.Text = " Vender Produto"
        Me.btn_Vender.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Vender.UseVisualStyleBackColor = False
        '
        'TbpedidosBindingSource
        '
        Me.TbpedidosBindingSource.DataMember = "tb_pedidos"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(16, 102)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1371, 42)
        Me.Panel2.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(837, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 25)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Valor Unitario"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(1103, 14)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 25)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Valor Total"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(293, 12)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(175, 25)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Nome do Produto"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(563, 12)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Quantidade"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(51, 12)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Data"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(957, 16)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 23)
        Me.Label2.TabIndex = 4
        '
        'txt_dataGrid_Func
        '
        Me.txt_dataGrid_Func.AllowUserToAddRows = False
        Me.txt_dataGrid_Func.AllowUserToDeleteRows = False
        Me.txt_dataGrid_Func.AllowUserToResizeColumns = False
        Me.txt_dataGrid_Func.AllowUserToResizeRows = False
        Me.txt_dataGrid_Func.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.txt_dataGrid_Func.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_dataGrid_Func.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_dataGrid_Func.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.txt_dataGrid_Func.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.txt_dataGrid_Func.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.txt_dataGrid_Func.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.txt_dataGrid_Func.ColumnHeadersVisible = False
        Me.txt_dataGrid_Func.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Data, Me.NomeProduto, Me.Quantidade, Me.ValorUnitario, Me.ValorTotal, Me.Excluir})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.txt_dataGrid_Func.DefaultCellStyle = DataGridViewCellStyle3
        Me.txt_dataGrid_Func.EnableHeadersVisualStyles = False
        Me.txt_dataGrid_Func.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txt_dataGrid_Func.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_dataGrid_Func.Location = New System.Drawing.Point(13, 153)
        Me.txt_dataGrid_Func.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_dataGrid_Func.Name = "txt_dataGrid_Func"
        Me.txt_dataGrid_Func.ReadOnly = True
        Me.txt_dataGrid_Func.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.txt_dataGrid_Func.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.txt_dataGrid_Func.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_dataGrid_Func.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.txt_dataGrid_Func.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.txt_dataGrid_Func.Size = New System.Drawing.Size(1373, 396)
        Me.txt_dataGrid_Func.TabIndex = 20
        '
        'Data
        '
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = "*"
        Me.Data.DefaultCellStyle = DataGridViewCellStyle2
        Me.Data.HeaderText = "Data"
        Me.Data.MaxInputLength = 7
        Me.Data.MinimumWidth = 6
        Me.Data.Name = "Data"
        Me.Data.ReadOnly = True
        '
        'NomeProduto
        '
        Me.NomeProduto.HeaderText = "NomeProduto"
        Me.NomeProduto.MinimumWidth = 6
        Me.NomeProduto.Name = "NomeProduto"
        Me.NomeProduto.ReadOnly = True
        '
        'Quantidade
        '
        Me.Quantidade.HeaderText = "Quantidade"
        Me.Quantidade.MinimumWidth = 6
        Me.Quantidade.Name = "Quantidade"
        Me.Quantidade.ReadOnly = True
        '
        'ValorUnitario
        '
        Me.ValorUnitario.HeaderText = "Nome do cliente"
        Me.ValorUnitario.MinimumWidth = 6
        Me.ValorUnitario.Name = "ValorUnitario"
        Me.ValorUnitario.ReadOnly = True
        '
        'ValorTotal
        '
        Me.ValorTotal.HeaderText = "ValorTotal"
        Me.ValorTotal.MinimumWidth = 6
        Me.ValorTotal.Name = "ValorTotal"
        Me.ValorTotal.ReadOnly = True
        '
        'Excluir
        '
        Me.Excluir.HeaderText = "Excluir"
        Me.Excluir.Image = CType(resources.GetObject("Excluir.Image"), System.Drawing.Image)
        Me.Excluir.MinimumWidth = 6
        Me.Excluir.Name = "Excluir"
        Me.Excluir.ReadOnly = True
        Me.Excluir.Visible = False
        '
        'btn_Print
        '
        Me.btn_Print.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Print.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Print.FlatAppearance.BorderSize = 0
        Me.btn_Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Print.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Print.ForeColor = System.Drawing.Color.Snow
        Me.btn_Print.Image = CType(resources.GetObject("btn_Print.Image"), System.Drawing.Image)
        Me.btn_Print.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Print.Location = New System.Drawing.Point(1335, 50)
        Me.btn_Print.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_Print.Name = "btn_Print"
        Me.btn_Print.Padding = New System.Windows.Forms.Padding(7, 0, 0, 0)
        Me.btn_Print.Size = New System.Drawing.Size(52, 44)
        Me.btn_Print.TabIndex = 21
        Me.btn_Print.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Print.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Print.UseVisualStyleBackColor = True
        '
        'Pedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(1555, 597)
        Me.Controls.Add(Me.btn_Print)
        Me.Controls.Add(Me.txt_dataGrid_Func)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btn_Vender)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Pedidos"
        Me.Text = "Form2"
        CType(Me.CucucucucuDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbpedidosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.txt_dataGrid_Func, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_Vender As Button
    Friend WithEvents CucucucucuDataSetBindingSource As BindingSource

    Friend WithEvents TbpedidosBindingSource As BindingSource
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_dataGrid_Func As MetroFramework.Controls.MetroGrid
    Friend WithEvents Label1 As Label
    Friend WithEvents Data As DataGridViewTextBoxColumn
    Friend WithEvents NomeProduto As DataGridViewTextBoxColumn
    Friend WithEvents Quantidade As DataGridViewTextBoxColumn
    Friend WithEvents ValorUnitario As DataGridViewTextBoxColumn
    Friend WithEvents ValorTotal As DataGridViewTextBoxColumn
    Friend WithEvents Excluir As DataGridViewImageColumn
    Friend WithEvents btn_Print As Button
End Class

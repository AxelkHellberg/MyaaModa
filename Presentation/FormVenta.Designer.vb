﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormVenta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormVenta))
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Total = New System.Windows.Forms.Panel()
        Me.DataGridViewVendedores = New System.Windows.Forms.DataGridView()
        Me.ClienteAsignado = New System.Windows.Forms.Label()
        Me.BotonCliente = New System.Windows.Forms.Button()
        Me.CheckCliente = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextDebito = New System.Windows.Forms.TextBox()
        Me.CheckPresupuesto = New System.Windows.Forms.CheckBox()
        Me.BotonPresupuesto = New System.Windows.Forms.Button()
        Me.Cuota1 = New System.Windows.Forms.Button()
        Me.Couta = New System.Windows.Forms.Label()
        Me.TextCouta = New System.Windows.Forms.TextBox()
        Me.TextAjuste = New System.Windows.Forms.TextBox()
        Me.Ajuste = New System.Windows.Forms.Label()
        Me.Boton6Coutas = New System.Windows.Forms.Button()
        Me.Boton12Coutas = New System.Windows.Forms.Button()
        Me.Boton3Coutas = New System.Windows.Forms.Button()
        Me.TextInteres = New System.Windows.Forms.TextBox()
        Me.Interes = New System.Windows.Forms.Label()
        Me.TextTarjeta = New System.Windows.Forms.TextBox()
        Me.Tarjeta = New System.Windows.Forms.Label()
        Me.TextEfectivo = New System.Windows.Forms.TextBox()
        Me.Efectivo = New System.Windows.Forms.Label()
        Me.BotonConfirmar = New System.Windows.Forms.Button()
        Me.TotalNum = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Venta = New System.Windows.Forms.Label()
        Me.DataGridViewVenta = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Busqueda = New System.Windows.Forms.Label()
        Me.BotonAgregar = New System.Windows.Forms.Button()
        Me.Cantidad = New System.Windows.Forms.Label()
        Me.TextCant = New System.Windows.Forms.TextBox()
        Me.BotonLimpiar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridViewBusqueda = New System.Windows.Forms.DataGridView()
        Me.Descripcion = New System.Windows.Forms.Label()
        Me.TextDescripcion = New System.Windows.Forms.TextBox()
        Me.CodigoBarra = New System.Windows.Forms.Label()
        Me.TextCodigoBarra = New System.Windows.Forms.TextBox()
        Me.PanelBarraTitulo = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BotonClose = New System.Windows.Forms.PictureBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.ClienteTableAdapter = New Presentation.sanjusto_centroDataSetTableAdapters.ClienteTableAdapter()
        Me.Total.SuspendLayout()
        CType(Me.DataGridViewVendedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBarraTitulo.SuspendLayout()
        CType(Me.BotonClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Total
        '
        Me.Total.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Total.Controls.Add(Me.DataGridViewVendedores)
        Me.Total.Controls.Add(Me.ClienteAsignado)
        Me.Total.Controls.Add(Me.BotonCliente)
        Me.Total.Controls.Add(Me.CheckCliente)
        Me.Total.Controls.Add(Me.Label4)
        Me.Total.Controls.Add(Me.TextDebito)
        Me.Total.Controls.Add(Me.CheckPresupuesto)
        Me.Total.Controls.Add(Me.BotonPresupuesto)
        Me.Total.Controls.Add(Me.Cuota1)
        Me.Total.Controls.Add(Me.Couta)
        Me.Total.Controls.Add(Me.TextCouta)
        Me.Total.Controls.Add(Me.TextAjuste)
        Me.Total.Controls.Add(Me.Ajuste)
        Me.Total.Controls.Add(Me.Boton6Coutas)
        Me.Total.Controls.Add(Me.Boton12Coutas)
        Me.Total.Controls.Add(Me.Boton3Coutas)
        Me.Total.Controls.Add(Me.TextInteres)
        Me.Total.Controls.Add(Me.Interes)
        Me.Total.Controls.Add(Me.TextTarjeta)
        Me.Total.Controls.Add(Me.Tarjeta)
        Me.Total.Controls.Add(Me.TextEfectivo)
        Me.Total.Controls.Add(Me.Efectivo)
        Me.Total.Controls.Add(Me.BotonConfirmar)
        Me.Total.Controls.Add(Me.TotalNum)
        Me.Total.Controls.Add(Me.Label1)
        Me.Total.Controls.Add(Me.Venta)
        Me.Total.Controls.Add(Me.DataGridViewVenta)
        Me.Total.Controls.Add(Me.Busqueda)
        Me.Total.Controls.Add(Me.BotonAgregar)
        Me.Total.Controls.Add(Me.Cantidad)
        Me.Total.Controls.Add(Me.TextCant)
        Me.Total.Controls.Add(Me.BotonLimpiar)
        Me.Total.Controls.Add(Me.Button1)
        Me.Total.Controls.Add(Me.DataGridViewBusqueda)
        Me.Total.Controls.Add(Me.Descripcion)
        Me.Total.Controls.Add(Me.TextDescripcion)
        Me.Total.Controls.Add(Me.CodigoBarra)
        Me.Total.Controls.Add(Me.TextCodigoBarra)
        Me.Total.Controls.Add(Me.PanelBarraTitulo)
        Me.Total.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Total.Location = New System.Drawing.Point(0, 0)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(932, 628)
        Me.Total.TabIndex = 0
        '
        'DataGridViewVendedores
        '
        Me.DataGridViewVendedores.AllowUserToAddRows = False
        Me.DataGridViewVendedores.AllowUserToDeleteRows = False
        Me.DataGridViewVendedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewVendedores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewVendedores.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.DataGridViewVendedores.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridViewVendedores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewVendedores.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridViewVendedores.ColumnHeadersHeight = 30
        Me.DataGridViewVendedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(103, Byte), Integer))
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewVendedores.DefaultCellStyle = DataGridViewCellStyle14
        Me.DataGridViewVendedores.EnableHeadersVisualStyles = False
        Me.DataGridViewVendedores.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DataGridViewVendedores.Location = New System.Drawing.Point(765, 97)
        Me.DataGridViewVendedores.Name = "DataGridViewVendedores"
        Me.DataGridViewVendedores.ReadOnly = True
        Me.DataGridViewVendedores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewVendedores.RowHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.DataGridViewVendedores.RowHeadersVisible = False
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewVendedores.RowsDefaultCellStyle = DataGridViewCellStyle16
        Me.DataGridViewVendedores.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewVendedores.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.DataGridViewVendedores.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewVendedores.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.DataGridViewVendedores.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.DataGridViewVendedores.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewVendedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewVendedores.Size = New System.Drawing.Size(131, 126)
        Me.DataGridViewVendedores.TabIndex = 71
        '
        'ClienteAsignado
        '
        Me.ClienteAsignado.AutoSize = True
        Me.ClienteAsignado.Font = New System.Drawing.Font("Century Gothic", 20.75!)
        Me.ClienteAsignado.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.ClienteAsignado.Location = New System.Drawing.Point(167, 585)
        Me.ClienteAsignado.Name = "ClienteAsignado"
        Me.ClienteAsignado.Size = New System.Drawing.Size(245, 34)
        Me.ClienteAsignado.TabIndex = 69
        Me.ClienteAsignado.Text = "Consumidor final"
        '
        'BotonCliente
        '
        Me.BotonCliente.FlatAppearance.BorderSize = 0
        Me.BotonCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BotonCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BotonCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BotonCliente.Image = Global.Presentation.My.Resources.Resources.seo11
        Me.BotonCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BotonCliente.Location = New System.Drawing.Point(47, 580)
        Me.BotonCliente.Name = "BotonCliente"
        Me.BotonCliente.Size = New System.Drawing.Size(103, 45)
        Me.BotonCliente.TabIndex = 68
        Me.BotonCliente.Text = "Cliente"
        Me.BotonCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BotonCliente.UseVisualStyleBackColor = True
        '
        'CheckCliente
        '
        Me.CheckCliente.AutoSize = True
        Me.CheckCliente.Location = New System.Drawing.Point(26, 597)
        Me.CheckCliente.Name = "CheckCliente"
        Me.CheckCliente.Size = New System.Drawing.Size(15, 14)
        Me.CheckCliente.TabIndex = 66
        Me.CheckCliente.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 10.75!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.Label4.Location = New System.Drawing.Point(761, 364)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 20)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "Debito"
        '
        'TextDebito
        '
        Me.TextDebito.Location = New System.Drawing.Point(834, 365)
        Me.TextDebito.Name = "TextDebito"
        Me.TextDebito.Size = New System.Drawing.Size(63, 20)
        Me.TextDebito.TabIndex = 47
        '
        'CheckPresupuesto
        '
        Me.CheckPresupuesto.AutoSize = True
        Me.CheckPresupuesto.Location = New System.Drawing.Point(779, 283)
        Me.CheckPresupuesto.Name = "CheckPresupuesto"
        Me.CheckPresupuesto.Size = New System.Drawing.Size(118, 17)
        Me.CheckPresupuesto.TabIndex = 61
        Me.CheckPresupuesto.Text = "Ocultar individuales"
        Me.CheckPresupuesto.UseVisualStyleBackColor = True
        '
        'BotonPresupuesto
        '
        Me.BotonPresupuesto.FlatAppearance.BorderSize = 0
        Me.BotonPresupuesto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BotonPresupuesto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BotonPresupuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonPresupuesto.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonPresupuesto.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BotonPresupuesto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BotonPresupuesto.Location = New System.Drawing.Point(763, 234)
        Me.BotonPresupuesto.Name = "BotonPresupuesto"
        Me.BotonPresupuesto.Size = New System.Drawing.Size(140, 43)
        Me.BotonPresupuesto.TabIndex = 58
        Me.BotonPresupuesto.Text = "Presupuesto"
        Me.BotonPresupuesto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BotonPresupuesto.UseVisualStyleBackColor = True
        '
        'Cuota1
        '
        Me.Cuota1.FlatAppearance.BorderSize = 0
        Me.Cuota1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Cuota1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Cuota1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cuota1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cuota1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Cuota1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cuota1.Location = New System.Drawing.Point(838, 457)
        Me.Cuota1.Name = "Cuota1"
        Me.Cuota1.Size = New System.Drawing.Size(24, 23)
        Me.Cuota1.TabIndex = 57
        Me.Cuota1.Text = "1"
        Me.Cuota1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Cuota1.UseVisualStyleBackColor = True
        '
        'Couta
        '
        Me.Couta.AutoSize = True
        Me.Couta.Font = New System.Drawing.Font("Century Gothic", 10.75!)
        Me.Couta.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.Couta.Location = New System.Drawing.Point(761, 434)
        Me.Couta.Name = "Couta"
        Me.Couta.Size = New System.Drawing.Size(55, 20)
        Me.Couta.TabIndex = 56
        Me.Couta.Text = "Cuota"
        '
        'TextCouta
        '
        Me.TextCouta.Location = New System.Drawing.Point(834, 434)
        Me.TextCouta.Name = "TextCouta"
        Me.TextCouta.ReadOnly = True
        Me.TextCouta.Size = New System.Drawing.Size(63, 20)
        Me.TextCouta.TabIndex = 55
        '
        'TextAjuste
        '
        Me.TextAjuste.Location = New System.Drawing.Point(834, 507)
        Me.TextAjuste.Name = "TextAjuste"
        Me.TextAjuste.Size = New System.Drawing.Size(63, 20)
        Me.TextAjuste.TabIndex = 54
        '
        'Ajuste
        '
        Me.Ajuste.AutoSize = True
        Me.Ajuste.Font = New System.Drawing.Font("Century Gothic", 10.75!)
        Me.Ajuste.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.Ajuste.Location = New System.Drawing.Point(764, 507)
        Me.Ajuste.Name = "Ajuste"
        Me.Ajuste.Size = New System.Drawing.Size(53, 20)
        Me.Ajuste.TabIndex = 53
        Me.Ajuste.Text = "Ajuste"
        '
        'Boton6Coutas
        '
        Me.Boton6Coutas.FlatAppearance.BorderSize = 0
        Me.Boton6Coutas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Boton6Coutas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Boton6Coutas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Boton6Coutas.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Boton6Coutas.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Boton6Coutas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Boton6Coutas.Location = New System.Drawing.Point(838, 481)
        Me.Boton6Coutas.Name = "Boton6Coutas"
        Me.Boton6Coutas.Size = New System.Drawing.Size(24, 23)
        Me.Boton6Coutas.TabIndex = 52
        Me.Boton6Coutas.Text = "6"
        Me.Boton6Coutas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Boton6Coutas.UseVisualStyleBackColor = True
        '
        'Boton12Coutas
        '
        Me.Boton12Coutas.FlatAppearance.BorderSize = 0
        Me.Boton12Coutas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Boton12Coutas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Boton12Coutas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Boton12Coutas.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Boton12Coutas.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Boton12Coutas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Boton12Coutas.Location = New System.Drawing.Point(864, 481)
        Me.Boton12Coutas.Name = "Boton12Coutas"
        Me.Boton12Coutas.Size = New System.Drawing.Size(31, 23)
        Me.Boton12Coutas.TabIndex = 51
        Me.Boton12Coutas.Text = "12"
        Me.Boton12Coutas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Boton12Coutas.UseVisualStyleBackColor = True
        '
        'Boton3Coutas
        '
        Me.Boton3Coutas.FlatAppearance.BorderSize = 0
        Me.Boton3Coutas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Boton3Coutas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Boton3Coutas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Boton3Coutas.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Boton3Coutas.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Boton3Coutas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Boton3Coutas.Location = New System.Drawing.Point(868, 457)
        Me.Boton3Coutas.Name = "Boton3Coutas"
        Me.Boton3Coutas.Size = New System.Drawing.Size(24, 23)
        Me.Boton3Coutas.TabIndex = 50
        Me.Boton3Coutas.Text = "3"
        Me.Boton3Coutas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Boton3Coutas.UseVisualStyleBackColor = True
        '
        'TextInteres
        '
        Me.TextInteres.Location = New System.Drawing.Point(834, 411)
        Me.TextInteres.Name = "TextInteres"
        Me.TextInteres.ReadOnly = True
        Me.TextInteres.Size = New System.Drawing.Size(63, 20)
        Me.TextInteres.TabIndex = 49
        '
        'Interes
        '
        Me.Interes.AutoSize = True
        Me.Interes.Font = New System.Drawing.Font("Century Gothic", 10.75!)
        Me.Interes.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.Interes.Location = New System.Drawing.Point(761, 411)
        Me.Interes.Name = "Interes"
        Me.Interes.Size = New System.Drawing.Size(59, 20)
        Me.Interes.TabIndex = 48
        Me.Interes.Text = "Interés"
        '
        'TextTarjeta
        '
        Me.TextTarjeta.Location = New System.Drawing.Point(834, 388)
        Me.TextTarjeta.Name = "TextTarjeta"
        Me.TextTarjeta.Size = New System.Drawing.Size(63, 20)
        Me.TextTarjeta.TabIndex = 48
        '
        'Tarjeta
        '
        Me.Tarjeta.AutoSize = True
        Me.Tarjeta.Font = New System.Drawing.Font("Century Gothic", 10.75!)
        Me.Tarjeta.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.Tarjeta.Location = New System.Drawing.Point(761, 388)
        Me.Tarjeta.Name = "Tarjeta"
        Me.Tarjeta.Size = New System.Drawing.Size(64, 20)
        Me.Tarjeta.TabIndex = 46
        Me.Tarjeta.Text = "Credito"
        '
        'TextEfectivo
        '
        Me.TextEfectivo.Location = New System.Drawing.Point(834, 342)
        Me.TextEfectivo.Name = "TextEfectivo"
        Me.TextEfectivo.ReadOnly = True
        Me.TextEfectivo.Size = New System.Drawing.Size(63, 20)
        Me.TextEfectivo.TabIndex = 45
        '
        'Efectivo
        '
        Me.Efectivo.AutoSize = True
        Me.Efectivo.Font = New System.Drawing.Font("Century Gothic", 10.75!)
        Me.Efectivo.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.Efectivo.Location = New System.Drawing.Point(759, 341)
        Me.Efectivo.Name = "Efectivo"
        Me.Efectivo.Size = New System.Drawing.Size(70, 20)
        Me.Efectivo.TabIndex = 44
        Me.Efectivo.Text = "Efectivo"
        '
        'BotonConfirmar
        '
        Me.BotonConfirmar.FlatAppearance.BorderSize = 0
        Me.BotonConfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BotonConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BotonConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonConfirmar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonConfirmar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BotonConfirmar.Image = Global.Presentation.My.Resources.Resources.payment1
        Me.BotonConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BotonConfirmar.Location = New System.Drawing.Point(765, 558)
        Me.BotonConfirmar.Name = "BotonConfirmar"
        Me.BotonConfirmar.Size = New System.Drawing.Size(140, 43)
        Me.BotonConfirmar.TabIndex = 32
        Me.BotonConfirmar.Text = "Confirmar"
        Me.BotonConfirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BotonConfirmar.UseVisualStyleBackColor = True
        '
        'TotalNum
        '
        Me.TotalNum.AutoSize = True
        Me.TotalNum.Font = New System.Drawing.Font("Century Gothic", 20.75!)
        Me.TotalNum.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.TotalNum.Location = New System.Drawing.Point(575, 585)
        Me.TotalNum.Name = "TotalNum"
        Me.TotalNum.Size = New System.Drawing.Size(70, 34)
        Me.TotalNum.TabIndex = 42
        Me.TotalNum.Text = "0.00"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 20.75!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.Label1.Location = New System.Drawing.Point(435, 585)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 34)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "TOTAL $"
        '
        'Venta
        '
        Me.Venta.AutoSize = True
        Me.Venta.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Venta.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.Venta.Location = New System.Drawing.Point(326, 350)
        Me.Venta.Name = "Venta"
        Me.Venta.Size = New System.Drawing.Size(73, 24)
        Me.Venta.TabIndex = 40
        Me.Venta.Text = "Venta"
        '
        'DataGridViewVenta
        '
        Me.DataGridViewVenta.AllowUserToAddRows = False
        Me.DataGridViewVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewVenta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewVenta.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.DataGridViewVenta.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridViewVenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewVenta.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.DataGridViewVenta.ColumnHeadersHeight = 30
        Me.DataGridViewVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridViewVenta.ColumnHeadersVisible = False
        Me.DataGridViewVenta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(103, Byte), Integer))
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewVenta.DefaultCellStyle = DataGridViewCellStyle18
        Me.DataGridViewVenta.EnableHeadersVisualStyles = False
        Me.DataGridViewVenta.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DataGridViewVenta.Location = New System.Drawing.Point(23, 376)
        Me.DataGridViewVenta.Name = "DataGridViewVenta"
        Me.DataGridViewVenta.ReadOnly = True
        Me.DataGridViewVenta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewVenta.RowHeadersDefaultCellStyle = DataGridViewCellStyle19
        Me.DataGridViewVenta.RowHeadersVisible = False
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle20.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewVenta.RowsDefaultCellStyle = DataGridViewCellStyle20
        Me.DataGridViewVenta.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewVenta.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.DataGridViewVenta.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewVenta.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.DataGridViewVenta.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.DataGridViewVenta.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewVenta.Size = New System.Drawing.Size(705, 203)
        Me.DataGridViewVenta.TabIndex = 39
        '
        'Column1
        '
        Me.Column1.HeaderText = "Codigo"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Descripcion"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Cantidad"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Precio"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Busqueda
        '
        Me.Busqueda.AutoSize = True
        Me.Busqueda.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Busqueda.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.Busqueda.Location = New System.Drawing.Point(313, 109)
        Me.Busqueda.Name = "Busqueda"
        Me.Busqueda.Size = New System.Drawing.Size(112, 24)
        Me.Busqueda.TabIndex = 38
        Me.Busqueda.Text = "Busqueda"
        '
        'BotonAgregar
        '
        Me.BotonAgregar.FlatAppearance.BorderSize = 0
        Me.BotonAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BotonAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BotonAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonAgregar.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BotonAgregar.Image = CType(resources.GetObject("BotonAgregar.Image"), System.Drawing.Image)
        Me.BotonAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BotonAgregar.Location = New System.Drawing.Point(371, 67)
        Me.BotonAgregar.Name = "BotonAgregar"
        Me.BotonAgregar.Size = New System.Drawing.Size(104, 43)
        Me.BotonAgregar.TabIndex = 37
        Me.BotonAgregar.Text = "Agregar"
        Me.BotonAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BotonAgregar.UseVisualStyleBackColor = True
        '
        'Cantidad
        '
        Me.Cantidad.AutoSize = True
        Me.Cantidad.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cantidad.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.Cantidad.Location = New System.Drawing.Point(297, 62)
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Size = New System.Drawing.Size(64, 17)
        Me.Cantidad.TabIndex = 36
        Me.Cantidad.Text = "Cantidad"
        '
        'TextCant
        '
        Me.TextCant.Location = New System.Drawing.Point(300, 82)
        Me.TextCant.Name = "TextCant"
        Me.TextCant.Size = New System.Drawing.Size(63, 20)
        Me.TextCant.TabIndex = 35
        '
        'BotonLimpiar
        '
        Me.BotonLimpiar.FlatAppearance.BorderSize = 0
        Me.BotonLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BotonLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BotonLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonLimpiar.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonLimpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BotonLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BotonLimpiar.Location = New System.Drawing.Point(88, 109)
        Me.BotonLimpiar.Name = "BotonLimpiar"
        Me.BotonLimpiar.Size = New System.Drawing.Size(48, 20)
        Me.BotonLimpiar.TabIndex = 34
        Me.BotonLimpiar.Text = "Limpiar"
        Me.BotonLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BotonLimpiar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(24, 108)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(48, 20)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Buscar"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridViewBusqueda
        '
        Me.DataGridViewBusqueda.AllowUserToAddRows = False
        Me.DataGridViewBusqueda.AllowUserToDeleteRows = False
        Me.DataGridViewBusqueda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewBusqueda.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewBusqueda.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.DataGridViewBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridViewBusqueda.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle21.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        DataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewBusqueda.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle21
        Me.DataGridViewBusqueda.ColumnHeadersHeight = 30
        Me.DataGridViewBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(103, Byte), Integer))
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewBusqueda.DefaultCellStyle = DataGridViewCellStyle22
        Me.DataGridViewBusqueda.EnableHeadersVisualStyles = False
        Me.DataGridViewBusqueda.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DataGridViewBusqueda.Location = New System.Drawing.Point(23, 135)
        Me.DataGridViewBusqueda.Name = "DataGridViewBusqueda"
        Me.DataGridViewBusqueda.ReadOnly = True
        Me.DataGridViewBusqueda.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewBusqueda.RowHeadersDefaultCellStyle = DataGridViewCellStyle23
        Me.DataGridViewBusqueda.RowHeadersVisible = False
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle24.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewBusqueda.RowsDefaultCellStyle = DataGridViewCellStyle24
        Me.DataGridViewBusqueda.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewBusqueda.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.DataGridViewBusqueda.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewBusqueda.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.DataGridViewBusqueda.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.DataGridViewBusqueda.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewBusqueda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewBusqueda.Size = New System.Drawing.Size(705, 203)
        Me.DataGridViewBusqueda.TabIndex = 28
        '
        'Descripcion
        '
        Me.Descripcion.AutoSize = True
        Me.Descripcion.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Descripcion.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.Descripcion.Location = New System.Drawing.Point(85, 62)
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.Size = New System.Drawing.Size(79, 17)
        Me.Descripcion.TabIndex = 16
        Me.Descripcion.Text = "Descripción"
        '
        'TextDescripcion
        '
        Me.TextDescripcion.Location = New System.Drawing.Point(88, 82)
        Me.TextDescripcion.Name = "TextDescripcion"
        Me.TextDescripcion.Size = New System.Drawing.Size(206, 20)
        Me.TextDescripcion.TabIndex = 15
        '
        'CodigoBarra
        '
        Me.CodigoBarra.AutoSize = True
        Me.CodigoBarra.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodigoBarra.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.CodigoBarra.Location = New System.Drawing.Point(20, 62)
        Me.CodigoBarra.Name = "CodigoBarra"
        Me.CodigoBarra.Size = New System.Drawing.Size(52, 17)
        Me.CodigoBarra.TabIndex = 14
        Me.CodigoBarra.Text = "Codigo"
        '
        'TextCodigoBarra
        '
        Me.TextCodigoBarra.Location = New System.Drawing.Point(23, 82)
        Me.TextCodigoBarra.Name = "TextCodigoBarra"
        Me.TextCodigoBarra.Size = New System.Drawing.Size(59, 20)
        Me.TextCodigoBarra.TabIndex = 13
        '
        'PanelBarraTitulo
        '
        Me.PanelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.PanelBarraTitulo.Controls.Add(Me.Label3)
        Me.PanelBarraTitulo.Controls.Add(Me.BotonClose)
        Me.PanelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBarraTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelBarraTitulo.Name = "PanelBarraTitulo"
        Me.PanelBarraTitulo.Size = New System.Drawing.Size(932, 40)
        Me.PanelBarraTitulo.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 24)
        Me.Label3.TabIndex = 75
        Me.Label3.Text = "VENTA"
        '
        'BotonClose
        '
        Me.BotonClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BotonClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BotonClose.Image = CType(resources.GetObject("BotonClose.Image"), System.Drawing.Image)
        Me.BotonClose.Location = New System.Drawing.Point(906, 10)
        Me.BotonClose.Name = "BotonClose"
        Me.BotonClose.Size = New System.Drawing.Size(18, 16)
        Me.BotonClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BotonClose.TabIndex = 3
        Me.BotonClose.TabStop = False
        '
        'BackgroundWorker1
        '
        '
        'ClienteTableAdapter
        '
        Me.ClienteTableAdapter.ClearBeforeFill = True
        '
        'FormVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(932, 628)
        Me.Controls.Add(Me.Total)
        Me.MinimumSize = New System.Drawing.Size(847, 514)
        Me.Name = "FormVenta"
        Me.Text = "vImports System.Runtime.InteropServices"
        Me.Total.ResumeLayout(False)
        Me.Total.PerformLayout()
        CType(Me.DataGridViewVendedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewVenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBarraTitulo.ResumeLayout(False)
        Me.PanelBarraTitulo.PerformLayout()
        CType(Me.BotonClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Total As Panel
    Friend WithEvents PanelBarraTitulo As Panel
    Friend WithEvents BotonClose As PictureBox
    Friend WithEvents TextCodigoBarra As TextBox
    Friend WithEvents CodigoBarra As Label
    Friend WithEvents TextDescripcion As TextBox
    Friend WithEvents Descripcion As Label
    Friend WithEvents DataGridViewBusqueda As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents BotonLimpiar As Button
    Friend WithEvents Cantidad As Label
    Friend WithEvents TextCant As TextBox
    Friend WithEvents BotonAgregar As Button
    Friend WithEvents Busqueda As Label
    Friend WithEvents DataGridViewVenta As DataGridView
    Friend WithEvents Venta As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents TotalNum As Label
    Friend WithEvents BotonConfirmar As Button
    Friend WithEvents TextEfectivo As TextBox
    Friend WithEvents Efectivo As Label
    Friend WithEvents Boton6Coutas As Button
    Friend WithEvents Boton12Coutas As Button
    Friend WithEvents Boton3Coutas As Button
    Friend WithEvents TextInteres As TextBox
    Friend WithEvents Interes As Label
    Friend WithEvents TextTarjeta As TextBox
    Friend WithEvents Tarjeta As Label
    Friend WithEvents TextAjuste As TextBox
    Friend WithEvents Ajuste As Label
    Friend WithEvents Couta As Label
    Friend WithEvents TextCouta As TextBox
    Friend WithEvents Cuota1 As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BotonPresupuesto As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents Label3 As Label
    Friend WithEvents CheckPresupuesto As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextDebito As TextBox
    Friend WithEvents ClienteTableAdapter As sanjusto_centroDataSetTableAdapters.ClienteTableAdapter
    Friend WithEvents CheckCliente As CheckBox
    Public WithEvents BotonCliente As Button
    Public WithEvents ClienteAsignado As Label
    Friend WithEvents DataGridViewVendedores As DataGridView
End Class
